using BE;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<BE.MANTENIMIENTO> ListarHistorialPorVehiculo(int IdVehiculo)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdVehiculo", IdVehiculo)
            };

            DataTable tabla = acceso.Leer("LISTAR_HISTORIAL_VEHICULO", parametros);
            acceso.Cerrar();

            List<BE.MANTENIMIENTO> historial = new List<BE.MANTENIMIENTO>();

            // 3. Mapeamos los resultados a objetos
            foreach (DataRow fila in tabla.Rows)
            {
                BE.MANTENIMIENTO remito = new BE.MANTENIMIENTO
                {
                    Id = Convert.ToInt32(fila["ID_MANTENIMIENTO"]),
                    FechaEntrada = Convert.ToDateTime(fila["FECHA_ENTRADA"]),
                    FechaSalida = Convert.ToDateTime(fila["FECHA_SALIDA"]),
                    KmService = Convert.ToInt32(fila["KM_SERVICE"]),
                    Costo = Convert.ToDecimal(fila["COSTO"]),
                    TareasRealizadas = fila["TAREAS_REALIZADAS"].ToString(),

                    // Instanciamos el objeto compuesto del vehículo solo con su ID para mantener la referencia
                    Vehiculo = new BE.VEHICULO { Id = Convert.ToInt32(fila["ID_VEHICULO"]) }
                };

                historial.Add(remito);
            }

            return historial;
        }
    }
}
