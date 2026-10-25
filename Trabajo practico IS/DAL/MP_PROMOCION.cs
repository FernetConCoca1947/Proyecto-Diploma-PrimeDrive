using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_PROMOCION
    {
        ACCESO acceso = new ACCESO();

        public List<BE.DIAGNOSTICO_OCUPACION> ObtenerMetricasOcupacion(int idSucursal, DateTime desde, DateTime hasta)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdSucursal", idSucursal),
                acceso.CrearParametro("@FechaDesde", desde),
                acceso.CrearParametro("@FechaHasta", hasta)
            };

            DataTable tabla = acceso.Leer("OBTENER_METRICAS_OCUPACION", parametros);
            acceso.Cerrar();

            List<BE.DIAGNOSTICO_OCUPACION> lista = new List<BE.DIAGNOSTICO_OCUPACION>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.DIAGNOSTICO_OCUPACION item = new BE.DIAGNOSTICO_OCUPACION
                {
                    Categoria = new BE.CATEGORIA
                    {
                        Id = Convert.ToInt32(fila["ID_CATEGORIA"]),
                        Nombre = fila["CATEGORIA_NOMBRE"].ToString(),
                        TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"])
                    },
                    TotalFlota = Convert.ToInt32(fila["TOTAL_FLOTA"]),
                    VehiculosReservados = Convert.ToInt32(fila["RESERVAS_SOLAPADAS"])
                };
                lista.Add(item);
            }
            return lista;
        }

        public bool RegistrarPromocion(BE.PROMOCION promo)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@Nombre", promo.Nombre),
                acceso.CrearParametro("@TipoPromocion", promo.TipoPromocion),
                acceso.CrearParametro("@IdSucursal", promo.Sucursal.Id),
                acceso.CrearParametro("@IdCategoriaObjetivo", promo.CategoriaObjetivo.Id),
                
                // Usamos SqlParameter nativo porque puede enviar INT o DBNull.Value (cuando es Baja Demanda)
                new SqlParameter("@IdCategoriaOrigenUpgrade", promo.CategoriaOrigenUpgrade == null
                                                                ? (object)DBNull.Value
                                                                : promo.CategoriaOrigenUpgrade.Id),

                acceso.CrearParametro("@PorcentajeDescuento", promo.PorcentajeDescuento),
                acceso.CrearParametro("@FechaDesde", promo.FechaDesde),
                acceso.CrearParametro("@FechaHasta", promo.FechaHasta),
                acceso.CrearParametro("@Motivo", promo.Motivo)
            };

            int filasAfectadas = acceso.Escribir("REGISTRAR_PROMOCION", parametros);
            acceso.Cerrar();

            return filasAfectadas > 0;
        }

    }
}
