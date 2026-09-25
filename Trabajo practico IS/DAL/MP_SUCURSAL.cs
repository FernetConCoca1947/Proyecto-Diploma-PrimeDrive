using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_SUCURSAL
    {
        ACCESO acceso = new ACCESO();
        public List<BE.SUCURSAL> Listar()
        {
            List<BE.SUCURSAL> listaSucursales = new List<BE.SUCURSAL>();

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("LISTAR_SUCURSALES", null);

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.SUCURSAL suc = new BE.SUCURSAL();
                    suc.Id = Convert.ToInt32(fila["ID_SUCURSAL"]);
                    suc.Nombre = fila["NOMBRE"].ToString();
                    suc.Direccion = fila["DIRECCION"].ToString();
                    suc.Activo = Convert.ToBoolean(fila["ACTIVO"]);

                    listaSucursales.Add(suc);
                }
            }
            finally
            {
                acceso.Cerrar();
            }

            return listaSucursales;
        }
    }
}
