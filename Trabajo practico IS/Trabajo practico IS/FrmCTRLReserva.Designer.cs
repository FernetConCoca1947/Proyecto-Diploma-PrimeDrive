namespace Trabajo_practico_IS
{
    partial class FrmCTRLReserva
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
            this.GB_DatosNuevaReserva = new System.Windows.Forms.GroupBox();
            this.BTNCtrlResBuscar = new System.Windows.Forms.Button();
            this.TXT_CtrlResDNI = new System.Windows.Forms.TextBox();
            this.LBLdniCliente = new System.Windows.Forms.Label();
            this.LBLClienteSeleccionado = new System.Windows.Forms.Label();
            this.LBLDatosCliente = new System.Windows.Forms.Label();
            this.LBLFechaRetiro = new System.Windows.Forms.Label();
            this.LBLFechaDevolucion = new System.Windows.Forms.Label();
            this.LBLCategoriaRes = new System.Windows.Forms.Label();
            this.dateTimeRetiro = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.CBX_Categoria = new System.Windows.Forms.ComboBox();
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.GB_Reservas = new System.Windows.Forms.GroupBox();
            this.DGV_CtrlResReservas = new System.Windows.Forms.DataGridView();
            this.BTNCtrlResGenerar = new System.Windows.Forms.Button();
            this.BTNCtrlResCancelar = new System.Windows.Forms.Button();
            this.CBX_SucursalRetiro = new System.Windows.Forms.ComboBox();
            this.LBLSucursalRetiro = new System.Windows.Forms.Label();
            this.CBX_SucursalDevolucion = new System.Windows.Forms.ComboBox();
            this.LBLSucursalDevolucion = new System.Windows.Forms.Label();
            this.GB_DatosNuevaReserva.SuspendLayout();
            this.GB_Reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CtrlResReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_DatosNuevaReserva
            // 
            this.GB_DatosNuevaReserva.Controls.Add(this.CBX_SucursalDevolucion);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLSucursalDevolucion);
            this.GB_DatosNuevaReserva.Controls.Add(this.CBX_SucursalRetiro);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLSucursalRetiro);
            this.GB_DatosNuevaReserva.Controls.Add(this.BTNCtrlResGenerar);
            this.GB_DatosNuevaReserva.Controls.Add(this.CBX_Categoria);
            this.GB_DatosNuevaReserva.Controls.Add(this.dateTimeDevolucion);
            this.GB_DatosNuevaReserva.Controls.Add(this.dateTimeRetiro);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLCategoriaRes);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLFechaDevolucion);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLFechaRetiro);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLDatosCliente);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLClienteSeleccionado);
            this.GB_DatosNuevaReserva.Controls.Add(this.BTNCtrlResBuscar);
            this.GB_DatosNuevaReserva.Controls.Add(this.TXT_CtrlResDNI);
            this.GB_DatosNuevaReserva.Controls.Add(this.LBLdniCliente);
            this.GB_DatosNuevaReserva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosNuevaReserva.Location = new System.Drawing.Point(12, 34);
            this.GB_DatosNuevaReserva.Name = "GB_DatosNuevaReserva";
            this.GB_DatosNuevaReserva.Size = new System.Drawing.Size(472, 544);
            this.GB_DatosNuevaReserva.TabIndex = 0;
            this.GB_DatosNuevaReserva.TabStop = false;
            this.GB_DatosNuevaReserva.Text = "Nueva reserva";
            // 
            // BTNCtrlResBuscar
            // 
            this.BTNCtrlResBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlResBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlResBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlResBuscar.Location = new System.Drawing.Point(298, 56);
            this.BTNCtrlResBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlResBuscar.Name = "BTNCtrlResBuscar";
            this.BTNCtrlResBuscar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlResBuscar.TabIndex = 29;
            this.BTNCtrlResBuscar.Tag = "";
            this.BTNCtrlResBuscar.Text = "Buscar";
            this.BTNCtrlResBuscar.UseVisualStyleBackColor = false;
            this.BTNCtrlResBuscar.Click += new System.EventHandler(this.BTNCtrlResBuscar_Click);
            // 
            // TXT_CtrlResDNI
            // 
            this.TXT_CtrlResDNI.Location = new System.Drawing.Point(13, 61);
            this.TXT_CtrlResDNI.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlResDNI.Name = "TXT_CtrlResDNI";
            this.TXT_CtrlResDNI.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlResDNI.TabIndex = 27;
            // 
            // LBLdniCliente
            // 
            this.LBLdniCliente.AutoSize = true;
            this.LBLdniCliente.Location = new System.Drawing.Point(9, 41);
            this.LBLdniCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLdniCliente.Name = "LBLdniCliente";
            this.LBLdniCliente.Size = new System.Drawing.Size(78, 17);
            this.LBLdniCliente.TabIndex = 28;
            this.LBLdniCliente.Text = "DNI cliente";
            // 
            // LBLClienteSeleccionado
            // 
            this.LBLClienteSeleccionado.AutoSize = true;
            this.LBLClienteSeleccionado.Location = new System.Drawing.Point(10, 112);
            this.LBLClienteSeleccionado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLClienteSeleccionado.Name = "LBLClienteSeleccionado";
            this.LBLClienteSeleccionado.Size = new System.Drawing.Size(149, 17);
            this.LBLClienteSeleccionado.TabIndex = 30;
            this.LBLClienteSeleccionado.Text = "Cliente seleccionado:";
            // 
            // LBLDatosCliente
            // 
            this.LBLDatosCliente.AutoSize = true;
            this.LBLDatosCliente.Location = new System.Drawing.Point(10, 138);
            this.LBLDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDatosCliente.Name = "LBLDatosCliente";
            this.LBLDatosCliente.Size = new System.Drawing.Size(92, 17);
            this.LBLDatosCliente.TabIndex = 31;
            this.LBLDatosCliente.Text = "datos cliente";
            // 
            // LBLFechaRetiro
            // 
            this.LBLFechaRetiro.AutoSize = true;
            this.LBLFechaRetiro.Location = new System.Drawing.Point(12, 188);
            this.LBLFechaRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFechaRetiro.Name = "LBLFechaRetiro";
            this.LBLFechaRetiro.Size = new System.Drawing.Size(105, 17);
            this.LBLFechaRetiro.TabIndex = 32;
            this.LBLFechaRetiro.Text = "Fecha de retiro";
            // 
            // LBLFechaDevolucion
            // 
            this.LBLFechaDevolucion.AutoSize = true;
            this.LBLFechaDevolucion.Location = new System.Drawing.Point(12, 245);
            this.LBLFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLFechaDevolucion.Name = "LBLFechaDevolucion";
            this.LBLFechaDevolucion.Size = new System.Drawing.Size(145, 17);
            this.LBLFechaDevolucion.TabIndex = 33;
            this.LBLFechaDevolucion.Text = "Fecha de devolución";
            // 
            // LBLCategoriaRes
            // 
            this.LBLCategoriaRes.AutoSize = true;
            this.LBLCategoriaRes.Location = new System.Drawing.Point(11, 307);
            this.LBLCategoriaRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCategoriaRes.Name = "LBLCategoriaRes";
            this.LBLCategoriaRes.Size = new System.Drawing.Size(136, 17);
            this.LBLCategoriaRes.TabIndex = 34;
            this.LBLCategoriaRes.Text = "Categoria deseada";
            // 
            // dateTimeRetiro
            // 
            this.dateTimeRetiro.Location = new System.Drawing.Point(13, 208);
            this.dateTimeRetiro.Name = "dateTimeRetiro";
            this.dateTimeRetiro.Size = new System.Drawing.Size(263, 23);
            this.dateTimeRetiro.TabIndex = 35;
            // 
            // dateTimeDevolucion
            // 
            this.dateTimeDevolucion.Location = new System.Drawing.Point(12, 265);
            this.dateTimeDevolucion.Name = "dateTimeDevolucion";
            this.dateTimeDevolucion.Size = new System.Drawing.Size(263, 23);
            this.dateTimeDevolucion.TabIndex = 36;
            // 
            // CBX_Categoria
            // 
            this.CBX_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Categoria.FormattingEnabled = true;
            this.CBX_Categoria.Location = new System.Drawing.Point(11, 327);
            this.CBX_Categoria.Name = "CBX_Categoria";
            this.CBX_Categoria.Size = new System.Drawing.Size(264, 25);
            this.CBX_Categoria.TabIndex = 37;
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(1119, 562);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(145, 33);
            this.BTNvolveralmenu.TabIndex = 34;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.Location = new System.Drawing.Point(1130, 15);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 33;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(1130, 34);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 32;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // GB_Reservas
            // 
            this.GB_Reservas.Controls.Add(this.DGV_CtrlResReservas);
            this.GB_Reservas.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Reservas.Location = new System.Drawing.Point(514, 75);
            this.GB_Reservas.Name = "GB_Reservas";
            this.GB_Reservas.Size = new System.Drawing.Size(750, 379);
            this.GB_Reservas.TabIndex = 35;
            this.GB_Reservas.TabStop = false;
            this.GB_Reservas.Text = "Reservas";
            // 
            // DGV_CtrlResReservas
            // 
            this.DGV_CtrlResReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CtrlResReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CtrlResReservas.Location = new System.Drawing.Point(12, 30);
            this.DGV_CtrlResReservas.Name = "DGV_CtrlResReservas";
            this.DGV_CtrlResReservas.Size = new System.Drawing.Size(720, 332);
            this.DGV_CtrlResReservas.TabIndex = 0;
            this.DGV_CtrlResReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CtrlResReservas_CellClick);
            // 
            // BTNCtrlResGenerar
            // 
            this.BTNCtrlResGenerar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlResGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlResGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlResGenerar.Location = new System.Drawing.Point(13, 469);
            this.BTNCtrlResGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlResGenerar.Name = "BTNCtrlResGenerar";
            this.BTNCtrlResGenerar.Size = new System.Drawing.Size(145, 51);
            this.BTNCtrlResGenerar.TabIndex = 38;
            this.BTNCtrlResGenerar.Tag = "";
            this.BTNCtrlResGenerar.Text = "Validar y generar reserva";
            this.BTNCtrlResGenerar.UseVisualStyleBackColor = false;
            this.BTNCtrlResGenerar.Click += new System.EventHandler(this.BTNCtrlResGenerar_Click);
            // 
            // BTNCtrlResCancelar
            // 
            this.BTNCtrlResCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlResCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlResCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlResCancelar.Location = new System.Drawing.Point(514, 472);
            this.BTNCtrlResCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlResCancelar.Name = "BTNCtrlResCancelar";
            this.BTNCtrlResCancelar.Size = new System.Drawing.Size(145, 51);
            this.BTNCtrlResCancelar.TabIndex = 39;
            this.BTNCtrlResCancelar.Tag = "";
            this.BTNCtrlResCancelar.Text = "Cancelar reserva";
            this.BTNCtrlResCancelar.UseVisualStyleBackColor = false;
            this.BTNCtrlResCancelar.Click += new System.EventHandler(this.BTNCtrlResCancelar_Click);
            // 
            // CBX_SucursalRetiro
            // 
            this.CBX_SucursalRetiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_SucursalRetiro.FormattingEnabled = true;
            this.CBX_SucursalRetiro.Location = new System.Drawing.Point(11, 378);
            this.CBX_SucursalRetiro.Name = "CBX_SucursalRetiro";
            this.CBX_SucursalRetiro.Size = new System.Drawing.Size(264, 25);
            this.CBX_SucursalRetiro.TabIndex = 40;
            // 
            // LBLSucursalRetiro
            // 
            this.LBLSucursalRetiro.AutoSize = true;
            this.LBLSucursalRetiro.Location = new System.Drawing.Point(11, 358);
            this.LBLSucursalRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLSucursalRetiro.Name = "LBLSucursalRetiro";
            this.LBLSucursalRetiro.Size = new System.Drawing.Size(117, 17);
            this.LBLSucursalRetiro.TabIndex = 39;
            this.LBLSucursalRetiro.Text = "Sucursal de retiro";
            // 
            // CBX_SucursalDevolucion
            // 
            this.CBX_SucursalDevolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_SucursalDevolucion.FormattingEnabled = true;
            this.CBX_SucursalDevolucion.Location = new System.Drawing.Point(11, 428);
            this.CBX_SucursalDevolucion.Name = "CBX_SucursalDevolucion";
            this.CBX_SucursalDevolucion.Size = new System.Drawing.Size(264, 25);
            this.CBX_SucursalDevolucion.TabIndex = 42;
            // 
            // LBLSucursalDevolucion
            // 
            this.LBLSucursalDevolucion.AutoSize = true;
            this.LBLSucursalDevolucion.Location = new System.Drawing.Point(11, 408);
            this.LBLSucursalDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLSucursalDevolucion.Name = "LBLSucursalDevolucion";
            this.LBLSucursalDevolucion.Size = new System.Drawing.Size(157, 17);
            this.LBLSucursalDevolucion.TabIndex = 41;
            this.LBLSucursalDevolucion.Text = "Sucursal de devolucion";
            // 
            // FrmCTRLReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 608);
            this.Controls.Add(this.BTNCtrlResCancelar);
            this.Controls.Add(this.GB_Reservas);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.GB_DatosNuevaReserva);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCTRLReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLReserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCTRLReserva_FormClosing);
            this.Load += new System.EventHandler(this.FrmCTRLReserva_Load);
            this.GB_DatosNuevaReserva.ResumeLayout(false);
            this.GB_DatosNuevaReserva.PerformLayout();
            this.GB_Reservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CtrlResReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_DatosNuevaReserva;
        private System.Windows.Forms.Button BTNCtrlResBuscar;
        private System.Windows.Forms.TextBox TXT_CtrlResDNI;
        private System.Windows.Forms.Label LBLdniCliente;
        private System.Windows.Forms.Label LBLCategoriaRes;
        private System.Windows.Forms.Label LBLFechaDevolucion;
        private System.Windows.Forms.Label LBLFechaRetiro;
        private System.Windows.Forms.Label LBLDatosCliente;
        private System.Windows.Forms.Label LBLClienteSeleccionado;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucion;
        private System.Windows.Forms.DateTimePicker dateTimeRetiro;
        private System.Windows.Forms.ComboBox CBX_Categoria;
        private System.Windows.Forms.Button BTNvolveralmenu;
        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.GroupBox GB_Reservas;
        private System.Windows.Forms.DataGridView DGV_CtrlResReservas;
        private System.Windows.Forms.Button BTNCtrlResGenerar;
        private System.Windows.Forms.Button BTNCtrlResCancelar;
        private System.Windows.Forms.ComboBox CBX_SucursalDevolucion;
        private System.Windows.Forms.Label LBLSucursalDevolucion;
        private System.Windows.Forms.ComboBox CBX_SucursalRetiro;
        private System.Windows.Forms.Label LBLSucursalRetiro;
    }
}