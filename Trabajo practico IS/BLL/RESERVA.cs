using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RESERVA
    {
        private MP_RESERVA mapper = new MP_RESERVA();
        private BLL.BITACORA GestorBitacora = new BLL.BITACORA();

        public void GenerarReserva(BE.RESERVA reserva)
        {
            ValidarDatosObligatorios(reserva);
            ValidarFechas(reserva.FechaInicio, reserva.FechaFin);

            // Regla crítica: Comprobar stock de la categoría para ese rango de fechas
            if (!ValidarDisponibilidad(reserva.Categoria.Id, reserva.FechaInicio, reserva.FechaFin))
            {
                throw new Exception($"No hay vehículos de la categoría {reserva.Categoria.Nombre} disponibles para las fechas seleccionadas.");
            }

            reserva.Estado = new BE.ESTADO { IdEstado = 1, Nombre = "Pendiente" };
            mapper.Alta(reserva);

            GestorBitacora.RegistrarEvento("Reservas", $"Nueva reserva generada para el cliente DNI {reserva.Cliente.DNI}", 2);
        }

        public void CancelarReserva(BE.RESERVA reserva)
        {
            if (reserva.Estado.IdEstado == 3)
                throw new Exception("La reserva ya se encuentra cancelada.");

            reserva.Estado = new BE.ESTADO { IdEstado = 3, Nombre = "Cancelada" };
            mapper.ModificarEstado(reserva);
            GestorBitacora.RegistrarEvento("Reservas", $"Reserva #{reserva.Id} cancelada", 2);
        }

        private bool ValidarDisponibilidad(int idCategoria, DateTime inicio, DateTime fin)
        {
            int totalFlota = mapper.ContarVehiculosPorCategoria(idCategoria);
            int reservasSolapadas = mapper.ContarReservasActivas(idCategoria, inicio, fin);

            return (totalFlota - reservasSolapadas) > 0;
        }
        private void ValidarFechas(DateTime inicio, DateTime fin)
        {
            if (inicio.Date < DateTime.Now.Date)
                throw new Exception("La fecha de inicio no puede ser anterior a hoy.");

            if (fin.Date < inicio.Date)
                throw new Exception("La fecha de finalización debe ser igual o posterior a la fecha de inicio.");
        }
        private void ValidarDatosObligatorios(BE.RESERVA reserva)
        {
            if (reserva.Cliente == null || reserva.Cliente.Id <= 0)
                throw new Exception("Debe seleccionar un cliente válido.");

            if (reserva.Categoria == null || reserva.Categoria.Id <= 0)
                throw new Exception("Debe seleccionar una categoría de vehículo.");
        }
    }
}
