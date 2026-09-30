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
    public class MP_RESERVA : MAPPER<BE.RESERVA>
    {
        public override void Alta(RESERVA reserva)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(acceso.CrearParametro("@idCliente", reserva.Cliente.Id));
            parametros.Add(acceso.CrearParametro("@idCategoria", reserva.Categoria.Id));
            parametros.Add(acceso.CrearParametro("@fechaInicio", reserva.FechaInicio));
            parametros.Add(acceso.CrearParametro("@fechaFin", reserva.FechaFin));
            parametros.Add(acceso.CrearParametro("@idEstado", reserva.Estado.IdEstado));
            parametros.Add(acceso.CrearParametro("@idSucursalRetiro", reserva.SucursalRetiro.Id));
            parametros.Add(acceso.CrearParametro("@idSucursalDevolucion", reserva.SucursalDevolucion.Id));

            reserva.Id = acceso.LeerEscalar("INSERTAR_RESERVA", parametros);
            acceso.Cerrar();
        }

        public void ModificarEstado(BE.RESERVA reserva)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idReserva", reserva.Id));
            parametros.Add(acceso.CrearParametro("@idEstado", reserva.Estado.IdEstado));

            acceso.Escribir("MODIFICAR_ESTADO_RESERVA", parametros);
            acceso.Cerrar();
        }

        public int ContarVehiculosPorCategoria(int idCategoria,int idSucursalRetiro)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idCategoria", idCategoria));
            parametros.Add(acceso.CrearParametro("@idSucursalRetiro", idSucursalRetiro));

            int total = acceso.LeerEscalar("CONTAR_VEHICULOS_CATEGORIA_SUCURSAL", parametros);
            acceso.Cerrar();

            return total;
        }

        public int ContarReservasActivas(int idCategoria, DateTime inicio, DateTime fin, int idSucursalRetiro)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idCategoria", idCategoria));
            parametros.Add(acceso.CrearParametro("@idSucursalRetiro", idSucursalRetiro));
            parametros.Add(acceso.CrearParametro("@fechaInicio", inicio));
            parametros.Add(acceso.CrearParametro("@fechaFin", fin));

            int reservasSolapadas = acceso.LeerEscalar("CONTAR_RESERVAS_SOLAPADAS_SUCURSAL", parametros);
            acceso.Cerrar();

            return reservasSolapadas;
        }

        public override void Baja(RESERVA reserva)
        {
            throw new NotImplementedException();
        }

        public override List<RESERVA> Listar()
        {
            acceso.Abrir();
            DataTable tabla = acceso.Leer("LISTAR_RESERVAS");
            acceso.Cerrar();

            List<BE.RESERVA> listaReservas = new List<BE.RESERVA>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.RESERVA reserva = new BE.RESERVA();
                reserva.Id = Convert.ToInt32(fila["ID_RESERVA"]);
                reserva.FechaInicio = Convert.ToDateTime(fila["FECHA_INICIO"]);
                reserva.FechaFin = Convert.ToDateTime(fila["FECHA_FIN"]);

                reserva.Cliente = new BE.CLIENTE
                {
                    Id = Convert.ToInt32(fila["ID_CLIENTE"]),
                    Nombre = fila["CLIENTE_NOMBRE"].ToString(),
                    Apellido = fila["CLIENTE_APELLIDO"].ToString(),
                    DNI = Convert.ToInt32(fila["DNI"])
                };

                reserva.Categoria = new BE.CATEGORIA
                {
                    Id = Convert.ToInt32(fila["ID_CATEGORIA"]),
                    Nombre = fila["CATEGORIA_NOMBRE"].ToString(),
                    TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"])
                };

                reserva.Estado = new BE.ESTADO
                {
                    IdEstado = Convert.ToInt32(fila["ID_ESTADO"]),
                    Nombre = fila["ESTADO_NOMBRE"].ToString()
                };

                reserva.SucursalRetiro = new BE.SUCURSAL
                {
                    Id = Convert.ToInt32(fila["ID_SUCURSAL_RETIRO"]),
                    Nombre = fila["SUCURSAL_RETIRO_NOMBRE"].ToString()
                };

                reserva.SucursalDevolucion = new BE.SUCURSAL
                {
                    Id = Convert.ToInt32(fila["ID_SUCURSAL_DEVOLUCION"]),
                    Nombre = fila["SUCURSAL_DEVOLUCION_NOMBRE"].ToString()
                };

                listaReservas.Add(reserva);
            }

            return listaReservas;
        }

        public List<BE.RESERVA> ListarConfirmadasPorDNI(int dni)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@dni", dni));

            DataTable tabla = acceso.Leer("BUSCAR_RESERVAS_CONFIRMADAS_POR_DNI", parametros);
            acceso.Cerrar();

            List<BE.RESERVA> listaReservas = new List<BE.RESERVA>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.RESERVA reserva = new BE.RESERVA();
                reserva.Id = Convert.ToInt32(fila["ID_RESERVA"]);
                reserva.FechaInicio = Convert.ToDateTime(fila["FECHA_INICIO"]);
                reserva.FechaFin = Convert.ToDateTime(fila["FECHA_FIN"]);

                reserva.Cliente = new BE.CLIENTE
                {
                    Id = Convert.ToInt32(fila["ID_CLIENTE"]),
                    Nombre = fila["CLIENTE_NOMBRE"].ToString(),
                    Apellido = fila["CLIENTE_APELLIDO"].ToString(),
                    DNI = Convert.ToInt32(fila["DNI"])
                };

                reserva.Categoria = new BE.CATEGORIA
                {
                    Id = Convert.ToInt32(fila["ID_CATEGORIA"]),
                    Nombre = fila["CATEGORIA_NOMBRE"].ToString(),
                    TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"])
                };

                reserva.Estado = new BE.ESTADO
                {
                    IdEstado = Convert.ToInt32(fila["ID_ESTADO"]),
                    Nombre = fila["ESTADO_NOMBRE"].ToString()
                };

                reserva.SucursalRetiro = new BE.SUCURSAL
                {
                    Id = Convert.ToInt32(fila["ID_SUCURSAL_RETIRO"]),
                    Nombre = fila["SUCURSAL_RETIRO_NOMBRE"].ToString()
                };

                reserva.SucursalDevolucion = new BE.SUCURSAL
                {
                    Id = Convert.ToInt32(fila["ID_SUCURSAL_DEVOLUCION"]),
                    Nombre = fila["SUCURSAL_DEVOLUCION_NOMBRE"].ToString()
                };

                listaReservas.Add(reserva);
            }

            return listaReservas;
        }

        public override void Modificar(RESERVA reserva)
        {
            throw new NotImplementedException();
        }

        public override bool Verificar(RESERVA reserva)
        {
            throw new NotImplementedException();
        }
    }
}
