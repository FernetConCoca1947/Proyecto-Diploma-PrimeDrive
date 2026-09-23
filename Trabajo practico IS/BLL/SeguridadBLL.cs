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
            // 1. Obtenemos el usuario de la sesión actual
            BE.USUARIO usuarioActual = SESION.GetInstancia().usuactual;

            // 2. Si no hay nadie logueado o no tiene el permiso, bloqueamos la operación
            if (usuarioActual == null || !usuarioActual.TienePermiso(permisoRequerido))
            {
                throw new Exception($"Acceso denegado: Operación cancelada por falta del permiso '{permisoRequerido}'.");
            }

            // 3. Retornamos el usuario para que la gestora pueda usar su nombre en la Bitácora
            return usuarioActual;
        }
    }
}
