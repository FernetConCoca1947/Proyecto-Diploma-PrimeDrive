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
    }
}
