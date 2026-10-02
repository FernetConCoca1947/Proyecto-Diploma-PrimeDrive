namespace Trabajo_practico_IS
{
    partial class FrmCategoria
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
            this.GB_DatosCategoria = new System.Windows.Forms.GroupBox();
            this.TXT_CtrlCatNombre = new System.Windows.Forms.TextBox();
            this.TXT_CtrlCatTarifa = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLtarifaDiaria = new System.Windows.Forms.Label();
            this.CKXmostrarInactivos = new System.Windows.Forms.CheckBox();
            this.BTNCategoriaReactivar = new System.Windows.Forms.Button();
            this.BTNCategoriaModificar = new System.Windows.Forms.Button();
            this.BTNCategoriaBaja = new System.Windows.Forms.Button();
            this.BTNCategoriaAlta = new System.Windows.Forms.Button();
            this.GB_Categorias = new System.Windows.Forms.GroupBox();
            this.DGV_Categorias = new System.Windows.Forms.DataGridView();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.GB_DatosCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_DatosCategoria
            // 
            this.GB_DatosCategoria.Controls.Add(this.TXT_CtrlCatNombre);
            this.GB_DatosCategoria.Controls.Add(this.TXT_CtrlCatTarifa);
            this.GB_DatosCategoria.Controls.Add(this.LBLnombre);
            this.GB_DatosCategoria.Controls.Add(this.LBLtarifaDiaria);
            this.GB_DatosCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_DatosCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_DatosCategoria.Location = new System.Drawing.Point(17, 15);
            this.GB_DatosCategoria.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_DatosCategoria.Name = "GB_DatosCategoria";
            this.GB_DatosCategoria.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_DatosCategoria.Size = new System.Drawing.Size(271, 157);
            this.GB_DatosCategoria.TabIndex = 26;
            this.GB_DatosCategoria.TabStop = false;
            this.GB_DatosCategoria.Text = "Datos de la categoria";
            // 
            // TXT_CtrlCatNombre
            // 
            this.TXT_CtrlCatNombre.Location = new System.Drawing.Point(14, 51);
            this.TXT_CtrlCatNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlCatNombre.Name = "TXT_CtrlCatNombre";
            this.TXT_CtrlCatNombre.Size = new System.Drawing.Size(240, 23);
            this.TXT_CtrlCatNombre.TabIndex = 0;
            // 
            // TXT_CtrlCatTarifa
            // 
            this.TXT_CtrlCatTarifa.Location = new System.Drawing.Point(14, 109);
            this.TXT_CtrlCatTarifa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlCatTarifa.Name = "TXT_CtrlCatTarifa";
            this.TXT_CtrlCatTarifa.Size = new System.Drawing.Size(240, 23);
            this.TXT_CtrlCatTarifa.TabIndex = 1;
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(9, 30);
            this.LBLnombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(61, 17);
            this.LBLnombre.TabIndex = 5;
            this.LBLnombre.Text = "Nombre";
            // 
            // LBLtarifaDiaria
            // 
            this.LBLtarifaDiaria.AutoSize = true;
            this.LBLtarifaDiaria.Location = new System.Drawing.Point(9, 89);
            this.LBLtarifaDiaria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLtarifaDiaria.Name = "LBLtarifaDiaria";
            this.LBLtarifaDiaria.Size = new System.Drawing.Size(83, 17);
            this.LBLtarifaDiaria.TabIndex = 6;
            this.LBLtarifaDiaria.Text = "Tarfia diaria";
            // 
            // CKXmostrarInactivos
            // 
            this.CKXmostrarInactivos.AutoSize = true;
            this.CKXmostrarInactivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarInactivos.ForeColor = System.Drawing.SystemColors.Window;
            this.CKXmostrarInactivos.Location = new System.Drawing.Point(17, 190);
            this.CKXmostrarInactivos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CKXmostrarInactivos.Name = "CKXmostrarInactivos";
            this.CKXmostrarInactivos.Size = new System.Drawing.Size(136, 21);
            this.CKXmostrarInactivos.TabIndex = 36;
            this.CKXmostrarInactivos.Text = "Mostrar Inactivas";
            this.CKXmostrarInactivos.UseVisualStyleBackColor = true;
            this.CKXmostrarInactivos.CheckedChanged += new System.EventHandler(this.CKXmostrarInactivos_CheckedChanged);
            // 
            // BTNCategoriaReactivar
            // 
            this.BTNCategoriaReactivar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCategoriaReactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaReactivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaReactivar.Location = new System.Drawing.Point(158, 267);
            this.BTNCategoriaReactivar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCategoriaReactivar.Name = "BTNCategoriaReactivar";
            this.BTNCategoriaReactivar.Size = new System.Drawing.Size(128, 35);
            this.BTNCategoriaReactivar.TabIndex = 35;
            this.BTNCategoriaReactivar.Text = "Reactivar";
            this.BTNCategoriaReactivar.UseVisualStyleBackColor = false;
            this.BTNCategoriaReactivar.Click += new System.EventHandler(this.BTNCategoriaReactivar_Click);
            // 
            // BTNCategoriaModificar
            // 
            this.BTNCategoriaModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCategoriaModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaModificar.Location = new System.Drawing.Point(14, 267);
            this.BTNCategoriaModificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCategoriaModificar.Name = "BTNCategoriaModificar";
            this.BTNCategoriaModificar.Size = new System.Drawing.Size(128, 35);
            this.BTNCategoriaModificar.TabIndex = 34;
            this.BTNCategoriaModificar.Text = "Modificar";
            this.BTNCategoriaModificar.UseVisualStyleBackColor = false;
            this.BTNCategoriaModificar.Click += new System.EventHandler(this.BTNCategoriaModificar_Click);
            // 
            // BTNCategoriaBaja
            // 
            this.BTNCategoriaBaja.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCategoriaBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaBaja.Location = new System.Drawing.Point(158, 224);
            this.BTNCategoriaBaja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCategoriaBaja.Name = "BTNCategoriaBaja";
            this.BTNCategoriaBaja.Size = new System.Drawing.Size(128, 35);
            this.BTNCategoriaBaja.TabIndex = 33;
            this.BTNCategoriaBaja.Text = "Baja";
            this.BTNCategoriaBaja.UseVisualStyleBackColor = false;
            this.BTNCategoriaBaja.Click += new System.EventHandler(this.BTNCategoriaBaja_Click);
            // 
            // BTNCategoriaAlta
            // 
            this.BTNCategoriaAlta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCategoriaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaAlta.Location = new System.Drawing.Point(15, 224);
            this.BTNCategoriaAlta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCategoriaAlta.Name = "BTNCategoriaAlta";
            this.BTNCategoriaAlta.Size = new System.Drawing.Size(128, 35);
            this.BTNCategoriaAlta.TabIndex = 32;
            this.BTNCategoriaAlta.Text = "Alta";
            this.BTNCategoriaAlta.UseVisualStyleBackColor = false;
            this.BTNCategoriaAlta.Click += new System.EventHandler(this.BTNCategoriaAlta_Click);
            // 
            // GB_Categorias
            // 
            this.GB_Categorias.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Categorias.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Categorias.Location = new System.Drawing.Point(310, 15);
            this.GB_Categorias.Name = "GB_Categorias";
            this.GB_Categorias.Size = new System.Drawing.Size(445, 340);
            this.GB_Categorias.TabIndex = 31;
            this.GB_Categorias.TabStop = false;
            this.GB_Categorias.Text = "Categorias";
            // 
            // DGV_Categorias
            // 
            this.DGV_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Categorias.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Categorias.Location = new System.Drawing.Point(323, 42);
            this.DGV_Categorias.Name = "DGV_Categorias";
            this.DGV_Categorias.Size = new System.Drawing.Size(417, 291);
            this.DGV_Categorias.TabIndex = 0;
            this.DGV_Categorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Categorias_CellClick);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(773, 15);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 38;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(776, 35);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(128, 25);
            this.CBXidiomas.TabIndex = 37;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(776, 360);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(128, 35);
            this.BTNvolveralmenu.TabIndex = 39;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(912, 404);
            this.Controls.Add(this.DGV_Categorias);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.CKXmostrarInactivos);
            this.Controls.Add(this.BTNCategoriaReactivar);
            this.Controls.Add(this.BTNCategoriaModificar);
            this.Controls.Add(this.BTNCategoriaBaja);
            this.Controls.Add(this.BTNCategoriaAlta);
            this.Controls.Add(this.GB_Categorias);
            this.Controls.Add(this.GB_DatosCategoria);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCategoria_FormClosing);
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.GB_DatosCategoria.ResumeLayout(false);
            this.GB_DatosCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_DatosCategoria;
        private System.Windows.Forms.TextBox TXT_CtrlCatNombre;
        private System.Windows.Forms.TextBox TXT_CtrlCatTarifa;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLtarifaDiaria;
        private System.Windows.Forms.CheckBox CKXmostrarInactivos;
        private System.Windows.Forms.Button BTNCategoriaReactivar;
        private System.Windows.Forms.Button BTNCategoriaModificar;
        private System.Windows.Forms.Button BTNCategoriaBaja;
        private System.Windows.Forms.Button BTNCategoriaAlta;
        private System.Windows.Forms.GroupBox GB_Categorias;
        private System.Windows.Forms.DataGridView DGV_Categorias;
        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.Button BTNvolveralmenu;
    }
}