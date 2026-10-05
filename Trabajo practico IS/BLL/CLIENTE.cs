using BE;
using DAL;
using Servicios.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CLIENTE
    {
        MP_CLIENTE mapper = new MP_CLIENTE();
        BLL.BITACORA GestorBitacora = new BLL.BITACORA();


        public void Insertar(BE.CLIENTE cliente)
        {
            ValidarDatosObligatorios(cliente);

            if (cliente.FechaVencimientoLicencia < DateTime.Now.Date)
            {
                throw new Exception("La licencia de conducir ingresada ya se encuentra vencida.");
            }

            BE.CLIENTE clienteExistente = mapper.ObtenerPorDNI(cliente.DNI);
            if (clienteExistente != null)
            {
                throw new Exception("El cliente con el DNI ingresado ya existe en el sistema.");
            }

            mapper.Alta(cliente);
            GestorBitacora.RegistrarEvento("Clientes", $"Se dio de alta el cliente {cliente.Nombre}, {cliente.Apellido}", 2);
        }

        public void Borrar(BE.CLIENTE cliente)
        {
            cliente.Activo = false;
            mapper.Baja(cliente);
            GestorBitacora.RegistrarEvento("Clientes", $"Se dio de baja el cliente {cliente.Nombre}, {cliente.Apellido}", 2);
        }

        public void Modificar(BE.CLIENTE cliente)
        {
            ValidarDatosObligatorios(cliente);
            if (cliente.FechaVencimientoLicencia < DateTime.Now.Date)
            {
                throw new Exception("La licencia de conducir ingresada ya se encuentra vencida.");
            }

            mapper.Modificar(cliente);
            GestorBitacora.RegistrarEvento("Inventario", $"Se modificó el cliente {cliente.Nombre}, {cliente.Apellido}", 2);
        }
        public List<BE.CLIENTE> Listar()
        {
            return mapper.Listar();
        }
        public void Reactivar(BE.CLIENTE cliente)  //VER ESTO
        {
            List<BE.CLIENTE> todosLosClientes = mapper.Listar();

            bool ClienteExistente = todosLosClientes.Any(c =>
                c.Id != cliente.Id &&
                c.Activo == true &&
                c.DNI == cliente.DNI
                );

            if (ClienteExistente)
            {
                throw new Exception("Ya existe un cliente activo con este mismo nombre.");
            }

            cliente.Activo = true;
            mapper.Reactivar(cliente);

            GestorBitacora.RegistrarEvento("Clientes", $"Se reactivó el cliente: {cliente.Nombre}, {cliente.Apellido}", 3);
        }
        public BE.CLIENTE ObtenerInactivoDuplicado(BE.CLIENTE cliente)
        {
            BE.CLIENTE clienteEncontrado = mapper.ObtenerPorDNI(cliente.DNI);

            if (clienteEncontrado != null && clienteEncontrado.Activo == false)
            {
                return clienteEncontrado;
            }

            return null;
        }

        public BE.CLIENTE ObtenerPorDNI(int dni)
        {
            if (dni <= 0)
            {
                throw new Exception("El DNI ingresado no es válido.");
            }

            BE.CLIENTE clienteEncontrado = mapper.ObtenerPorDNI(dni);

            if (clienteEncontrado == null)
            {
                return null;
            }

            return clienteEncontrado;
        }

        private void ValidarDatosObligatorios(BE.CLIENTE cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new Exception("El nombre es obligatorio.");
            }
            
            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new Exception("El apellido es obligatorio.");
            }

            if (cliente.DNI <= 0)
            {
                throw new Exception("El DNI ingresado es inválido.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Email))
            {
                throw new Exception("El campo Email es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Telefono))
            {
                throw new Exception("El número de Teléfono es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(cliente.NumeroLicenciaConducir))
            {
                throw new Exception("El Número de Licencia de Conducir es obligatorio para procesar el alquiler.");
            }

            if (cliente.FechaVencimientoLicencia == DateTime.MinValue)
            {
                throw new Exception("Debe ingresar una Fecha de Vencimiento de Licencia válida.");
            }
        }
    }
}
