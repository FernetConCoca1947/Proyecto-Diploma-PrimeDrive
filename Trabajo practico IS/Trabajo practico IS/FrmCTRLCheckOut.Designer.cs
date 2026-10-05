namespace Trabajo_practico_IS
{
    partial class FrmCTRLCheckOut
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
            this.BTNvolveralmenu = new System.Windows.Forms.Button();
            this.LBLidiomas = new System.Windows.Forms.Label();
            this.CBXidiomas = new System.Windows.Forms.ComboBox();
            this.BTNCCtrlChkOutBuscar = new System.Windows.Forms.Button();
            this.TXT_CtrlChkOutDNI = new System.Windows.Forms.TextBox();
            this.LBLdniCliente = new System.Windows.Forms.Label();
            this.LBLCliente = new System.Windows.Forms.Label();
            this.LBLRetiro = new System.Windows.Forms.Label();
            this.LBLDevolucion = new System.Windows.Forms.Label();
            this.LBLcategoriaSeleccionada = new System.Windows.Forms.Label();
            this.LBLDATOSCliente = new System.Windows.Forms.Label();
            this.LBLDATOSRetiro = new System.Windows.Forms.Label();
            this.LBLDATOSDevolucion = new System.Windows.Forms.Label();
            this.LBLDATOScategoria = new System.Windows.Forms.Label();
            this.CBX_VehiculosDisponibles = new System.Windows.Forms.ComboBox();
            this.LBLvehiculos = new System.Windows.Forms.Label();
            this.LBLkilometraje = new System.Windows.Forms.Label();
            this.TXT_CtrlChkOutKmAct = new System.Windows.Forms.TextBox();
            this.LBLreservasCliente = new System.Windows.Forms.Label();
            this.CBX_ReservasCliente = new System.Windows.Forms.ComboBox();
            this.BTNCCtrlChkOutGenerar = new System.Windows.Forms.Button();
            this.LBLTarifaDiaria = new System.Windows.Forms.Label();
            this.LBLDiasEstimado = new System.Windows.Forms.Label();
            this.LBLDATOSTarifaDiaria = new System.Windows.Forms.Label();
            this.LBLDATOSDiasEstimado = new System.Windows.Forms.Label();
            this.LBLMontoGarantia = new System.Windows.Forms.Label();
            this.TXT_CtrlChkOutGarantia = new System.Windows.Forms.TextBox();
            this.LBLObservaciones = new System.Windows.Forms.Label();
            this.TXT_CtrlChkOutObservaciones = new System.Windows.Forms.TextBox();
            this.LBLMetodoPago = new System.Windows.Forms.Label();
            this.CBX_MetodoPago = new System.Windows.Forms.ComboBox();
            this.GB_DatosBuscarReserva = new System.Windows.Forms.GroupBox();
            this.GB_DatosNuevoContrato = new System.Windows.Forms.GroupBox();
            this.GB_AsignarVehiculo = new System.Windows.Forms.GroupBox();
            this.GB_DatosBuscarReserva.SuspendLayout();
            this.GB_DatosNuevoContrato.SuspendLayout();
            this.GB_AsignarVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(790, 478);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(154, 35);
            this.BTNvolveralmenu.TabIndex = 37;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            this.BTNvolveralmenu.Click += new System.EventHandler(this.BTNvolveralmenu_Click);
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.ForeColor = System.Drawing.SystemColors.Window;
            this.LBLidiomas.Location = new System.Drawing.Point(790, 9);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 36;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(790, 29);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(154, 25);
            this.CBXidiomas.TabIndex = 35;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // BTNCCtrlChkOutBuscar
            // 
            this.BTNCCtrlChkOutBuscar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCCtrlChkOutBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BTNCCtrlChkOutBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCCtrlChkOutBuscar.Location = new System.Drawing.Point(246, 38);
            this.BTNCCtrlChkOutBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCCtrlChkOutBuscar.Name = "BTNCCtrlChkOutBuscar";
            this.BTNCCtrlChkOutBuscar.Size = new System.Drawing.Size(154, 35);
            this.BTNCCtrlChkOutBuscar.TabIndex = 40;
            this.BTNCCtrlChkOutBuscar.Tag = "";
            this.BTNCCtrlChkOutBuscar.Text = "Buscar";
            this.BTNCCtrlChkOutBuscar.UseVisualStyleBackColor = false;
            this.BTNCCtrlChkOutBuscar.Click += new System.EventHandler(this.BTNCCtrlChkOutBuscar_Click);
            // 
            // TXT_CtrlChkOutDNI
            // 
            this.TXT_CtrlChkOutDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutDNI.Location = new System.Drawing.Point(10, 44);
            this.TXT_CtrlChkOutDNI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlChkOutDNI.Name = "TXT_CtrlChkOutDNI";
            this.TXT_CtrlChkOutDNI.Size = new System.Drawing.Size(226, 23);
            this.TXT_CtrlChkOutDNI.TabIndex = 38;
            // 
            // LBLdniCliente
            // 
            this.LBLdniCliente.AutoSize = true;
            this.LBLdniCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLdniCliente.Location = new System.Drawing.Point(10, 23);
            this.LBLdniCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLdniCliente.Name = "LBLdniCliente";
            this.LBLdniCliente.Size = new System.Drawing.Size(82, 17);
            this.LBLdniCliente.TabIndex = 39;
            this.LBLdniCliente.Text = "DNI cliente:";
            // 
            // LBLCliente
            // 
            this.LBLCliente.AutoSize = true;
            this.LBLCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLCliente.Location = new System.Drawing.Point(10, 138);
            this.LBLCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLCliente.Name = "LBLCliente";
            this.LBLCliente.Size = new System.Drawing.Size(57, 16);
            this.LBLCliente.TabIndex = 41;
            this.LBLCliente.Text = "Cliente:";
            // 
            // LBLRetiro
            // 
            this.LBLRetiro.AutoSize = true;
            this.LBLRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLRetiro.Location = new System.Drawing.Point(10, 178);
            this.LBLRetiro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLRetiro.Name = "LBLRetiro";
            this.LBLRetiro.Size = new System.Drawing.Size(48, 16);
            this.LBLRetiro.TabIndex = 42;
            this.LBLRetiro.Text = "Retiro:";
            // 
            // LBLDevolucion
            // 
            this.LBLDevolucion.AutoSize = true;
            this.LBLDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDevolucion.Location = new System.Drawing.Point(10, 218);
            this.LBLDevolucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDevolucion.Name = "LBLDevolucion";
            this.LBLDevolucion.Size = new System.Drawing.Size(83, 16);
            this.LBLDevolucion.TabIndex = 43;
            this.LBLDevolucion.Text = "Devolucion:";
            // 
            // LBLcategoriaSeleccionada
            // 
            this.LBLcategoriaSeleccionada.AutoSize = true;
            this.LBLcategoriaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLcategoriaSeleccionada.Location = new System.Drawing.Point(10, 258);
            this.LBLcategoriaSeleccionada.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLcategoriaSeleccionada.Name = "LBLcategoriaSeleccionada";
            this.LBLcategoriaSeleccionada.Size = new System.Drawing.Size(170, 16);
            this.LBLcategoriaSeleccionada.TabIndex = 44;
            this.LBLcategoriaSeleccionada.Text = "Categoria seleccionada:";
            // 
            // LBLDATOSCliente
            // 
            this.LBLDATOSCliente.AutoSize = true;
            this.LBLDATOSCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDATOSCliente.Location = new System.Drawing.Point(10, 154);
            this.LBLDATOSCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDATOSCliente.Name = "LBLDATOSCliente";
            this.LBLDATOSCliente.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSCliente.TabIndex = 45;
            // 
            // LBLDATOSRetiro
            // 
            this.LBLDATOSRetiro.AutoSize = true;
            this.LBLDATOSRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDATOSRetiro.Location = new System.Drawing.Point(10, 192);
            this.LBLDATOSRetiro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDATOSRetiro.Name = "LBLDATOSRetiro";
            this.LBLDATOSRetiro.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSRetiro.TabIndex = 46;
            // 
            // LBLDATOSDevolucion
            // 
            this.LBLDATOSDevolucion.AutoSize = true;
            this.LBLDATOSDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDATOSDevolucion.Location = new System.Drawing.Point(10, 234);
            this.LBLDATOSDevolucion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDATOSDevolucion.Name = "LBLDATOSDevolucion";
            this.LBLDATOSDevolucion.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSDevolucion.TabIndex = 47;
            // 
            // LBLDATOScategoria
            // 
            this.LBLDATOScategoria.AutoSize = true;
            this.LBLDATOScategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDATOScategoria.Location = new System.Drawing.Point(10, 274);
            this.LBLDATOScategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDATOScategoria.Name = "LBLDATOScategoria";
            this.LBLDATOScategoria.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOScategoria.TabIndex = 48;
            // 
            // CBX_VehiculosDisponibles
            // 
            this.CBX_VehiculosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_VehiculosDisponibles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_VehiculosDisponibles.FormattingEnabled = true;
            this.CBX_VehiculosDisponibles.Location = new System.Drawing.Point(10, 53);
            this.CBX_VehiculosDisponibles.Name = "CBX_VehiculosDisponibles";
            this.CBX_VehiculosDisponibles.Size = new System.Drawing.Size(304, 25);
            this.CBX_VehiculosDisponibles.TabIndex = 49;
            this.CBX_VehiculosDisponibles.SelectedIndexChanged += new System.EventHandler(this.CBX_VehiculosDisponibles_SelectedIndexChanged);
            // 
            // LBLvehiculos
            // 
            this.LBLvehiculos.AutoSize = true;
            this.LBLvehiculos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLvehiculos.Location = new System.Drawing.Point(10, 32);
            this.LBLvehiculos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLvehiculos.Name = "LBLvehiculos";
            this.LBLvehiculos.Size = new System.Drawing.Size(148, 17);
            this.LBLvehiculos.TabIndex = 50;
            this.LBLvehiculos.Text = "Vehículos disponibles:";
            // 
            // LBLkilometraje
            // 
            this.LBLkilometraje.AutoSize = true;
            this.LBLkilometraje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLkilometraje.Location = new System.Drawing.Point(10, 99);
            this.LBLkilometraje.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLkilometraje.Name = "LBLkilometraje";
            this.LBLkilometraje.Size = new System.Drawing.Size(131, 17);
            this.LBLkilometraje.TabIndex = 51;
            this.LBLkilometraje.Text = "Kilometraje actual:";
            // 
            // TXT_CtrlChkOutKmAct
            // 
            this.TXT_CtrlChkOutKmAct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutKmAct.Location = new System.Drawing.Point(10, 120);
            this.TXT_CtrlChkOutKmAct.Name = "TXT_CtrlChkOutKmAct";
            this.TXT_CtrlChkOutKmAct.ReadOnly = true;
            this.TXT_CtrlChkOutKmAct.Size = new System.Drawing.Size(304, 23);
            this.TXT_CtrlChkOutKmAct.TabIndex = 52;
            // 
            // LBLreservasCliente
            // 
            this.LBLreservasCliente.AutoSize = true;
            this.LBLreservasCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLreservasCliente.Location = new System.Drawing.Point(10, 80);
            this.LBLreservasCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLreservasCliente.Name = "LBLreservasCliente";
            this.LBLreservasCliente.Size = new System.Drawing.Size(67, 17);
            this.LBLreservasCliente.TabIndex = 54;
            this.LBLreservasCliente.Text = "Reservas:";
            // 
            // CBX_ReservasCliente
            // 
            this.CBX_ReservasCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_ReservasCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_ReservasCliente.FormattingEnabled = true;
            this.CBX_ReservasCliente.Location = new System.Drawing.Point(10, 101);
            this.CBX_ReservasCliente.Name = "CBX_ReservasCliente";
            this.CBX_ReservasCliente.Size = new System.Drawing.Size(226, 25);
            this.CBX_ReservasCliente.TabIndex = 53;
            this.CBX_ReservasCliente.SelectedIndexChanged += new System.EventHandler(this.CBX_ReservasCliente_SelectedIndexChanged);
            // 
            // BTNCCtrlChkOutGenerar
            // 
            this.BTNCCtrlChkOutGenerar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BTNCCtrlChkOutGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BTNCCtrlChkOutGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCCtrlChkOutGenerar.Location = new System.Drawing.Point(165, 444);
            this.BTNCCtrlChkOutGenerar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BTNCCtrlChkOutGenerar.Name = "BTNCCtrlChkOutGenerar";
            this.BTNCCtrlChkOutGenerar.Size = new System.Drawing.Size(154, 35);
            this.BTNCCtrlChkOutGenerar.TabIndex = 55;
            this.BTNCCtrlChkOutGenerar.Tag = "";
            this.BTNCCtrlChkOutGenerar.Text = "Generar contrato";
            this.BTNCCtrlChkOutGenerar.UseVisualStyleBackColor = false;
            this.BTNCCtrlChkOutGenerar.Click += new System.EventHandler(this.BTNCCtrlChkOutGenerar_Click);
            // 
            // LBLTarifaDiaria
            // 
            this.LBLTarifaDiaria.AutoSize = true;
            this.LBLTarifaDiaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLTarifaDiaria.Location = new System.Drawing.Point(13, 28);
            this.LBLTarifaDiaria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLTarifaDiaria.Name = "LBLTarifaDiaria";
            this.LBLTarifaDiaria.Size = new System.Drawing.Size(180, 16);
            this.LBLTarifaDiaria.TabIndex = 56;
            this.LBLTarifaDiaria.Text = "Tarifa diaria de categoría:";
            // 
            // LBLDiasEstimado
            // 
            this.LBLDiasEstimado.AutoSize = true;
            this.LBLDiasEstimado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDiasEstimado.Location = new System.Drawing.Point(13, 78);
            this.LBLDiasEstimado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDiasEstimado.Name = "LBLDiasEstimado";
            this.LBLDiasEstimado.Size = new System.Drawing.Size(108, 16);
            this.LBLDiasEstimado.TabIndex = 57;
            this.LBLDiasEstimado.Text = "Días estimados:";
            // 
            // LBLDATOSTarifaDiaria
            // 
            this.LBLDATOSTarifaDiaria.AutoSize = true;
            this.LBLDATOSTarifaDiaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDATOSTarifaDiaria.Location = new System.Drawing.Point(13, 44);
            this.LBLDATOSTarifaDiaria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDATOSTarifaDiaria.Name = "LBLDATOSTarifaDiaria";
            this.LBLDATOSTarifaDiaria.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSTarifaDiaria.TabIndex = 58;
            // 
            // LBLDATOSDiasEstimado
            // 
            this.LBLDATOSDiasEstimado.AutoSize = true;
            this.LBLDATOSDiasEstimado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBLDATOSDiasEstimado.Location = new System.Drawing.Point(13, 94);
            this.LBLDATOSDiasEstimado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLDATOSDiasEstimado.Name = "LBLDATOSDiasEstimado";
            this.LBLDATOSDiasEstimado.Size = new System.Drawing.Size(0, 16);
            this.LBLDATOSDiasEstimado.TabIndex = 59;
            // 
            // LBLMontoGarantia
            // 
            this.LBLMontoGarantia.AutoSize = true;
            this.LBLMontoGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLMontoGarantia.Location = new System.Drawing.Point(13, 123);
            this.LBLMontoGarantia.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLMontoGarantia.Name = "LBLMontoGarantia";
            this.LBLMontoGarantia.Size = new System.Drawing.Size(197, 17);
            this.LBLMontoGarantia.TabIndex = 60;
            this.LBLMontoGarantia.Text = "Monto de garantia a retener:";
            // 
            // TXT_CtrlChkOutGarantia
            // 
            this.TXT_CtrlChkOutGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutGarantia.Location = new System.Drawing.Point(13, 146);
            this.TXT_CtrlChkOutGarantia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlChkOutGarantia.Name = "TXT_CtrlChkOutGarantia";
            this.TXT_CtrlChkOutGarantia.Size = new System.Drawing.Size(301, 23);
            this.TXT_CtrlChkOutGarantia.TabIndex = 61;
            // 
            // LBLObservaciones
            // 
            this.LBLObservaciones.AutoSize = true;
            this.LBLObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLObservaciones.Location = new System.Drawing.Point(13, 239);
            this.LBLObservaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLObservaciones.Name = "LBLObservaciones";
            this.LBLObservaciones.Size = new System.Drawing.Size(103, 17);
            this.LBLObservaciones.TabIndex = 62;
            this.LBLObservaciones.Text = "Observaciones";
            // 
            // TXT_CtrlChkOutObservaciones
            // 
            this.TXT_CtrlChkOutObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutObservaciones.Location = new System.Drawing.Point(13, 260);
            this.TXT_CtrlChkOutObservaciones.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TXT_CtrlChkOutObservaciones.Multiline = true;
            this.TXT_CtrlChkOutObservaciones.Name = "TXT_CtrlChkOutObservaciones";
            this.TXT_CtrlChkOutObservaciones.Size = new System.Drawing.Size(306, 176);
            this.TXT_CtrlChkOutObservaciones.TabIndex = 63;
            // 
            // LBLMetodoPago
            // 
            this.LBLMetodoPago.AutoSize = true;
            this.LBLMetodoPago.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLMetodoPago.Location = new System.Drawing.Point(13, 180);
            this.LBLMetodoPago.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBLMetodoPago.Name = "LBLMetodoPago";
            this.LBLMetodoPago.Size = new System.Drawing.Size(124, 17);
            this.LBLMetodoPago.TabIndex = 65;
            this.LBLMetodoPago.Text = "Metodo de pago:";
            // 
            // CBX_MetodoPago
            // 
            this.CBX_MetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_MetodoPago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_MetodoPago.FormattingEnabled = true;
            this.CBX_MetodoPago.Location = new System.Drawing.Point(13, 201);
            this.CBX_MetodoPago.Name = "CBX_MetodoPago";
            this.CBX_MetodoPago.Size = new System.Drawing.Size(301, 25);
            this.CBX_MetodoPago.TabIndex = 64;
            // 
            // GB_DatosBuscarReserva
            // 
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLreservasCliente);
            this.GB_DatosBuscarReserva.Controls.Add(this.CBX_ReservasCliente);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLDATOScategoria);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLDATOSDevolucion);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLDATOSRetiro);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLDATOSCliente);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLcategoriaSeleccionada);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLDevolucion);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLRetiro);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLCliente);
            this.GB_DatosBuscarReserva.Controls.Add(this.BTNCCtrlChkOutBuscar);
            this.GB_DatosBuscarReserva.Controls.Add(this.TXT_CtrlChkOutDNI);
            this.GB_DatosBuscarReserva.Controls.Add(this.LBLdniCliente);
            this.GB_DatosBuscarReserva.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_DatosBuscarReserva.Location = new System.Drawing.Point(21, 21);
            this.GB_DatosBuscarReserva.Name = "GB_DatosBuscarReserva";
            this.GB_DatosBuscarReserva.Size = new System.Drawing.Size(409, 302);
            this.GB_DatosBuscarReserva.TabIndex = 66;
            this.GB_DatosBuscarReserva.TabStop = false;
            this.GB_DatosBuscarReserva.Text = "Buscar reserva";
            // 
            // GB_DatosNuevoContrato
            // 
            this.GB_DatosNuevoContrato.Controls.Add(this.BTNCCtrlChkOutGenerar);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLMetodoPago);
            this.GB_DatosNuevoContrato.Controls.Add(this.CBX_MetodoPago);
            this.GB_DatosNuevoContrato.Controls.Add(this.TXT_CtrlChkOutObservaciones);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLObservaciones);
            this.GB_DatosNuevoContrato.Controls.Add(this.TXT_CtrlChkOutGarantia);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLMontoGarantia);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLDATOSDiasEstimado);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLDiasEstimado);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLDATOSTarifaDiaria);
            this.GB_DatosNuevoContrato.Controls.Add(this.LBLTarifaDiaria);
            this.GB_DatosNuevoContrato.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_DatosNuevoContrato.Location = new System.Drawing.Point(448, 21);
            this.GB_DatosNuevoContrato.Name = "GB_DatosNuevoContrato";
            this.GB_DatosNuevoContrato.Size = new System.Drawing.Size(334, 492);
            this.GB_DatosNuevoContrato.TabIndex = 67;
            this.GB_DatosNuevoContrato.TabStop = false;
            this.GB_DatosNuevoContrato.Text = "Garantía y firma de contrato";
            // 
            // GB_AsignarVehiculo
            // 
            this.GB_AsignarVehiculo.Controls.Add(this.CBX_VehiculosDisponibles);
            this.GB_AsignarVehiculo.Controls.Add(this.LBLvehiculos);
            this.GB_AsignarVehiculo.Controls.Add(this.LBLkilometraje);
            this.GB_AsignarVehiculo.Controls.Add(this.TXT_CtrlChkOutKmAct);
            this.GB_AsignarVehiculo.ForeColor = System.Drawing.SystemColors.Window;
            this.GB_AsignarVehiculo.Location = new System.Drawing.Point(21, 339);
            this.GB_AsignarVehiculo.Name = "GB_AsignarVehiculo";
            this.GB_AsignarVehiculo.Size = new System.Drawing.Size(409, 174);
            this.GB_AsignarVehiculo.TabIndex = 68;
            this.GB_AsignarVehiculo.TabStop = false;
            this.GB_AsignarVehiculo.Text = "Asignar vehículo";
            // 
            // FrmCTRLCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(958, 529);
            this.Controls.Add(this.GB_AsignarVehiculo);
            this.Controls.Add(this.GB_DatosNuevoContrato);
            this.Controls.Add(this.GB_DatosBuscarReserva);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmCTRLCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLCheckOut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCTRLCheckOut_FormClosing);
            this.Load += new System.EventHandler(this.FrmCTRLCheckOut_Load);
            this.GB_DatosBuscarReserva.ResumeLayout(false);
            this.GB_DatosBuscarReserva.PerformLayout();
            this.GB_DatosNuevoContrato.ResumeLayout(false);
            this.GB_DatosNuevoContrato.PerformLayout();
            this.GB_AsignarVehiculo.ResumeLayout(false);
            this.GB_AsignarVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNvolveralmenu;
        private System.Windows.Forms.Label LBLidiomas;
        private System.Windows.Forms.ComboBox CBXidiomas;
        private System.Windows.Forms.Button BTNCCtrlChkOutBuscar;
        private System.Windows.Forms.TextBox TXT_CtrlChkOutDNI;
        private System.Windows.Forms.Label LBLdniCliente;
        private System.Windows.Forms.Label LBLCliente;
        private System.Windows.Forms.Label LBLRetiro;
        private System.Windows.Forms.Label LBLDevolucion;
        private System.Windows.Forms.Label LBLcategoriaSeleccionada;
        private System.Windows.Forms.Label LBLDATOSCliente;
        private System.Windows.Forms.Label LBLDATOSRetiro;
        private System.Windows.Forms.Label LBLDATOSDevolucion;
        private System.Windows.Forms.Label LBLDATOScategoria;
        private System.Windows.Forms.ComboBox CBX_VehiculosDisponibles;
        private System.Windows.Forms.Label LBLvehiculos;
        private System.Windows.Forms.Label LBLkilometraje;
        private System.Windows.Forms.TextBox TXT_CtrlChkOutKmAct;
        private System.Windows.Forms.Label LBLreservasCliente;
        private System.Windows.Forms.ComboBox CBX_ReservasCliente;
        private System.Windows.Forms.Button BTNCCtrlChkOutGenerar;
        private System.Windows.Forms.Label LBLTarifaDiaria;
        private System.Windows.Forms.Label LBLDiasEstimado;
        private System.Windows.Forms.Label LBLDATOSTarifaDiaria;
        private System.Windows.Forms.Label LBLDATOSDiasEstimado;
        private System.Windows.Forms.Label LBLMontoGarantia;
        private System.Windows.Forms.TextBox TXT_CtrlChkOutGarantia;
        private System.Windows.Forms.Label LBLObservaciones;
        private System.Windows.Forms.TextBox TXT_CtrlChkOutObservaciones;
        private System.Windows.Forms.Label LBLMetodoPago;
        private System.Windows.Forms.ComboBox CBX_MetodoPago;
        private System.Windows.Forms.GroupBox GB_DatosBuscarReserva;
        private System.Windows.Forms.GroupBox GB_DatosNuevoContrato;
        private System.Windows.Forms.GroupBox GB_AsignarVehiculo;
    }
}