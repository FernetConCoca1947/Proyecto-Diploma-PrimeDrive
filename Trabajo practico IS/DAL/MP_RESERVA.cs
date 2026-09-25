using BE;
using System;
using System.Collections.Generic;
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

        public int ContarVehiculosPorCategoria(int idCategoria)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idCategoria", idCategoria));

            int total = acceso.LeerEscalar("CONTAR_VEHICULOS_CATEGORIA", parametros);
            acceso.Cerrar();

            return total;
        }

        public int ContarReservasActivas(int idCategoria, DateTime inicio, DateTime fin)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idCategoria", idCategoria));
            parametros.Add(acceso.CrearParametro("@fechaInicio", inicio));
            parametros.Add(acceso.CrearParametro("@fechaFin", fin));

            int reservasSolapadas = acceso.LeerEscalar("CONTAR_RESERVAS_SOLAPADAS", parametros);
            acceso.Cerrar();

            return reservasSolapadas;
        }

        public override void Baja(RESERVA reserva)
        {
            throw new NotImplementedException();
        }

        public override List<RESERVA> Listar()
        {
            throw new NotImplementedException();
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
