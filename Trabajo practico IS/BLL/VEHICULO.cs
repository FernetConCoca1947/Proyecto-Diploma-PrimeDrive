using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL
{
    public class VEHICULO
    {
        private MP_VEHICULO mapper = new MP_VEHICULO();
        private BLL.BITACORA GestorBitacora = new BLL.BITACORA();

        public void Insertar(BE.VEHICULO vehiculo)
        {
            BE.USUARIO usr = SeguridadBLL.ValidarPermiso("ABM_VEHICULOS");
            // 1. Validaciones de negocio (Ej: Patente obligatoria, unicidad)

            ValidarDatosObligatorios(vehiculo);

            // 2. Persistencia en la base de datos
            mapper.Alta(vehiculo);

            // 3. Registro de auditoría (Módulo de Seguridad Base)
            GestorBitacora.RegistrarEvento("Flota", $"Se dio de alta el vehículo: {vehiculo.Patente}",2);
        }

        public void Modificar(BE.VEHICULO vehiculo)
        {
            BE.USUARIO usr = SeguridadBLL.ValidarPermiso("ABM_VEHICULOS");
            ValidarDatosObligatorios(vehiculo);
            mapper.Modificar(vehiculo);
            GestorBitacora.RegistrarEvento("Flota", $"Se modifico el vehículo: {vehiculo.Patente}", 2);
        }

        public void Borrar(BE.VEHICULO vehiculo)
        {
            BE.USUARIO usr = SeguridadBLL.ValidarPermiso("ABM_VEHICULOS");
            mapper.Baja(vehiculo);
            GestorBitacora.RegistrarEvento("Flota", $"Se dio de baja el vehículo: {vehiculo.Patente}", 2);
        }

        public List<BE.VEHICULO> Listar()
        {
            return mapper.Listar();
        }

        public void Reactivar(BE.VEHICULO vehiculo)
        {
            BE.USUARIO usr = SeguridadBLL.ValidarPermiso("ABM_VEHICULOS");
            mapper.Reactivar(vehiculo);
        }


        public void ActualizarKilometraje(BE.VEHICULO vehiculo, int nuevoKilometraje)
        {
            BE.USUARIO usr = SeguridadBLL.ValidarPermiso("ABM_VEHICULOS");
            vehiculo.KmActual = nuevoKilometraje;

            // Evalúa si el nuevo kilometraje supera el umbral establecido (ej. 10.000 km)
            if (vehiculo.KmActual >= 10000)
            {
                // Cambia automáticamente el estado del vehículo a "Mantenimiento Preventivo" o "Baja"
                vehiculo.Estado = new BE.ESTADO { IdEstado = 3, Nombre = "Mantenimiento Preventivo" };
            }

            mapper.Modificar(vehiculo);
        }

        public BE.VEHICULO ObtenerInactivoDuplicado(string patente)
        {
            return mapper.ObtenerInactivoDuplicado(patente);
        }

        public List<BE.VEHICULO> ListarDisponiblesPorSucursalYCategoria(int idSucursal, int idCategoria)
        {
            if (idSucursal <= 0)
                throw new Exception("La sucursal seleccionada no es válida.");

            if (idCategoria <= 0)
                throw new Exception("La categoría seleccionada no es válida.");

            return mapper.ListarDisponiblesPorSucursalYCategoria(idSucursal, idCategoria);
        }

        public List<BE.VEHICULO> ListarVehiculosPorEstado(int idEstado)
        {
            if (idEstado <= 0)
                throw new Exception("El ID de estado proporcionado no es válido.");

            return mapper.ListarVehiculosPorEstado(idEstado);
        }

        public void DesestimarRevision(BE.VEHICULO vehiculo)
        {
            // Regla de Negocio: Si se desestima, el auto vuelve a estar disponible y se borra la alerta
            vehiculo.Estado = new BE.ESTADO { IdEstado = 1, Nombre = "Disponible" };
            vehiculo.ObservacionRevision = null;

            bool exito = mapper.ResolverRevision(vehiculo);
            if (!exito) throw new Exception("Error en la base de datos al liberar el vehículo.");
        }

        public void DerivarATaller(BE.VEHICULO vehiculo)
        {
            // Regla de Negocio: Si se deriva, pasa a Mantenimiento. 
            // NO borramos la ObservacionRevision para que el mecánico sepa qué arreglar.
            vehiculo.Estado = new BE.ESTADO { IdEstado = 3, Nombre = "Mantenimiento" };

            bool exito = mapper.ResolverRevision(vehiculo);
            if (!exito) throw new Exception("Error en la base de datos al derivar el vehículo.");
        }

        private void ValidarDatosObligatorios(BE.VEHICULO vehiculo)
        {
            if (string.IsNullOrWhiteSpace(vehiculo.Patente))
                throw new Exception("La patente es obligatoria.");

            bool formatoValido = Regex.IsMatch(vehiculo.Patente,@"^[A-Z]{2}\s?[0-9]{3}\s?[A-Z]{2}$");

            if (!formatoValido)
                throw new Exception("El formato de la patente es incorrecto. Debe respetar el formato 'AA 123 AA'.");

            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
                throw new Exception("La marca del vehículo es obligatoria.");

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
                throw new Exception("El modelo del vehículo es obligatorio.");

            if (vehiculo.Categoria == null || vehiculo.Categoria.Id <= 0)
                throw new Exception("Debe asignar una categoría al vehículo.");

            if (vehiculo.Sucursal == null || vehiculo.Sucursal.Id <= 0)
                throw new Exception("Debe asignar una sucursal física al vehículo.");

            if (vehiculo.Estado == null || vehiculo.Estado.IdEstado <= 0)
                throw new Exception("El vehículo debe tener un estado operativo asignado.");

            if (vehiculo.Estado != null && vehiculo.Estado.IdEstado == 10)
            {
                if (string.IsNullOrWhiteSpace(vehiculo.ObservacionRevision))
                {
                    throw new Exception("Error de Negocio: El vehículo no puede pasar al estado 'En Revisión' sin una observación técnica detallada.");
                }
            }
        }
    }
}
