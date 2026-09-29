using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_CONTRATO
    {
        private ACCESO acceso = new ACCESO();
        public void AltaTransaccional(BE.CONTRATO contrato)
        {
            acceso.Abrir();
            // Iniciamos la transacción en la base de datos
            SqlTransaction transaccion = acceso.Conexion.BeginTransaction();

            try
            {
                // OPERACIÓN 1: Insertar el contrato y obtener el ID
                List<SqlParameter> paramContrato = new List<SqlParameter>();
                paramContrato.Add(acceso.CrearParametro("@idReserva", contrato.Reserva.Id));
                paramContrato.Add(acceso.CrearParametro("@idVehiculo", contrato.Vehiculo.Id));
                paramContrato.Add(acceso.CrearParametro("@fechaHoraRetiro", contrato.FechaHoraRetiro));
                paramContrato.Add(acceso.CrearParametro("@kmSalida", contrato.KmSalida));
                paramContrato.Add(acceso.CrearParametro("@garantiaRetenida", contrato.GarantiaRetenida));
                paramContrato.Add(acceso.CrearParametro("@idEstado", contrato.Estado.IdEstado));

                // Usamos tu nuevo método que devuelve el SCOPE_IDENTITY()
                contrato.Id = acceso.LeerEscalarTransaccional("INSERTAR_CONTRATO", paramContrato, transaccion);

                // OPERACIÓN 2: Cambiar el estado del vehículo a "Alquilado" (ID = 2)
                List<SqlParameter> paramVehiculo = new List<SqlParameter>();
                paramVehiculo.Add(acceso.CrearParametro("@idVehiculo", contrato.Vehiculo.Id));
                paramVehiculo.Add(acceso.CrearParametro("@idEstado", 2));

                // Usamos tu nuevo método de escritura que lanza un throw en caso de error
                acceso.EscribirTransaccional("MODIFICAR_ESTADO_VEHICULO", paramVehiculo, transaccion);

                // Si llegó hasta aquí, confirmamos ambas operaciones
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                // Revertimos todos los cambios si algo falló
                transaccion.Rollback();
                throw new Exception("Error crítico en el Check-out. La operación ha sido cancelada para proteger la integridad del sistema.", ex);
            }
            finally
            {
                acceso.Cerrar();
            }
        }
    }
}

