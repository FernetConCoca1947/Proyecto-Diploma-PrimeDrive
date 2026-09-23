namespace Trabajo_practico_IS
{
    partial class FrmCTRLVehiculo
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
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.CKXmostrarInactivos = new System.Windows.Forms.CheckBox();
            this.BTNCtrlVehReactivar = new System.Windows.Forms.Button();
            this.BTNCtrlVehModificar = new System.Windows.Forms.Button();
            this.BTNCtrlVehBaja = new System.Windows.Forms.Button();
            this.BTNCtrlVehAlta = new System.Windows.Forms.Button();
            this.GB_Vehiculos = new System.Windows.Forms.GroupBox();
            this.DGV_Vehiculos = new System.Windows.Forms.DataGridView();
            this.GB_DatosVehiculo = new System.Windows.Forms.GroupBox();
            this.LBLestado = new System.Windows.Forms.Label();
            this.LBLsucursal = new System.Windows.Forms.Label();
            this.TXT_CtrlVehPatente = new System.Windows.Forms.TextBox();
            this.TXT_CtrlVehMarca = new System.Windows.Forms.TextBox();
            this.TXT_CtrlVehModelo = new System.Windows.Forms.TextBox();
            this.LBLCateogria = new System.Windows.Forms.Label();
            this.LBLpatente = new System.Windows.Forms.Label();
            this.LBLmarca = new System.Windows.Forms.Label();
            this.LBLmodelo = new System.Windows.Forms.Label();
            this.LBLkmActual = new System.Windows.Forms.Label();
            this.NUM_KmActual = new System.Windows.Forms.NumericUpDown();
            this.CBX_Categoria = new System.Windows.Forms.ComboBox();
            this.CBX_Sucursal = new System.Windows.Forms.ComboBox();
            this.CBX_Estado = new System.Windows.Forms.ComboBox();
            this.GB_Vehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vehiculos)).BeginInit();
            this.GB_DatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmActual)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.Location = new System.Drawing.Point(782, 9);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 40;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(782, 28);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 39;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // CKXmostrarInactivos
            // 
            this.CKXmostrarInactivos.AutoSize = true;
            this.CKXmostrarInactivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarInactivos.Location = new System.Drawing.Point(270, 449);
            this.CKXmostrarInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.CKXmostrarInactivos.Name = "CKXmostrarInactivos";
            this.CKXmostrarInactivos.Size = new System.Drawing.Size(136, 21);
            this.CKXmostrarInactivos.TabIndex = 46;
            this.CKXmostrarInactivos.Text = "Mostrar Inactivas";
            this.CKXmostrarInactivos.UseVisualStyleBackColor = true;
            // 
            // BTNCtrlVehReactivar
            // 
            this.BTNCtrlVehReactivar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlVehReactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehReactivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehReactivar.Location = new System.Drawing.Point(423, 522);
            this.BTNCtrlVehReactivar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlVehReactivar.Name = "BTNCtrlVehReactivar";
            this.BTNCtrlVehReactivar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlVehReactivar.TabIndex = 45;
            this.BTNCtrlVehReactivar.Text = "Reactivar";
            this.BTNCtrlVehReactivar.UseVisualStyleBackColor = false;
            this.BTNCtrlVehReactivar.Click += new System.EventHandler(this.BTNCtrlVehReactivar_Click);
            // 
            // BTNCtrlVehModificar
            // 
            this.BTNCtrlVehModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlVehModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehModificar.Location = new System.Drawing.Point(270, 522);
            this.BTNCtrlVehModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlVehModificar.Name = "BTNCtrlVehModificar";
            this.BTNCtrlVehModificar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlVehModificar.TabIndex = 44;
            this.BTNCtrlVehModificar.Text = "Modificar";
            this.BTNCtrlVehModificar.UseVisualStyleBackColor = false;
            this.BTNCtrlVehModificar.Click += new System.EventHandler(this.BTNCtrlVehModificar_Click);
            // 
            // BTNCtrlVehBaja
            // 
            this.BTNCtrlVehBaja.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlVehBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehBaja.Location = new System.Drawing.Point(423, 481);
            this.BTNCtrlVehBaja.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlVehBaja.Name = "BTNCtrlVehBaja";
            this.BTNCtrlVehBaja.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlVehBaja.TabIndex = 43;
            this.BTNCtrlVehBaja.Text = "Baja";
            this.BTNCtrlVehBaja.UseVisualStyleBackColor = false;
            this.BTNCtrlVehBaja.Click += new System.EventHandler(this.BTNCtrlVehBaja_Click);
            // 
            // BTNCtrlVehAlta
            // 
            this.BTNCtrlVehAlta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlVehAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehAlta.Location = new System.Drawing.Point(270, 481);
            this.BTNCtrlVehAlta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlVehAlta.Name = "BTNCtrlVehAlta";
            this.BTNCtrlVehAlta.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlVehAlta.TabIndex = 42;
            this.BTNCtrlVehAlta.Text = "Alta";
            this.BTNCtrlVehAlta.UseVisualStyleBackColor = false;
            this.BTNCtrlVehAlta.Click += new System.EventHandler(this.BTNCtrlVehAlta_Click);
            // 
            // GB_Vehiculos
            // 
            this.GB_Vehiculos.Controls.Add(this.DGV_Vehiculos);
            this.GB_Vehiculos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Vehiculos.Location = new System.Drawing.Point(12, 76);
            this.GB_Vehiculos.Name = "GB_Vehiculos";
            this.GB_Vehiculos.Size = new System.Drawing.Size(680, 320);
            this.GB_Vehiculos.TabIndex = 41;
            this.GB_Vehiculos.TabStop = false;
            this.GB_Vehiculos.Text = "Vehiculos";
            // 
            // DGV_Vehiculos
            // 
            this.DGV_Vehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Vehiculos.Location = new System.Drawing.Point(12, 30);
            this.DGV_Vehiculos.Name = "DGV_Vehiculos";
            this.DGV_Vehiculos.Size = new System.Drawing.Size(652, 274);
            this.DGV_Vehiculos.TabIndex = 0;
            this.DGV_Vehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Vehiculos_CellClick);
            // 
            // GB_DatosVehiculo
            // 
            this.GB_DatosVehiculo.Controls.Add(this.CBX_Estado);
            this.GB_DatosVehiculo.Controls.Add(this.CBX_Sucursal);
            this.GB_DatosVehiculo.Controls.Add(this.CBX_Categoria);
            this.GB_DatosVehiculo.Controls.Add(this.NUM_KmActual);
            this.GB_DatosVehiculo.Controls.Add(this.LBLestado);
            this.GB_DatosVehiculo.Controls.Add(this.LBLsucursal);
            this.GB_DatosVehiculo.Controls.Add(this.TXT_CtrlVehPatente);
            this.GB_DatosVehiculo.Controls.Add(this.TXT_CtrlVehMarca);
            this.GB_DatosVehiculo.Controls.Add(this.TXT_CtrlVehModelo);
            this.GB_DatosVehiculo.Controls.Add(this.LBLCateogria);
            this.GB_DatosVehiculo.Controls.Add(this.LBLpatente);
            this.GB_DatosVehiculo.Controls.Add(this.LBLmarca);
            this.GB_DatosVehiculo.Controls.Add(this.LBLmodelo);
            this.GB_DatosVehiculo.Controls.Add(this.LBLkmActual);
            this.GB_DatosVehiculo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosVehiculo.Location = new System.Drawing.Point(713, 69);
            this.GB_DatosVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.GB_DatosVehiculo.Name = "GB_DatosVehiculo";
            this.GB_DatosVehiculo.Padding = new System.Windows.Forms.Padding(4);
            this.GB_DatosVehiculo.Size = new System.Drawing.Size(300, 432);
            this.GB_DatosVehiculo.TabIndex = 47;
            this.GB_DatosVehiculo.TabStop = false;
            this.GB_DatosVehiculo.Text = "Datos del vehiculos";
            // 
            // LBLestado
            // 
            this.LBLestado.AutoSize = true;
            this.LBLestado.Location = new System.Drawing.Point(9, 367);
            this.LBLestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLestado.Name = "LBLestado";
            this.LBLestado.Size = new System.Drawing.Size(52, 17);
            this.LBLestado.TabIndex = 29;
            this.LBLestado.Text = "Estado";
            // 
            // LBLsucursal
            // 
            this.LBLsucursal.AutoSize = true;
            this.LBLsucursal.Location = new System.Drawing.Point(9, 310);
            this.LBLsucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLsucursal.Name = "LBLsucursal";
            this.LBLsucursal.Size = new System.Drawing.Size(59, 17);
            this.LBLsucursal.TabIndex = 27;
            this.LBLsucursal.Text = "Sucursal";
            // 
            // TXT_CtrlVehPatente
            // 
            this.TXT_CtrlVehPatente.Location = new System.Drawing.Point(12, 48);
            this.TXT_CtrlVehPatente.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlVehPatente.Name = "TXT_CtrlVehPatente";
            this.TXT_CtrlVehPatente.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlVehPatente.TabIndex = 0;
            // 
            // TXT_CtrlVehMarca
            // 
            this.TXT_CtrlVehMarca.Location = new System.Drawing.Point(12, 103);
            this.TXT_CtrlVehMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlVehMarca.Name = "TXT_CtrlVehMarca";
            this.TXT_CtrlVehMarca.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlVehMarca.TabIndex = 1;
            // 
            // TXT_CtrlVehModelo
            // 
            this.TXT_CtrlVehModelo.Location = new System.Drawing.Point(12, 159);
            this.TXT_CtrlVehModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlVehModelo.Name = "TXT_CtrlVehModelo";
            this.TXT_CtrlVehModelo.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlVehModelo.TabIndex = 2;
            // 
            // LBLCateogria
            // 
            this.LBLCateogria.AutoSize = true;
            this.LBLCateogria.Location = new System.Drawing.Point(8, 250);
            this.LBLCateogria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCateogria.Name = "LBLCateogria";
            this.LBLCateogria.Size = new System.Drawing.Size(75, 17);
            this.LBLCateogria.TabIndex = 19;
            this.LBLCateogria.Text = "Categoría";
            // 
            // LBLpatente
            // 
            this.LBLpatente.AutoSize = true;
            this.LBLpatente.Location = new System.Drawing.Point(8, 28);
            this.LBLpatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLpatente.Name = "LBLpatente";
            this.LBLpatente.Size = new System.Drawing.Size(59, 17);
            this.LBLpatente.TabIndex = 5;
            this.LBLpatente.Text = "Patente";
            // 
            // LBLmarca
            // 
            this.LBLmarca.AutoSize = true;
            this.LBLmarca.Location = new System.Drawing.Point(8, 84);
            this.LBLmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmarca.Name = "LBLmarca";
            this.LBLmarca.Size = new System.Drawing.Size(49, 17);
            this.LBLmarca.TabIndex = 6;
            this.LBLmarca.Text = "Marca";
            // 
            // LBLmodelo
            // 
            this.LBLmodelo.AutoSize = true;
            this.LBLmodelo.Location = new System.Drawing.Point(8, 139);
            this.LBLmodelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLmodelo.Name = "LBLmodelo";
            this.LBLmodelo.Size = new System.Drawing.Size(57, 17);
            this.LBLmodelo.TabIndex = 7;
            this.LBLmodelo.Text = "Modelo";
            // 
            // LBLkmActual
            // 
            this.LBLkmActual.AutoSize = true;
            this.LBLkmActual.Location = new System.Drawing.Point(8, 194);
            this.LBLkmActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLkmActual.Name = "LBLkmActual";
            this.LBLkmActual.Size = new System.Drawing.Size(75, 17);
            this.LBLkmActual.TabIndex = 8;
            this.LBLkmActual.Text = "Km Actual";
            // 
            // NUM_KmActual
            // 
            this.NUM_KmActual.Location = new System.Drawing.Point(12, 215);
            this.NUM_KmActual.Name = "NUM_KmActual";
            this.NUM_KmActual.Size = new System.Drawing.Size(263, 23);
            this.NUM_KmActual.TabIndex = 31;
            // 
            // CBX_Categoria
            // 
            this.CBX_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Categoria.FormattingEnabled = true;
            this.CBX_Categoria.Location = new System.Drawing.Point(11, 271);
            this.CBX_Categoria.Name = "CBX_Categoria";
            this.CBX_Categoria.Size = new System.Drawing.Size(264, 25);
            this.CBX_Categoria.TabIndex = 32;
            // 
            // CBX_Sucursal
            // 
            this.CBX_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Sucursal.FormattingEnabled = true;
            this.CBX_Sucursal.Location = new System.Drawing.Point(11, 330);
            this.CBX_Sucursal.Name = "CBX_Sucursal";
            this.CBX_Sucursal.Size = new System.Drawing.Size(264, 25);
            this.CBX_Sucursal.TabIndex = 33;
            // 
            // CBX_Estado
            // 
            this.CBX_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Estado.FormattingEnabled = true;
            this.CBX_Estado.Location = new System.Drawing.Point(11, 387);
            this.CBX_Estado.Name = "CBX_Estado";
            this.CBX_Estado.Size = new System.Drawing.Size(264, 25);
            this.CBX_Estado.TabIndex = 34;
            // 
            // FrmCTRLVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 602);
            this.Controls.Add(this.GB_DatosVehiculo);
            this.Controls.Add(this.CKXmostrarInactivos);
            this.Controls.Add(this.BTNCtrlVehReactivar);
            this.Controls.Add(this.BTNCtrlVehModificar);
            this.Controls.Add(this.BTNCtrlVehBaja);
            this.Controls.Add(this.BTNCtrlVehAlta);
            this.Controls.Add(this.GB_Vehiculos);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCTRLVehiculo";
            this.Text = "FrmCTRLVehiculo";
            this.Load += new System.EventHandler(this.FrmCTRLVehiculo_Load);
            this.GB_Vehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vehiculos)).EndInit();
            this.GB_DatosVehiculo.ResumeLayout(false);
            this.GB_DatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.CheckBox CKXmostrarInactivos;
        private System.Windows.Forms.Button BTNCtrlVehReactivar;
        private System.Windows.Forms.Button BTNCtrlVehModificar;
        private System.Windows.Forms.Button BTNCtrlVehBaja;
        private System.Windows.Forms.Button BTNCtrlVehAlta;
        private System.Windows.Forms.GroupBox GB_Vehiculos;
        private System.Windows.Forms.DataGridView DGV_Vehiculos;
        private System.Windows.Forms.GroupBox GB_DatosVehiculo;
        private System.Windows.Forms.Label LBLestado;
        private System.Windows.Forms.Label LBLsucursal;
        private System.Windows.Forms.TextBox TXT_CtrlVehPatente;
        private System.Windows.Forms.TextBox TXT_CtrlVehMarca;
        private System.Windows.Forms.TextBox TXT_CtrlVehModelo;
        private System.Windows.Forms.Label LBLCateogria;
        private System.Windows.Forms.Label LBLpatente;
        private System.Windows.Forms.Label LBLmarca;
        private System.Windows.Forms.Label LBLmodelo;
        private System.Windows.Forms.Label LBLkmActual;
        private System.Windows.Forms.NumericUpDown NUM_KmActual;
        private System.Windows.Forms.ComboBox CBX_Estado;
        private System.Windows.Forms.ComboBox CBX_Sucursal;
        private System.Windows.Forms.ComboBox CBX_Categoria;
    }
}