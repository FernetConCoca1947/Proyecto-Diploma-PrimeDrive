namespace Trabajo_practico_IS
{
    partial class FrmCTRLCliente
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
            this.DGV_CtrlCliClientes = new System.Windows.Forms.DataGridView();
            this.GB_Clientes = new System.Windows.Forms.GroupBox();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.GB_DatosCliente = new System.Windows.Forms.GroupBox();
            this.dateTimeVencimiento = new System.Windows.Forms.DateTimePicker();
            this.LBLVencimiento = new System.Windows.Forms.Label();
            this.TXT_CtrlCliLicencia = new System.Windows.Forms.TextBox();
            this.LBLLicencia = new System.Windows.Forms.Label();
            this.TXT_CtrlCliTelefono = new System.Windows.Forms.TextBox();
            this.TXT_CtrlCLiNombre = new System.Windows.Forms.TextBox();
            this.TXT_CtrlCliApellido = new System.Windows.Forms.TextBox();
            this.TXT_CtrlCliDNI = new System.Windows.Forms.TextBox();
            this.LBLTelefono = new System.Windows.Forms.Label();
            this.TXT_CtrlCliEmail = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLapellido = new System.Windows.Forms.Label();
            this.LBLdni = new System.Windows.Forms.Label();
            this.LBLemail = new System.Windows.Forms.Label();
            this.BTNCtrlCliAlta = new System.Windows.Forms.Button();
            this.BTNCtrlCliBaja = new System.Windows.Forms.Button();
            this.BTNCtrlCliModificar = new System.Windows.Forms.Button();
            this.BTNCtrlCliReactivar = new System.Windows.Forms.Button();
            this.CKXmostrarInactivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CtrlCliClientes)).BeginInit();
            this.GB_Clientes.SuspendLayout();
            this.GB_DatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_CtrlCliClientes
            // 
            this.DGV_CtrlCliClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CtrlCliClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CtrlCliClientes.Location = new System.Drawing.Point(12, 30);
            this.DGV_CtrlCliClientes.Name = "DGV_CtrlCliClientes";
            this.DGV_CtrlCliClientes.Size = new System.Drawing.Size(743, 274);
            this.DGV_CtrlCliClientes.TabIndex = 0;
            this.DGV_CtrlCliClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CtrlCliClientes_CellClick);
            // 
            // GB_Clientes
            // 
            this.GB_Clientes.Controls.Add(this.DGV_CtrlCliClientes);
            this.GB_Clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Clientes.Location = new System.Drawing.Point(338, 64);
            this.GB_Clientes.Name = "GB_Clientes";
            this.GB_Clientes.Size = new System.Drawing.Size(773, 320);
            this.GB_Clientes.TabIndex = 1;
            this.GB_Clientes.TabStop = false;
            this.GB_Clientes.Text = "Clientes";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(976, 33);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 2;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.Location = new System.Drawing.Point(976, 14);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 23;
            this.LBLidiomas.Text = "Language";
            // 
            // GB_DatosCliente
            // 
            this.GB_DatosCliente.Controls.Add(this.dateTimeVencimiento);
            this.GB_DatosCliente.Controls.Add(this.LBLVencimiento);
            this.GB_DatosCliente.Controls.Add(this.TXT_CtrlCliLicencia);
            this.GB_DatosCliente.Controls.Add(this.LBLLicencia);
            this.GB_DatosCliente.Controls.Add(this.TXT_CtrlCliTelefono);
            this.GB_DatosCliente.Controls.Add(this.TXT_CtrlCLiNombre);
            this.GB_DatosCliente.Controls.Add(this.TXT_CtrlCliApellido);
            this.GB_DatosCliente.Controls.Add(this.TXT_CtrlCliDNI);
            this.GB_DatosCliente.Controls.Add(this.LBLTelefono);
            this.GB_DatosCliente.Controls.Add(this.TXT_CtrlCliEmail);
            this.GB_DatosCliente.Controls.Add(this.LBLnombre);
            this.GB_DatosCliente.Controls.Add(this.LBLapellido);
            this.GB_DatosCliente.Controls.Add(this.LBLdni);
            this.GB_DatosCliente.Controls.Add(this.LBLemail);
            this.GB_DatosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosCliente.Location = new System.Drawing.Point(13, 33);
            this.GB_DatosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.GB_DatosCliente.Name = "GB_DatosCliente";
            this.GB_DatosCliente.Padding = new System.Windows.Forms.Padding(4);
            this.GB_DatosCliente.Size = new System.Drawing.Size(300, 432);
            this.GB_DatosCliente.TabIndex = 25;
            this.GB_DatosCliente.TabStop = false;
            this.GB_DatosCliente.Text = "Datos del cliente";
            // 
            // dateTimeVencimiento
            // 
            this.dateTimeVencimiento.Location = new System.Drawing.Point(12, 393);
            this.dateTimeVencimiento.Name = "dateTimeVencimiento";
            this.dateTimeVencimiento.Size = new System.Drawing.Size(263, 23);
            this.dateTimeVencimiento.TabIndex = 30;
            // 
            // LBLVencimiento
            // 
            this.LBLVencimiento.AutoSize = true;
            this.LBLVencimiento.Location = new System.Drawing.Point(9, 367);
            this.LBLVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLVencimiento.Name = "LBLVencimiento";
            this.LBLVencimiento.Size = new System.Drawing.Size(90, 17);
            this.LBLVencimiento.TabIndex = 29;
            this.LBLVencimiento.Text = "Vencimiento";
            // 
            // TXT_CtrlCliLicencia
            // 
            this.TXT_CtrlCliLicencia.Location = new System.Drawing.Point(12, 331);
            this.TXT_CtrlCliLicencia.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCliLicencia.Name = "TXT_CtrlCliLicencia";
            this.TXT_CtrlCliLicencia.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCliLicencia.TabIndex = 28;
            // 
            // LBLLicencia
            // 
            this.LBLLicencia.AutoSize = true;
            this.LBLLicencia.Location = new System.Drawing.Point(9, 310);
            this.LBLLicencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLLicencia.Name = "LBLLicencia";
            this.LBLLicencia.Size = new System.Drawing.Size(61, 17);
            this.LBLLicencia.TabIndex = 27;
            this.LBLLicencia.Text = "Licencia";
            // 
            // TXT_CtrlCliTelefono
            // 
            this.TXT_CtrlCliTelefono.Location = new System.Drawing.Point(11, 271);
            this.TXT_CtrlCliTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCliTelefono.Name = "TXT_CtrlCliTelefono";
            this.TXT_CtrlCliTelefono.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCliTelefono.TabIndex = 26;
            // 
            // TXT_CtrlCLiNombre
            // 
            this.TXT_CtrlCLiNombre.Location = new System.Drawing.Point(12, 48);
            this.TXT_CtrlCLiNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCLiNombre.Name = "TXT_CtrlCLiNombre";
            this.TXT_CtrlCLiNombre.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCLiNombre.TabIndex = 0;
            // 
            // TXT_CtrlCliApellido
            // 
            this.TXT_CtrlCliApellido.Location = new System.Drawing.Point(12, 103);
            this.TXT_CtrlCliApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCliApellido.Name = "TXT_CtrlCliApellido";
            this.TXT_CtrlCliApellido.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCliApellido.TabIndex = 1;
            // 
            // TXT_CtrlCliDNI
            // 
            this.TXT_CtrlCliDNI.Location = new System.Drawing.Point(12, 159);
            this.TXT_CtrlCliDNI.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCliDNI.Name = "TXT_CtrlCliDNI";
            this.TXT_CtrlCliDNI.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCliDNI.TabIndex = 2;
            // 
            // LBLTelefono
            // 
            this.LBLTelefono.AutoSize = true;
            this.LBLTelefono.Location = new System.Drawing.Point(8, 250);
            this.LBLTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTelefono.Name = "LBLTelefono";
            this.LBLTelefono.Size = new System.Drawing.Size(62, 17);
            this.LBLTelefono.TabIndex = 19;
            this.LBLTelefono.Text = "Telefono";
            // 
            // TXT_CtrlCliEmail
            // 
            this.TXT_CtrlCliEmail.Location = new System.Drawing.Point(12, 214);
            this.TXT_CtrlCliEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCliEmail.Name = "TXT_CtrlCliEmail";
            this.TXT_CtrlCliEmail.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCliEmail.TabIndex = 3;
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(8, 28);
            this.LBLnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(61, 17);
            this.LBLnombre.TabIndex = 5;
            this.LBLnombre.Text = "Nombre";
            // 
            // LBLapellido
            // 
            this.LBLapellido.AutoSize = true;
            this.LBLapellido.Location = new System.Drawing.Point(8, 84);
            this.LBLapellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLapellido.Name = "LBLapellido";
            this.LBLapellido.Size = new System.Drawing.Size(61, 17);
            this.LBLapellido.TabIndex = 6;
            this.LBLapellido.Text = "Apellido";
            // 
            // LBLdni
            // 
            this.LBLdni.AutoSize = true;
            this.LBLdni.Location = new System.Drawing.Point(8, 139);
            this.LBLdni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLdni.Name = "LBLdni";
            this.LBLdni.Size = new System.Drawing.Size(31, 17);
            this.LBLdni.TabIndex = 7;
            this.LBLdni.Text = "DNI";
            // 
            // LBLemail
            // 
            this.LBLemail.AutoSize = true;
            this.LBLemail.Location = new System.Drawing.Point(8, 194);
            this.LBLemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLemail.Name = "LBLemail";
            this.LBLemail.Size = new System.Drawing.Size(43, 17);
            this.LBLemail.TabIndex = 8;
            this.LBLemail.Text = "Email";
            // 
            // BTNCtrlCliAlta
            // 
            this.BTNCtrlCliAlta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlCliAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlCliAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlCliAlta.Location = new System.Drawing.Point(338, 424);
            this.BTNCtrlCliAlta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlCliAlta.Name = "BTNCtrlCliAlta";
            this.BTNCtrlCliAlta.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlCliAlta.TabIndex = 26;
            this.BTNCtrlCliAlta.Tag = "";
            this.BTNCtrlCliAlta.Text = "Alta";
            this.BTNCtrlCliAlta.UseVisualStyleBackColor = false;
            this.BTNCtrlCliAlta.Click += new System.EventHandler(this.BTNCtrlCliAlta_Click);
            // 
            // BTNCtrlCliBaja
            // 
            this.BTNCtrlCliBaja.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlCliBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlCliBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlCliBaja.Location = new System.Drawing.Point(491, 424);
            this.BTNCtrlCliBaja.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlCliBaja.Name = "BTNCtrlCliBaja";
            this.BTNCtrlCliBaja.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlCliBaja.TabIndex = 27;
            this.BTNCtrlCliBaja.Text = "Baja";
            this.BTNCtrlCliBaja.UseVisualStyleBackColor = false;
            this.BTNCtrlCliBaja.Click += new System.EventHandler(this.BTNCtrlCliBaja_Click);
            // 
            // BTNCtrlCliModificar
            // 
            this.BTNCtrlCliModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlCliModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlCliModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlCliModificar.Location = new System.Drawing.Point(644, 424);
            this.BTNCtrlCliModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlCliModificar.Name = "BTNCtrlCliModificar";
            this.BTNCtrlCliModificar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlCliModificar.TabIndex = 28;
            this.BTNCtrlCliModificar.Text = "Modificar";
            this.BTNCtrlCliModificar.UseVisualStyleBackColor = false;
            this.BTNCtrlCliModificar.Click += new System.EventHandler(this.BTNCtrlCliModificar_Click);
            // 
            // BTNCtrlCliReactivar
            // 
            this.BTNCtrlCliReactivar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCtrlCliReactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlCliReactivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlCliReactivar.Location = new System.Drawing.Point(797, 424);
            this.BTNCtrlCliReactivar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCtrlCliReactivar.Name = "BTNCtrlCliReactivar";
            this.BTNCtrlCliReactivar.Size = new System.Drawing.Size(145, 33);
            this.BTNCtrlCliReactivar.TabIndex = 29;
            this.BTNCtrlCliReactivar.Text = "Reactivar";
            this.BTNCtrlCliReactivar.UseVisualStyleBackColor = false;
            this.BTNCtrlCliReactivar.Click += new System.EventHandler(this.BTNCtrlCliReactivar_Click);
            // 
            // CKXmostrarInactivos
            // 
            this.CKXmostrarInactivos.AutoSize = true;
            this.CKXmostrarInactivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarInactivos.Location = new System.Drawing.Point(338, 395);
            this.CKXmostrarInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.CKXmostrarInactivos.Name = "CKXmostrarInactivos";
            this.CKXmostrarInactivos.Size = new System.Drawing.Size(136, 21);
            this.CKXmostrarInactivos.TabIndex = 30;
            this.CKXmostrarInactivos.Text = "Mostrar Inactivos";
            this.CKXmostrarInactivos.UseVisualStyleBackColor = true;
            this.CKXmostrarInactivos.CheckedChanged += new System.EventHandler(this.CKXmostrarInactivos_CheckedChanged);
            // 
            // FrmCTRLCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 511);
            this.Controls.Add(this.CKXmostrarInactivos);
            this.Controls.Add(this.BTNCtrlCliReactivar);
            this.Controls.Add(this.BTNCtrlCliModificar);
            this.Controls.Add(this.BTNCtrlCliBaja);
            this.Controls.Add(this.BTNCtrlCliAlta);
            this.Controls.Add(this.GB_DatosCliente);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.GB_Clientes);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCTRLCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLCliente";
            this.Load += new System.EventHandler(this.FrmCTRLCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CtrlCliClientes)).EndInit();
            this.GB_Clientes.ResumeLayout(false);
            this.GB_DatosCliente.ResumeLayout(false);
            this.GB_DatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_CtrlCliClientes;
        private System.Windows.Forms.GroupBox GB_Clientes;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.GroupBox GB_DatosCliente;
        private System.Windows.Forms.TextBox TXT_CtrlCLiNombre;
        private System.Windows.Forms.TextBox TXT_CtrlCliApellido;
        private System.Windows.Forms.TextBox TXT_CtrlCliDNI;
        private System.Windows.Forms.Label LBLTelefono;
        private System.Windows.Forms.TextBox TXT_CtrlCliEmail;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLapellido;
        private System.Windows.Forms.Label LBLdni;
        private System.Windows.Forms.Label LBLemail;
        private System.Windows.Forms.TextBox TXT_CtrlCliTelefono;
        private System.Windows.Forms.Button BTNCtrlCliAlta;
        private System.Windows.Forms.Button BTNCtrlCliBaja;
        private System.Windows.Forms.Button BTNCtrlCliModificar;
        private System.Windows.Forms.Button BTNCtrlCliReactivar;
        private System.Windows.Forms.DateTimePicker dateTimeVencimiento;
        private System.Windows.Forms.Label LBLVencimiento;
        private System.Windows.Forms.TextBox TXT_CtrlCliLicencia;
        private System.Windows.Forms.Label LBLLicencia;
        private System.Windows.Forms.CheckBox CKXmostrarInactivos;
    }
}