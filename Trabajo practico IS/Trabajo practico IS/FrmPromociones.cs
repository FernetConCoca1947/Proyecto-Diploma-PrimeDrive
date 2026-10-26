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
    public partial class FrmPromociones : Form, BE.IObserver
    {
        private BLL.SUCURSAL GestorSucursales = new BLL.SUCURSAL();
        private BLL.PROMOCION GestorPromociones = new BLL.PROMOCION();
        private BLL.IDIOMA gestorIdioma = new BLL.IDIOMA();
        private BLL.BITACORA GestorBitacora = new BLL.BITACORA();
        private BE.DIAGNOSTICO_OCUPACION DiagnosticoSeleccionado = null;
        public FrmPromociones()
        {
            InitializeComponent();
        }

        private void FrmPromociones_Load(object sender, EventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Suscribir(this);
            CBXidiomas.SelectedIndexChanged -= CBXidiomas_SelectedIndexChanged;
            CBXidiomas.DataSource = gestorIdioma.Listar();
            CBXidiomas.DisplayMember = "Nombre";
            CBXidiomas.ValueMember = "Id";
            CBXidiomas.SelectedValue = Servicios.IDIOMAS.GetInstancia().IdIdiomaActual;
            CBXidiomas.SelectedIndexChanged += CBXidiomas_SelectedIndexChanged;

            CBX_Sucursal.DataSource = GestorSucursales.Listar();
            CBX_Sucursal.DisplayMember = "Nombre";
            CBX_Sucursal.ValueMember = "Id";

            dateTimeDesde.Value = DateTime.Today;
            dateTimeHasta.Value = DateTime.Today.AddDays(7);

            GB_AprobacionPromo.Enabled = false;
            //CargarGrillaPromocionesVigentes();
            ActualizarIdioma();
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

        private void BTN_AnalizarDemanda_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBX_Sucursal.SelectedItem == null)
                    throw new Exception("Debe seleccionar una sucursal para realizar el diagnóstico.");

                BE.SUCURSAL sucursalElegida = (BE.SUCURSAL)CBX_Sucursal.SelectedItem;

                // Ejecutamos el motor algorítmico en la BLL
                List<BE.DIAGNOSTICO_OCUPACION> diagnostico = GestorPromociones.AnalizarOcupacionSucursal(sucursalElegida.Id,dateTimeDesde.Value.Date,dateTimeHasta.Value.Date);

                DGV_PromosDiagnosticos.DataSource = null;
                DGV_PromosDiagnosticos.DataSource = diagnostico;
                ConfigurarColumnasDiagnostico();

                // Flujo Alternativo 5.1 del CU07: Verificar si hay al menos una alerta accionable
                bool hayOportunidades = diagnostico.Exists(d => d.TipoAccionSugerida != "Ninguna");
                if (!hayOportunidades)
                {
                    MessageBox.Show(
                        "Todas las categorías se encuentran en niveles equilibrados de ocupación o saturadas sin gamas superiores ociosas.\nNo se requieren acciones promocionales para el período consultado.",
                        "Diagnóstico Óptimo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarColumnasDiagnostico()
        {
            DGV_PromosDiagnosticos.ReadOnly = true;
            DGV_PromosDiagnosticos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_PromosDiagnosticos.MultiSelect = false;

            // Ocultamos las columnas técnicas auxiliares que ya se ven en el panel derecho
            if (DGV_PromosDiagnosticos.Columns["TipoAccionSugerida"] != null)
                DGV_PromosDiagnosticos.Columns["TipoAccionSugerida"].Visible = false;
            if (DGV_PromosDiagnosticos.Columns["CategoriaOrigenSaturada"] != null)
                DGV_PromosDiagnosticos.Columns["CategoriaOrigenSaturada"].Visible = false;
            if (DGV_PromosDiagnosticos.Columns["DescuentoSugerido"] != null)
                DGV_PromosDiagnosticos.Columns["DescuentoSugerido"].Visible = false;
            if (DGV_PromosDiagnosticos.Columns["TarifaFinalSugerida"] != null)
                DGV_PromosDiagnosticos.Columns["TarifaFinalSugerida"].Visible = false;
            if (DGV_PromosDiagnosticos.Columns["ExplicacionDetallada"] != null)
                DGV_PromosDiagnosticos.Columns["ExplicacionDetallada"].Visible = false;
        }

        private void DGV_PromosDiagnosticos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_PromosDiagnosticos.CurrentRow != null && DGV_PromosDiagnosticos.CurrentRow.DataBoundItem is BE.DIAGNOSTICO_OCUPACION item)
            {
                DiagnosticoSeleccionado = item;
                TXT_PromosDetalleAlerta.Text = item.ExplicacionDetallada;

                // Solo habilitamos el Panel 3 si es una alerta accionable (CU08 o CU09)
                if (item.TipoAccionSugerida == "Upgrade Estratégico" || item.TipoAccionSugerida == "Baja Demanda")
                {
                    GB_AprobacionPromo.Enabled = true;

                    //LBL_ValorTipoAccion.Text = item.TipoAccionSugerida.ToUpper();
                    LBL_ValorCatObjetivo.Text = $"{item.Categoria.Nombre} ($ {item.Categoria.TarifaDiaria:N2})";

                    if (item.TipoAccionSugerida == "Upgrade Estratégico" && item.CategoriaOrigenSaturada != null)
                    {
                        LBL_ValorCatOrigen.Text = $"{item.CategoriaOrigenSaturada.Nombre} ($ {item.CategoriaOrigenSaturada.TarifaDiaria:N2})";
                        TXT_NombrePromo.Text = $"Upgrade {item.CategoriaOrigenSaturada.Nombre} a {item.Categoria.Nombre}";
                    }
                    else
                    {
                        LBL_ValorCatOrigen.Text = "N/A (Descuento Directo)";
                        TXT_NombrePromo.Text = $"Promo Baja Demanda - {item.Categoria.Nombre}";
                    }

                    // Ajustamos el porcentaje dentro de los límites del NumericUpDown (1% a 50%)
                    decimal descSugerido = Math.Min(Math.Max(item.DescuentoSugerido, NUD_Descuento.Minimum), NUD_Descuento.Maximum);
                    NUD_Descuento.Value = descSugerido;

                    TXT_MotivoPromo.Text = item.ExplicacionDetallada;
                    //RecalcularTarifaEnVivo();
                }
                else
                {
                    //LimpiarPanelConfiguracion();
                }
            }
            else
            {
                TXT_PromosDetalleAlerta.Clear();
                //LimpiarPanelConfiguracion();
            }
        }
    }
}
