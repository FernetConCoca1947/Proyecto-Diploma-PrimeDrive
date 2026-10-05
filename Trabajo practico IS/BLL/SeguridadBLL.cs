using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal static class SeguridadBLL
    {
        public static BE.USUARIO ValidarPermiso(string permisoRequerido)
        {
            BE.USUARIO usuarioActual = SESION.GetInstancia().usuactual;

            if (usuarioActual == null || !usuarioActual.TienePermiso(permisoRequerido))
            {
                throw new Exception($"Acceso denegado: Operación cancelada por falta del permiso '{permisoRequerido}'.");
            }
            return usuarioActual;
        }
    }
}
