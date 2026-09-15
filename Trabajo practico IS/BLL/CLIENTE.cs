using BE;
using DAL;
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
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre del producto no puede estar vacío.");

            //if (producto.Precio <= 0)
            //    throw new Exception("El precio debe ser mayor a cero.");

            //if (producto.Stock < 0)
            //    throw new Exception("El stock no puede ser negativo.");

            //var todos = mapper.Listar();
            //if (todos.Any(p => p.Nombre.Equals(producto.Nombre, StringComparison.OrdinalIgnoreCase) && p.Activo == true))
            //    throw new Exception("Ya existe un producto con ese nombre.");

            mapper.Alta(cliente);
            GestorBitacora.RegistrarEvento("Inventario", $"Se dio de alta el producto {cliente.Nombre}, {cliente.Apellido}", 2);
        }

        public void Borrar(BE.CLIENTE cliente)
        {
            cliente.Activo = false;
            mapper.Baja(cliente);
            GestorBitacora.RegistrarEvento("Inventario", $"Se dio de baja el producto {cliente.Nombre}, {cliente.Apellido}", 2);
        }

        public void Modificar(BE.CLIENTE cliente)
        {

        }
        public List<BE.CLIENTE> Listar()
        {
            return mapper.Listar();
        }
        public void Reactivar(BE.CLIENTE cliente)
        {
            List<BE.CLIENTE> todosLosProductos = mapper.Listar();

            bool productoExistente = todosLosProductos.Any(p =>
                p.Id != cliente.Id &&
                p.Activo == true &&
                p.DNI == cliente.DNI
                );

            if (productoExistente)
            {
                throw new Exception("Operación Denegada: Ya existe un cliente activo en el catálogo con este mismo nombre.");
            }

            cliente.Activo = true;
            mapper.Reactivar(cliente);

            GestorBitacora.RegistrarEvento("Inventario", $"Se reactivó el cliente: {cliente.Nombre}, {cliente.Apellido}", 3);
        }
        public BE.CLIENTE ObtenerInactivoDuplicado(BE.CLIENTE cliente)
        {
            List<BE.CLIENTE> todosLosProductos = mapper.Listar();

            return todosLosProductos.FirstOrDefault(p =>
                p.Activo == false &&
                p.DNI == cliente.DNI      
                );
        }
        private string ObtenerResponsable()
        {
            return Servicios.SESION.GetInstancia().usuactual != null
                ? Servicios.SESION.GetInstancia().usuactual.Usuario
                : "SISTEMA";
        }
    }
}
