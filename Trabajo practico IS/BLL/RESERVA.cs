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
        private BLL.CATEGORIA GestorCategoria = new BLL.CATEGORIA();

        public void GenerarReserva(BE.RESERVA reserva)
        {
            ValidarDatosObligatorios(reserva);
            ValidarFechas(reserva.FechaInicio, reserva.FechaFin);

            var categoriasLibres = GestorCategoria.ConsultarDisponibles(reserva.FechaInicio, reserva.FechaFin, reserva.SucursalRetiro.Id);

            if (!categoriasLibres.Any(c => c.Id == reserva.Categoria.Id))
            {
                throw new Exception($"La categoría {reserva.Categoria.Nombre} acaba de ser reservada por otro usuario. Vuelva a verificar disponibilidad.");
            }

            mapper.Alta(reserva);

            GestorBitacora.RegistrarEvento("Reservas", $"Nueva reserva generada para el cliente DNI {reserva.Cliente.DNI}", 2);
        }

        public void CancelarReserva(BE.RESERVA reserva)
        {
            if (reserva.Estado.IdEstado == 7)
                throw new Exception("La reserva ya se encuentra cancelada.");

            reserva.Estado = new BE.ESTADO { IdEstado = 7, Nombre = "Cancelada" };
            mapper.ModificarEstado(reserva);
            GestorBitacora.RegistrarEvento("Reservas", $"Reserva #{reserva.Id} cancelada", 2);
        }

        public void ConfirmarReserva(BE.RESERVA reserva)
        {
            if (reserva.Estado.IdEstado == 6)
                throw new Exception("La reserva ya se encuentra confirmada.");

            reserva.Estado = new BE.ESTADO { IdEstado = 6, Nombre = "Confirmada" };
            mapper.ModificarEstado(reserva);
            GestorBitacora.RegistrarEvento("Reservas", $"Reserva #{reserva.Id} confirmada", 2);
        }

        public List<BE.RESERVA> Listar()
        {
            return mapper.Listar();
        }

        public List<BE.CATEGORIA> ValidarFechasYBuscarAlternativas(DateTime inicio, DateTime fin, int idSucursalRetiro)
        {
            ValidarFechas(inicio, fin);
            return GestorCategoria.ConsultarDisponibles(inicio, fin, idSucursalRetiro);
        }

        public List<BE.RESERVA> ObtenerReservasConfirmadasPorDNI(int dni)
        {
            if (dni <= 0)
                throw new Exception("Ingrese un número de DNI válido.");

            var reservas = mapper.ListarConfirmadasPorDNI(dni);

            if (reservas.Count == 0)
                throw new Exception("No se encontraron reservas en estado 'Confirmada' para el DNI ingresado.");

            return reservas;
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
