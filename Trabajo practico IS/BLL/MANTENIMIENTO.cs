using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MANTENIMIENTO
    {
        MP_MANTENIMIENTO mapper = new MP_MANTENIMIENTO();

        public void RegistrarRetornoTaller(BE.MANTENIMIENTO remito)
        {
            if (remito.Vehiculo == null || remito.Vehiculo.Id == 0)
                throw new Exception("El remito debe estar asociado a un vehículo válido.");

            if (remito.FechaEntrada > remito.FechaSalida)
                throw new Exception("Incoherencia temporal: La fecha de entrada al taller no puede ser posterior a la fecha de salida.");

            if (remito.FechaSalida > DateTime.Now)
                throw new Exception("La fecha de salida no puede ser una fecha futura.");

            if (remito.Costo < 0)
                throw new Exception("El costo de la reparación no puede ser un valor negativo.");

            if (remito.KmService < remito.Vehiculo.KmActual)
                throw new Exception($"El kilometraje reportado por el taller ({remito.KmService} km) no puede ser menor al kilometraje con el que el vehículo ingresó ({remito.Vehiculo.KmActual} km).");

            if (string.IsNullOrWhiteSpace(remito.TareasRealizadas))
                throw new Exception("Debe detallar obligatoriamente las tareas realizadas por el mecánico en el remito.");

            bool exito = mapper.RegistrarRemito(remito);

            if (!exito)
                throw new Exception("Ocurrió un error en la base de datos al intentar registrar el mantenimiento y reincorporar el vehículo.");
        }

        public List<BE.MANTENIMIENTO> ObtenerHistorial(int idVehiculo)
        {
            return mapper.ListarHistorialPorVehiculo(idVehiculo);
        }
    }
}
