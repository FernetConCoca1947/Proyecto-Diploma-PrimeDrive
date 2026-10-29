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
        private int IdSucursalPreseleccionada = 0;
        public FrmPromociones()
        {
            InitializeComponent();
        }
        public FrmPromociones(int idSucursalInicial) : this()
        {
            IdSucursalPreseleccionada = idSucursalInicial;
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

            if (IdSucursalPreseleccionada > 0)
            {
                CBX_Sucursal.SelectedValue = IdSucursalPreseleccionada;
            }

            GB_AprobacionPromo.Enabled = false;
            CargarGrillaPromocionesVigentes();
            ActualizarIdioma();

            if (CBX_Sucursal.SelectedItem != null)
            {
                BTN_AnalizarDemanda_Click(null, EventArgs.Empty);
            }
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

            if (DGV_PromosDiagnosticos.Columns["LucroCesante"] != null)
            {
                DGV_PromosDiagnosticos.Columns["LucroCesante"].HeaderText = "Lucro Cesante ($)";
                DGV_PromosDiagnosticos.Columns["LucroCesante"].DefaultCellStyle.Format = "C2";
            }
            if (DGV_PromosDiagnosticos.Columns["UnidadesOciosas"] != null)
                DGV_PromosDiagnosticos.Columns["UnidadesOciosas"].Visible = false;

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

                    LBL_DatosTipoAccion.Text = item.TipoAccionSugerida.ToUpper();
                    LBL_DatosValorCatObjetivo.Text = $"{item.Categoria.Nombre} ($ {item.Categoria.TarifaDiaria:N2})";

                    if (item.TipoAccionSugerida == "Upgrade Estratégico" && item.CategoriaOrigenSaturada != null)
                    {
                        LBL_DatosValorCatOrigen.Text = $"{item.CategoriaOrigenSaturada.Nombre} ($ {item.CategoriaOrigenSaturada.TarifaDiaria:N2})";
                        TXT_NombrePromo.Text = $"Upgrade {item.CategoriaOrigenSaturada.Nombre} a {item.Categoria.Nombre}";
                    }
                    else
                    {
                        LBL_DatosValorCatOrigen.Text = "N/A (Descuento Directo)";
                        TXT_NombrePromo.Text = $"Promo Baja Demanda - {item.Categoria.Nombre}";
                    }

                    // Ajustamos el porcentaje dentro de los límites del NumericUpDown (1% a 50%)
                    decimal descSugerido = Math.Min(Math.Max(item.DescuentoSugerido, NUD_Descuento.Minimum), NUD_Descuento.Maximum);
                    NUD_Descuento.Value = descSugerido;

                    TXT_MotivoPromo.Text = item.ExplicacionDetallada;
                    RecalcularTarifaEnVivo();
                }
                else
                {
                    LimpiarPanelAprobacion();
                }
            }
            else
            {
                TXT_PromosDetalleAlerta.Clear();
                LimpiarPanelAprobacion();
            }
        }

        private void DGV_PromosDiagnosticos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && DGV_PromosDiagnosticos.Rows[e.RowIndex].DataBoundItem is BE.DIAGNOSTICO_OCUPACION item)
            {
                if (item.TipoAccionSugerida == "Upgrade Estratégico")
                    DGV_PromosDiagnosticos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218); // Verde suave
                else if (item.TipoAccionSugerida == "Baja Demanda")
                    DGV_PromosDiagnosticos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205); // Amarillo suave
                else if (item.PorcentajeOcupacion >= 80)
                    DGV_PromosDiagnosticos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218); // Rojo suave
            }
        }

        private void RecalcularTarifaEnVivo()
        {
            if (DiagnosticoSeleccionado != null && DiagnosticoSeleccionado.Categoria != null)
            {
                decimal tarifaBase = DiagnosticoSeleccionado.Categoria.TarifaDiaria;
                decimal porcentaje = NUD_Descuento.Value;
                decimal tarifaFinal = Math.Round(tarifaBase * (1 - (porcentaje / 100m)), 2);

                LBL_DatosTarifaPromo.Text = $"$ {tarifaFinal:N2} / día";

                // NUEVO: Simulador de Ingreso Recuperable en vivo
                int diasAuditados = Math.Max(1, (dateTimeHasta.Value.Date - dateTimeDesde.Value.Date).Days + 1);
                decimal ingresoRecuperable = DiagnosticoSeleccionado.UnidadesOciosas * tarifaFinal * diasAuditados;
                LBL_DatosIngresoRecuperable.Text = $"$ {ingresoRecuperable:N2} ({DiagnosticoSeleccionado.UnidadesOciosas} unid. x {diasAuditados} días)";
            }
        }

        private void NUD_Descuento_ValueChanged(object sender, EventArgs e)
        {
            RecalcularTarifaEnVivo();
        }

        private void BTN_AprobarPromocion_Click(object sender, EventArgs e)
        {
            try
            {
                if (DiagnosticoSeleccionado == null || DiagnosticoSeleccionado.TipoAccionSugerida == "Ninguna")
                    throw new Exception("Debe seleccionar una alerta de Baja Demanda o Upgrade Estratégico en la grilla.");

                if (string.IsNullOrWhiteSpace(TXT_NombrePromo.Text))
                    throw new Exception("Debe ingresar un nombre identificatorio para la promoción.");

                BE.SUCURSAL sucursalElegida = (BE.SUCURSAL)CBX_Sucursal.SelectedItem;

                BE.PROMOCION nuevaPromo = new BE.PROMOCION
                {
                    Nombre = TXT_NombrePromo.Text.Trim(),
                    TipoPromocion = DiagnosticoSeleccionado.TipoAccionSugerida,
                    Sucursal = sucursalElegida,
                    CategoriaObjetivo = DiagnosticoSeleccionado.Categoria,
                    CategoriaOrigenUpgrade = DiagnosticoSeleccionado.CategoriaOrigenSaturada,
                    PorcentajeDescuento = NUD_Descuento.Value,
                    FechaDesde = dateTimeDesde.Value.Date,
                    FechaHasta = dateTimeHasta.Value.Date,
                    Motivo = TXT_MotivoPromo.Text.Trim(),
                    Activa = true
                };

                // La BLL valida fechas, rentabilidad y solapamiento (Flujo Alternativo 4.1) e inserta en BD
                GestorPromociones.AprobarPromocion(nuevaPromo);

                GestorBitacora.RegistrarEvento(
                    "Inteligencia Comercial",
                    $"Se lanzó {nuevaPromo.TipoPromocion}: {nuevaPromo.Nombre} ({nuevaPromo.PorcentajeDescuento}% OFF)",
                    2);

                MessageBox.Show(
                    $"¡{nuevaPromo.TipoPromocion} activada con éxito!\nLa tarifa bonificada de {nuevaPromo.CategoriaObjetivo.Nombre} ya se encuentra vigente en el mostrador de {nuevaPromo.Sucursal.Nombre}.",
                    "Promoción Publicada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarGrillaPromocionesVigentes();
                LimpiarPanelAprobacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación Comercial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarPanelAprobacion()
        {
            GB_AprobacionPromo.Enabled = false;
            TXT_NombrePromo.Clear();
            LBL_DatosTipoAccion.Text = "-";
            LBL_DatosValorCatOrigen.Text = "-";
            LBL_DatosValorCatObjetivo.Text = "-";
            LBL_DatosTarifaPromo.Text = "$ 0.00 / día";
            LBL_DatosIngresoRecuperable.Text = "$ 0.00";
            TXT_MotivoPromo.Clear();
        }

        private void CargarGrillaPromocionesVigentes()
        {
            try
            {
                DGV_PromocionesVigentes.DataSource = null;
                DGV_PromocionesVigentes.DataSource = GestorPromociones.ListarPromocionesActivas();
                DGV_PromocionesVigentes.ReadOnly = true;
                DGV_PromocionesVigentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DGV_PromocionesVigentes.MultiSelect = false;

                if (DGV_PromocionesVigentes.Columns["IdPromocion"] != null)
                    DGV_PromocionesVigentes.Columns["IdPromocion"].Visible = false;
                if (DGV_PromocionesVigentes.Columns["Activa"] != null)
                    DGV_PromocionesVigentes.Columns["Activa"].Visible = false;
                if (DGV_PromocionesVigentes.Columns["ReservasCaptadas"] != null)
                    DGV_PromocionesVigentes.Columns["ReservasCaptadas"].HeaderText = "Reservas Captadas";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar promociones vigentes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_DesactivarPromocion_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGV_PromocionesVigentes.CurrentRow == null)
                    throw new Exception("Seleccione una promoción vigente de la grilla inferior para desactivarla.");

                BE.PROMOCION promoSeleccionada = (BE.PROMOCION)DGV_PromocionesVigentes.CurrentRow.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea desactivar la promoción '{promoSeleccionada.Nombre}'?",
                    "Confirmar Baja Comercial",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    GestorPromociones.DesactivarPromocion(promoSeleccionada.IdPromocion);

                    GestorBitacora.RegistrarEvento(
                        "Inteligencia Comercial",
                        $"Se desactivó la promoción ID #{promoSeleccionada.IdPromocion}: {promoSeleccionada.Nombre}",
                        2);

                    MessageBox.Show("La promoción fue desactivada y dejó de aplicarse en mostrador.", "Baja Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrillaPromocionesVigentes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void FrmPromociones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Servicios.IDIOMAS.GetInstancia().Desuscribir(this);
        }
    }
}
