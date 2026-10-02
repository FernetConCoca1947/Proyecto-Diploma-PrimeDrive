namespace Trabajo_practico_IS
{
    partial class FrmCTRLUsuario
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
            this.TXT_CtrlUsuUsuario = new System.Windows.Forms.TextBox();
            this.TXT_CtrlUsuContraseña = new System.Windows.Forms.TextBox();
            this.TXT_CtrlUsuDNI = new System.Windows.Forms.TextBox();
            this.TXT_CtrlUsuEmail = new System.Windows.Forms.TextBox();
            this.LBLusuario = new System.Windows.Forms.Label();
            this.LBLcontraseña = new System.Windows.Forms.Label();
            this.LBLdni = new System.Windows.Forms.Label();
            this.LBLemail = new System.Windows.Forms.Label();
            this.BTNCtrlUsuAlta = new System.Windows.Forms.Button();
            this.BTNCtrlUsuBaja = new System.Windows.Forms.Button();
            this.BTNCtrlUsuModificar = new System.Windows.Forms.Button();
            this.BTNCtrlUsuVolverMenu = new System.Windows.Forms.Button();
            this.DGV_CtrlUsuUsuarios = new System.Windows.Forms.DataGridView();
            this.BTNCtrlUsuDesbloquear = new System.Windows.Forms.Button();
            this.CKXmostrarbloqueados = new System.Windows.Forms.CheckBox();
            this.LBLrol = new System.Windows.Forms.Label();
            this.Cb_CTRLUsuarioRol = new System.Windows.Forms.ComboBox();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.GB_Usuarios = new System.Windows.Forms.GroupBox();
            this.GB_Datos = new System.Windows.Forms.GroupBox();
            this.CKXmostrarInactivos = new System.Windows.Forms.CheckBox();
            this.BTNCtrlUsuReactivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CtrlUsuUsuarios)).BeginInit();
            this.GB_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_CtrlUsuUsuario
            // 
            this.TXT_CtrlUsuUsuario.Location = new System.Drawing.Point(14, 51);
            this.TXT_CtrlUsuUsuario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlUsuUsuario.Name = "TXT_CtrlUsuUsuario";
            this.TXT_CtrlUsuUsuario.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlUsuUsuario.TabIndex = 0;
            // 
            // TXT_CtrlUsuContraseña
            // 
            this.TXT_CtrlUsuContraseña.Location = new System.Drawing.Point(14, 109);
            this.TXT_CtrlUsuContraseña.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlUsuContraseña.Name = "TXT_CtrlUsuContraseña";
            this.TXT_CtrlUsuContraseña.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlUsuContraseña.TabIndex = 1;
            // 
            // TXT_CtrlUsuDNI
            // 
            this.TXT_CtrlUsuDNI.Location = new System.Drawing.Point(14, 169);
            this.TXT_CtrlUsuDNI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlUsuDNI.Name = "TXT_CtrlUsuDNI";
            this.TXT_CtrlUsuDNI.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlUsuDNI.TabIndex = 2;
            // 
            // TXT_CtrlUsuEmail
            // 
            this.TXT_CtrlUsuEmail.Location = new System.Drawing.Point(14, 227);
            this.TXT_CtrlUsuEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlUsuEmail.Name = "TXT_CtrlUsuEmail";
            this.TXT_CtrlUsuEmail.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlUsuEmail.TabIndex = 3;
            // 
            // LBLusuario
            // 
            this.LBLusuario.AutoSize = true;
            this.LBLusuario.Location = new System.Drawing.Point(9, 30);
            this.LBLusuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLusuario.Name = "LBLusuario";
            this.LBLusuario.Size = new System.Drawing.Size(54, 17);
            this.LBLusuario.TabIndex = 5;
            this.LBLusuario.Text = "Usuario";
            // 
            // LBLcontraseña
            // 
            this.LBLcontraseña.AutoSize = true;
            this.LBLcontraseña.Location = new System.Drawing.Point(9, 89);
            this.LBLcontraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLcontraseña.Name = "LBLcontraseña";
            this.LBLcontraseña.Size = new System.Drawing.Size(84, 17);
            this.LBLcontraseña.TabIndex = 6;
            this.LBLcontraseña.Text = "Contraseña";
            // 
            // LBLdni
            // 
            this.LBLdni.AutoSize = true;
            this.LBLdni.Location = new System.Drawing.Point(9, 148);
            this.LBLdni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLdni.Name = "LBLdni";
            this.LBLdni.Size = new System.Drawing.Size(31, 17);
            this.LBLdni.TabIndex = 7;
            this.LBLdni.Text = "DNI";
            // 
            // LBLemail
            // 
            this.LBLemail.AutoSize = true;
            this.LBLemail.Location = new System.Drawing.Point(9, 206);
            this.LBLemail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLemail.Name = "LBLemail";
            this.LBLemail.Size = new System.Drawing.Size(43, 17);
            this.LBLemail.TabIndex = 8;
            this.LBLemail.Text = "Email";
            // 
            // BTNCtrlUsuAlta
            // 
            this.BTNCtrlUsuAlta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlUsuAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlUsuAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlUsuAlta.Location = new System.Drawing.Point(374, 416);
            this.BTNCtrlUsuAlta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlUsuAlta.Name = "BTNCtrlUsuAlta";
            this.BTNCtrlUsuAlta.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlUsuAlta.TabIndex = 10;
            this.BTNCtrlUsuAlta.Text = "Alta";
            this.BTNCtrlUsuAlta.UseVisualStyleBackColor = false;
            this.BTNCtrlUsuAlta.Click += new System.EventHandler(this.BTNCtrlUsuAlta_Click);
            // 
            // BTNCtrlUsuBaja
            // 
            this.BTNCtrlUsuBaja.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlUsuBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlUsuBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlUsuBaja.Location = new System.Drawing.Point(553, 416);
            this.BTNCtrlUsuBaja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlUsuBaja.Name = "BTNCtrlUsuBaja";
            this.BTNCtrlUsuBaja.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlUsuBaja.TabIndex = 11;
            this.BTNCtrlUsuBaja.Text = "Baja";
            this.BTNCtrlUsuBaja.UseVisualStyleBackColor = false;
            this.BTNCtrlUsuBaja.Click += new System.EventHandler(this.BTNCtrlUsuBaja_Click);
            // 
            // BTNCtrlUsuModificar
            // 
            this.BTNCtrlUsuModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlUsuModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlUsuModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlUsuModificar.Location = new System.Drawing.Point(733, 416);
            this.BTNCtrlUsuModificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlUsuModificar.Name = "BTNCtrlUsuModificar";
            this.BTNCtrlUsuModificar.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlUsuModificar.TabIndex = 12;
            this.BTNCtrlUsuModificar.Text = "Modificar";
            this.BTNCtrlUsuModificar.UseVisualStyleBackColor = false;
            this.BTNCtrlUsuModificar.Click += new System.EventHandler(this.BTNCtrlUsuModificar_Click);
            // 
            // BTNCtrlUsuVolverMenu
            // 
            this.BTNCtrlUsuVolverMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlUsuVolverMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlUsuVolverMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlUsuVolverMenu.Location = new System.Drawing.Point(1081, 659);
            this.BTNCtrlUsuVolverMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlUsuVolverMenu.Name = "BTNCtrlUsuVolverMenu";
            this.BTNCtrlUsuVolverMenu.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlUsuVolverMenu.TabIndex = 13;
            this.BTNCtrlUsuVolverMenu.Text = "Volver al Menu";
            this.BTNCtrlUsuVolverMenu.UseVisualStyleBackColor = false;
            this.BTNCtrlUsuVolverMenu.Click += new System.EventHandler(this.BTNCtrlUsuVolverMenu_Click);
            // 
            // DGV_CtrlUsuUsuarios
            // 
            this.DGV_CtrlUsuUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CtrlUsuUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CtrlUsuUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CtrlUsuUsuarios.Location = new System.Drawing.Point(31, 46);
            this.DGV_CtrlUsuUsuarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DGV_CtrlUsuUsuarios.Name = "DGV_CtrlUsuUsuarios";
            this.DGV_CtrlUsuUsuarios.Size = new System.Drawing.Size(1033, 291);
            this.DGV_CtrlUsuUsuarios.TabIndex = 14;
            this.DGV_CtrlUsuUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CtrlUsuUsuarios_CellClick);
            // 
            // BTNCtrlUsuDesbloquear
            // 
            this.BTNCtrlUsuDesbloquear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlUsuDesbloquear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlUsuDesbloquear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlUsuDesbloquear.Location = new System.Drawing.Point(1081, 416);
            this.BTNCtrlUsuDesbloquear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlUsuDesbloquear.Name = "BTNCtrlUsuDesbloquear";
            this.BTNCtrlUsuDesbloquear.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlUsuDesbloquear.TabIndex = 17;
            this.BTNCtrlUsuDesbloquear.Text = "Desbloquear";
            this.BTNCtrlUsuDesbloquear.UseVisualStyleBackColor = false;
            this.BTNCtrlUsuDesbloquear.Click += new System.EventHandler(this.BTNCtrlUsuDesbloquear_Click);
            // 
            // CKXmostrarbloqueados
            // 
            this.CKXmostrarbloqueados.AutoSize = true;
            this.CKXmostrarbloqueados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarbloqueados.ForeColor = System.Drawing.SystemColors.Window;
            this.CKXmostrarbloqueados.Location = new System.Drawing.Point(630, 374);
            this.CKXmostrarbloqueados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CKXmostrarbloqueados.Name = "CKXmostrarbloqueados";
            this.CKXmostrarbloqueados.Size = new System.Drawing.Size(154, 21);
            this.CKXmostrarbloqueados.TabIndex = 18;
            this.CKXmostrarbloqueados.Text = "Mostrar Bloqueados";
            this.CKXmostrarbloqueados.UseVisualStyleBackColor = true;
            this.CKXmostrarbloqueados.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LBLrol
            // 
            this.LBLrol.AutoSize = true;
            this.LBLrol.Location = new System.Drawing.Point(9, 266);
            this.LBLrol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLrol.Name = "LBLrol";
            this.LBLrol.Size = new System.Drawing.Size(28, 17);
            this.LBLrol.TabIndex = 19;
            this.LBLrol.Text = "Rol";
            // 
            // Cb_CTRLUsuarioRol
            // 
            this.Cb_CTRLUsuarioRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_CTRLUsuarioRol.FormattingEnabled = true;
            this.Cb_CTRLUsuarioRol.Location = new System.Drawing.Point(14, 287);
            this.Cb_CTRLUsuarioRol.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Cb_CTRLUsuarioRol.Name = "Cb_CTRLUsuarioRol";
            this.Cb_CTRLUsuarioRol.Size = new System.Drawing.Size(301, 25);
            this.Cb_CTRLUsuarioRol.TabIndex = 20;
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(1115, 35);
            this.CBXidiomas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(154, 25);
            this.CBXidiomas.TabIndex = 21;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(1115, 15);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 22;
            this.LBLidiomas.Text = "Language";
            // 
            // GB_Usuarios
            // 
            this.GB_Usuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Usuarios.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Usuarios.Location = new System.Drawing.Point(16, 16);
            this.GB_Usuarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Usuarios.Name = "GB_Usuarios";
            this.GB_Usuarios.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Usuarios.Size = new System.Drawing.Size(1062, 340);
            this.GB_Usuarios.TabIndex = 23;
            this.GB_Usuarios.TabStop = false;
            this.GB_Usuarios.Text = "Usuarios";
            // 
            // GB_Datos
            // 
            this.GB_Datos.Controls.Add(this.Cb_CTRLUsuarioRol);
            this.GB_Datos.Controls.Add(this.TXT_CtrlUsuUsuario);
            this.GB_Datos.Controls.Add(this.TXT_CtrlUsuContraseña);
            this.GB_Datos.Controls.Add(this.TXT_CtrlUsuDNI);
            this.GB_Datos.Controls.Add(this.LBLrol);
            this.GB_Datos.Controls.Add(this.TXT_CtrlUsuEmail);
            this.GB_Datos.Controls.Add(this.LBLusuario);
            this.GB_Datos.Controls.Add(this.LBLcontraseña);
            this.GB_Datos.Controls.Add(this.LBLdni);
            this.GB_Datos.Controls.Add(this.LBLemail);
            this.GB_Datos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Datos.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Datos.Location = new System.Drawing.Point(16, 363);
            this.GB_Datos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Datos.Name = "GB_Datos";
            this.GB_Datos.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Datos.Size = new System.Drawing.Size(343, 334);
            this.GB_Datos.TabIndex = 24;
            this.GB_Datos.TabStop = false;
            this.GB_Datos.Text = "Datos de usuario";
            // 
            // CKXmostrarInactivos
            // 
            this.CKXmostrarInactivos.AutoSize = true;
            this.CKXmostrarInactivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarInactivos.ForeColor = System.Drawing.SystemColors.Window;
            this.CKXmostrarInactivos.Location = new System.Drawing.Point(375, 374);
            this.CKXmostrarInactivos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CKXmostrarInactivos.Name = "CKXmostrarInactivos";
            this.CKXmostrarInactivos.Size = new System.Drawing.Size(136, 21);
            this.CKXmostrarInactivos.TabIndex = 25;
            this.CKXmostrarInactivos.Text = "Mostrar Inactivos";
            this.CKXmostrarInactivos.UseVisualStyleBackColor = true;
            this.CKXmostrarInactivos.CheckedChanged += new System.EventHandler(this.CKXmostrarInactivos_CheckedChanged);
            // 
            // BTNCtrlUsuReactivar
            // 
            this.BTNCtrlUsuReactivar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlUsuReactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlUsuReactivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlUsuReactivar.Location = new System.Drawing.Point(906, 416);
            this.BTNCtrlUsuReactivar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlUsuReactivar.Name = "BTNCtrlUsuReactivar";
            this.BTNCtrlUsuReactivar.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlUsuReactivar.TabIndex = 26;
            this.BTNCtrlUsuReactivar.Text = "Reactivar";
            this.BTNCtrlUsuReactivar.UseVisualStyleBackColor = false;
            this.BTNCtrlUsuReactivar.Click += new System.EventHandler(this.BTNCtrlUsuReactivar_Click);
            // 
            // FrmCTRLUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1295, 708);
            this.Controls.Add(this.DGV_CtrlUsuUsuarios);
            this.Controls.Add(this.BTNCtrlUsuReactivar);
            this.Controls.Add(this.CKXmostrarInactivos);
            this.Controls.Add(this.GB_Usuarios);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.CKXmostrarbloqueados);
            this.Controls.Add(this.BTNCtrlUsuDesbloquear);
            this.Controls.Add(this.BTNCtrlUsuVolverMenu);
            this.Controls.Add(this.BTNCtrlUsuModificar);
            this.Controls.Add(this.BTNCtrlUsuBaja);
            this.Controls.Add(this.BTNCtrlUsuAlta);
            this.Controls.Add(this.GB_Datos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCTRLUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCTRLUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FrmCTRLUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CtrlUsuUsuarios)).EndInit();
            this.GB_Datos.ResumeLayout(false);
            this.GB_Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_CtrlUsuUsuario;
        private System.Windows.Forms.TextBox TXT_CtrlUsuContraseña;
        private System.Windows.Forms.TextBox TXT_CtrlUsuDNI;
        private System.Windows.Forms.TextBox TXT_CtrlUsuEmail;
        private System.Windows.Forms.Label LBLusuario;
        private System.Windows.Forms.Label LBLcontraseña;
        private System.Windows.Forms.Label LBLdni;
        private System.Windows.Forms.Label LBLemail;
        private System.Windows.Forms.Button BTNCtrlUsuAlta;
        private System.Windows.Forms.Button BTNCtrlUsuBaja;
        private System.Windows.Forms.Button BTNCtrlUsuModificar;
        private System.Windows.Forms.Button BTNCtrlUsuVolverMenu;
        private System.Windows.Forms.DataGridView DGV_CtrlUsuUsuarios;
        private System.Windows.Forms.Button BTNCtrlUsuDesbloquear;
        private System.Windows.Forms.CheckBox CKXmostrarbloqueados;
        private System.Windows.Forms.Label LBLrol;
        private System.Windows.Forms.ComboBox Cb_CTRLUsuarioRol;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.GroupBox GB_Usuarios;
        private System.Windows.Forms.GroupBox GB_Datos;
        private System.Windows.Forms.CheckBox CKXmostrarInactivos;
        private System.Windows.Forms.Button BTNCtrlUsuReactivar;
    }
}