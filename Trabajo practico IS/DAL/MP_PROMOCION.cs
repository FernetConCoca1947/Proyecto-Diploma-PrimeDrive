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
            List<BE.DIAGNOSTICO_OCUPACION> lista = new List<BE.DIAGNOSTICO_OCUPACION>();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdSucursal", idSucursal),
                acceso.CrearParametro("@FechaDesde", desde),
                acceso.CrearParametro("@FechaHasta", hasta)
            };

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("OBTENER_METRICAS_OCUPACION", parametros);

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
            }
            finally
            {
                acceso.Cerrar();
            }

            return lista;
        }

        public bool RegistrarPromocion(BE.PROMOCION promo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@Nombre", promo.Nombre),
                acceso.CrearParametro("@TipoPromocion", promo.TipoPromocion),
                acceso.CrearParametro("@IdSucursal", promo.Sucursal.Id),
                acceso.CrearParametro("@IdCategoriaObjetivo", promo.CategoriaObjetivo.Id),
                
                // Si es Baja Demanda pura, CategoriaOrigenUpgrade es null y enviamos DBNull.Value
                new SqlParameter("@IdCategoriaOrigenUpgrade", promo.CategoriaOrigenUpgrade == null
                                                                ? (object)DBNull.Value
                                                                : promo.CategoriaOrigenUpgrade.Id),

                acceso.CrearParametro("@PorcentajeDescuento", promo.PorcentajeDescuento),
                acceso.CrearParametro("@FechaDesde", promo.FechaDesde),
                acceso.CrearParametro("@FechaHasta", promo.FechaHasta),
                acceso.CrearParametro("@Motivo", promo.Motivo)
            };

            try
            {
                acceso.Abrir();
                int filasAfectadas = acceso.Escribir("REGISTRAR_PROMOCION", parametros);
                return filasAfectadas > 0;
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public int ValidarSolapamiento(int idSucursal, int idCategoriaObjetivo, DateTime desde, DateTime hasta)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdSucursal", idSucursal),
                acceso.CrearParametro("@IdCategoriaObjetivo", idCategoriaObjetivo),
                acceso.CrearParametro("@FechaDesde", desde),
                acceso.CrearParametro("@FechaHasta", hasta)
            };

            try
            {
                acceso.Abrir();
                return acceso.LeerEscalar("VALIDAR_SOLAPAMIENTO_PROMOCIONES", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public List<BE.PROMOCION> Listar()
        {
            List<BE.PROMOCION> lista = new List<BE.PROMOCION>();

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("LISTAR_PROMOCIONES_ACTIVAS", null);

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.PROMOCION promo = new BE.PROMOCION
                    {
                        IdPromocion = Convert.ToInt32(fila["ID_PROMOCION"]),
                        Nombre = fila["NOMBRE_PROMO"].ToString(),
                        TipoPromocion = fila["TIPO_PROMOCION"].ToString(),
                        Sucursal = new BE.SUCURSAL
                        {
                            Id = Convert.ToInt32(fila["ID_SUCURSAL"]),
                            Nombre = fila["SUCURSAL_NOMBRE"].ToString()
                        },
                        CategoriaObjetivo = new BE.CATEGORIA
                        {
                            Id = Convert.ToInt32(fila["ID_CATEGORIA_OBJETIVO"]),
                            Nombre = fila["CATEGORIA_OBJETIVO_NOMBRE"].ToString()
                        },
                        // Hidratación segura de la categoría de origen (solo viene si es Upgrade)
                        CategoriaOrigenUpgrade = fila["ID_CATEGORIA_ORIGEN_UPGRADE"] == DBNull.Value? null : new BE.CATEGORIA
                            {
                                Id = Convert.ToInt32(fila["ID_CATEGORIA_ORIGEN_UPGRADE"]),
                                Nombre = fila["CATEGORIA_ORIGEN_NOMBRE"].ToString()
                            },
                        PorcentajeDescuento = Convert.ToDecimal(fila["PORCENTAJE_DESCUENTO"]),
                        FechaDesde = Convert.ToDateTime(fila["FECHA_DESDE"]),
                        FechaHasta = Convert.ToDateTime(fila["FECHA_HASTA"]),
                        Motivo = fila["MOTIVO"].ToString(),
                        Activa = Convert.ToBoolean(fila["ACTIVA"])
                    };

                    lista.Add(promo);
                }
            }
            finally
            {
                acceso.Cerrar();
            }

            return lista;
        }

        public bool DesactivarPromocion(int idPromocion)
        {
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdPromocion", idPromocion)
            };

            try
            {
                acceso.Abrir();
                int filasAfectadas = acceso.Escribir("DESACTIVAR_PROMOCION", parametros);
                return filasAfectadas > 0;
            }
            finally
            {
                acceso.Cerrar();
            }
        }

    }
}
