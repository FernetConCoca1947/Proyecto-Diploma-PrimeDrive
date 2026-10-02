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
        public override void Alta(BE.VEHICULO vehiculo)
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

        public override void Baja(BE.VEHICULO vehiculo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idVehiculo", vehiculo.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("BORRAR_VEHICULO", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public override List<BE.VEHICULO> Listar()
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

                    veh.Estado = new BE.ESTADO
                    {
                        IdEstado = Convert.ToInt32(fila["ID_ESTADO"]),
                        Nombre = fila["ESTADO_NOMBRE"].ToString()
                    };

                    veh.Categoria = new BE.CATEGORIA
                    {
                        Id = Convert.ToInt32(fila["ID_CATEGORIA"]),
                        Nombre = fila["CATEGORIA_NOMBRE"].ToString(),
                        TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"])
                    };

                    veh.Sucursal = new BE.SUCURSAL
                    {
                        Id = Convert.ToInt32(fila["ID_SUCURSAL"]),
                        Nombre = fila["SUCURSAL_NOMBRE"].ToString()
                    };

                    listaVehiculos.Add(veh);
                }
            }
            finally
            {
                acceso.Cerrar();
            }

            return listaVehiculos;
        }

        public override void Modificar(BE.VEHICULO vehiculo)
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
                acceso.Escribir("REACTIVAR_VEHICULO", parametros);
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public BE.VEHICULO ObtenerInactivoDuplicado(string patente)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@patente", patente));

            try
            {
                acceso.Abrir();
                DataTable tabla = acceso.Leer("OBTENER_VEHICULO_INACTIVO_DUPLICADO", parametros);

                if (tabla.Rows.Count > 0)
                {
                    DataRow fila = tabla.Rows[0];
                    BE.VEHICULO veh = new BE.VEHICULO();

                    veh.Id = Convert.ToInt32(fila["ID_VEHICULO"]);
                    veh.Patente = fila["PATENTE"].ToString();
                    veh.Marca = fila["MARCA"].ToString();
                    veh.Modelo = fila["MODELO"].ToString();
                    veh.KmActual = Convert.ToInt32(fila["KM_ACTUAL"]);
                    veh.Estado = new BE.ESTADO { IdEstado = Convert.ToInt32(fila["ID_ESTADO"]) };
                    veh.Categoria = new BE.CATEGORIA { Id = Convert.ToInt32(fila["ID_CATEGORIA"]) };
                    veh.Sucursal = new BE.SUCURSAL { Id = Convert.ToInt32(fila["ID_SUCURSAL"]) };

                    return veh;
                }

                return null;
            }
            finally
            {
                acceso.Cerrar();
            }
        }

        public List<BE.VEHICULO> ListarDisponiblesPorSucursalYCategoria(int idSucursal, int idCategoria)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@idSucursal", idSucursal),
                acceso.CrearParametro("@idCategoria", idCategoria)
            };

            DataTable tabla = acceso.Leer("LISTAR_VEHICULOS_DISPONIBLES_SUCURSAL_CATEGORIA", parametros);
            acceso.Cerrar();

            List<BE.VEHICULO> listaVehiculos = new List<BE.VEHICULO>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.VEHICULO vehiculo = new BE.VEHICULO
                {
                    Id = Convert.ToInt32(fila["ID_VEHICULO"]),
                    Patente = fila["PATENTE"].ToString(),
                    Marca = fila["MARCA"].ToString(),
                    Modelo = fila["MODELO"].ToString(),
                    KmActual = Convert.ToInt32(fila["KM_ACTUAL"]),

                    Estado = new BE.ESTADO
                    {
                        IdEstado = Convert.ToInt32(fila["ID_ESTADO"])
                        //Nombre = fila["ESTADO_NOMBRE"].ToString()
                    },

                    Categoria = new BE.CATEGORIA
                    {
                        Id = Convert.ToInt32(fila["ID_CATEGORIA"])
                        //Nombre = fila["CATEGORIA_NOMBRE"].ToString(),
                        //TarifaDiaria = Convert.ToDecimal(fila["TARIFA_DIARIA"])
                    },

                    Sucursal = new BE.SUCURSAL
                    {
                        Id = Convert.ToInt32(fila["ID_SUCURSAL"])
                        //Nombre = fila["SUCURSAL_NOMBRE"].ToString()
                    }
                };

                listaVehiculos.Add(vehiculo);
            }

            return listaVehiculos;
        }

        public List<BE.VEHICULO> ListarVehiculosPorEstado(int idEstado)
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdEstado", idEstado)
            };

            // Leemos la base de datos
            DataTable tabla = acceso.Leer("OBTENER_VEHICULOS_POR_ESTADO", parametros);
            acceso.Cerrar();

            List<BE.VEHICULO> listaVehiculos = new List<BE.VEHICULO>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.VEHICULO vehiculo = new BE.VEHICULO
                {
                    Id = Convert.ToInt32(fila["ID_VEHICULO"]),
                    Patente = fila["PATENTE"].ToString(),

                    // Asumo que tu entidad vehículo tiene marca o modelo. Ajustalo a tus propiedades reales.
                    Marca = fila["MARCA"].ToString(),
                    Modelo = fila["MODELO"].ToString(),

                    KmActual = Convert.ToInt32(fila["KM_ACTUAL"]),

                    // LECTURA SEGURA DE NULLS: Si SQL Server devuelve NULL, lo mapeamos a null en C#. 
                    // Si tiene texto, lo convertimos a string.
                    ObservacionRevision = fila["OBSERVACION_REVISION"] == DBNull.Value
                                            ? null
                                            : fila["OBSERVACION_REVISION"].ToString(),

                    // Ensamblaje del objeto anidado ESTADO
                    Estado = new BE.ESTADO
                    {
                        IdEstado = Convert.ToInt32(fila["ID_ESTADO"]),
                        Nombre = fila["ESTADO_NOMBRE"].ToString()
                    }
                };

                listaVehiculos.Add(vehiculo);
            }

            return listaVehiculos;
        }

        public bool ResolverRevision(BE.VEHICULO vehiculo)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                acceso.CrearParametro("@IdVehiculo", vehiculo.Id),
                acceso.CrearParametro("@IdEstado", vehiculo.Estado.IdEstado),
        
                new SqlParameter("@ObservacionRevision", string.IsNullOrWhiteSpace(vehiculo.ObservacionRevision)
                                                ? (object)DBNull.Value
                                                : vehiculo.ObservacionRevision)
            };

            int filasAfectadas = acceso.Escribir("RESOLVER_REVISION_VEHICULO", parametros);
            //int filasAfectadas = acceso.LeerEscalar("RESOLVER_REVISION_VEHICULO", parametros);
            acceso.Cerrar();

            return filasAfectadas > 0;
        }

        public override bool Verificar(BE.VEHICULO vehiculo)
        {
            throw new NotImplementedException();
        }
    }
}
