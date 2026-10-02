using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_practico_IS
{
    public partial class FrmCTRLCheckOut : Form, BE.IObserver
    {
        BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        BLL.CONTRATO GestorContrato = new BLL.CONTRATO();
        BLL.RESERVA GestorReserva = new BLL.RESERVA();
        BLL.VEHICULO GestorVehiculo = new BLL.VEHICULO();
        BE.RESERVA ReservaSeleccionada = null;
        BE.VEHICULO VehiculoSeleccionado = null;
        public FrmCTRLCheckOut()
        {
            InitializeComponent();
        }
        private void FrmCTRLCheckOut_Load(object sender, EventArgs e)
        {
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            ActualizarIdioma();
            BloquearControlesOperativos(false);
            LBLDATOSRetiro.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            CBX_MetodoPago.Items.Clear();
            CBX_MetodoPago.Items.Add("Tarjeta de Crédito");
            CBX_MetodoPago.Items.Add("Tarjeta de Débito");
            CBX_MetodoPago.Items.Add("Efectivo");
            CBX_MetodoPago.SelectedIndex = 0;
        }

        public void ActualizarIdioma()
        {
            var traducciones = Servicios.IDIOMAS.GetInstancia().Traducciones;
            TraducirControles(this.Controls, traducciones);
            if (traducciones.TryGetValue($"{this.Name}_Titulo", out string textoTitulo)) this.Text = textoTitulo;
            if (CBXidiomas.Items.Count > 0)
            {
                CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
                CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
                CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            }
        }
        public void TraducirControles(Control.ControlCollection controles, Dictionary<string, string> traducciones)
        {
            foreach (Control control in controles)
            {
                string clave = $"{this.Name}_{control.Name}";
                if (traducciones.TryGetValue(clave, out string textoTraducido)) control.Text = textoTraducido;
                if (control.HasChildren) TraducirControles(control.Controls, traducciones);
            }
        }

        private void CBXidiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CBXidiomas.SelectedValue != null && int.TryParse(CBXidiomas.SelectedValue.ToString(), out int idIdioma))
                {
                    BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
                    var traducciones = gestorIdioma.ObtenerTraducciones(idIdioma);
                    Servicios.IDIOMAS.GetInstancia().CambiarIdioma(idIdioma, traducciones);

                    if (Servicios.SESION.GetInstancia().usuactual != null)
                    {
                        BLL.USUARIO gestorUsu = new BLL.USUARIO();
                        gestorUsu.ActualizarIdiomaUsuario(Servicios.SESION.GetInstancia().usuactual, idIdioma);
                        Servicios.SESION.GetInstancia().usuactual.IdIdioma = idIdioma;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void BTNCCtrlChkOutBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(TXT_CtrlChkOutDNI.Text.Trim(), out int dni))
                {
                    throw new Exception("Ingrese un número de DNI válido para buscar reservas.");
                }

                // Consumimos el método de la BLL que filtra por DNI y estado "Confirmada" (ID 6)
                List<BE.RESERVA> reservasConfirmadas = GestorReserva.ObtenerReservasConfirmadasPorDNI(dni);

                CBX_ReservasCliente.DataSource = reservasConfirmadas;
                CBX_ReservasCliente.DisplayMember = "ToString"; // Muestra el formato amigable de la entidad
                CBX_ReservasCliente.SelectedIndex = -1;

                MessageBox.Show($"Se encontraron {reservasConfirmadas.Count} reserva(s) confirmada(s).", "Búsqueda Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarPanelReserva();
            }
        }

        private void CBX_ReservasCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_ReservasCliente.SelectedItem is BE.RESERVA reserva)
            {
                ReservaSeleccionada = reserva;

                LBLDATOSCliente.Text = $"{reserva.Cliente.Apellido}, {reserva.Cliente.Nombre} (DNI: {reserva.Cliente.DNI})";
                LBLDATOSDevolucion.Text = reserva.SucursalDevolucion.Nombre;
                LBLDATOScategoria.Text = reserva.Categoria.Nombre;
                LBLDATOSTarifaDiaria.Text = $"$ {reserva.Categoria.TarifaDiaria:N2}";

                TimeSpan diferenciaFechas = reserva.FechaFin.Date - reserva.FechaInicio.Date;

                int diasEstimados = diferenciaFechas.Days > 0 ? diferenciaFechas.Days : 1;
                LBLDATOSDiasEstimado.Text = diasEstimados.ToString();

                // Habilitamos el Panel 2 y cargamos la flota física disponible
                CargarFlotaDisponible(reserva.SucursalRetiro.Id, reserva.Categoria.Id);
                BloquearControlesOperativos(true);
            }
        }

        private void CargarFlotaDisponible(int idSucursalRetiro, int idCategoria)
        {
            try
            {
                // Buscamos vehículos físicos en esa sucursal, de esa categoría, con Estado = 1 (Disponible)
                List<BE.VEHICULO> vehiculosDisponibles = GestorVehiculo.ListarDisponiblesPorSucursalYCategoria(idSucursalRetiro, idCategoria);

                CBX_VehiculosDisponibles.DataSource = vehiculosDisponibles;
                CBX_VehiculosDisponibles.DisplayMember = "ToString"; // Muestra la patente en el combo
                CBX_VehiculosDisponibles.SelectedIndex = -1;
                TXT_CtrlChkOutKmAct.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la flota física: " + ex.Message, "Error DAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBX_VehiculosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_VehiculosDisponibles.SelectedItem is BE.VEHICULO vehiculo)
            {
                VehiculoSeleccionado = vehiculo;
                TXT_CtrlChkOutKmAct.Text = vehiculo.KmActual.ToString();
            }
        }

        private void BTNCCtrlChkOutGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validaciones de Interfaz
                if (ReservaSeleccionada == null)
                    throw new Exception("Debe seleccionar una reserva válida.");

                if (VehiculoSeleccionado == null)
                    throw new Exception("Debe asignar un vehículo físico (patente) para la entrega.");

                if (!decimal.TryParse(TXT_CtrlChkOutGarantia.Text.Trim(), out decimal garantia) || garantia <= 0)
                    throw new Exception("Debe ingresar un monto de garantía retenida válido.");

                if (!int.TryParse(TXT_CtrlChkOutKmAct.Text.Trim(), out int kmSalida))
                    throw new Exception("El kilometraje de salida no es válido.");

                // 2. Construcción de la Entidad Contrato
                BE.CONTRATO nuevoContrato = new BE.CONTRATO
                {
                    Reserva = ReservaSeleccionada,
                    Vehiculo = VehiculoSeleccionado,
                    FechaHoraRetiro = DateTime.Now,
                    KmSalida = kmSalida,
                    GarantiaRetenida = garantia,
                    Observaciones = TXT_CtrlChkOutObservaciones.Text.Trim(),
                    Estado = new BE.ESTADO { IdEstado = 8, Nombre = "Abierto" } // Estado del contrato
                };

                // 3. Ejecución a través de la Capa de Negocio (Dispara la Transacción Dual)
                GestorContrato.GenerarContrato(nuevoContrato);

                MessageBox.Show($"¡Check-out exitoso!\nContrato #{nuevoContrato.Id} generado correctamente.\nVehículo {VehiculoSeleccionado.Patente} marcado como Alquilado.", "Operación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Limpieza de pantalla para el próximo cliente
                LimpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Crítico en Check-out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearControlesOperativos(bool estado)
        {
            CBX_VehiculosDisponibles.Enabled = estado;
            TXT_CtrlChkOutGarantia.Enabled = estado;
            TXT_CtrlChkOutObservaciones.Enabled = estado;
            BTNCCtrlChkOutGenerar.Enabled = estado;
        }

        private void LimpiarPanelReserva()
        {
            ReservaSeleccionada = null;
            LBLDATOSCliente.Text = "-";
            LBLDATOSDevolucion.Text = "-";
            LBLDATOScategoria.Text = "-";
            LBLDATOScategoria.Text = "$ 0.00";
            CBX_ReservasCliente.DataSource = null;
            BloquearControlesOperativos(false);
        }

        private void LimpiarTodo()
        {
            TXT_CtrlChkOutDNI.Clear();
            LimpiarPanelReserva();
            CBX_VehiculosDisponibles.DataSource = null;
            TXT_CtrlChkOutKmAct.Clear();
            TXT_CtrlChkOutGarantia.Clear();
            TXT_CtrlChkOutObservaciones.Clear();
        }
    }
}
