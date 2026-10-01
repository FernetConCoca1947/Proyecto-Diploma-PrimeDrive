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
    public partial class FrmCTRLCheckIn : Form, BE.IObserver
    {
        BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        BLL.CONTRATO GestorContrato = new BLL.CONTRATO();
        BLL.VEHICULO GestorVehiculo = new BLL.VEHICULO();

        BE.CONTRATO ContratoSeleccionado = null;
        public FrmCTRLCheckIn()
        {
            InitializeComponent();
        }
        private void FrmCTRLCheckIn_Load(object sender, EventArgs e)
        {
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;

            CBX_BuscarPor.Items.AddRange(new string[] { "DNI Cliente", "Patente Vehículo" });
            CBX_BuscarPor.SelectedIndex = 0;

            CBX_NivelCombustible.Items.AddRange(new string[] { "Lleno", "3/4", "Medio", "Reserva" });

            BloquearPanelesOperativos(false);
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

        private void BTNCtrlCheckInBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string valorBusqueda = TXT_CtrlCheckInBuscar.Text.Trim();
                string criterio = CBX_BuscarPor.SelectedItem.ToString();

                // 1. Obtenemos la lista de contratos desde la BLL
                List<BE.CONTRATO> contratosEncontrados = GestorContrato.ObtenerContratosAbiertos(criterio, valorBusqueda);

                // 2. Evaluamos la cantidad de alquileres en curso
                if (contratosEncontrados.Count == 1)
                {
                    // Ocultamos el selector por si estaba visible de una búsqueda anterior
                    LBLSeleccionarVehiculo.Visible = false;
                    CBX_Contratos.Visible = false;

                    // Cargamos directamente el único contrato disponible
                    CargarDatosAuditoria(contratosEncontrados[0]);
                }
                else if (contratosEncontrados.Count > 1)
                {
                    // Encendemos los controles del selector en el Panel 1
                    LBLSeleccionarVehiculo.Visible = true;
                    CBX_Contratos.Visible = true;

                    // Poblamos el ComboBox
                    CBX_Contratos.DataSource = null;
                    CBX_Contratos.DataSource = contratosEncontrados;
                    CBX_Contratos.DisplayMember = "InfoVehiculoMultiple"; // Usa la propiedad que creamos en la BE
                    CBX_Contratos.SelectedIndex = -1; // Lo dejamos en blanco para obligar a seleccionar

                    MessageBox.Show("El cliente posee múltiples alquileres en curso.\nPor favor, seleccione la patente del vehículo que está ingresando.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarTodo();
            }
        }
        private void BTNCtrlCheckInCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoSeleccionado.KmEntrada = int.Parse(TXT_CtrlCheckInKmDevolucion.Text);
                string combustible = CBX_NivelCombustible.SelectedItem.ToString();
                decimal daños = string.IsNullOrWhiteSpace(TXT_CargosExtrasDaños.Text) ? 0 : decimal.Parse(TXT_CargosExtrasDaños.Text);

                decimal totalACobrar = GestorContrato.CalcularLiquidacionFinal(ContratoSeleccionado, combustible, daños);

                TimeSpan tiempoUso = ContratoSeleccionado.FechaHoraDevolucion.Value - ContratoSeleccionado.FechaHoraRetiro;
                int diasReales = tiempoUso.Days > 0 ? tiempoUso.Days : 1;
                decimal tarifaBaseCalculada = diasReales * ContratoSeleccionado.Reserva.Categoria.TarifaDiaria;

                // Deducción para mostrar el recargo de combustible separado
                decimal recargoCombustibleVisual = totalACobrar - tarifaBaseCalculada - daños;

                // Hidratación de pantalla
                LBLDATOSDiasUso.Text = diasReales.ToString();
                LBLDATOSTarifaTotal.Text = $"$ {tarifaBaseCalculada:N2}";
                LBLDATOSRecargoCombustible.Text = $"$ {recargoCombustibleVisual:N2}";
                LBLDATOSCargosDaños.Text = $"$ {daños:N2}";

                LBLDATOSMontoFinal.Text = $"$ {totalACobrar:N2}";
                BTNCtrlCheckInCerrarCont.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNCtrlCheckInCerrarCont_Click(object sender, EventArgs e)
        {
            try
            {
                // Control operativo cruzado
                if (!CHK_GarantiaLiberada.Checked)
                    throw new Exception("Debe confirmar la liberación de la garantía en el posnet físico antes de cerrar el contrato en el sistema.");

                // Cambiamos el estado de la entidad Contrato a "Cerrado" (ID 2)
                ContratoSeleccionado.Estado = new BE.ESTADO { IdEstado = 9, Nombre = "Cerrado" };
                ContratoSeleccionado.Observaciones += $" | Check-in Ok. Garantía liberada.";

                // Ejecutamos la Transacción Dual en la Capa de Negocio
                // Este método internamente actualizará el Contrato y derivará el Vehículo a "Disponible" o "Mantenimiento"
                GestorContrato.CerrarContratoCheckIn(ContratoSeleccionado);

                MessageBox.Show($"¡Check-in finalizado correctamente!\nContrato #{ContratoSeleccionado.Id} cerrado.\nLiquidación Total: $ {ContratoSeleccionado.MontoFinal:N2}", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo al ejecutar la transacción de Check-in: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosAuditoria(BE.CONTRATO contrato)
        {
            ContratoSeleccionado = contrato;

            // Hidratamos el Panel 1
            LBLDatosCliente.Text = $"{ContratoSeleccionado.Reserva.Cliente.Apellido}, {ContratoSeleccionado.Reserva.Cliente.Nombre} (DNI: {ContratoSeleccionado.Reserva.Cliente.DNI})";
            LBLDATOSVehiculo.Text = $"{ContratoSeleccionado.Vehiculo.Patente} - {ContratoSeleccionado.Reserva.Categoria.Nombre}";
            LBLDATOSRetiro.Text = ContratoSeleccionado.FechaHoraRetiro.ToString("dd/MM/yyyy HH:mm");
            LBLDATOSGarantia.Text = $"$ {ContratoSeleccionado.GarantiaRetenida:N2}";

            // Preparamos el Panel 2 (Auditoría)
            LBLDATOSKilometrajeSalida.Text = ContratoSeleccionado.KmSalida.ToString();
            CBX_NivelCombustible.SelectedIndex = 0;
            TXT_CargosExtrasDaños.Text = "0.00";

            BloquearPanelesOperativos(true); // Habilitamos los controles para cargar kilometraje
            BTNCtrlCheckInCerrarCont.Enabled = false;
            CHK_GarantiaLiberada.Checked = false;
        }

        private void BloquearPanelesOperativos(bool estado)
        {
            // Panel 2
            TXT_CtrlCheckInKmDevolucion.Enabled = estado;
            CBX_NivelCombustible.Enabled = estado;
            TXT_CargosExtrasDaños.Enabled = estado;
            BTNCtrlCheckInCalcular.Enabled = estado;

            // Panel 3
            CHK_GarantiaLiberada.Enabled = estado;
        }

        private void LimpiarTodo()
        {
            ContratoSeleccionado = null;

            TXT_CtrlCheckInBuscar.Clear();
            LBLDatosCliente.Text = "-";
            LBLDATOSVehiculo.Text = "-";
            LBLDATOSRetiro.Text = "-";
            LBLDATOSGarantia.Text = "$ 0.00";

            TXT_CtrlCheckInKmDevolucion.Clear();
            TXT_CargosExtrasDaños.Clear();
            CBX_NivelCombustible.SelectedIndex = -1;

            LBLDATOSDiasUso.Text = "0";
            LBLDATOSTarifaTotal.Text = "$ 0.00";
            LBLDATOSCargosDaños.Text = "$ 0.00";
            LBLDATOSMontoFinal.Text = "$ 0.00";

            BloquearPanelesOperativos(false);
            BTNCtrlCheckInCerrarCont.Enabled = false;
            CHK_GarantiaLiberada.Checked = false;
        }

        private void CBX_Contratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBX_Contratos.SelectedItem is BE.CONTRATO contratoSeleccionado)
            {
                CargarDatosAuditoria(contratoSeleccionado);
            }
        }
    }
}
