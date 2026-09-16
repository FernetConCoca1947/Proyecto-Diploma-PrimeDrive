using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_CATEGORIA : MAPPER<BE.CATEGORIA>
    {
        
        public override void Alta(BE.CATEGORIA categoria)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", categoria.Nombre));
            parametros.Add(acceso.CrearParametro("@tarifaDiaria", categoria.TarifaDiaria));

            try
            {
                acceso.Abrir();
                acceso.Escribir("INSERTAR_CATEGORIA", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override void Baja(BE.CATEGORIA categoria)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idCategoria", categoria.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("BORRAR_CATEGORIA", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override List<CATEGORIA> Listar()
        {
            List<BE.CATEGORIA> listaCategorias = new List<BE.CATEGORIA>();

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("LISTAR_CATEGORIAS", null);

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.CATEGORIA cat = new BE.CATEGORIA();
                    cat.Id = Convert.ToInt32(fila["ID_CATEGORIA"]);
                    cat.Nombre = fila["NOMBRE"].ToString();
                    cat.TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"]);
                    cat.Activo = Convert.ToBoolean(fila["ACTIVO"]);

                    listaCategorias.Add(cat);
                }
            }
            finally
            {
                acceso.Cerrar();
            }

            return listaCategorias;
        }

        public override void Modificar(BE.CATEGORIA categoria)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idCategoria", categoria.Id));
            parametros.Add(acceso.CrearParametro("@nombre", categoria.Nombre));
            parametros.Add(acceso.CrearParametro("@tarifaDiaria", categoria.TarifaDiaria));
            parametros.Add(acceso.CrearParametro("@activo", categoria.Activo));

            try
            {
                acceso.Abrir();
                acceso.Escribir("MODIFICAR_CATEGORIA", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }
        public void Reactivar(BE.CATEGORIA categoria)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", categoria.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("REACTIVAR_CATEGORIA", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override bool Verificar(CATEGORIA categoria)
        {
            throw new NotImplementedException();
        }
    }
}
