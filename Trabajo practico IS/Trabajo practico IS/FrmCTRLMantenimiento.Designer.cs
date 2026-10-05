namespace Trabajo_practico_IS
{
    partial class FrmCTRLMantenimiento
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
            this.TAB_CTRLMantenimientos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV_VehiculosRevision = new System.Windows.Forms.DataGridView();
            this.BTNCtrlMantDerivar = new System.Windows.Forms.Button();
            this.BTNCtrlMantDesestimar = new System.Windows.Forms.Button();
            this.LBLReporteRevision = new System.Windows.Forms.Label();
            this.GB_VehiculosRevision = new System.Windows.Forms.GroupBox();
            this.TXT_CtrlMantReporteRevision = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV_VehiculosMantenimiento = new System.Windows.Forms.DataGridView();
            this.BTNCtrlMantRetorno = new System.Windows.Forms.Button();
            this.LBLDetalleMantenimientoRealizado = new System.Windows.Forms.Label();
            this.TXT_CtrlMantDetalleMantenimiento = new System.Windows.Forms.TextBox();
            this.GB_DatosRemito = new System.Windows.Forms.GroupBox();
            this.DTP_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.DTP_FechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.NUM_KmReal = new System.Windows.Forms.NumericUpDown();
            this.TXT_CtrlMantCosto = new System.Windows.Forms.TextBox();
            this.LBLFechaIngreso = new System.Windows.Forms.Label();
            this.LBLFechaSalida = new System.Windows.Forms.Label();
            this.LBLCosto = new System.Windows.Forms.Label();
            this.LBLkmReal = new System.Windows.Forms.Label();
            this.GB_VehiculosMantenimiento = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LBLDATOSGastoAcumulado = new System.Windows.Forms.Label();
            this.LBLDATOSCantidadIngresos = new System.Windows.Forms.Label();
            this.LBLGastoAcumulado = new System.Windows.Forms.Label();
            this.LBLCantidadIngresos = new System.Windows.Forms.Label();
            this.BTNCtrlMantBuscarHist = new System.Windows.Forms.Button();
            this.CBXVehiculoHistorial = new System.Windows.Forms.ComboBox();
            this.DGV_HistorialMantenimiento = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.TAB_CTRLMantenimientos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosRevision)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosMantenimiento)).BeginInit();
            this.GB_DatosRemito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmReal)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistorialMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // TAB_CTRLMantenimientos
            // 
            this.TAB_CTRLMantenimientos.Controls.Add(this.tabPage1);
            this.TAB_CTRLMantenimientos.Controls.Add(this.tabPage2);
            this.TAB_CTRLMantenimientos.Controls.Add(this.tabPage3);
            this.TAB_CTRLMantenimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TAB_CTRLMantenimientos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_CTRLMantenimientos.Location = new System.Drawing.Point(0, 39);
            this.TAB_CTRLMantenimientos.Name = "TAB_CTRLMantenimientos";
            this.TAB_CTRLMantenimientos.SelectedIndex = 0;
            this.TAB_CTRLMantenimientos.Size = new System.Drawing.Size(1097, 539);
            this.TAB_CTRLMantenimientos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.tabPage1.Controls.Add(this.DGV_VehiculosRevision);
            this.tabPage1.Controls.Add(this.BTNCtrlMantDerivar);
            this.tabPage1.Controls.Add(this.BTNCtrlMantDesestimar);
            this.tabPage1.Controls.Add(this.LBLReporteRevision);
            this.tabPage1.Controls.Add(this.GB_VehiculosRevision);
            this.tabPage1.Controls.Add(this.TXT_CtrlMantReporteRevision);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehiculos en revisión";
            // 
            // DGV_VehiculosRevision
            // 
            this.DGV_VehiculosRevision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VehiculosRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VehiculosRevision.Location = new System.Drawing.Point(35, 50);
            this.DGV_VehiculosRevision.Name = "DGV_VehiculosRevision";
            this.DGV_VehiculosRevision.ReadOnly = true;
            this.DGV_VehiculosRevision.Size = new System.Drawing.Size(944, 236);
            this.DGV_VehiculosRevision.TabIndex = 0;
            this.DGV_VehiculosRevision.SelectionChanged += new System.EventHandler(this.DGV_VehiculosRevision_SelectionChanged);
            // 
            // BTNCtrlMantDerivar
            // 
            this.BTNCtrlMantDerivar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlMantDerivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantDerivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantDerivar.Location = new System.Drawing.Point(175, 455);
            this.BTNCtrlMantDerivar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlMantDerivar.Name = "BTNCtrlMantDerivar";
            this.BTNCtrlMantDerivar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlMantDerivar.TabIndex = 46;
            this.BTNCtrlMantDerivar.Text = "Derivar a taller";
            this.BTNCtrlMantDerivar.UseVisualStyleBackColor = false;
            this.BTNCtrlMantDerivar.Click += new System.EventHandler(this.BTNCtrlMantDerivar_Click);
            // 
            // BTNCtrlMantDesestimar
            // 
            this.BTNCtrlMantDesestimar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlMantDesestimar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantDesestimar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantDesestimar.Location = new System.Drawing.Point(22, 455);
            this.BTNCtrlMantDesestimar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlMantDesestimar.Name = "BTNCtrlMantDesestimar";
            this.BTNCtrlMantDesestimar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlMantDesestimar.TabIndex = 45;
            this.BTNCtrlMantDesestimar.Text = "Desestimar";
            this.BTNCtrlMantDesestimar.UseVisualStyleBackColor = false;
            this.BTNCtrlMantDesestimar.Click += new System.EventHandler(this.BTNCtrlMantDesestimar_Click);
            // 
            // LBLReporteRevision
            // 
            this.LBLReporteRevision.AutoSize = true;
            this.LBLReporteRevision.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLReporteRevision.Location = new System.Drawing.Point(22, 309);
            this.LBLReporteRevision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLReporteRevision.Name = "LBLReporteRevision";
            this.LBLReporteRevision.Size = new System.Drawing.Size(136, 17);
            this.LBLReporteRevision.TabIndex = 44;
            this.LBLReporteRevision.Text = "Reporte de revision:";
            // 
            // GB_VehiculosRevision
            // 
            this.GB_VehiculosRevision.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_VehiculosRevision.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_VehiculosRevision.Location = new System.Drawing.Point(22, 21);
            this.GB_VehiculosRevision.Name = "GB_VehiculosRevision";
            this.GB_VehiculosRevision.Size = new System.Drawing.Size(975, 278);
            this.GB_VehiculosRevision.TabIndex = 42;
            this.GB_VehiculosRevision.TabStop = false;
            this.GB_VehiculosRevision.Text = "Vehiculos en revisión";
            // 
            // TXT_CtrlMantReporteRevision
            // 
            this.TXT_CtrlMantReporteRevision.BackColor = System.Drawing.SystemColors.Window;
            this.TXT_CtrlMantReporteRevision.Location = new System.Drawing.Point(22, 329);
            this.TXT_CtrlMantReporteRevision.Multiline = true;
            this.TXT_CtrlMantReporteRevision.Name = "TXT_CtrlMantReporteRevision";
            this.TXT_CtrlMantReporteRevision.ReadOnly = true;
            this.TXT_CtrlMantReporteRevision.Size = new System.Drawing.Size(581, 117);
            this.TXT_CtrlMantReporteRevision.TabIndex = 43;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.tabPage2.Controls.Add(this.DGV_VehiculosMantenimiento);
            this.tabPage2.Controls.Add(this.BTNCtrlMantRetorno);
            this.tabPage2.Controls.Add(this.LBLDetalleMantenimientoRealizado);
            this.tabPage2.Controls.Add(this.TXT_CtrlMantDetalleMantenimiento);
            this.tabPage2.Controls.Add(this.GB_DatosRemito);
            this.tabPage2.Controls.Add(this.GB_VehiculosMantenimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control de taller";
            // 
            // DGV_VehiculosMantenimiento
            // 
            this.DGV_VehiculosMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VehiculosMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VehiculosMantenimiento.Location = new System.Drawing.Point(35, 50);
            this.DGV_VehiculosMantenimiento.Name = "DGV_VehiculosMantenimiento";
            this.DGV_VehiculosMantenimiento.ReadOnly = true;
            this.DGV_VehiculosMantenimiento.Size = new System.Drawing.Size(717, 236);
            this.DGV_VehiculosMantenimiento.TabIndex = 0;
            this.DGV_VehiculosMantenimiento.SelectionChanged += new System.EventHandler(this.DGV_VehiculosMantenimiento_SelectionChanged);
            // 
            // BTNCtrlMantRetorno
            // 
            this.BTNCtrlMantRetorno.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlMantRetorno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantRetorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantRetorno.Location = new System.Drawing.Point(22, 455);
            this.BTNCtrlMantRetorno.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlMantRetorno.Name = "BTNCtrlMantRetorno";
            this.BTNCtrlMantRetorno.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlMantRetorno.TabIndex = 51;
            this.BTNCtrlMantRetorno.Text = "Registrar retorno";
            this.BTNCtrlMantRetorno.UseVisualStyleBackColor = false;
            this.BTNCtrlMantRetorno.Click += new System.EventHandler(this.BTNCtrlMantRetorno_Click);
            // 
            // LBLDetalleMantenimientoRealizado
            // 
            this.LBLDetalleMantenimientoRealizado.AutoSize = true;
            this.LBLDetalleMantenimientoRealizado.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLDetalleMantenimientoRealizado.Location = new System.Drawing.Point(22, 309);
            this.LBLDetalleMantenimientoRealizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDetalleMantenimientoRealizado.Name = "LBLDetalleMantenimientoRealizado";
            this.LBLDetalleMantenimientoRealizado.Size = new System.Drawing.Size(263, 17);
            this.LBLDetalleMantenimientoRealizado.TabIndex = 50;
            this.LBLDetalleMantenimientoRealizado.Text = "Detalle de tareas realizadas en el taller:";
            // 
            // TXT_CtrlMantDetalleMantenimiento
            // 
            this.TXT_CtrlMantDetalleMantenimiento.Location = new System.Drawing.Point(22, 329);
            this.TXT_CtrlMantDetalleMantenimiento.Multiline = true;
            this.TXT_CtrlMantDetalleMantenimiento.Name = "TXT_CtrlMantDetalleMantenimiento";
            this.TXT_CtrlMantDetalleMantenimiento.Size = new System.Drawing.Size(581, 117);
            this.TXT_CtrlMantDetalleMantenimiento.TabIndex = 49;
            // 
            // GB_DatosRemito
            // 
            this.GB_DatosRemito.Controls.Add(this.DTP_FechaSalida);
            this.GB_DatosRemito.Controls.Add(this.DTP_FechaEntrada);
            this.GB_DatosRemito.Controls.Add(this.NUM_KmReal);
            this.GB_DatosRemito.Controls.Add(this.TXT_CtrlMantCosto);
            this.GB_DatosRemito.Controls.Add(this.LBLFechaIngreso);
            this.GB_DatosRemito.Controls.Add(this.LBLFechaSalida);
            this.GB_DatosRemito.Controls.Add(this.LBLCosto);
            this.GB_DatosRemito.Controls.Add(this.LBLkmReal);
            this.GB_DatosRemito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosRemito.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_DatosRemito.Location = new System.Drawing.Point(790, 21);
            this.GB_DatosRemito.Margin = new System.Windows.Forms.Padding(4);
            this.GB_DatosRemito.Name = "GB_DatosRemito";
            this.GB_DatosRemito.Padding = new System.Windows.Forms.Padding(4);
            this.GB_DatosRemito.Size = new System.Drawing.Size(292, 278);
            this.GB_DatosRemito.TabIndex = 48;
            this.GB_DatosRemito.TabStop = false;
            this.GB_DatosRemito.Text = "Registro de remito";
            // 
            // DTP_FechaSalida
            // 
            this.DTP_FechaSalida.Location = new System.Drawing.Point(10, 112);
            this.DTP_FechaSalida.Name = "DTP_FechaSalida";
            this.DTP_FechaSalida.Size = new System.Drawing.Size(264, 23);
            this.DTP_FechaSalida.TabIndex = 33;
            // 
            // DTP_FechaEntrada
            // 
            this.DTP_FechaEntrada.Location = new System.Drawing.Point(10, 48);
            this.DTP_FechaEntrada.Name = "DTP_FechaEntrada";
            this.DTP_FechaEntrada.Size = new System.Drawing.Size(264, 23);
            this.DTP_FechaEntrada.TabIndex = 32;
            // 
            // NUM_KmReal
            // 
            this.NUM_KmReal.Location = new System.Drawing.Point(10, 240);
            this.NUM_KmReal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUM_KmReal.Name = "NUM_KmReal";
            this.NUM_KmReal.Size = new System.Drawing.Size(263, 23);
            this.NUM_KmReal.TabIndex = 31;
            // 
            // TXT_CtrlMantCosto
            // 
            this.TXT_CtrlMantCosto.Location = new System.Drawing.Point(10, 176);
            this.TXT_CtrlMantCosto.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlMantCosto.Name = "TXT_CtrlMantCosto";
            this.TXT_CtrlMantCosto.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlMantCosto.TabIndex = 2;
            // 
            // LBLFechaIngreso
            // 
            this.LBLFechaIngreso.AutoSize = true;
            this.LBLFechaIngreso.Location = new System.Drawing.Point(10, 28);
            this.LBLFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFechaIngreso.Name = "LBLFechaIngreso";
            this.LBLFechaIngreso.Size = new System.Drawing.Size(174, 17);
            this.LBLFechaIngreso.TabIndex = 5;
            this.LBLFechaIngreso.Text = "Fecha de ingreso al taller:";
            // 
            // LBLFechaSalida
            // 
            this.LBLFechaSalida.AutoSize = true;
            this.LBLFechaSalida.Location = new System.Drawing.Point(10, 92);
            this.LBLFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFechaSalida.Name = "LBLFechaSalida";
            this.LBLFechaSalida.Size = new System.Drawing.Size(166, 17);
            this.LBLFechaSalida.TabIndex = 6;
            this.LBLFechaSalida.Text = "Fecha de salida al taller:";
            // 
            // LBLCosto
            // 
            this.LBLCosto.AutoSize = true;
            this.LBLCosto.Location = new System.Drawing.Point(10, 156);
            this.LBLCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCosto.Name = "LBLCosto";
            this.LBLCosto.Size = new System.Drawing.Size(147, 17);
            this.LBLCosto.TabIndex = 7;
            this.LBLCosto.Text = "Costo de reparación:";
            // 
            // LBLkmReal
            // 
            this.LBLkmReal.AutoSize = true;
            this.LBLkmReal.Location = new System.Drawing.Point(10, 220);
            this.LBLkmReal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLkmReal.Name = "LBLkmReal";
            this.LBLkmReal.Size = new System.Drawing.Size(113, 17);
            this.LBLkmReal.TabIndex = 8;
            this.LBLkmReal.Text = "Kilometraje real:";
            // 
            // GB_VehiculosMantenimiento
            // 
            this.GB_VehiculosMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_VehiculosMantenimiento.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_VehiculosMantenimiento.Location = new System.Drawing.Point(22, 21);
            this.GB_VehiculosMantenimiento.Name = "GB_VehiculosMantenimiento";
            this.GB_VehiculosMantenimiento.Size = new System.Drawing.Size(744, 278);
            this.GB_VehiculosMantenimiento.TabIndex = 43;
            this.GB_VehiculosMantenimiento.TabStop = false;
            this.GB_VehiculosMantenimiento.Text = "Vehiculos en mantenimiento";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.tabPage3.Controls.Add(this.LBLDATOSGastoAcumulado);
            this.tabPage3.Controls.Add(this.LBLDATOSCantidadIngresos);
            this.tabPage3.Controls.Add(this.LBLGastoAcumulado);
            this.tabPage3.Controls.Add(this.LBLCantidadIngresos);
            this.tabPage3.Controls.Add(this.BTNCtrlMantBuscarHist);
            this.tabPage3.Controls.Add(this.CBXVehiculoHistorial);
            this.tabPage3.Controls.Add(this.DGV_HistorialMantenimiento);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1089, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historial de mantenimientos";
            // 
            // LBLDATOSGastoAcumulado
            // 
            this.LBLDATOSGastoAcumulado.AutoSize = true;
            this.LBLDATOSGastoAcumulado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDATOSGastoAcumulado.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLDATOSGastoAcumulado.Location = new System.Drawing.Point(15, 442);
            this.LBLDATOSGastoAcumulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSGastoAcumulado.Name = "LBLDATOSGastoAcumulado";
            this.LBLDATOSGastoAcumulado.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSGastoAcumulado.TabIndex = 51;
            // 
            // LBLDATOSCantidadIngresos
            // 
            this.LBLDATOSCantidadIngresos.AutoSize = true;
            this.LBLDATOSCantidadIngresos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDATOSCantidadIngresos.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLDATOSCantidadIngresos.Location = new System.Drawing.Point(15, 387);
            this.LBLDATOSCantidadIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSCantidadIngresos.Name = "LBLDATOSCantidadIngresos";
            this.LBLDATOSCantidadIngresos.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSCantidadIngresos.TabIndex = 50;
            // 
            // LBLGastoAcumulado
            // 
            this.LBLGastoAcumulado.AutoSize = true;
            this.LBLGastoAcumulado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGastoAcumulado.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLGastoAcumulado.Location = new System.Drawing.Point(15, 425);
            this.LBLGastoAcumulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLGastoAcumulado.Name = "LBLGastoAcumulado";
            this.LBLGastoAcumulado.Size = new System.Drawing.Size(128, 16);
            this.LBLGastoAcumulado.TabIndex = 49;
            this.LBLGastoAcumulado.Text = "Gasto acumulado:";
            // 
            // LBLCantidadIngresos
            // 
            this.LBLCantidadIngresos.AutoSize = true;
            this.LBLCantidadIngresos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCantidadIngresos.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLCantidadIngresos.Location = new System.Drawing.Point(15, 370);
            this.LBLCantidadIngresos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCantidadIngresos.Name = "LBLCantidadIngresos";
            this.LBLCantidadIngresos.Size = new System.Drawing.Size(152, 16);
            this.LBLCantidadIngresos.TabIndex = 48;
            this.LBLCantidadIngresos.Text = "Cantidad de ingresos:";
            // 
            // BTNCtrlMantBuscarHist
            // 
            this.BTNCtrlMantBuscarHist.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlMantBuscarHist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantBuscarHist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantBuscarHist.Location = new System.Drawing.Point(340, 17);
            this.BTNCtrlMantBuscarHist.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlMantBuscarHist.Name = "BTNCtrlMantBuscarHist";
            this.BTNCtrlMantBuscarHist.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlMantBuscarHist.TabIndex = 47;
            this.BTNCtrlMantBuscarHist.Text = "Buscar";
            this.BTNCtrlMantBuscarHist.UseVisualStyleBackColor = false;
            this.BTNCtrlMantBuscarHist.Click += new System.EventHandler(this.BTNCtrlMantBuscarHist_Click);
            // 
            // CBXVehiculoHistorial
            // 
            this.CBXVehiculoHistorial.FormattingEnabled = true;
            this.CBXVehiculoHistorial.Location = new System.Drawing.Point(15, 22);
            this.CBXVehiculoHistorial.Name = "CBXVehiculoHistorial";
            this.CBXVehiculoHistorial.Size = new System.Drawing.Size(318, 25);
            this.CBXVehiculoHistorial.TabIndex = 46;
            // 
            // DGV_HistorialMantenimiento
            // 
            this.DGV_HistorialMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_HistorialMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HistorialMantenimiento.Location = new System.Drawing.Point(28, 96);
            this.DGV_HistorialMantenimiento.Name = "DGV_HistorialMantenimiento";
            this.DGV_HistorialMantenimiento.ReadOnly = true;
            this.DGV_HistorialMantenimiento.Size = new System.Drawing.Size(1024, 236);
            this.DGV_HistorialMantenimiento.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(15, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 278);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de mantenimientos";
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(955, 11);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 53;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(955, 30);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 52;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // FrmCTRLMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1097, 578);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.TAB_CTRLMantenimientos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCTRLMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLMantenimiento";
            this.Load += new System.EventHandler(this.FrmCTRLMantenimiento_Load);
            this.TAB_CTRLMantenimientos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosRevision)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosMantenimiento)).EndInit();
            this.GB_DatosRemito.ResumeLayout(false);
            this.GB_DatosRemito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmReal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HistorialMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TAB_CTRLMantenimientos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.TextBox TXT_CtrlMantReporteRevision;
        private System.Windows.Forms.GroupBox GB_VehiculosRevision;
        private System.Windows.Forms.DataGridView DGV_VehiculosRevision;
        private System.Windows.Forms.Label LBLReporteRevision;
        private System.Windows.Forms.Button BTNCtrlMantDerivar;
        private System.Windows.Forms.Button BTNCtrlMantDesestimar;
        private System.Windows.Forms.GroupBox GB_VehiculosMantenimiento;
        private System.Windows.Forms.DataGridView DGV_VehiculosMantenimiento;
        private System.Windows.Forms.GroupBox GB_DatosRemito;
        private System.Windows.Forms.NumericUpDown NUM_KmReal;
        private System.Windows.Forms.TextBox TXT_CtrlMantCosto;
        private System.Windows.Forms.Label LBLFechaIngreso;
        private System.Windows.Forms.Label LBLFechaSalida;
        private System.Windows.Forms.Label LBLCosto;
        private System.Windows.Forms.Label LBLkmReal;
        private System.Windows.Forms.Label LBLDetalleMantenimientoRealizado;
        private System.Windows.Forms.TextBox TXT_CtrlMantDetalleMantenimiento;
        private System.Windows.Forms.Button BTNCtrlMantRetorno;
        private System.Windows.Forms.DateTimePicker DTP_FechaSalida;
        private System.Windows.Forms.DateTimePicker DTP_FechaEntrada;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGV_HistorialMantenimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBXVehiculoHistorial;
        private System.Windows.Forms.Button BTNCtrlMantBuscarHist;
        private System.Windows.Forms.Label LBLGastoAcumulado;
        private System.Windows.Forms.Label LBLCantidadIngresos;
        private System.Windows.Forms.Label LBLDATOSGastoAcumulado;
        private System.Windows.Forms.Label LBLDATOSCantidadIngresos;
    }
}