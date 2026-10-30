namespace Trabajo_practico_IS
{
    partial class FrmPromociones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.GB_ParametrosAnalisis = new System.Windows.Forms.GroupBox();
            this.BTN_AnalizarDemanda = new System.Windows.Forms.Button();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.LBLFechaHasta = new System.Windows.Forms.Label();
            this.CBX_Sucursal = new System.Windows.Forms.ComboBox();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.LBLSucursal = new System.Windows.Forms.Label();
            this.LBLFechaDesde = new System.Windows.Forms.Label();
            this.GB_Diagnostico = new System.Windows.Forms.GroupBox();
            this.LBL_DetalleDiagnostico = new System.Windows.Forms.Label();
            this.TXT_PromosDetalleAlerta = new System.Windows.Forms.TextBox();
            this.GB_AprobacionPromo = new System.Windows.Forms.GroupBox();
            this.LBL_DatosIngresoRecuperable = new System.Windows.Forms.Label();
            this.LBL_IngresoRecuperable = new System.Windows.Forms.Label();
            this.BTN_AprobarPromocion = new System.Windows.Forms.Button();
            this.LBL_DatosTarifaPromo = new System.Windows.Forms.Label();
            this.LBL_DatosValorCatObjetivo = new System.Windows.Forms.Label();
            this.LBL_DatosValorCatOrigen = new System.Windows.Forms.Label();
            this.LBL_DatosTipoAccion = new System.Windows.Forms.Label();
            this.NUD_Descuento = new System.Windows.Forms.NumericUpDown();
            this.TXT_MotivoPromo = new System.Windows.Forms.TextBox();
            this.LBL_MotivoPromo = new System.Windows.Forms.Label();
            this.LBL_TarifaPromo = new System.Windows.Forms.Label();
            this.LBL_PorcDescuento = new System.Windows.Forms.Label();
            this.LBL_ValorCatObjetivo = new System.Windows.Forms.Label();
            this.LBL_ValorCatOrigen = new System.Windows.Forms.Label();
            this.LBL_TipoAccion = new System.Windows.Forms.Label();
            this.TXT_NombrePromo = new System.Windows.Forms.TextBox();
            this.LBLNombrePromo = new System.Windows.Forms.Label();
            this.GB_PromocionesVigentes = new System.Windows.Forms.GroupBox();
            this.BTN_ExportarReporte = new System.Windows.Forms.Button();
            this.BTN_DesactivarPromocion = new System.Windows.Forms.Button();
            this.DGV_PromosDiagnosticos = new System.Windows.Forms.DataGridView();
            this.DGV_PromocionesVigentes = new System.Windows.Forms.DataGridView();
            this.GB_ParametrosAnalisis.SuspendLayout();
            this.GB_Diagnostico.SuspendLayout();
            this.GB_AprobacionPromo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Descuento)).BeginInit();
            this.GB_PromocionesVigentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PromosDiagnosticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PromocionesVigentes)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(1200, 19);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 35;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(1200, 38);
            this.CBXidiomas.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(154, 25);
            this.CBXidiomas.TabIndex = 34;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(1273, 873);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(154, 35);
            this.BTNvolveralmenu.TabIndex = 36;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // GB_ParametrosAnalisis
            // 
            this.GB_ParametrosAnalisis.Controls.Add(this.BTN_AnalizarDemanda);
            this.GB_ParametrosAnalisis.Controls.Add(this.dateTimeHasta);
            this.GB_ParametrosAnalisis.Controls.Add(this.LBLFechaHasta);
            this.GB_ParametrosAnalisis.Controls.Add(this.CBX_Sucursal);
            this.GB_ParametrosAnalisis.Controls.Add(this.dateTimeDesde);
            this.GB_ParametrosAnalisis.Controls.Add(this.LBLSucursal);
            this.GB_ParametrosAnalisis.Controls.Add(this.LBLFechaDesde);
            this.GB_ParametrosAnalisis.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_ParametrosAnalisis.Location = new System.Drawing.Point(12, 12);
            this.GB_ParametrosAnalisis.Name = "GB_ParametrosAnalisis";
            this.GB_ParametrosAnalisis.Size = new System.Drawing.Size(1149, 77);
            this.GB_ParametrosAnalisis.TabIndex = 37;
            this.GB_ParametrosAnalisis.TabStop = false;
            this.GB_ParametrosAnalisis.Text = "Parámetros de auditoría";
            // 
            // BTN_AnalizarDemanda
            // 
            this.BTN_AnalizarDemanda.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_AnalizarDemanda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AnalizarDemanda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_AnalizarDemanda.Location = new System.Drawing.Point(987, 31);
            this.BTN_AnalizarDemanda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_AnalizarDemanda.Name = "BTN_AnalizarDemanda";
            this.BTN_AnalizarDemanda.Size = new System.Drawing.Size(154, 35);
            this.BTN_AnalizarDemanda.TabIndex = 43;
            this.BTN_AnalizarDemanda.Text = "Analizar";
            this.BTN_AnalizarDemanda.UseVisualStyleBackColor = false;
            this.BTN_AnalizarDemanda.Click += new System.EventHandler(this.BTN_AnalizarDemanda_Click);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(661, 43);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(300, 23);
            this.dateTimeHasta.TabIndex = 44;
            // 
            // LBLFechaHasta
            // 
            this.LBLFechaHasta.AutoSize = true;
            this.LBLFechaHasta.Location = new System.Drawing.Point(661, 24);
            this.LBLFechaHasta.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLFechaHasta.Name = "LBLFechaHasta";
            this.LBLFechaHasta.Size = new System.Drawing.Size(108, 17);
            this.LBLFechaHasta.TabIndex = 42;
            this.LBLFechaHasta.Text = "Fecha de hasta";
            // 
            // CBX_Sucursal
            // 
            this.CBX_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Sucursal.FormattingEnabled = true;
            this.CBX_Sucursal.Location = new System.Drawing.Point(8, 41);
            this.CBX_Sucursal.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.CBX_Sucursal.Name = "CBX_Sucursal";
            this.CBX_Sucursal.Size = new System.Drawing.Size(301, 25);
            this.CBX_Sucursal.TabIndex = 46;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(338, 43);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(300, 23);
            this.dateTimeDesde.TabIndex = 43;
            // 
            // LBLSucursal
            // 
            this.LBLSucursal.AutoSize = true;
            this.LBLSucursal.Location = new System.Drawing.Point(8, 22);
            this.LBLSucursal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLSucursal.Name = "LBLSucursal";
            this.LBLSucursal.Size = new System.Drawing.Size(59, 17);
            this.LBLSucursal.TabIndex = 45;
            this.LBLSucursal.Text = "Sucursal";
            // 
            // LBLFechaDesde
            // 
            this.LBLFechaDesde.AutoSize = true;
            this.LBLFechaDesde.Location = new System.Drawing.Point(338, 24);
            this.LBLFechaDesde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLFechaDesde.Name = "LBLFechaDesde";
            this.LBLFechaDesde.Size = new System.Drawing.Size(111, 17);
            this.LBLFechaDesde.TabIndex = 41;
            this.LBLFechaDesde.Text = "Fecha de desde";
            // 
            // GB_Diagnostico
            // 
            this.GB_Diagnostico.Controls.Add(this.BTN_ExportarReporte);
            this.GB_Diagnostico.Controls.Add(this.LBL_DetalleDiagnostico);
            this.GB_Diagnostico.Controls.Add(this.TXT_PromosDetalleAlerta);
            this.GB_Diagnostico.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Diagnostico.Location = new System.Drawing.Point(12, 98);
            this.GB_Diagnostico.Name = "GB_Diagnostico";
            this.GB_Diagnostico.Size = new System.Drawing.Size(905, 460);
            this.GB_Diagnostico.TabIndex = 38;
            this.GB_Diagnostico.TabStop = false;
            this.GB_Diagnostico.Text = "Diagnóstico";
            // 
            // LBL_DetalleDiagnostico
            // 
            this.LBL_DetalleDiagnostico.AutoSize = true;
            this.LBL_DetalleDiagnostico.Location = new System.Drawing.Point(8, 285);
            this.LBL_DetalleDiagnostico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DetalleDiagnostico.Name = "LBL_DetalleDiagnostico";
            this.LBL_DetalleDiagnostico.Size = new System.Drawing.Size(133, 17);
            this.LBL_DetalleDiagnostico.TabIndex = 43;
            this.LBL_DetalleDiagnostico.Text = "Detalle algorítmico";
            // 
            // TXT_PromosDetalleAlerta
            // 
            this.TXT_PromosDetalleAlerta.Location = new System.Drawing.Point(11, 313);
            this.TXT_PromosDetalleAlerta.Multiline = true;
            this.TXT_PromosDetalleAlerta.Name = "TXT_PromosDetalleAlerta";
            this.TXT_PromosDetalleAlerta.ReadOnly = true;
            this.TXT_PromosDetalleAlerta.Size = new System.Drawing.Size(886, 75);
            this.TXT_PromosDetalleAlerta.TabIndex = 0;
            // 
            // GB_AprobacionPromo
            // 
            this.GB_AprobacionPromo.Controls.Add(this.LBL_DatosIngresoRecuperable);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_IngresoRecuperable);
            this.GB_AprobacionPromo.Controls.Add(this.BTN_AprobarPromocion);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_DatosTarifaPromo);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_DatosValorCatObjetivo);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_DatosValorCatOrigen);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_DatosTipoAccion);
            this.GB_AprobacionPromo.Controls.Add(this.NUD_Descuento);
            this.GB_AprobacionPromo.Controls.Add(this.TXT_MotivoPromo);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_MotivoPromo);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_TarifaPromo);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_PorcDescuento);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_ValorCatObjetivo);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_ValorCatOrigen);
            this.GB_AprobacionPromo.Controls.Add(this.LBL_TipoAccion);
            this.GB_AprobacionPromo.Controls.Add(this.TXT_NombrePromo);
            this.GB_AprobacionPromo.Controls.Add(this.LBLNombrePromo);
            this.GB_AprobacionPromo.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_AprobacionPromo.Location = new System.Drawing.Point(923, 98);
            this.GB_AprobacionPromo.Name = "GB_AprobacionPromo";
            this.GB_AprobacionPromo.Size = new System.Drawing.Size(512, 460);
            this.GB_AprobacionPromo.TabIndex = 39;
            this.GB_AprobacionPromo.TabStop = false;
            this.GB_AprobacionPromo.Text = "Aprobación de promoción";
            // 
            // LBL_DatosIngresoRecuperable
            // 
            this.LBL_DatosIngresoRecuperable.AutoSize = true;
            this.LBL_DatosIngresoRecuperable.Location = new System.Drawing.Point(241, 285);
            this.LBL_DatosIngresoRecuperable.Name = "LBL_DatosIngresoRecuperable";
            this.LBL_DatosIngresoRecuperable.Size = new System.Drawing.Size(163, 17);
            this.LBL_DatosIngresoRecuperable.TabIndex = 49;
            this.LBL_DatosIngresoRecuperable.Text = "Ingreso recuperable dat";
            // 
            // LBL_IngresoRecuperable
            // 
            this.LBL_IngresoRecuperable.AutoSize = true;
            this.LBL_IngresoRecuperable.Location = new System.Drawing.Point(241, 268);
            this.LBL_IngresoRecuperable.Name = "LBL_IngresoRecuperable";
            this.LBL_IngresoRecuperable.Size = new System.Drawing.Size(136, 17);
            this.LBL_IngresoRecuperable.TabIndex = 48;
            this.LBL_IngresoRecuperable.Text = "Ingreso recuperable";
            // 
            // BTN_AprobarPromocion
            // 
            this.BTN_AprobarPromocion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_AprobarPromocion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AprobarPromocion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_AprobarPromocion.Location = new System.Drawing.Point(350, 418);
            this.BTN_AprobarPromocion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_AprobarPromocion.Name = "BTN_AprobarPromocion";
            this.BTN_AprobarPromocion.Size = new System.Drawing.Size(154, 35);
            this.BTN_AprobarPromocion.TabIndex = 47;
            this.BTN_AprobarPromocion.Text = "Aprobar promocion";
            this.BTN_AprobarPromocion.UseVisualStyleBackColor = false;
            this.BTN_AprobarPromocion.Click += new System.EventHandler(this.BTN_AprobarPromocion_Click);
            // 
            // LBL_DatosTarifaPromo
            // 
            this.LBL_DatosTarifaPromo.AutoSize = true;
            this.LBL_DatosTarifaPromo.Location = new System.Drawing.Point(8, 285);
            this.LBL_DatosTarifaPromo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DatosTarifaPromo.Name = "LBL_DatosTarifaPromo";
            this.LBL_DatosTarifaPromo.Size = new System.Drawing.Size(116, 17);
            this.LBL_DatosTarifaPromo.TabIndex = 42;
            this.LBL_DatosTarifaPromo.Text = "Tarifa Promo dat";
            // 
            // LBL_DatosValorCatObjetivo
            // 
            this.LBL_DatosValorCatObjetivo.AutoSize = true;
            this.LBL_DatosValorCatObjetivo.Location = new System.Drawing.Point(8, 188);
            this.LBL_DatosValorCatObjetivo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DatosValorCatObjetivo.Name = "LBL_DatosValorCatObjetivo";
            this.LBL_DatosValorCatObjetivo.Size = new System.Drawing.Size(122, 17);
            this.LBL_DatosValorCatObjetivo.TabIndex = 41;
            this.LBL_DatosValorCatObjetivo.Text = "Cat. objetivo dat";
            // 
            // LBL_DatosValorCatOrigen
            // 
            this.LBL_DatosValorCatOrigen.AutoSize = true;
            this.LBL_DatosValorCatOrigen.Location = new System.Drawing.Point(8, 142);
            this.LBL_DatosValorCatOrigen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DatosValorCatOrigen.Name = "LBL_DatosValorCatOrigen";
            this.LBL_DatosValorCatOrigen.Size = new System.Drawing.Size(126, 17);
            this.LBL_DatosValorCatOrigen.TabIndex = 40;
            this.LBL_DatosValorCatOrigen.Text = "Cat. saturada dat";
            // 
            // LBL_DatosTipoAccion
            // 
            this.LBL_DatosTipoAccion.AutoSize = true;
            this.LBL_DatosTipoAccion.Location = new System.Drawing.Point(8, 96);
            this.LBL_DatosTipoAccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_DatosTipoAccion.Name = "LBL_DatosTipoAccion";
            this.LBL_DatosTipoAccion.Size = new System.Drawing.Size(131, 17);
            this.LBL_DatosTipoAccion.TabIndex = 39;
            this.LBL_DatosTipoAccion.Text = "Tipo de Acción dat";
            // 
            // NUD_Descuento
            // 
            this.NUD_Descuento.DecimalPlaces = 2;
            this.NUD_Descuento.Location = new System.Drawing.Point(8, 237);
            this.NUD_Descuento.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUD_Descuento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Descuento.Name = "NUD_Descuento";
            this.NUD_Descuento.Size = new System.Drawing.Size(120, 23);
            this.NUD_Descuento.TabIndex = 38;
            this.NUD_Descuento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Descuento.ValueChanged += new System.EventHandler(this.NUD_Descuento_ValueChanged);
            // 
            // TXT_MotivoPromo
            // 
            this.TXT_MotivoPromo.Location = new System.Drawing.Point(8, 333);
            this.TXT_MotivoPromo.Multiline = true;
            this.TXT_MotivoPromo.Name = "TXT_MotivoPromo";
            this.TXT_MotivoPromo.Size = new System.Drawing.Size(493, 75);
            this.TXT_MotivoPromo.TabIndex = 37;
            // 
            // LBL_MotivoPromo
            // 
            this.LBL_MotivoPromo.AutoSize = true;
            this.LBL_MotivoPromo.Location = new System.Drawing.Point(8, 313);
            this.LBL_MotivoPromo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_MotivoPromo.Name = "LBL_MotivoPromo";
            this.LBL_MotivoPromo.Size = new System.Drawing.Size(215, 17);
            this.LBL_MotivoPromo.TabIndex = 36;
            this.LBL_MotivoPromo.Text = "Motivo / Justificación comercial";
            // 
            // LBL_TarifaPromo
            // 
            this.LBL_TarifaPromo.AutoSize = true;
            this.LBL_TarifaPromo.Location = new System.Drawing.Point(8, 268);
            this.LBL_TarifaPromo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_TarifaPromo.Name = "LBL_TarifaPromo";
            this.LBL_TarifaPromo.Size = new System.Drawing.Size(89, 17);
            this.LBL_TarifaPromo.TabIndex = 35;
            this.LBL_TarifaPromo.Text = "Tarifa Promo";
            // 
            // LBL_PorcDescuento
            // 
            this.LBL_PorcDescuento.AutoSize = true;
            this.LBL_PorcDescuento.Location = new System.Drawing.Point(8, 217);
            this.LBL_PorcDescuento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_PorcDescuento.Name = "LBL_PorcDescuento";
            this.LBL_PorcDescuento.Size = new System.Drawing.Size(100, 17);
            this.LBL_PorcDescuento.TabIndex = 34;
            this.LBL_PorcDescuento.Text = "Descuento (%)";
            // 
            // LBL_ValorCatObjetivo
            // 
            this.LBL_ValorCatObjetivo.AutoSize = true;
            this.LBL_ValorCatObjetivo.Location = new System.Drawing.Point(8, 171);
            this.LBL_ValorCatObjetivo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_ValorCatObjetivo.Name = "LBL_ValorCatObjetivo";
            this.LBL_ValorCatObjetivo.Size = new System.Drawing.Size(95, 17);
            this.LBL_ValorCatObjetivo.TabIndex = 33;
            this.LBL_ValorCatObjetivo.Text = "Cat. objetivo";
            // 
            // LBL_ValorCatOrigen
            // 
            this.LBL_ValorCatOrigen.AutoSize = true;
            this.LBL_ValorCatOrigen.Location = new System.Drawing.Point(8, 125);
            this.LBL_ValorCatOrigen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_ValorCatOrigen.Name = "LBL_ValorCatOrigen";
            this.LBL_ValorCatOrigen.Size = new System.Drawing.Size(99, 17);
            this.LBL_ValorCatOrigen.TabIndex = 32;
            this.LBL_ValorCatOrigen.Text = "Cat. saturada";
            // 
            // LBL_TipoAccion
            // 
            this.LBL_TipoAccion.AutoSize = true;
            this.LBL_TipoAccion.Location = new System.Drawing.Point(8, 79);
            this.LBL_TipoAccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBL_TipoAccion.Name = "LBL_TipoAccion";
            this.LBL_TipoAccion.Size = new System.Drawing.Size(104, 17);
            this.LBL_TipoAccion.TabIndex = 31;
            this.LBL_TipoAccion.Text = "Tipo de Acción";
            // 
            // TXT_NombrePromo
            // 
            this.TXT_NombrePromo.Location = new System.Drawing.Point(8, 49);
            this.TXT_NombrePromo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_NombrePromo.Name = "TXT_NombrePromo";
            this.TXT_NombrePromo.Size = new System.Drawing.Size(301, 23);
            this.TXT_NombrePromo.TabIndex = 29;
            // 
            // LBLNombrePromo
            // 
            this.LBLNombrePromo.AutoSize = true;
            this.LBLNombrePromo.Location = new System.Drawing.Point(8, 27);
            this.LBLNombrePromo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLNombrePromo.Name = "LBLNombrePromo";
            this.LBLNombrePromo.Size = new System.Drawing.Size(130, 17);
            this.LBLNombrePromo.TabIndex = 30;
            this.LBLNombrePromo.Text = "Nombre campaña";
            // 
            // GB_PromocionesVigentes
            // 
            this.GB_PromocionesVigentes.Controls.Add(this.BTN_DesactivarPromocion);
            this.GB_PromocionesVigentes.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_PromocionesVigentes.Location = new System.Drawing.Point(12, 564);
            this.GB_PromocionesVigentes.Name = "GB_PromocionesVigentes";
            this.GB_PromocionesVigentes.Size = new System.Drawing.Size(1423, 305);
            this.GB_PromocionesVigentes.TabIndex = 40;
            this.GB_PromocionesVigentes.TabStop = false;
            this.GB_PromocionesVigentes.Text = "Promociones y upgrades activos";
            // 
            // BTN_ExportarReporte
            // 
            this.BTN_ExportarReporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_ExportarReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ExportarReporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_ExportarReporte.Location = new System.Drawing.Point(743, 399);
            this.BTN_ExportarReporte.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_ExportarReporte.Name = "BTN_ExportarReporte";
            this.BTN_ExportarReporte.Size = new System.Drawing.Size(154, 48);
            this.BTN_ExportarReporte.TabIndex = 49;
            this.BTN_ExportarReporte.Text = "Exportar reporte";
            this.BTN_ExportarReporte.UseVisualStyleBackColor = false;
            this.BTN_ExportarReporte.Click += new System.EventHandler(this.BTN_ExportarReporte_Click);
            // 
            // BTN_DesactivarPromocion
            // 
            this.BTN_DesactivarPromocion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_DesactivarPromocion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DesactivarPromocion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_DesactivarPromocion.Location = new System.Drawing.Point(1258, 245);
            this.BTN_DesactivarPromocion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_DesactivarPromocion.Name = "BTN_DesactivarPromocion";
            this.BTN_DesactivarPromocion.Size = new System.Drawing.Size(154, 48);
            this.BTN_DesactivarPromocion.TabIndex = 48;
            this.BTN_DesactivarPromocion.Text = "Desactivar promocion";
            this.BTN_DesactivarPromocion.UseVisualStyleBackColor = false;
            this.BTN_DesactivarPromocion.Click += new System.EventHandler(this.BTN_DesactivarPromocion_Click);
            // 
            // DGV_PromosDiagnosticos
            // 
            this.DGV_PromosDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PromosDiagnosticos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.DGV_PromosDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PromosDiagnosticos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PromosDiagnosticos.Location = new System.Drawing.Point(22, 126);
            this.DGV_PromosDiagnosticos.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.DGV_PromosDiagnosticos.Name = "DGV_PromosDiagnosticos";
            this.DGV_PromosDiagnosticos.Size = new System.Drawing.Size(887, 238);
            this.DGV_PromosDiagnosticos.TabIndex = 41;
            this.DGV_PromosDiagnosticos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_PromosDiagnosticos_CellFormatting);
            this.DGV_PromosDiagnosticos.SelectionChanged += new System.EventHandler(this.DGV_PromosDiagnosticos_SelectionChanged);
            // 
            // DGV_PromocionesVigentes
            // 
            this.DGV_PromocionesVigentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PromocionesVigentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_PromocionesVigentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_PromocionesVigentes.Location = new System.Drawing.Point(22, 589);
            this.DGV_PromocionesVigentes.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.DGV_PromocionesVigentes.Name = "DGV_PromocionesVigentes";
            this.DGV_PromocionesVigentes.Size = new System.Drawing.Size(1402, 214);
            this.DGV_PromocionesVigentes.TabIndex = 42;
            // 
            // FrmPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1449, 916);
            this.Controls.Add(this.DGV_PromocionesVigentes);
            this.Controls.Add(this.DGV_PromosDiagnosticos);
            this.Controls.Add(this.GB_PromocionesVigentes);
            this.Controls.Add(this.GB_AprobacionPromo);
            this.Controls.Add(this.GB_Diagnostico);
            this.Controls.Add(this.GB_ParametrosAnalisis);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPromociones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPromociones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPromociones_FormClosing);
            this.Load += new System.EventHandler(this.FrmPromociones_Load);
            this.GB_ParametrosAnalisis.ResumeLayout(false);
            this.GB_ParametrosAnalisis.PerformLayout();
            this.GB_Diagnostico.ResumeLayout(false);
            this.GB_Diagnostico.PerformLayout();
            this.GB_AprobacionPromo.ResumeLayout(false);
            this.GB_AprobacionPromo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Descuento)).EndInit();
            this.GB_PromocionesVigentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PromosDiagnosticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PromocionesVigentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.Button BTNvolveralmenu;
        private System.Windows.Forms.GroupBox GB_ParametrosAnalisis;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Label LBLFechaHasta;
        private System.Windows.Forms.ComboBox CBX_Sucursal;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label LBLSucursal;
        private System.Windows.Forms.Label LBLFechaDesde;
        private System.Windows.Forms.GroupBox GB_Diagnostico;
        private System.Windows.Forms.GroupBox GB_AprobacionPromo;
        private System.Windows.Forms.GroupBox GB_PromocionesVigentes;
        private System.Windows.Forms.DataGridView DGV_PromosDiagnosticos;
        private System.Windows.Forms.TextBox TXT_PromosDetalleAlerta;
        private System.Windows.Forms.TextBox TXT_NombrePromo;
        private System.Windows.Forms.Label LBLNombrePromo;
        private System.Windows.Forms.TextBox TXT_MotivoPromo;
        private System.Windows.Forms.Label LBL_MotivoPromo;
        private System.Windows.Forms.Label LBL_TarifaPromo;
        private System.Windows.Forms.Label LBL_PorcDescuento;
        private System.Windows.Forms.Label LBL_ValorCatObjetivo;
        private System.Windows.Forms.Label LBL_ValorCatOrigen;
        private System.Windows.Forms.Label LBL_TipoAccion;
        private System.Windows.Forms.NumericUpDown NUD_Descuento;
        private System.Windows.Forms.DataGridView DGV_PromocionesVigentes;
        private System.Windows.Forms.Label LBL_DetalleDiagnostico;
        private System.Windows.Forms.Button BTN_AnalizarDemanda;
        private System.Windows.Forms.Button BTN_AprobarPromocion;
        private System.Windows.Forms.Label LBL_DatosTarifaPromo;
        private System.Windows.Forms.Label LBL_DatosValorCatObjetivo;
        private System.Windows.Forms.Label LBL_DatosValorCatOrigen;
        private System.Windows.Forms.Label LBL_DatosTipoAccion;
        private System.Windows.Forms.Button BTN_DesactivarPromocion;
        private System.Windows.Forms.Label LBL_DatosIngresoRecuperable;
        private System.Windows.Forms.Label LBL_IngresoRecuperable;
        private System.Windows.Forms.Button BTN_ExportarReporte;
    }
}