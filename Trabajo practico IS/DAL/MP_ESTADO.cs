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
    public class MP_ESTADO
    {
        ACCESO acceso = new ACCESO();
        public List<BE.ESTADO> Listar()
        {
            List<BE.ESTADO> listaEstados = new List<BE.ESTADO>();

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("LISTAR_ESTADOS", null);

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.ESTADO est = new BE.ESTADO();
                    est.IdEstado = Convert.ToInt32(fila["ID_ESTADO"]);
                    est.Nombre = fila["NOMBRE"].ToString();
                    est.Ambito = fila["AMBITO"].ToString();

                    listaEstados.Add(est);
                }
            }
            finally
            {
                acceso.Cerrar();
            }

            return listaEstados;
        }

        public List<BE.ESTADO> ListarPorAmbito(string ambito)
        {
            List<BE.ESTADO> lista = new List<BE.ESTADO>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ambito", ambito));

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("LISTAR_ESTADOS_POR_AMBITO", parametros);
                foreach (DataRow fila in tabla.Rows)
                {
                    BE.ESTADO est = new BE.ESTADO();
                    est.IdEstado = Convert.ToInt32(fila["ID_ESTADO"]);
                    est.Nombre = fila["NOMBRE"].ToString();
                    est.Ambito = fila["AMBITO"].ToString();

                    lista.Add(est);
                }
            }
            finally
            {
                acceso.Cerrar();
            }
            return lista;
        }
    }
}
