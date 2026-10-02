using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_MANTENIMIENTO
    {
        ACCESO acceso = new ACCESO();
        public bool RegistrarRemito(BE.MANTENIMIENTO remito)
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdVehiculo", remito.Vehiculo.Id),
                acceso.CrearParametro("@FechaEntrada", remito.FechaEntrada),
                acceso.CrearParametro("@FechaSalida", remito.FechaSalida),
                acceso.CrearParametro("@KmService", remito.KmService),
                acceso.CrearParametro("@Costo", remito.Costo),
                acceso.CrearParametro("@TareasRealizadas", remito.TareasRealizadas)
            };

            // Ejecuta la transacción dual en SQL Server
            int filasAfectadas = acceso.Escribir("REGISTRAR_MANTENIMIENTO", parametros);

            acceso.Cerrar();

            // Validamos que se hayan afectado al menos 2 filas (1 inserción en MANTENIMIENTO + 1 actualización en VEHICULO)
            return filasAfectadas >= 2;
        }
    }
}
