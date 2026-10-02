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
    public partial class FrmCTRLReserva : Form, BE.IObserver
    {
        BLL.RESERVA GestorReservas = new BLL.RESERVA();
        BLL.BITACORA GestorBitacora = new BLL.BITACORA();
        BLL.CLIENTE GestorClientes = new BLL.CLIENTE();
        BLL.CATEGORIA GestorCategorias = new BLL.CATEGORIA();
        BLL.SUCURSAL GestorSucursales = new BLL.SUCURSAL();
        BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();

        BE.CLIENTE ClienteSeleccionado = null;
        BE.RESERVA ReservaSeleccionada = null;
        private List<BE.RESERVA> ListaReservas = new List<BE.RESERVA>();
        public FrmCTRLReserva()
        {
            InitializeComponent();
        }

        private void FrmCTRLReserva_Load(object sender, EventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Suscribir(this);
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            ActualizarIdioma();
            //CBX_Categoria.DataSource = GestorCategorias.Listar();
            //CBX_Categoria.DisplayMember = "Nombre";
            //CBX_Categoria.ValueMember = "Id";

            CBX_Categoria.Enabled = false;
            BTNCtrlResGenerar.Enabled = false;

            dateTimeRetiro.Value = DateTime.Now.Date;
            dateTimeDevolucion.Value = DateTime.Now.Date.AddDays(1);
            var listaSucursales = GestorSucursales.Listar();
            CBX_SucursalRetiro.DataSource = new List<BE.SUCURSAL>(listaSucursales);
            CBX_SucursalRetiro.DisplayMember = "Nombre";
            CBX_SucursalDevolucion.DataSource = new List<BE.SUCURSAL>(listaSucursales);
            CBX_SucursalDevolucion.DisplayMember = "Nombre";
            ActualizarIdioma();

            EnlazarReservas();
            ActualizarEstadoBotones();
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

        private void EnlazarReservas()
        {
            try
            {
                ListaReservas = GestorReservas.Listar();

                DGV_CtrlResReservas.DataSource = null;
                DGV_CtrlResReservas.DataSource = ListaReservas;
                DGV_CtrlResReservas.ReadOnly = true;

                if (DGV_CtrlResReservas.Columns["Id"] != null) DGV_CtrlResReservas.Columns["Id"].Visible = false;

                ActualizarEstadoBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar historial", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarEstadoBotones()
        {
            if (ReservaSeleccionada != null && (ReservaSeleccionada.Estado.IdEstado == 5 || ReservaSeleccionada.Estado.IdEstado == 6))
            {
                BTNCtrlResCancelar.Enabled = true;
            }
            else
            {
                BTNCtrlResCancelar.Enabled = false;
            }
        }

        private void DGV_CtrlResReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ReservaSeleccionada = DGV_CtrlResReservas.Rows[e.RowIndex].DataBoundItem as BE.RESERVA;
                if (ReservaSeleccionada != null)
                {
                    //LBL_ReservaSeleccionada.Text = ReservaSeleccionada.ToString();
                    ActualizarEstadoBotones();
                }
            }
        }

        private void LimpiarControles()
        {
            TXT_CtrlResDNI.Text = "";
            LBLDatosCliente.Text = "";
            ClienteSeleccionado = null;
            dateTimeRetiro.Value = DateTime.Now.Date;
            dateTimeDevolucion.Value = DateTime.Now.Date.AddDays(1);
            if (CBX_Categoria.Items.Count > 0) CBX_Categoria.SelectedIndex = 0;

            ReservaSeleccionada = null;
            ActualizarEstadoBotones();
            CBX_Categoria.DataSource = null;
            CBX_Categoria.Enabled = false;
            BTNCtrlResGenerar.Enabled = false;
        }

        private void BTNCtrlResBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(TXT_CtrlResDNI.Text.Trim(), out int dniBuscado))
                {
                    MessageBox.Show("Ingrese un DNI numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ClienteSeleccionado = GestorClientes.ObtenerPorDNI(dniBuscado);

                if (ClienteSeleccionado != null && ClienteSeleccionado.Activo)
                {
                    LBLDatosCliente.Text = ClienteSeleccionado.ToString();
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show(
                        $"No se encontró ningún cliente activo con el DNI {dniBuscado}.\n\n¿Desea registrarlo en el sistema ahora mismo?",
                        "Cliente no encontrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        FrmCTRLCliente frmCliente = new FrmCTRLCliente();
                        frmCliente.ShowDialog();

                        ClienteSeleccionado = GestorClientes.ObtenerPorDNI(dniBuscado);

                        if (ClienteSeleccionado != null && ClienteSeleccionado.Activo)
                        {
                            LBLDatosCliente.Text = ClienteSeleccionado.ToString();
                        }
                        else
                        {
                            LBLDatosCliente.Text = "Ninguno";
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTNCtrlResGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteSeleccionado == null)
                    throw new Exception("Debe buscar y seleccionar un cliente para iniciar la reserva.");

                BE.CATEGORIA categoriaElegida = (BE.CATEGORIA)CBX_Categoria.SelectedItem;
                if (categoriaElegida == null)
                    throw new Exception("Debe seleccionar una categoría.");

                BE.RESERVA nuevaReserva = new BE.RESERVA
                {
                    Cliente = ClienteSeleccionado,
                    Categoria = categoriaElegida,
                    SucursalRetiro = (BE.SUCURSAL)CBX_SucursalRetiro.SelectedItem,
                    SucursalDevolucion = (BE.SUCURSAL)CBX_SucursalDevolucion.SelectedItem,
                    FechaInicio = dateTimeRetiro.Value.Date,
                    FechaFin = dateTimeDevolucion.Value.Date,
                    Estado = new BE.ESTADO { IdEstado = 6, Nombre = "Confirmada" }
                };

                GestorReservas.GenerarReserva(nuevaReserva);

                MessageBox.Show("La reserva fue confirmada exitosamente.", "Reserva Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnlazarReservas();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNCtrlResCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReservaSeleccionada == null) return;

                DialogResult result = MessageBox.Show($"¿Desea cancelar la reserva del cliente {ReservaSeleccionada.Cliente.Nombre} {ReservaSeleccionada.Cliente.Apellido}?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GestorReservas.CancelarReserva(ReservaSeleccionada);
                    MessageBox.Show("La reserva ha sido cancelada.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EnlazarReservas();
                    ReservaSeleccionada = null;
                    //LBL_ReservaSeleccionada.Text = "Ninguna";
                    ActualizarEstadoBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNCtrlResConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReservaSeleccionada == null) return;

                DialogResult result = MessageBox.Show($"¿Desea confirmar la reserva del cliente {ReservaSeleccionada.Cliente.Nombre} {ReservaSeleccionada.Cliente.Apellido}?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GestorReservas.ConfirmarReserva(ReservaSeleccionada);
                    MessageBox.Show("La reserva ha sido confirmada.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EnlazarReservas();
                    ReservaSeleccionada = null;
                    //LBL_ReservaSeleccionada.Text = "Ninguna";
                    ActualizarEstadoBotones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cancelar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNvolveralmenu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea volver al menu principal?", "Atención",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmCTRLReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Desuscribir(this);
        }

        private void BTNCtrlResVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.SUCURSAL sucursalRetiro = (BE.SUCURSAL)CBX_SucursalRetiro.SelectedItem;
                if (sucursalRetiro == null) throw new Exception("Debe seleccionar una sucursal de retiro.");

                var categoriasLibres = GestorReservas.ValidarFechasYBuscarAlternativas(dateTimeRetiro.Value.Date, dateTimeDevolucion.Value.Date, sucursalRetiro.Id);

                if (categoriasLibres.Count == 0)
                {
                    MessageBox.Show("No hay disponibilidad de ninguna categoría para las fechas y sucursal solicitadas. Intente con otras fechas.", "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Apagamos los controles
                    CBX_Categoria.DataSource = null;
                    CBX_Categoria.Enabled = false;
                    BTNCtrlResGenerar.Enabled = false;
                }
                else
                {
                    // Encendemos y cargamos solo lo disponible
                    CBX_Categoria.DataSource = categoriasLibres;
                    CBX_Categoria.DisplayMember = "Nombre";
                    CBX_Categoria.ValueMember = "Id";

                    CBX_Categoria.Enabled = true;
                    BTNCtrlResGenerar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
