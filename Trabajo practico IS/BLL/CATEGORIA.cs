using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CATEGORIA
    {
        MP_CATEGORIA mapper = new MP_CATEGORIA();
        BLL.BITACORA GestorBitacora = new BLL.BITACORA();

        public void Insertar(BE.CATEGORIA categoria)
        {
            if (categoria.TarifaDiaria <= 0)
            {
                throw new Exception("La tarifa diaria debe ser mayor a cero.");
            }

            //if (mapper.Verificar(categoria))
            //{
            //    throw new Exception("Ya existe una categoría registrada con el mismo nombre en el sistema.");
            //}

            mapper.Alta(categoria);
            GestorBitacora.RegistrarEvento("Flota", $"Se dio de alta la categoría: {categoria.Nombre}",2);
        }

        public void Borrar(BE.CATEGORIA categoria)
        {
            mapper.Baja(categoria);
            GestorBitacora.RegistrarEvento("Flota", $"Se dio de baja la categoría: {categoria.Nombre}", 2);
        }

        public void Modificar(BE.CATEGORIA categoria)
        {
            mapper.Modificar(categoria);
            GestorBitacora.RegistrarEvento("Flota", $"Se dio de modifico la categoría: {categoria.Nombre}", 2);
        }

        public List<BE.CATEGORIA> Listar()
        {
            return mapper.Listar();
        }

        public void Reactivar(BE.CATEGORIA categoria)
        {
            mapper.Reactivar(categoria);
            GestorBitacora.RegistrarEvento("Flota", $"Se dio de reactivo la categoría: {categoria.Nombre}", 2);
        }
    }
}
