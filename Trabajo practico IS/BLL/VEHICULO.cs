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

        // Regla de Negocio Core de Prime Drive
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

            // Actualiza el registro físico a través de la DAL
            mapper.Modificar(vehiculo);
        }

        public BE.VEHICULO ObtenerInactivoDuplicado(string patente)
        {
            return mapper.ObtenerInactivoDuplicado(patente);
        }

        private void ValidarDatosObligatorios(BE.VEHICULO vehiculo)
        {
            // 1. Validación de cadenas de texto (Textos en blanco)
            if (string.IsNullOrWhiteSpace(vehiculo.Patente))
                throw new Exception("La patente es obligatoria.");

            bool formatoValido = Regex.IsMatch(vehiculo.Patente,@"^[A-Z]{2}\s?[0-9]{3}\s?[A-Z]{2}$");

            if (!formatoValido)
                throw new Exception("El formato de la patente es incorrecto. Debe respetar el formato 'AA 123 AA'.");

            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
                throw new Exception("La marca del vehículo es obligatoria.");

            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
                throw new Exception("El modelo del vehículo es obligatorio.");

            // 2. Validación de objetos compuestos (Desplegables nulos en la GUI)
            if (vehiculo.Categoria == null || vehiculo.Categoria.Id <= 0)
                throw new Exception("Debe asignar una categoría al vehículo.");

            if (vehiculo.Sucursal == null || vehiculo.Sucursal.Id <= 0)
                throw new Exception("Debe asignar una sucursal física al vehículo.");

            if (vehiculo.Estado == null || vehiculo.Estado.IdEstado <= 0)
                throw new Exception("El vehículo debe tener un estado operativo asignado.");
        }
    }
}
