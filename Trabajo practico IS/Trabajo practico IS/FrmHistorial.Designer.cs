namespace Trabajo_practico_IS
{
    partial class FrmHistorial
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
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXIdiomas = new System.Windows.Forms.ComboBox();
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.BTNrestaurar = new System.Windows.Forms.Button();
            this.CBX_Filtro = new System.Windows.Forms.ComboBox();
            this.CBX_Entidad = new System.Windows.Forms.ComboBox();
            this.BTN_LimpiarFiltrosHist = new System.Windows.Forms.Button();
            this.GB_FiltrarHistorial = new System.Windows.Forms.GroupBox();
            this.DGVHistorial = new System.Windows.Forms.DataGridView();
            this.GB_Historial = new System.Windows.Forms.GroupBox();
            this.GB_FiltrarHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).BeginInit();
            this.GB_Historial.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(1237, 12);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(59, 17);
            this.LBLidiomas.TabIndex = 15;
            this.LBLidiomas.Text = "Idiomas";
            // 
            // CBXIdiomas
            // 
            this.CBXIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXIdiomas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXIdiomas.FormattingEnabled = true;
            this.CBXIdiomas.Location = new System.Drawing.Point(1237, 33);
            this.CBXIdiomas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBXIdiomas.Name = "CBXIdiomas";
            this.CBXIdiomas.Size = new System.Drawing.Size(159, 25);
            this.CBXIdiomas.TabIndex = 14;
            this.CBXIdiomas.SelectedIndexChanged += new System.EventHandler(this.CBXIdiomas_SelectedIndexChanged);
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(1233, 544);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(166, 35);
            this.BTNvolveralmenu.TabIndex = 13;
            this.BTNvolveralmenu.Text = "Volver al menu ";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // BTNrestaurar
            // 
            this.BTNrestaurar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNrestaurar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNrestaurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNrestaurar.Location = new System.Drawing.Point(442, 529);
            this.BTNrestaurar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNrestaurar.Name = "BTNrestaurar";
            this.BTNrestaurar.Size = new System.Drawing.Size(166, 35);
            this.BTNrestaurar.TabIndex = 12;
            this.BTNrestaurar.Text = "Restaurar";
            this.BTNrestaurar.UseVisualStyleBackColor = false;
            this.BTNrestaurar.Click += new System.EventHandler(this.BTNrestaurar_Click);
            // 
            // CBX_Filtro
            // 
            this.CBX_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Filtro.FormattingEnabled = true;
            this.CBX_Filtro.Location = new System.Drawing.Point(8, 33);
            this.CBX_Filtro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBX_Filtro.Name = "CBX_Filtro";
            this.CBX_Filtro.Size = new System.Drawing.Size(213, 25);
            this.CBX_Filtro.TabIndex = 16;
            this.CBX_Filtro.SelectedIndexChanged += new System.EventHandler(this.CBX_Filtro_SelectedIndexChanged);
            // 
            // CBX_Entidad
            // 
            this.CBX_Entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Entidad.FormattingEnabled = true;
            this.CBX_Entidad.Location = new System.Drawing.Point(16, 26);
            this.CBX_Entidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBX_Entidad.Name = "CBX_Entidad";
            this.CBX_Entidad.Size = new System.Drawing.Size(159, 25);
            this.CBX_Entidad.TabIndex = 17;
            this.CBX_Entidad.SelectedIndexChanged += new System.EventHandler(this.CBX_Entidad_SelectedIndexChanged);
            // 
            // BTN_LimpiarFiltrosHist
            // 
            this.BTN_LimpiarFiltrosHist.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_LimpiarFiltrosHist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LimpiarFiltrosHist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_LimpiarFiltrosHist.Location = new System.Drawing.Point(231, 28);
            this.BTN_LimpiarFiltrosHist.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTN_LimpiarFiltrosHist.Name = "BTN_LimpiarFiltrosHist";
            this.BTN_LimpiarFiltrosHist.Size = new System.Drawing.Size(166, 35);
            this.BTN_LimpiarFiltrosHist.TabIndex = 18;
            this.BTN_LimpiarFiltrosHist.Text = "Ver Todo";
            this.BTN_LimpiarFiltrosHist.UseVisualStyleBackColor = false;
            this.BTN_LimpiarFiltrosHist.Click += new System.EventHandler(this.BTN_LimpiarFiltrosHist_Click);
            // 
            // GB_FiltrarHistorial
            // 
            this.GB_FiltrarHistorial.Controls.Add(this.BTN_LimpiarFiltrosHist);
            this.GB_FiltrarHistorial.Controls.Add(this.CBX_Filtro);
            this.GB_FiltrarHistorial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FiltrarHistorial.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_FiltrarHistorial.Location = new System.Drawing.Point(21, 503);
            this.GB_FiltrarHistorial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_FiltrarHistorial.Name = "GB_FiltrarHistorial";
            this.GB_FiltrarHistorial.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_FiltrarHistorial.Size = new System.Drawing.Size(413, 78);
            this.GB_FiltrarHistorial.TabIndex = 20;
            this.GB_FiltrarHistorial.TabStop = false;
            this.GB_FiltrarHistorial.Text = "Filtrar";
            // 
            // DGVHistorial
            // 
            this.DGVHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVHistorial.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHistorial.Location = new System.Drawing.Point(31, 80);
            this.DGVHistorial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DGVHistorial.MultiSelect = false;
            this.DGVHistorial.Name = "DGVHistorial";
            this.DGVHistorial.ReadOnly = true;
            this.DGVHistorial.Size = new System.Drawing.Size(1163, 392);
            this.DGVHistorial.TabIndex = 8;
            this.DGVHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVHistorial_CellContentClick);
            this.DGVHistorial.SelectionChanged += new System.EventHandler(this.DGVHistorial_SelectionChanged);
            // 
            // GB_Historial
            // 
            this.GB_Historial.Controls.Add(this.CBX_Entidad);
            this.GB_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GB_Historial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Historial.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Historial.Location = new System.Drawing.Point(21, 16);
            this.GB_Historial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Historial.Name = "GB_Historial";
            this.GB_Historial.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Historial.Size = new System.Drawing.Size(1189, 478);
            this.GB_Historial.TabIndex = 19;
            this.GB_Historial.TabStop = false;
            this.GB_Historial.Text = "Historial de cambios";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1407, 593);
            this.Controls.Add(this.DGVHistorial);
            this.Controls.Add(this.GB_FiltrarHistorial);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXIdiomas);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.BTNrestaurar);
            this.Controls.Add(this.GB_Historial);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.GB_FiltrarHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVHistorial)).EndInit();
            this.GB_Historial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXIdiomas;
        private System.Windows.Forms.Button BTNvolveralmenu;
        private System.Windows.Forms.Button BTNrestaurar;
        private System.Windows.Forms.ComboBox CBX_Filtro;
        private System.Windows.Forms.ComboBox CBX_Entidad;
        private System.Windows.Forms.Button BTN_LimpiarFiltrosHist;
        private System.Windows.Forms.GroupBox GB_FiltrarHistorial;
        private System.Windows.Forms.DataGridView DGVHistorial;
        private System.Windows.Forms.GroupBox GB_Historial;
    }
}