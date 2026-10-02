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
            this.BTNCtrlMantDerivar = new System.Windows.Forms.Button();
            this.BTNCtrlMantDesestimar = new System.Windows.Forms.Button();
            this.LBLReporteRevision = new System.Windows.Forms.Label();
            this.TXT_CtrlMantReporteRevision = new System.Windows.Forms.TextBox();
            this.GB_VehiculosRevision = new System.Windows.Forms.GroupBox();
            this.DGV_VehiculosRevision = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.DGV_VehiculosMantenimiento = new System.Windows.Forms.DataGridView();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.TAB_CTRLMantenimientos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GB_VehiculosRevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosRevision)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.GB_DatosRemito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmReal)).BeginInit();
            this.GB_VehiculosMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // TAB_CTRLMantenimientos
            // 
            this.TAB_CTRLMantenimientos.Controls.Add(this.tabPage1);
            this.TAB_CTRLMantenimientos.Controls.Add(this.tabPage2);
            this.TAB_CTRLMantenimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TAB_CTRLMantenimientos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_CTRLMantenimientos.Location = new System.Drawing.Point(0, 57);
            this.TAB_CTRLMantenimientos.Name = "TAB_CTRLMantenimientos";
            this.TAB_CTRLMantenimientos.SelectedIndex = 0;
            this.TAB_CTRLMantenimientos.Size = new System.Drawing.Size(1097, 521);
            this.TAB_CTRLMantenimientos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTNCtrlMantDerivar);
            this.tabPage1.Controls.Add(this.BTNCtrlMantDesestimar);
            this.tabPage1.Controls.Add(this.LBLReporteRevision);
            this.tabPage1.Controls.Add(this.TXT_CtrlMantReporteRevision);
            this.tabPage1.Controls.Add(this.GB_VehiculosRevision);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTNCtrlMantDerivar
            // 
            this.BTNCtrlMantDerivar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlMantDerivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantDerivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantDerivar.Location = new System.Drawing.Point(175, 440);
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
            this.BTNCtrlMantDesestimar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlMantDesestimar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantDesestimar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantDesestimar.Location = new System.Drawing.Point(22, 440);
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
            this.LBLReporteRevision.Location = new System.Drawing.Point(20, 320);
            this.LBLReporteRevision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLReporteRevision.Name = "LBLReporteRevision";
            this.LBLReporteRevision.Size = new System.Drawing.Size(136, 17);
            this.LBLReporteRevision.TabIndex = 44;
            this.LBLReporteRevision.Text = "Reporte de revision:";
            // 
            // TXT_CtrlMantReporteRevision
            // 
            this.TXT_CtrlMantReporteRevision.Location = new System.Drawing.Point(23, 340);
            this.TXT_CtrlMantReporteRevision.Multiline = true;
            this.TXT_CtrlMantReporteRevision.Name = "TXT_CtrlMantReporteRevision";
            this.TXT_CtrlMantReporteRevision.Size = new System.Drawing.Size(581, 80);
            this.TXT_CtrlMantReporteRevision.TabIndex = 43;
            // 
            // GB_VehiculosRevision
            // 
            this.GB_VehiculosRevision.Controls.Add(this.DGV_VehiculosRevision);
            this.GB_VehiculosRevision.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_VehiculosRevision.Location = new System.Drawing.Point(23, 25);
            this.GB_VehiculosRevision.Name = "GB_VehiculosRevision";
            this.GB_VehiculosRevision.Size = new System.Drawing.Size(581, 278);
            this.GB_VehiculosRevision.TabIndex = 42;
            this.GB_VehiculosRevision.TabStop = false;
            this.GB_VehiculosRevision.Text = "Vehiculos en revisión";
            // 
            // DGV_VehiculosRevision
            // 
            this.DGV_VehiculosRevision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VehiculosRevision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VehiculosRevision.Location = new System.Drawing.Point(12, 30);
            this.DGV_VehiculosRevision.Name = "DGV_VehiculosRevision";
            this.DGV_VehiculosRevision.ReadOnly = true;
            this.DGV_VehiculosRevision.Size = new System.Drawing.Size(550, 236);
            this.DGV_VehiculosRevision.TabIndex = 0;
            this.DGV_VehiculosRevision.SelectionChanged += new System.EventHandler(this.DGV_VehiculosRevision_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTNCtrlMantRetorno);
            this.tabPage2.Controls.Add(this.LBLDetalleMantenimientoRealizado);
            this.tabPage2.Controls.Add(this.TXT_CtrlMantDetalleMantenimiento);
            this.tabPage2.Controls.Add(this.GB_DatosRemito);
            this.tabPage2.Controls.Add(this.GB_VehiculosMantenimiento);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTNCtrlMantRetorno
            // 
            this.BTNCtrlMantRetorno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlMantRetorno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlMantRetorno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlMantRetorno.Location = new System.Drawing.Point(20, 430);
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
            this.LBLDetalleMantenimientoRealizado.Location = new System.Drawing.Point(17, 311);
            this.LBLDetalleMantenimientoRealizado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDetalleMantenimientoRealizado.Name = "LBLDetalleMantenimientoRealizado";
            this.LBLDetalleMantenimientoRealizado.Size = new System.Drawing.Size(263, 17);
            this.LBLDetalleMantenimientoRealizado.TabIndex = 50;
            this.LBLDetalleMantenimientoRealizado.Text = "Detalle de tareas realizadas en el taller:";
            // 
            // TXT_CtrlMantDetalleMantenimiento
            // 
            this.TXT_CtrlMantDetalleMantenimiento.Location = new System.Drawing.Point(20, 331);
            this.TXT_CtrlMantDetalleMantenimiento.Multiline = true;
            this.TXT_CtrlMantDetalleMantenimiento.Name = "TXT_CtrlMantDetalleMantenimiento";
            this.TXT_CtrlMantDetalleMantenimiento.Size = new System.Drawing.Size(581, 80);
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
            this.GB_DatosRemito.Location = new System.Drawing.Point(638, 39);
            this.GB_DatosRemito.Margin = new System.Windows.Forms.Padding(4);
            this.GB_DatosRemito.Name = "GB_DatosRemito";
            this.GB_DatosRemito.Padding = new System.Windows.Forms.Padding(4);
            this.GB_DatosRemito.Size = new System.Drawing.Size(300, 249);
            this.GB_DatosRemito.TabIndex = 48;
            this.GB_DatosRemito.TabStop = false;
            this.GB_DatosRemito.Text = "Registro de remito";
            // 
            // DTP_FechaSalida
            // 
            this.DTP_FechaSalida.Location = new System.Drawing.Point(12, 104);
            this.DTP_FechaSalida.Name = "DTP_FechaSalida";
            this.DTP_FechaSalida.Size = new System.Drawing.Size(264, 23);
            this.DTP_FechaSalida.TabIndex = 33;
            // 
            // DTP_FechaEntrada
            // 
            this.DTP_FechaEntrada.Location = new System.Drawing.Point(12, 49);
            this.DTP_FechaEntrada.Name = "DTP_FechaEntrada";
            this.DTP_FechaEntrada.Size = new System.Drawing.Size(264, 23);
            this.DTP_FechaEntrada.TabIndex = 32;
            // 
            // NUM_KmReal
            // 
            this.NUM_KmReal.Location = new System.Drawing.Point(12, 215);
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
            this.TXT_CtrlMantCosto.Location = new System.Drawing.Point(12, 159);
            this.TXT_CtrlMantCosto.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlMantCosto.Name = "TXT_CtrlMantCosto";
            this.TXT_CtrlMantCosto.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlMantCosto.TabIndex = 2;
            // 
            // LBLFechaIngreso
            // 
            this.LBLFechaIngreso.AutoSize = true;
            this.LBLFechaIngreso.Location = new System.Drawing.Point(8, 28);
            this.LBLFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFechaIngreso.Name = "LBLFechaIngreso";
            this.LBLFechaIngreso.Size = new System.Drawing.Size(174, 17);
            this.LBLFechaIngreso.TabIndex = 5;
            this.LBLFechaIngreso.Text = "Fecha de ingreso al taller:";
            // 
            // LBLFechaSalida
            // 
            this.LBLFechaSalida.AutoSize = true;
            this.LBLFechaSalida.Location = new System.Drawing.Point(8, 84);
            this.LBLFechaSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFechaSalida.Name = "LBLFechaSalida";
            this.LBLFechaSalida.Size = new System.Drawing.Size(166, 17);
            this.LBLFechaSalida.TabIndex = 6;
            this.LBLFechaSalida.Text = "Fecha de salida al taller:";
            // 
            // LBLCosto
            // 
            this.LBLCosto.AutoSize = true;
            this.LBLCosto.Location = new System.Drawing.Point(8, 139);
            this.LBLCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCosto.Name = "LBLCosto";
            this.LBLCosto.Size = new System.Drawing.Size(147, 17);
            this.LBLCosto.TabIndex = 7;
            this.LBLCosto.Text = "Costo de reparación:";
            // 
            // LBLkmReal
            // 
            this.LBLkmReal.AutoSize = true;
            this.LBLkmReal.Location = new System.Drawing.Point(8, 194);
            this.LBLkmReal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLkmReal.Name = "LBLkmReal";
            this.LBLkmReal.Size = new System.Drawing.Size(113, 17);
            this.LBLkmReal.TabIndex = 8;
            this.LBLkmReal.Text = "Kilometraje real:";
            // 
            // GB_VehiculosMantenimiento
            // 
            this.GB_VehiculosMantenimiento.Controls.Add(this.DGV_VehiculosMantenimiento);
            this.GB_VehiculosMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_VehiculosMantenimiento.Location = new System.Drawing.Point(8, 22);
            this.GB_VehiculosMantenimiento.Name = "GB_VehiculosMantenimiento";
            this.GB_VehiculosMantenimiento.Size = new System.Drawing.Size(581, 278);
            this.GB_VehiculosMantenimiento.TabIndex = 43;
            this.GB_VehiculosMantenimiento.TabStop = false;
            this.GB_VehiculosMantenimiento.Text = "Vehiculos en mantenimiento";
            // 
            // DGV_VehiculosMantenimiento
            // 
            this.DGV_VehiculosMantenimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_VehiculosMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VehiculosMantenimiento.Location = new System.Drawing.Point(12, 30);
            this.DGV_VehiculosMantenimiento.Name = "DGV_VehiculosMantenimiento";
            this.DGV_VehiculosMantenimiento.ReadOnly = true;
            this.DGV_VehiculosMantenimiento.Size = new System.Drawing.Size(550, 236);
            this.DGV_VehiculosMantenimiento.TabIndex = 0;
            this.DGV_VehiculosMantenimiento.SelectionChanged += new System.EventHandler(this.DGV_VehiculosMantenimiento_SelectionChanged);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.Location = new System.Drawing.Point(798, 7);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 53;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(798, 26);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 52;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // FrmCTRLMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.GB_VehiculosRevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosRevision)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GB_DatosRemito.ResumeLayout(false);
            this.GB_DatosRemito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmReal)).EndInit();
            this.GB_VehiculosMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VehiculosMantenimiento)).EndInit();
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
    }
}