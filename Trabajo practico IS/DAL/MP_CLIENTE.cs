using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            parametros.Add(acceso.CrearParametro("@licencia", cliente.NumeroLicenciaConducir));
            parametros.Add(acceso.CrearParametro("@vencimiento", cliente.FechaVencimientoLicencia));


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
            acceso.Abrir();
            DataTable tabla = acceso.Leer("LISTAR_CLIENTES");
            acceso.Cerrar();

            List <BE.CLIENTE> productos = new List<BE.CLIENTE>();
            foreach (DataRow registro in tabla.Rows)
            {
                BE.CLIENTE cliente = new BE.CLIENTE();
                cliente.Id = int.Parse(registro["ID_CLIENTE"].ToString());
                cliente.Nombre = registro["NOMBRE"].ToString();
                cliente.Apellido = registro["APELLIDO"].ToString();
                cliente.DNI = int.Parse(registro["DNI"].ToString());
                cliente.Email = registro["EMAIL"].ToString();
                cliente.Telefono = registro["TELEFONO"].ToString();
                cliente.NumeroLicenciaConducir = registro["LICENCIA"].ToString();
                cliente.FechaVencimientoLicencia = DateTime.Parse(registro["VENCIMIENTO_LICENCIA"].ToString());
                cliente.Activo = Convert.ToBoolean(registro["ACTIVO"]);

                productos.Add(cliente);
            }
            return productos;
        }

        public override void Modificar(BE.CLIENTE cliente)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", cliente.Id));
            parametros.Add(acceso.CrearParametro("@nombre", cliente.Nombre));
            parametros.Add(acceso.CrearParametro("@apellido", cliente.Apellido));
            parametros.Add(acceso.CrearParametro("@email", cliente.Email));
            parametros.Add(acceso.CrearParametro("@telefono", cliente.Telefono));
            parametros.Add(acceso.CrearParametro("@licencia", cliente.NumeroLicenciaConducir));
            parametros.Add(acceso.CrearParametro("@vencimiento", cliente.FechaVencimientoLicencia));
            parametros.Add(acceso.CrearParametro("@activo", cliente.Activo));
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

        public BE.CLIENTE ObtenerPorDNI(int dni)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@dni", dni));
            DataTable tabla = acceso.Leer("OBTENER_CLIENTE_POR_DNI", parametros);
            acceso.Cerrar();

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                BE.CLIENTE clienteEncontrado = new BE.CLIENTE();

                clienteEncontrado.Id = Convert.ToInt32(fila["ID_CLIENTE"]);
                clienteEncontrado.Nombre = fila["NOMBRE"].ToString();
                clienteEncontrado.Apellido = fila["APELLIDO"].ToString();
                clienteEncontrado.DNI = Convert.ToInt32(fila["DNI"]);
                clienteEncontrado.Email = fila["EMAIL"].ToString();
                clienteEncontrado.Telefono = fila["TELEFONO"].ToString();
                clienteEncontrado.NumeroLicenciaConducir = fila["LICENCIA"].ToString();
                clienteEncontrado.FechaVencimientoLicencia = Convert.ToDateTime(fila["VENCIMIENTO_LICENCIA"]);
                clienteEncontrado.Activo = Convert.ToBoolean(fila["ACTIVO"]);

                return clienteEncontrado;
            }

            return null;
        }

        public override bool Verificar(CLIENTE cliente)
        {
            throw new NotImplementedException();
        }
    }
}
