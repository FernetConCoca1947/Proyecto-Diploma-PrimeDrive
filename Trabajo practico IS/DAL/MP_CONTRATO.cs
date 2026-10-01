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
                contrato.Id = acceso.LeerEscalarTransaccional("INSERTAR_CONTRATO", paramContrato, transaccion);

                // OPERACIÓN 2: Cambiar el estado del vehículo a "Alquilado" (ID = 2)
                List<SqlParameter> paramVehiculo = new List<SqlParameter>();
                paramVehiculo.Add(acceso.CrearParametro("@idVehiculo", contrato.Vehiculo.Id));
                paramVehiculo.Add(acceso.CrearParametro("@idEstado", 2));
                acceso.EscribirTransaccional("MODIFICAR_ESTADO_VEHICULO", paramVehiculo, transaccion);

                List<SqlParameter> paramReserva = new List<SqlParameter>();
                paramReserva.Add(acceso.CrearParametro("@idReserva", contrato.Reserva.Id));
                paramReserva.Add(acceso.CrearParametro("@idEstado", 5));
                acceso.EscribirTransaccional("MODIFICAR_ESTADO_RESERVA", paramReserva, transaccion);

                // Si llegó hasta aquí, confirmamos ambas operaciones
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw new Exception("Error crítico en el Check-out. La operación ha sido cancelada para proteger la integridad del sistema.", ex);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public List<BE.CONTRATO> ObtenerContratosAbiertos(string criterio, string valorBusqueda)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@Criterio", criterio),
                acceso.CrearParametro("@ValorBusqueda", valorBusqueda)
            };

            DataTable tabla = acceso.Leer("OBTENER_CONTRATOS_ABIERTOS", parametros);
            acceso.Cerrar();

            List<BE.CONTRATO> listaContratos = new List<BE.CONTRATO>();

            foreach (DataRow fila in tabla.Rows)
            {
                // Ensamblaje de entidades anidadas
                BE.CLIENTE cliente = new BE.CLIENTE { DNI = Convert.ToInt32(fila["DNI"].ToString()), Nombre = fila["NOMBRE"].ToString(), Apellido = fila["APELLIDO"].ToString() };
                BE.CATEGORIA categoria = new BE.CATEGORIA { Nombre = fila["CATEGORIA_NOMBRE"].ToString(), TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"]) };
                BE.RESERVA reserva = new BE.RESERVA { Id = Convert.ToInt32(fila["ID_RESERVA"]), Cliente = cliente, Categoria = categoria };
                BE.VEHICULO vehiculo = new BE.VEHICULO { Id = Convert.ToInt32(fila["ID_VEHICULO"]), Patente = fila["PATENTE"].ToString() };

                // Ensamblaje del Contrato
                BE.CONTRATO contrato = new BE.CONTRATO
                {
                    Id = Convert.ToInt32(fila["ID_CONTRATO"]),
                    Reserva = reserva,
                    Vehiculo = vehiculo,
                    FechaHoraRetiro = Convert.ToDateTime(fila["FECHA_HORA_RETIRO"]),
                    KmSalida = Convert.ToInt32(fila["KM_SALIDA"]),
                    GarantiaRetenida = Convert.ToDecimal(fila["GARANTIA_RETENIDA"]),
                    Estado = new BE.ESTADO { IdEstado = 1, Nombre = "Abierto" }
                };

                listaContratos.Add(contrato);
            }

            return listaContratos;
        }

        public bool CerrarContratoCheckIn(BE.CONTRATO contrato)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdContrato", contrato.Id),
                acceso.CrearParametro("@KmEntrada", contrato.KmEntrada.Value),
                acceso.CrearParametro("@MontoFinal", contrato.MontoFinal.Value),
                acceso.CrearParametro("@Observaciones", contrato.Observaciones),
                acceso.CrearParametro("@IdVehiculo", contrato.Vehiculo.Id),
                acceso.CrearParametro("@IdEstadoVehiculo", contrato.Vehiculo.Estado.IdEstado)
            };

            // Ejecuta el comando (Retorna la cantidad de filas afectadas)
            int filasAfectadas = acceso.Escribir("CERRAR_CONTRATO_CHECKIN", parametros);
            acceso.Cerrar();

            // Si se actualizaron correctamente las 2 tablas (CONTRATO y VEHICULO), retorna true
            return filasAfectadas >= 2;
        }
    }
}

