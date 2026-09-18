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
            this.GB_DatosCategoria.SuspendLayout();
            this.GB_Categorias.SuspendLayout();
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
            this.GB_DatosCategoria.Location = new System.Drawing.Point(13, 33);
            this.GB_DatosCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.GB_DatosCategoria.Name = "GB_DatosCategoria";
            this.GB_DatosCategoria.Padding = new System.Windows.Forms.Padding(4);
            this.GB_DatosCategoria.Size = new System.Drawing.Size(300, 148);
            this.GB_DatosCategoria.TabIndex = 26;
            this.GB_DatosCategoria.TabStop = false;
            this.GB_DatosCategoria.Text = "Datos de la categoria";
            // 
            // TXT_CtrlCatNombre
            // 
            this.TXT_CtrlCatNombre.Location = new System.Drawing.Point(12, 48);
            this.TXT_CtrlCatNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCatNombre.Name = "TXT_CtrlCatNombre";
            this.TXT_CtrlCatNombre.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCatNombre.TabIndex = 0;
            // 
            // TXT_CtrlCatTarifa
            // 
            this.TXT_CtrlCatTarifa.Location = new System.Drawing.Point(12, 103);
            this.TXT_CtrlCatTarifa.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlCatTarifa.Name = "TXT_CtrlCatTarifa";
            this.TXT_CtrlCatTarifa.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlCatTarifa.TabIndex = 1;
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
            // LBLtarifaDiaria
            // 
            this.LBLtarifaDiaria.AutoSize = true;
            this.LBLtarifaDiaria.Location = new System.Drawing.Point(8, 84);
            this.LBLtarifaDiaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLtarifaDiaria.Name = "LBLtarifaDiaria";
            this.LBLtarifaDiaria.Size = new System.Drawing.Size(83, 17);
            this.LBLtarifaDiaria.TabIndex = 6;
            this.LBLtarifaDiaria.Text = "Tarfia diaria";
            // 
            // CKXmostrarInactivos
            // 
            this.CKXmostrarInactivos.AutoSize = true;
            this.CKXmostrarInactivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarInactivos.Location = new System.Drawing.Point(15, 201);
            this.CKXmostrarInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.CKXmostrarInactivos.Name = "CKXmostrarInactivos";
            this.CKXmostrarInactivos.Size = new System.Drawing.Size(136, 21);
            this.CKXmostrarInactivos.TabIndex = 36;
            this.CKXmostrarInactivos.Text = "Mostrar Inactivas";
            this.CKXmostrarInactivos.UseVisualStyleBackColor = true;
            this.CKXmostrarInactivos.CheckedChanged += new System.EventHandler(this.CKXmostrarInactivos_CheckedChanged);
            // 
            // BTNCategoriaReactivar
            // 
            this.BTNCategoriaReactivar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCategoriaReactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaReactivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaReactivar.Location = new System.Drawing.Point(168, 274);
            this.BTNCategoriaReactivar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCategoriaReactivar.Name = "BTNCategoriaReactivar";
            this.BTNCategoriaReactivar.Size = new System.Drawing.Size(145, 33);
            this.BTNCategoriaReactivar.TabIndex = 35;
            this.BTNCategoriaReactivar.Text = "Reactivar";
            this.BTNCategoriaReactivar.UseVisualStyleBackColor = false;
            this.BTNCategoriaReactivar.Click += new System.EventHandler(this.BTNCategoriaReactivar_Click);
            // 
            // BTNCategoriaModificar
            // 
            this.BTNCategoriaModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCategoriaModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaModificar.Location = new System.Drawing.Point(15, 274);
            this.BTNCategoriaModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCategoriaModificar.Name = "BTNCategoriaModificar";
            this.BTNCategoriaModificar.Size = new System.Drawing.Size(145, 33);
            this.BTNCategoriaModificar.TabIndex = 34;
            this.BTNCategoriaModificar.Text = "Modificar";
            this.BTNCategoriaModificar.UseVisualStyleBackColor = false;
            this.BTNCategoriaModificar.Click += new System.EventHandler(this.BTNCategoriaModificar_Click);
            // 
            // BTNCategoriaBaja
            // 
            this.BTNCategoriaBaja.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCategoriaBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaBaja.Location = new System.Drawing.Point(168, 233);
            this.BTNCategoriaBaja.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCategoriaBaja.Name = "BTNCategoriaBaja";
            this.BTNCategoriaBaja.Size = new System.Drawing.Size(145, 33);
            this.BTNCategoriaBaja.TabIndex = 33;
            this.BTNCategoriaBaja.Text = "Baja";
            this.BTNCategoriaBaja.UseVisualStyleBackColor = false;
            this.BTNCategoriaBaja.Click += new System.EventHandler(this.BTNCategoriaBaja_Click);
            // 
            // BTNCategoriaAlta
            // 
            this.BTNCategoriaAlta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCategoriaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCategoriaAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCategoriaAlta.Location = new System.Drawing.Point(15, 233);
            this.BTNCategoriaAlta.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCategoriaAlta.Name = "BTNCategoriaAlta";
            this.BTNCategoriaAlta.Size = new System.Drawing.Size(145, 33);
            this.BTNCategoriaAlta.TabIndex = 32;
            this.BTNCategoriaAlta.Text = "Alta";
            this.BTNCategoriaAlta.UseVisualStyleBackColor = false;
            this.BTNCategoriaAlta.Click += new System.EventHandler(this.BTNCategoriaAlta_Click);
            // 
            // GB_Categorias
            // 
            this.GB_Categorias.Controls.Add(this.DGV_Categorias);
            this.GB_Categorias.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Categorias.Location = new System.Drawing.Point(343, 81);
            this.GB_Categorias.Name = "GB_Categorias";
            this.GB_Categorias.Size = new System.Drawing.Size(389, 320);
            this.GB_Categorias.TabIndex = 31;
            this.GB_Categorias.TabStop = false;
            this.GB_Categorias.Text = "Categorias";
            // 
            // DGV_Categorias
            // 
            this.DGV_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Categorias.Location = new System.Drawing.Point(12, 30);
            this.DGV_Categorias.Name = "DGV_Categorias";
            this.DGV_Categorias.Size = new System.Drawing.Size(365, 274);
            this.DGV_Categorias.TabIndex = 0;
            this.DGV_Categorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Categorias_CellClick);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.Location = new System.Drawing.Point(676, 14);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 38;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(676, 33);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 37;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 439);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.CKXmostrarInactivos);
            this.Controls.Add(this.BTNCategoriaReactivar);
            this.Controls.Add(this.BTNCategoriaModificar);
            this.Controls.Add(this.BTNCategoriaBaja);
            this.Controls.Add(this.BTNCategoriaAlta);
            this.Controls.Add(this.GB_Categorias);
            this.Controls.Add(this.GB_DatosCategoria);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.GB_DatosCategoria.ResumeLayout(false);
            this.GB_DatosCategoria.PerformLayout();
            this.GB_Categorias.ResumeLayout(false);
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
    }
}