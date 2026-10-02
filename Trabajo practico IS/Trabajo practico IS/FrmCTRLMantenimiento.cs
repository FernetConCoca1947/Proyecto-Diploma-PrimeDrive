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

            // Ocultar columnas irrelevantes si es necesario
            DGV_VehiculosRevision.Columns["ObservacionRevision"].Visible = false; 
        }

        private void DGV_VehiculosRevision_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_VehiculosRevision.CurrentRow != null)
            {
                BE.VEHICULO autoSeleccionado = (BE.VEHICULO)DGV_VehiculosRevision.CurrentRow.DataBoundItem;

                // Rellenamos el cuadro de texto de solo lectura con el reporte del mostrador
                TXT_CtrlMantReporteRevision.Text = autoSeleccionado.ObservacionRevision;
            }
            else
            {
                TXT_CtrlMantReporteRevision.Clear();
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
                    // CargarGrillaTaller(); -> Si tenés un método para recargar la Pestaña 2, llamalo acá
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}
