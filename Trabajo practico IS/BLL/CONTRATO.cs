using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CONTRATO
    {
        private MP_CONTRATO mapper = new MP_CONTRATO();
        private BLL.BITACORA GestorBitacora = new BLL.BITACORA();

        public void GenerarContrato(BE.CONTRATO nuevoContrato)
        {
            // 1. Reglas de negocio restrictivas
            if (nuevoContrato.Reserva.Estado.IdEstado != 6)
                throw new Exception("La reserva debe estar 'Confirmada' para proceder al Check-out.");

            if (nuevoContrato.Vehiculo.Estado.IdEstado != 1)
                throw new Exception($"El vehículo patente {nuevoContrato.Vehiculo.Patente} no se encuentra 'Disponible'.");

            if (nuevoContrato.GarantiaRetenida <= 0)
                throw new Exception("Debe registrar un monto de retención de garantía válido.");

            // 2. Configuración automática de sistema
            nuevoContrato.FechaHoraRetiro = DateTime.Now;
            nuevoContrato.Estado = new BE.ESTADO { IdEstado = 8, Nombre = "Abierto" };

            // 3. Ejecución en la base de datos
            mapper.AltaTransaccional(nuevoContrato);

            GestorBitacora.RegistrarEvento("Contrato", $"Check-out generado. Contrato ID: {nuevoContrato.Id} - Vehículo: {nuevoContrato.Vehiculo.Patente}", 2);
        }

        public decimal CalcularLiquidacionFinal(BE.CONTRATO contrato, string nivelCombustible, decimal recargoDanosManual)
        {
            // 1. Validaciones de Integridad
            if (contrato.KmEntrada == null)
                throw new Exception("Debe registrar el kilometraje de entrada del vehículo.");

            if (contrato.KmEntrada < contrato.KmSalida)
                throw new Exception($"Error de auditoría: El kilometraje actual ({contrato.KmEntrada}) no puede ser menor al de salida ({contrato.KmSalida}).");

            // 2. Cálculo de Días Reales de Uso
            contrato.FechaHoraDevolucion = DateTime.Now;
            TimeSpan tiempoUso = contrato.FechaHoraDevolucion.Value - contrato.FechaHoraRetiro;

            // Regla comercial: Todo alquiler cobra un mínimo de 1 día, incluso si se devuelve a las pocas horas.
            int diasReales = tiempoUso.Days > 0 ? tiempoUso.Days : 1;

            // 3. Cálculo de Tarifa Base
            decimal tarifaBase = diasReales * contrato.Reserva.Categoria.TarifaDiaria;


            // 5. Auditoría de Combustible (Penalidad escalonada por tanque incompleto)
            decimal multaCombustible = 0;
            switch (nivelCombustible)
            {
                case "3/4":
                    multaCombustible = 15000.00m;
                    break;
                case "Medio":
                    multaCombustible = 30000.00m;
                    break;
                case "Reserva":
                    multaCombustible = 45000.00m;
                    break;
                case "Lleno":
                default:
                    multaCombustible = 0.00m;
                    break;
            }

            // 6. Consolidación del Monto Final
            contrato.MontoFinal = tarifaBase + multaCombustible + recargoDanosManual;

            return contrato.MontoFinal.Value;
        }

        public List<BE.CONTRATO> ObtenerContratosAbiertos(string criterio, string valorBusqueda)
        {
            if (string.IsNullOrWhiteSpace(valorBusqueda))
                throw new Exception("El valor de búsqueda no puede estar vacío.");

            if (criterio == "DNI Cliente" && !int.TryParse(valorBusqueda, out _))
                throw new Exception("El DNI debe contener un formato numérico válido.");

            List<BE.CONTRATO> contratosEncontrados = mapper.ObtenerContratosAbiertos(criterio, valorBusqueda);

            if (contratosEncontrados.Count == 0)
                throw new Exception($"No se encontró ningún contrato activo asociado a ese {criterio}.");

            return contratosEncontrados;
        }

        public void CerrarContratoCheckIn(BE.CONTRATO contrato)
        {
            // 1. Validaciones de integridad
            if (contrato.MontoFinal == null || contrato.MontoFinal <= 0)
                throw new Exception("Error: No se puede cerrar el contrato sin una liquidación final calculada.");

            if (contrato.KmEntrada == null)
                throw new Exception("Error: Faltan los datos de la auditoría de kilometraje.");

            // 2. Regla de Negocio: Mantenimiento Preventivo Automático
            // Evaluamos si el vehículo cruzó la barrera de los 10.000 km durante este alquiler
            int intervaloService = 10000;
            int servicePrevio = contrato.KmSalida / intervaloService;
            int serviceActual = contrato.KmEntrada.Value / intervaloService;

            // Actualizamos el kilometraje del vehículo en memoria
            contrato.Vehiculo.KmActual = contrato.KmEntrada.Value;

            if (serviceActual > servicePrevio)
            {
                // El cliente cruzó la barrera (ej. pasó de 9.800 km a 10.150 km). Va al taller.
                contrato.Vehiculo.Estado = new BE.ESTADO { IdEstado = 3, Nombre = "Mantenimiento" };
                contrato.Observaciones += " | NOTA AUTOMÁTICA: Vehículo derivado a service preventivo.";
            }
            else
            {
                // El vehículo no requiere service. Se lava y vuelve a la oferta comercial.
                contrato.Vehiculo.Estado = new BE.ESTADO { IdEstado = 1, Nombre = "Disponible" };
            }

            // 3. Delegación a la Capa de Datos
            bool exito = mapper.CerrarContratoCheckIn(contrato);

            if (!exito)
                throw new Exception("Ocurrió un error en la base de datos al intentar procesar el Check-in.");
        }
    }
}

