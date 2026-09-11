using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_CLIENTE : MAPPER<BE.CLIENTE>
    {
        public override void Alta(BE.CLIENTE cliente)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", cliente.Nombre));
            parametros.Add(acceso.CrearParametro("@apellido", cliente.Apellido));
            parametros.Add(acceso.CrearParametro("@dni", cliente.DNI));
            parametros.Add(acceso.CrearParametro("@email", cliente.Email));
            parametros.Add(acceso.CrearParametro("@telefono", cliente.Telefono));
            parametros.Add(acceso.CrearParametro("@fechaLicencia", cliente.FechaVencimientoLicencia));
            parametros.Add(acceso.CrearParametro("@numeroLicencia", cliente.NumeroLicenciaConducir));

            cliente.Id = acceso.LeerEscalar("INSERTAR_CLIENTE", parametros);
            acceso.Cerrar();
        }

        public override void Baja(BE.CLIENTE cliente)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", cliente.Id));
            acceso.Escribir("BORRAR_CLIENTE", parametros);
            acceso.Cerrar();
        }

        public override List<BE.CLIENTE> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(BE.CLIENTE cliente)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", cliente.Nombre));
            parametros.Add(acceso.CrearParametro("@apellido", cliente.Apellido));
            parametros.Add(acceso.CrearParametro("@dni", cliente.DNI));
            parametros.Add(acceso.CrearParametro("@email", cliente.Email));
            parametros.Add(acceso.CrearParametro("@telefono", cliente.Telefono));
            parametros.Add(acceso.CrearParametro("@fechaLicencia", cliente.FechaVencimientoLicencia));
            parametros.Add(acceso.CrearParametro("@numeroLicencia", cliente.NumeroLicenciaConducir));
            int res = acceso.Escribir("MODIFICAR_CLIENTE", parametros);
        }

        public void Reactivar(BE.CLIENTE cliente)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", cliente.Id));
            acceso.Escribir("REACTIVAR_CLIENTE", parametros);
            acceso.Cerrar();
        }

        public override bool Verificar(CLIENTE cliente)
        {
            throw new NotImplementedException();
        }
    }
}
