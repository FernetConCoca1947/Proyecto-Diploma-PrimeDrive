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

            if (nuevoContrato.Reserva.Estado.IdEstado != 6)
                throw new Exception("La reserva debe estar 'Confirmada' para proceder al Check-out.");

            if (nuevoContrato.Vehiculo.Estado.IdEstado != 1)
                throw new Exception($"El vehículo patente {nuevoContrato.Vehiculo.Patente} no se encuentra 'Disponible'.");

            if (nuevoContrato.GarantiaRetenida <= 0)
                throw new Exception("Debe registrar un monto de retención de garantía válido.");

            nuevoContrato.FechaHoraRetiro = DateTime.Now;
            nuevoContrato.Estado = new BE.ESTADO { IdEstado = 8, Nombre = "Abierto" };

            mapper.AltaTransaccional(nuevoContrato);

            GestorBitacora.RegistrarEvento("Contrato", $"Check-out generado. Contrato ID: {nuevoContrato.Id} - Vehículo: {nuevoContrato.Vehiculo.Patente}", 2);
        }

        public decimal CalcularLiquidacionFinal(BE.CONTRATO contrato, string nivelCombustible, decimal recargoDanosManual)
        {
            if (contrato.KmEntrada == null)
                throw new Exception("Debe registrar el kilometraje de entrada del vehículo.");

            if (contrato.KmEntrada < contrato.KmSalida)
                throw new Exception($"Error de auditoría: El kilometraje actual ({contrato.KmEntrada}) no puede ser menor al de salida ({contrato.KmSalida}).");

            contrato.FechaHoraDevolucion = DateTime.Now;
            TimeSpan tiempoUso = contrato.FechaHoraDevolucion.Value - contrato.FechaHoraRetiro;

            int diasReales = tiempoUso.Days > 0 ? tiempoUso.Days : 1;

            decimal tarifaBase = diasReales * contrato.Reserva.Categoria.TarifaDiaria;

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

            if (contrato.MontoFinal == null || contrato.MontoFinal <= 0)
                throw new Exception("Error: No se puede cerrar el contrato sin una liquidación final calculada.");

            if (contrato.KmEntrada == null)
                throw new Exception("Error: Faltan los datos de la auditoría de kilometraje.");

            int intervaloService = 10000;
            int servicePrevio = contrato.KmSalida / intervaloService;
            int serviceActual = contrato.KmEntrada.Value / intervaloService;

            contrato.Vehiculo.KmActual = contrato.KmEntrada.Value;

            if (serviceActual > servicePrevio)
            {
                contrato.Vehiculo.Estado = new BE.ESTADO { IdEstado = 3, Nombre = "Mantenimiento" };
                contrato.Observaciones += " | [SISTEMA]: Vehículo derivado a service preventivo automático.";
            }
            else if (!string.IsNullOrWhiteSpace(contrato.Vehiculo.ObservacionRevision))
            {
                contrato.Vehiculo.Estado = new BE.ESTADO { IdEstado = 10, Nombre = "En Revisión" };
            }
            else
            {
                contrato.Vehiculo.Estado = new BE.ESTADO { IdEstado = 1, Nombre = "Disponible" };
            }

            bool exito = mapper.CerrarContratoCheckIn(contrato);

            if (!exito)
                throw new Exception("Ocurrió un error en la base de datos al intentar procesar el Check-in.");
        }
    }
}

