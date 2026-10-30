using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabajo_practico_IS
{
    public partial class FrmCTRLMantenimiento : Form, BE.IObserver
    {
        private BLL.MANTENIMIENTO GestorMantenimiento = new BLL.MANTENIMIENTO();
        private BLL.VEHICULO GestorVehiculos = new BLL.VEHICULO();
        private BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        public FrmCTRLMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmCTRLMantenimiento_Load(object sender, EventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Suscribir(this);
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;
            ActualizarIdioma();
            CargarVehiculosRevision();
            CargarVehiculosMantenimiento();
            CargarBuscadorHistorial();
            GB_DatosRemito.Enabled = false;
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

        private void CargarVehiculosRevision()
        {
            DGV_VehiculosRevision.DataSource = null;
            DGV_VehiculosRevision.DataSource = GestorVehiculos.ListarVehiculosPorEstado(10);

            DGV_VehiculosRevision.Columns["Id"].Visible = false;
            DGV_VehiculosRevision.Columns["Sucursal"].Visible = false;
            DGV_VehiculosRevision.Columns["Categoria"].Visible = false;
            DGV_VehiculosRevision.Columns["ObservacionRevision"].Visible = false; 
        }

        private void CargarVehiculosMantenimiento()
        {
            DGV_VehiculosMantenimiento.DataSource = null;
            DGV_VehiculosMantenimiento.DataSource = GestorVehiculos.ListarVehiculosPorEstado(3);
            DGV_VehiculosMantenimiento.Columns["Id"].Visible = false;
            DGV_VehiculosMantenimiento.Columns["Sucursal"].Visible = false;
            DGV_VehiculosMantenimiento.Columns["Categoria"].Visible = false;
            //DGV_VehiculosMantenimiento.Columns["ObservacionRevision"].Visible = false;
        }

        private void CargarBuscadorHistorial()
        {
            try
            {
                CBXVehiculoHistorial.DataSource = null;
                CBXVehiculoHistorial.DataSource = GestorVehiculos.Listar();

                CBXVehiculoHistorial.DisplayMember = "ToString";
                CBXVehiculoHistorial.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el buscador: " + ex.Message);
            }
        }

        private void DGV_VehiculosRevision_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_VehiculosRevision.CurrentRow != null)
            {
                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)DGV_VehiculosRevision.CurrentRow.DataBoundItem;

                TXT_CtrlMantReporteRevision.Text = autoSeleccionado.ObservacionRevision;
            }
            else
            {
                TXT_CtrlMantReporteRevision.Clear();
            }
        }

        private void DGV_VehiculosMantenimiento_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_VehiculosMantenimiento.CurrentRow != null)
            {
                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)DGV_VehiculosMantenimiento.CurrentRow.DataBoundItem;

                NUM_KmReal.Value = autoSeleccionado.KmActual;

                GB_DatosRemito.Enabled = true;
            }
            else
            {
                LimpiarControlesTaller();
                GB_DatosRemito.Enabled = false;
            }
        }
        private void BTNCtrlMantDesestimar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_VehiculosRevision.CurrentRow == null) throw new Exception("Seleccione un vehículo.");

                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)DGV_VehiculosRevision.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show($"¿Confirma que el vehículo {autoSeleccionado.Patente} está en condiciones y desea devolverlo a disponibilidad?", "Desestimar Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    GestorVehiculos.DesestimarRevision(autoSeleccionado);
                    MessageBox.Show("Vehículo liberado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVehiculosRevision();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void BTNCtrlMantDerivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_VehiculosRevision.CurrentRow == null) throw new Exception("Seleccione un vehículo.");

                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)DGV_VehiculosRevision.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show($"¿Confirma enviar el vehículo {autoSeleccionado.Patente} al Taller Mecánico?", "Derivar a Taller", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    GestorVehiculos.DerivarATaller(autoSeleccionado);
                    MessageBox.Show("Vehículo derivado a Mantenimiento. Ya puede gestionarlo desde la pestaña de Control de Taller.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVehiculosRevision();
                    CargarVehiculosMantenimiento();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void LimpiarControlesTaller()
        {
            NUM_KmReal.Value = 0;
            TXT_CtrlMantCosto.Clear();
            TXT_CtrlMantDetalleMantenimiento.Clear();
            DTP_FechaEntrada.Value = DateTime.Now;
            DTP_FechaSalida.Value = DateTime.Now;
        }

        private void BTNCtrlMantRetorno_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_VehiculosMantenimiento.CurrentRow == null)
                    throw new Exception("Debe seleccionar un vehículo de la grilla para reincorporarlo.");

                if (string.IsNullOrWhiteSpace(TXT_CtrlMantCosto.Text) || string.IsNullOrWhiteSpace(NUM_KmReal.Text))
                    throw new Exception("Debe completar el costo y el kilometraje real.");

                BE.MANTENIMIENTO remito = new BE.MANTENIMIENTO
                {
                    Vehiculo = (BE.VEHICULO)DGV_VehiculosMantenimiento.CurrentRow.DataBoundItem,
                    FechaEntrada = DTP_FechaEntrada.Value,
                    FechaSalida = DTP_FechaSalida.Value,
                    KmService = Convert.ToInt32(NUM_KmReal.Text),
                    Costo = Convert.ToDecimal(TXT_CtrlMantCosto.Text),
                    TareasRealizadas = TXT_CtrlMantDetalleMantenimiento.Text
                };

                GestorMantenimiento.RegistrarRetornoTaller(remito);

                MessageBox.Show($"¡Operación exitosa!\nEl vehículo {remito.Vehiculo.Patente} ha sido reincorporado y ya está DISPONIBLE en el mostrador.", "Alta de Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarVehiculosMantenimiento();
                LimpiarControlesTaller();
            }
            catch (FormatException)
            {
                MessageBox.Show("El costo y el kilometraje deben ser valores numéricos válidos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTNCtrlMantBuscarHist_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBXVehiculoHistorial.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un vehículo para auditar su historial.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)CBXVehiculoHistorial.SelectedItem;

                List<BE.MANTENIMIENTO> historialMantenimientos = GestorMantenimiento.ObtenerHistorial(autoSeleccionado.Id);

                DGV_HistorialMantenimiento.DataSource = null;
                DGV_HistorialMantenimiento.DataSource = historialMantenimientos;

                if (DGV_HistorialMantenimiento.Columns["Id"] != null)
                    DGV_HistorialMantenimiento.Columns["Id"].Visible = false;
                if (DGV_HistorialMantenimiento.Columns["Vehiculo"] != null)
                    DGV_HistorialMantenimiento.Columns["Vehiculo"].Visible = false;

                if (historialMantenimientos.Count > 0)
                {
                    int cantidadIngresos = historialMantenimientos.Count;

                    decimal gastoTotal = historialMantenimientos.Sum(remito => remito.Costo);

                    LBLDATOSCantidadIngresos.Text = cantidadIngresos.ToString();
                    LBLDATOSGastoAcumulado.Text = $"$ {gastoTotal:N2}";
                }
                else
                {
                    LBLDATOSCantidadIngresos.Text = "0";
                    LBLDATOSGastoAcumulado.Text = "$ 0.00";
                    MessageBox.Show("Este vehículo no registra mantenimientos previos en su legajo histórico.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_ExportarRemito_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_VehiculosMantenimiento.CurrentRow == null)
                    throw new Exception("Seleccione un vehículo de la grilla de taller.");

                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)DGV_VehiculosMantenimiento.CurrentRow.DataBoundItem;

                // Si ya escribiste datos en los TextBox los toma; si están vacíos, pone valores por defecto
                //int km = int.TryParse(TXT_KmRealTaller.Text.Trim(), out int kmVal) ? kmVal : autoSeleccionado.KmActual;
                int km = (int)NUM_KmReal.Value;
                decimal costo = decimal.TryParse(TXT_CtrlMantCosto.Text.Trim(), out decimal costoVal) ? costoVal : 0m;
                string tareas = string.IsNullOrWhiteSpace(TXT_CtrlMantDetalleMantenimiento.Text) ? "Pendiente de detalle técnico" : TXT_CtrlMantDetalleMantenimiento.Text.Trim();

                BE.MANTENIMIENTO remitoParaExportar = new BE.MANTENIMIENTO
                {
                    Vehiculo = autoSeleccionado,
                    FechaEntrada = DTP_FechaEntrada.Value,
                    FechaSalida = DTP_FechaSalida.Value,
                    KmService = km,
                    Costo = costo,
                    TareasRealizadas = tareas
                };

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo XML (*.xml)|*.xml";
                    sfd.Title = "Exportar Remito de Mantenimiento (Serializar)";
                    sfd.FileName = $"Remito_{autoSeleccionado.Patente}.xml";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Servicios.XmlSerializator<BE.MANTENIMIENTO> serializador = new Servicios.XmlSerializator<BE.MANTENIMIENTO>();
                        string rutaGenerada = serializador.Serializar(remitoParaExportar, sfd.FileName);

                        MessageBox.Show($"Remito serializado exitosamente en:\n{rutaGenerada}", "Serialización XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al serializar el mantenimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_ImportarRemito_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivo XML (*.xml)|*.xml";
                    ofd.Title = "Importar Remito del Taller (Deserializar)";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                        {
                            Servicios.XmlSerializator<BE.MANTENIMIENTO> serializador = new Servicios.XmlSerializator<BE.MANTENIMIENTO>();

                            // Reconstruimos el objeto BE.MANTENIMIENTO en memoria a partir del XML
                            BE.MANTENIMIENTO remitoImportado = serializador.Deserializar(fs);

                            // Volcamos los datos del objeto recuperado en los controles de la pantalla
                            DTP_FechaEntrada.Value = remitoImportado.FechaEntrada;
                            DTP_FechaSalida.Value = remitoImportado.FechaSalida;
                            NUM_KmReal.Text = remitoImportado.KmService.ToString();
                            TXT_CtrlMantCosto.Text = remitoImportado.Costo.ToString("0.00");
                            TXT_CtrlMantDetalleMantenimiento.Text = remitoImportado.TareasRealizadas;

                            MessageBox.Show("Remito deserializado correctamente. Verifique los datos autocompletados en pantalla antes de registrar el alta.", "Deserialización XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar el archivo XML: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
