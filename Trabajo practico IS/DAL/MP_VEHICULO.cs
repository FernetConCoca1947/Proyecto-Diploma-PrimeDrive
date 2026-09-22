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
    public class MP_VEHICULO : MAPPER<BE.VEHICULO>
    {
        public override void Alta(VEHICULO vehiculo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@patente", vehiculo.Patente));
            parametros.Add(acceso.CrearParametro("@marca", vehiculo.Marca));
            parametros.Add(acceso.CrearParametro("@modelo", vehiculo.Modelo));
            parametros.Add(acceso.CrearParametro("@kmActual", vehiculo.KmActual));
            parametros.Add(acceso.CrearParametro("@idEstado", vehiculo.Estado.IdEstado));
            parametros.Add(acceso.CrearParametro("@idCategoria", vehiculo.Categoria.Id));
            parametros.Add(acceso.CrearParametro("@idSucursal", vehiculo.Sucursal.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("INSERTAR_VEHICULO", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override void Baja(VEHICULO vehiculo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idVehiculo", vehiculo.Id));

            try
            {
                acceso.Abrir();
                // Esto pasará el ID_ESTADO a 4 (Baja) como definimos en el SP
                acceso.Escribir("BORRAR_VEHICULO", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override List<VEHICULO> Listar()
        {
            List<BE.VEHICULO> listaVehiculos = new List<BE.VEHICULO>();

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("LISTAR_VEHICULOS", null);

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.VEHICULO veh = new BE.VEHICULO();
                    veh.Id = Convert.ToInt32(fila["ID_VEHICULO"]);
                    veh.Patente = fila["PATENTE"].ToString();
                    veh.Marca = fila["MARCA"].ToString();
                    veh.Modelo = fila["MODELO"].ToString();
                    veh.KmActual = Convert.ToInt32(fila["KM_ACTUAL"]);

                    // Instanciamos los objetos compuestos solo con su ID para mantener la referencia
                    veh.Estado = new BE.ESTADO { IdEstado = Convert.ToInt32(fila["ID_ESTADO"]) };
                    veh.Categoria = new BE.CATEGORIA { Id = Convert.ToInt32(fila["ID_CATEGORIA"]) };
                    veh.Sucursal = new BE.SUCURSAL { Id = Convert.ToInt32(fila["ID_SUCURSAL"]) };

                    listaVehiculos.Add(veh);
                }
            }
            finally
            {
                acceso.Cerrar();
            }

            return listaVehiculos;
        }

        public override void Modificar(VEHICULO vehiculo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idVehiculo", vehiculo.Id));
            parametros.Add(acceso.CrearParametro("@patente", vehiculo.Patente));
            parametros.Add(acceso.CrearParametro("@marca", vehiculo.Marca));
            parametros.Add(acceso.CrearParametro("@modelo", vehiculo.Modelo));
            parametros.Add(acceso.CrearParametro("@kmActual", vehiculo.KmActual));
            parametros.Add(acceso.CrearParametro("@idEstado", vehiculo.Estado.IdEstado));
            parametros.Add(acceso.CrearParametro("@idCategoria", vehiculo.Categoria.Id));
            parametros.Add(acceso.CrearParametro("@idSucursal", vehiculo.Sucursal.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("MODIFICAR_VEHICULO", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public void Reactivar(BE.VEHICULO vehiculo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idVehiculo", vehiculo.Id));

            try
            {
                acceso.Abrir();
                // Este SP deberá hacer: UPDATE VEHICULO SET ID_ESTADO = 1 WHERE ID_VEHICULO = @idVehiculo
                acceso.Escribir("REACTIVAR_VEHICULO", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override bool Verificar(VEHICULO vehiculo)
        {
            throw new NotImplementedException();
        }
    }
}
