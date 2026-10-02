namespace Trabajo_practico_IS
{
    partial class FrmIdioma
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
            System.Windows.Forms.GroupBox GB_Traducciones;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNcrear = new System.Windows.Forms.Button();
            this.BTNdeshabilitar = new System.Windows.Forms.Button();
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.LBLsufijo = new System.Windows.Forms.Label();
            this.TXTsufijo = new System.Windows.Forms.TextBox();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.LBLidiomas2 = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.BTNhabilitar = new System.Windows.Forms.Button();
            this.DGVtraducciones = new System.Windows.Forms.DataGridView();
            this.GB_NuevoIdioma = new System.Windows.Forms.GroupBox();
            this.GB_Idiomas = new System.Windows.Forms.GroupBox();
            GB_Traducciones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtraducciones)).BeginInit();
            this.GB_NuevoIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTNcrear
            // 
            this.BTNcrear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNcrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNcrear.Location = new System.Drawing.Point(11, 143);
            this.BTNcrear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNcrear.Name = "BTNcrear";
            this.BTNcrear.Size = new System.Drawing.Size(166, 35);
            this.BTNcrear.TabIndex = 2;
            this.BTNcrear.Text = "Crear";
            this.BTNcrear.UseVisualStyleBackColor = false;
            this.BTNcrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNdeshabilitar
            // 
            this.BTNdeshabilitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNdeshabilitar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdeshabilitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNdeshabilitar.Location = new System.Drawing.Point(27, 470);
            this.BTNdeshabilitar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNdeshabilitar.Name = "BTNdeshabilitar";
            this.BTNdeshabilitar.Size = new System.Drawing.Size(166, 35);
            this.BTNdeshabilitar.TabIndex = 4;
            this.BTNdeshabilitar.Text = "Deshabilitar";
            this.BTNdeshabilitar.UseVisualStyleBackColor = false;
            this.BTNdeshabilitar.Click += new System.EventHandler(this.BTNdeshabilitar_Click);
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(1019, 566);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(166, 35);
            this.BTNvolveralmenu.TabIndex = 5;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(11, 46);
            this.TXTnombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(164, 23);
            this.TXTnombre.TabIndex = 6;
            // 
            // LBLsufijo
            // 
            this.LBLsufijo.AutoSize = true;
            this.LBLsufijo.Location = new System.Drawing.Point(11, 83);
            this.LBLsufijo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLsufijo.Name = "LBLsufijo";
            this.LBLsufijo.Size = new System.Drawing.Size(41, 17);
            this.LBLsufijo.TabIndex = 9;
            this.LBLsufijo.Text = "Sufijo";
            // 
            // TXTsufijo
            // 
            this.TXTsufijo.Location = new System.Drawing.Point(11, 103);
            this.TXTsufijo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXTsufijo.Name = "TXTsufijo";
            this.TXTsufijo.Size = new System.Drawing.Size(164, 23);
            this.TXTsufijo.TabIndex = 10;
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Location = new System.Drawing.Point(11, 24);
            this.LBLnombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(61, 17);
            this.LBLnombre.TabIndex = 11;
            this.LBLnombre.Text = "Nombre";
            // 
            // LBLidiomas2
            // 
            this.LBLidiomas2.AutoSize = true;
            this.LBLidiomas2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas2.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas2.Location = new System.Drawing.Point(1019, 12);
            this.LBLidiomas2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas2.Name = "LBLidiomas2";
            this.LBLidiomas2.Size = new System.Drawing.Size(59, 17);
            this.LBLidiomas2.TabIndex = 12;
            this.LBLidiomas2.Text = "Idiomas";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(1019, 33);
            this.CBXidiomas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(159, 25);
            this.CBXidiomas.TabIndex = 13;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // BTNhabilitar
            // 
            this.BTNhabilitar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNhabilitar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNhabilitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNhabilitar.Location = new System.Drawing.Point(27, 512);
            this.BTNhabilitar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNhabilitar.Name = "BTNhabilitar";
            this.BTNhabilitar.Size = new System.Drawing.Size(166, 35);
            this.BTNhabilitar.TabIndex = 14;
            this.BTNhabilitar.Text = "Habilitar";
            this.BTNhabilitar.UseVisualStyleBackColor = false;
            this.BTNhabilitar.Click += new System.EventHandler(this.BTNhabilitar_Click);
            // 
            // DGVtraducciones
            // 
            this.DGVtraducciones.AllowUserToAddRows = false;
            this.DGVtraducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVtraducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVtraducciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVtraducciones.Location = new System.Drawing.Point(481, 44);
            this.DGVtraducciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DGVtraducciones.Name = "DGVtraducciones";
            this.DGVtraducciones.ReadOnly = true;
            this.DGVtraducciones.Size = new System.Drawing.Size(486, 540);
            this.DGVtraducciones.TabIndex = 15;
            // 
            // GB_NuevoIdioma
            // 
            this.GB_NuevoIdioma.Controls.Add(this.BTNcrear);
            this.GB_NuevoIdioma.Controls.Add(this.TXTnombre);
            this.GB_NuevoIdioma.Controls.Add(this.LBLsufijo);
            this.GB_NuevoIdioma.Controls.Add(this.TXTsufijo);
            this.GB_NuevoIdioma.Controls.Add(this.LBLnombre);
            this.GB_NuevoIdioma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_NuevoIdioma.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_NuevoIdioma.Location = new System.Drawing.Point(16, 272);
            this.GB_NuevoIdioma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_NuevoIdioma.Name = "GB_NuevoIdioma";
            this.GB_NuevoIdioma.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_NuevoIdioma.Size = new System.Drawing.Size(194, 189);
            this.GB_NuevoIdioma.TabIndex = 16;
            this.GB_NuevoIdioma.TabStop = false;
            this.GB_NuevoIdioma.Text = "Nuevo idioma";
            // 
            // GB_Idiomas
            // 
            this.GB_Idiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Idiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Idiomas.Location = new System.Drawing.Point(15, 21);
            this.GB_Idiomas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Idiomas.Name = "GB_Idiomas";
            this.GB_Idiomas.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_Idiomas.Size = new System.Drawing.Size(427, 237);
            this.GB_Idiomas.TabIndex = 17;
            this.GB_Idiomas.TabStop = false;
            this.GB_Idiomas.Text = "Idiomas";
            // 
            // GB_Traducciones
            // 
            GB_Traducciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GB_Traducciones.ForeColor = System.Drawing.SystemColors.Window;
            GB_Traducciones.Location = new System.Drawing.Point(466, 16);
            GB_Traducciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            GB_Traducciones.Name = "GB_Traducciones";
            GB_Traducciones.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            GB_Traducciones.Size = new System.Drawing.Size(516, 585);
            GB_Traducciones.TabIndex = 18;
            GB_Traducciones.TabStop = false;
            GB_Traducciones.Text = "Traducciones";
            // 
            // FrmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1199, 610);
            this.Controls.Add(this.DGVtraducciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GB_Idiomas);
            this.Controls.Add(this.BTNhabilitar);
            this.Controls.Add(this.CBXidiomas);
            this.Controls.Add(this.LBLidiomas2);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.BTNdeshabilitar);
            this.Controls.Add(this.GB_NuevoIdioma);
            this.Controls.Add(GB_Traducciones);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIdioma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIdioma_FormClosing);
            this.Load += new System.EventHandler(this.FrmIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtraducciones)).EndInit();
            this.GB_NuevoIdioma.ResumeLayout(false);
            this.GB_NuevoIdioma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.Button BTNdeshabilitar;
        private System.Windows.Forms.Button BTNvolveralmenu;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.Label LBLsufijo;
        private System.Windows.Forms.TextBox TXTsufijo;
        private System.Windows.Forms.Label LBLnombre;
        private System.Windows.Forms.Label LBLidiomas2;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.Button BTNhabilitar;
        private System.Windows.Forms.DataGridView DGVtraducciones;
        private System.Windows.Forms.GroupBox GB_NuevoIdioma;
        private System.Windows.Forms.GroupBox GB_Idiomas;
    }
}