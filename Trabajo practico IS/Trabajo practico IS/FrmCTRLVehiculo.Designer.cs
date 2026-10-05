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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CBX_Estado = new System.Windows.Forms.ComboBox();
            this.CBX_Sucursal = new System.Windows.Forms.ComboBox();
            this.CBX_Categoria = new System.Windows.Forms.ComboBox();
            this.NUM_KmActual = new System.Windows.Forms.NumericUpDown();
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
            this.TXT_FiltroPatente = new System.Windows.Forms.TextBox();
            this.CBX_FiltroEstadoVeh = new System.Windows.Forms.ComboBox();
            this.CBX_FiltroCategoriaVeh = new System.Windows.Forms.ComboBox();
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.LBLBuscarPatente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_FiltrosVehiculos = new System.Windows.Forms.GroupBox();
            this.TXT_CtrlVehObservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vehiculos)).BeginInit();
            this.GB_DatosVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmActual)).BeginInit();
            this.GB_FiltrosVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(1269, 10);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 40;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(1272, 30);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(154, 25);
            this.CBXidiomas.TabIndex = 39;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // CKXmostrarInactivos
            // 
            this.CKXmostrarInactivos.AutoSize = true;
            this.CKXmostrarInactivos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CKXmostrarInactivos.Location = new System.Drawing.Point(723, 646);
            this.CKXmostrarInactivos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CKXmostrarInactivos.Name = "CKXmostrarInactivos";
            this.CKXmostrarInactivos.Size = new System.Drawing.Size(136, 21);
            this.CKXmostrarInactivos.TabIndex = 46;
            this.CKXmostrarInactivos.Text = "Mostrar Inactivas";
            this.CKXmostrarInactivos.UseVisualStyleBackColor = true;
            this.CKXmostrarInactivos.Visible = false;
            // 
            // BTNCtrlVehReactivar
            // 
            this.BTNCtrlVehReactivar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlVehReactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehReactivar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehReactivar.Location = new System.Drawing.Point(537, 633);
            this.BTNCtrlVehReactivar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlVehReactivar.Name = "BTNCtrlVehReactivar";
            this.BTNCtrlVehReactivar.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlVehReactivar.TabIndex = 45;
            this.BTNCtrlVehReactivar.Text = "Reactivar";
            this.BTNCtrlVehReactivar.UseVisualStyleBackColor = false;
            this.BTNCtrlVehReactivar.Click += new System.EventHandler(this.BTNCtrlVehReactivar_Click);
            // 
            // BTNCtrlVehModificar
            // 
            this.BTNCtrlVehModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlVehModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehModificar.Location = new System.Drawing.Point(362, 633);
            this.BTNCtrlVehModificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlVehModificar.Name = "BTNCtrlVehModificar";
            this.BTNCtrlVehModificar.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlVehModificar.TabIndex = 44;
            this.BTNCtrlVehModificar.Text = "Modificar";
            this.BTNCtrlVehModificar.UseVisualStyleBackColor = false;
            this.BTNCtrlVehModificar.Click += new System.EventHandler(this.BTNCtrlVehModificar_Click);
            // 
            // BTNCtrlVehBaja
            // 
            this.BTNCtrlVehBaja.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlVehBaja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehBaja.Location = new System.Drawing.Point(187, 633);
            this.BTNCtrlVehBaja.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlVehBaja.Name = "BTNCtrlVehBaja";
            this.BTNCtrlVehBaja.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlVehBaja.TabIndex = 43;
            this.BTNCtrlVehBaja.Text = "Baja";
            this.BTNCtrlVehBaja.UseVisualStyleBackColor = false;
            this.BTNCtrlVehBaja.Click += new System.EventHandler(this.BTNCtrlVehBaja_Click);
            // 
            // BTNCtrlVehAlta
            // 
            this.BTNCtrlVehAlta.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCtrlVehAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCtrlVehAlta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCtrlVehAlta.Location = new System.Drawing.Point(11, 633);
            this.BTNCtrlVehAlta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCtrlVehAlta.Name = "BTNCtrlVehAlta";
            this.BTNCtrlVehAlta.Size = new System.Drawing.Size(166, 35);
            this.BTNCtrlVehAlta.TabIndex = 42;
            this.BTNCtrlVehAlta.Text = "Alta";
            this.BTNCtrlVehAlta.UseVisualStyleBackColor = false;
            this.BTNCtrlVehAlta.Click += new System.EventHandler(this.BTNCtrlVehAlta_Click);
            // 
            // GB_Vehiculos
            // 
            this.GB_Vehiculos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GB_Vehiculos.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_Vehiculos.Location = new System.Drawing.Point(14, 110);
            this.GB_Vehiculos.Name = "GB_Vehiculos";
            this.GB_Vehiculos.Size = new System.Drawing.Size(1074, 514);
            this.GB_Vehiculos.TabIndex = 41;
            this.GB_Vehiculos.TabStop = false;
            this.GB_Vehiculos.Text = "Vehiculos";
            // 
            // DGV_Vehiculos
            // 
            this.DGV_Vehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Vehiculos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Vehiculos.Location = new System.Drawing.Point(27, 141);
            this.DGV_Vehiculos.MultiSelect = false;
            this.DGV_Vehiculos.Name = "DGV_Vehiculos";
            this.DGV_Vehiculos.ReadOnly = true;
            this.DGV_Vehiculos.Size = new System.Drawing.Size(1046, 470);
            this.DGV_Vehiculos.TabIndex = 0;
            this.DGV_Vehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Vehiculos_CellClick);
            // 
            // GB_DatosVehiculo
            // 
            this.GB_DatosVehiculo.Controls.Add(this.TXT_CtrlVehObservacion);
            this.GB_DatosVehiculo.Controls.Add(this.label3);
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
            this.GB_DatosVehiculo.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_DatosVehiculo.Location = new System.Drawing.Point(1096, 64);
            this.GB_DatosVehiculo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_DatosVehiculo.Name = "GB_DatosVehiculo";
            this.GB_DatosVehiculo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GB_DatosVehiculo.Size = new System.Drawing.Size(330, 561);
            this.GB_DatosVehiculo.TabIndex = 47;
            this.GB_DatosVehiculo.TabStop = false;
            this.GB_DatosVehiculo.Text = "Datos del vehiculos";
            // 
            // CBX_Estado
            // 
            this.CBX_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Estado.FormattingEnabled = true;
            this.CBX_Estado.Location = new System.Drawing.Point(14, 411);
            this.CBX_Estado.Name = "CBX_Estado";
            this.CBX_Estado.Size = new System.Drawing.Size(301, 25);
            this.CBX_Estado.TabIndex = 34;
            this.CBX_Estado.SelectedIndexChanged += new System.EventHandler(this.CBX_Estado_SelectedIndexChanged);
            // 
            // CBX_Sucursal
            // 
            this.CBX_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Sucursal.FormattingEnabled = true;
            this.CBX_Sucursal.Location = new System.Drawing.Point(14, 351);
            this.CBX_Sucursal.Name = "CBX_Sucursal";
            this.CBX_Sucursal.Size = new System.Drawing.Size(301, 25);
            this.CBX_Sucursal.TabIndex = 33;
            // 
            // CBX_Categoria
            // 
            this.CBX_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Categoria.FormattingEnabled = true;
            this.CBX_Categoria.Location = new System.Drawing.Point(14, 288);
            this.CBX_Categoria.Name = "CBX_Categoria";
            this.CBX_Categoria.Size = new System.Drawing.Size(301, 25);
            this.CBX_Categoria.TabIndex = 32;
            // 
            // NUM_KmActual
            // 
            this.NUM_KmActual.Location = new System.Drawing.Point(14, 228);
            this.NUM_KmActual.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NUM_KmActual.Name = "NUM_KmActual";
            this.NUM_KmActual.Size = new System.Drawing.Size(301, 23);
            this.NUM_KmActual.TabIndex = 31;
            // 
            // LBLestado
            // 
            this.LBLestado.AutoSize = true;
            this.LBLestado.Location = new System.Drawing.Point(14, 390);
            this.LBLestado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLestado.Name = "LBLestado";
            this.LBLestado.Size = new System.Drawing.Size(52, 17);
            this.LBLestado.TabIndex = 29;
            this.LBLestado.Text = "Estado";
            // 
            // LBLsucursal
            // 
            this.LBLsucursal.AutoSize = true;
            this.LBLsucursal.Location = new System.Drawing.Point(14, 329);
            this.LBLsucursal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLsucursal.Name = "LBLsucursal";
            this.LBLsucursal.Size = new System.Drawing.Size(59, 17);
            this.LBLsucursal.TabIndex = 27;
            this.LBLsucursal.Text = "Sucursal";
            // 
            // TXT_CtrlVehPatente
            // 
            this.TXT_CtrlVehPatente.Location = new System.Drawing.Point(14, 51);
            this.TXT_CtrlVehPatente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlVehPatente.Name = "TXT_CtrlVehPatente";
            this.TXT_CtrlVehPatente.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlVehPatente.TabIndex = 0;
            // 
            // TXT_CtrlVehMarca
            // 
            this.TXT_CtrlVehMarca.Location = new System.Drawing.Point(14, 109);
            this.TXT_CtrlVehMarca.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlVehMarca.Name = "TXT_CtrlVehMarca";
            this.TXT_CtrlVehMarca.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlVehMarca.TabIndex = 1;
            // 
            // TXT_CtrlVehModelo
            // 
            this.TXT_CtrlVehModelo.Location = new System.Drawing.Point(14, 169);
            this.TXT_CtrlVehModelo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlVehModelo.Name = "TXT_CtrlVehModelo";
            this.TXT_CtrlVehModelo.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlVehModelo.TabIndex = 2;
            // 
            // LBLCateogria
            // 
            this.LBLCateogria.AutoSize = true;
            this.LBLCateogria.Location = new System.Drawing.Point(14, 266);
            this.LBLCateogria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLCateogria.Name = "LBLCateogria";
            this.LBLCateogria.Size = new System.Drawing.Size(75, 17);
            this.LBLCateogria.TabIndex = 19;
            this.LBLCateogria.Text = "Categoría";
            // 
            // LBLpatente
            // 
            this.LBLpatente.AutoSize = true;
            this.LBLpatente.Location = new System.Drawing.Point(14, 30);
            this.LBLpatente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLpatente.Name = "LBLpatente";
            this.LBLpatente.Size = new System.Drawing.Size(59, 17);
            this.LBLpatente.TabIndex = 5;
            this.LBLpatente.Text = "Patente";
            // 
            // LBLmarca
            // 
            this.LBLmarca.AutoSize = true;
            this.LBLmarca.Location = new System.Drawing.Point(14, 89);
            this.LBLmarca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLmarca.Name = "LBLmarca";
            this.LBLmarca.Size = new System.Drawing.Size(49, 17);
            this.LBLmarca.TabIndex = 6;
            this.LBLmarca.Text = "Marca";
            // 
            // LBLmodelo
            // 
            this.LBLmodelo.AutoSize = true;
            this.LBLmodelo.Location = new System.Drawing.Point(14, 148);
            this.LBLmodelo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLmodelo.Name = "LBLmodelo";
            this.LBLmodelo.Size = new System.Drawing.Size(57, 17);
            this.LBLmodelo.TabIndex = 7;
            this.LBLmodelo.Text = "Modelo";
            // 
            // LBLkmActual
            // 
            this.LBLkmActual.AutoSize = true;
            this.LBLkmActual.Location = new System.Drawing.Point(14, 206);
            this.LBLkmActual.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLkmActual.Name = "LBLkmActual";
            this.LBLkmActual.Size = new System.Drawing.Size(75, 17);
            this.LBLkmActual.TabIndex = 8;
            this.LBLkmActual.Text = "Km Actual";
            // 
            // TXT_FiltroPatente
            // 
            this.TXT_FiltroPatente.Location = new System.Drawing.Point(11, 47);
            this.TXT_FiltroPatente.Name = "TXT_FiltroPatente";
            this.TXT_FiltroPatente.Size = new System.Drawing.Size(131, 23);
            this.TXT_FiltroPatente.TabIndex = 48;
            this.TXT_FiltroPatente.TextChanged += new System.EventHandler(this.TXT_FiltroPatente_TextChanged);
            // 
            // CBX_FiltroEstadoVeh
            // 
            this.CBX_FiltroEstadoVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_FiltroEstadoVeh.FormattingEnabled = true;
            this.CBX_FiltroEstadoVeh.Location = new System.Drawing.Point(176, 47);
            this.CBX_FiltroEstadoVeh.Name = "CBX_FiltroEstadoVeh";
            this.CBX_FiltroEstadoVeh.Size = new System.Drawing.Size(185, 25);
            this.CBX_FiltroEstadoVeh.TabIndex = 49;
            this.CBX_FiltroEstadoVeh.SelectedIndexChanged += new System.EventHandler(this.CBX_FiltroEstadoVeh_SelectedIndexChanged);
            // 
            // CBX_FiltroCategoriaVeh
            // 
            this.CBX_FiltroCategoriaVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_FiltroCategoriaVeh.FormattingEnabled = true;
            this.CBX_FiltroCategoriaVeh.Location = new System.Drawing.Point(394, 47);
            this.CBX_FiltroCategoriaVeh.Name = "CBX_FiltroCategoriaVeh";
            this.CBX_FiltroCategoriaVeh.Size = new System.Drawing.Size(185, 25);
            this.CBX_FiltroCategoriaVeh.TabIndex = 50;
            this.CBX_FiltroCategoriaVeh.SelectedIndexChanged += new System.EventHandler(this.CBX_FiltroCategoriaVeh_SelectedIndexChanged);
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(1261, 633);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(166, 35);
            this.BTNvolveralmenu.TabIndex = 51;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // LBLBuscarPatente
            // 
            this.LBLBuscarPatente.AutoSize = true;
            this.LBLBuscarPatente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLBuscarPatente.Location = new System.Drawing.Point(8, 26);
            this.LBLBuscarPatente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLBuscarPatente.Name = "LBLBuscarPatente";
            this.LBLBuscarPatente.Size = new System.Drawing.Size(59, 17);
            this.LBLBuscarPatente.TabIndex = 52;
            this.LBLBuscarPatente.Text = "Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Sucursal";
            // 
            // GB_FiltrosVehiculos
            // 
            this.GB_FiltrosVehiculos.Controls.Add(this.label2);
            this.GB_FiltrosVehiculos.Controls.Add(this.label1);
            this.GB_FiltrosVehiculos.Controls.Add(this.LBLBuscarPatente);
            this.GB_FiltrosVehiculos.Controls.Add(this.CBX_FiltroCategoriaVeh);
            this.GB_FiltrosVehiculos.Controls.Add(this.CBX_FiltroEstadoVeh);
            this.GB_FiltrosVehiculos.Controls.Add(this.TXT_FiltroPatente);
            this.GB_FiltrosVehiculos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_FiltrosVehiculos.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_FiltrosVehiculos.Location = new System.Drawing.Point(14, 13);
            this.GB_FiltrosVehiculos.Name = "GB_FiltrosVehiculos";
            this.GB_FiltrosVehiculos.Size = new System.Drawing.Size(818, 86);
            this.GB_FiltrosVehiculos.TabIndex = 54;
            this.GB_FiltrosVehiculos.TabStop = false;
            this.GB_FiltrosVehiculos.Text = "Filtros";
            // 
            // TXT_CtrlVehObservacion
            // 
            this.TXT_CtrlVehObservacion.Location = new System.Drawing.Point(14, 473);
            this.TXT_CtrlVehObservacion.Multiline = true;
            this.TXT_CtrlVehObservacion.Name = "TXT_CtrlVehObservacion";
            this.TXT_CtrlVehObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TXT_CtrlVehObservacion.Size = new System.Drawing.Size(301, 76);
            this.TXT_CtrlVehObservacion.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 452);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Observaciones de la revisión";
            // 
            // FrmCTRLVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1440, 682);
            this.Controls.Add(this.DGV_Vehiculos);
            this.Controls.Add(this.GB_Vehiculos);
            this.Controls.Add(this.GB_FiltrosVehiculos);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.GB_DatosVehiculo);
            this.Controls.Add(this.CKXmostrarInactivos);
            this.Controls.Add(this.BTNCtrlVehReactivar);
            this.Controls.Add(this.BTNCtrlVehModificar);
            this.Controls.Add(this.BTNCtrlVehBaja);
            this.Controls.Add(this.BTNCtrlVehAlta);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCTRLVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLVehiculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCTRLVehiculo_FormClosing);
            this.Load += new System.EventHandler(this.FrmCTRLVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Vehiculos)).EndInit();
            this.GB_DatosVehiculo.ResumeLayout(false);
            this.GB_DatosVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_KmActual)).EndInit();
            this.GB_FiltrosVehiculos.ResumeLayout(false);
            this.GB_FiltrosVehiculos.PerformLayout();
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
        private System.Windows.Forms.TextBox TXT_FiltroPatente;
        private System.Windows.Forms.ComboBox CBX_FiltroEstadoVeh;
        private System.Windows.Forms.ComboBox CBX_FiltroCategoriaVeh;
        private System.Windows.Forms.Button BTNvolveralmenu;
        private System.Windows.Forms.Label LBLBuscarPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GB_FiltrosVehiculos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CtrlVehObservacion;
    }
}