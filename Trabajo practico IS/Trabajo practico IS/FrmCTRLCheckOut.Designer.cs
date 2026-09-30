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
            this.SuspendLayout();
            // 
            // BTNvolveralmenu
            // 
            this.BTNvolveralmenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNvolveralmenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNvolveralmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNvolveralmenu.Location = new System.Drawing.Point(1076, 593);
            this.BTNvolveralmenu.Margin = new System.Windows.Forms.Padding(4);
            this.BTNvolveralmenu.Name = "BTNvolveralmenu";
            this.BTNvolveralmenu.Size = new System.Drawing.Size(145, 33);
            this.BTNvolveralmenu.TabIndex = 37;
            this.BTNvolveralmenu.Text = "Volver al menu";
            this.BTNvolveralmenu.UseVisualStyleBackColor = false;
            // 
            // LBLidiomas
            // 
            this.LBLidiomas.AutoSize = true;
            this.LBLidiomas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLidiomas.Location = new System.Drawing.Point(1086, 10);
            this.LBLidiomas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLidiomas.Name = "LBLidiomas";
            this.LBLidiomas.Size = new System.Drawing.Size(74, 17);
            this.LBLidiomas.TabIndex = 36;
            this.LBLidiomas.Text = "Language";
            // 
            // CBXidiomas
            // 
            this.CBXidiomas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CBXidiomas.FormattingEnabled = true;
            this.CBXidiomas.Location = new System.Drawing.Point(1086, 29);
            this.CBXidiomas.Name = "CBXidiomas";
            this.CBXidiomas.Size = new System.Drawing.Size(135, 25);
            this.CBXidiomas.TabIndex = 35;
            this.CBXidiomas.SelectedIndexChanged += new System.EventHandler(this.CBXidiomas_SelectedIndexChanged);
            // 
            // BTNCCtrlChkOutBuscar
            // 
            this.BTNCCtrlChkOutBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCCtrlChkOutBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BTNCCtrlChkOutBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCCtrlChkOutBuscar.Location = new System.Drawing.Point(318, 76);
            this.BTNCCtrlChkOutBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCCtrlChkOutBuscar.Name = "BTNCCtrlChkOutBuscar";
            this.BTNCCtrlChkOutBuscar.Size = new System.Drawing.Size(145, 33);
            this.BTNCCtrlChkOutBuscar.TabIndex = 40;
            this.BTNCCtrlChkOutBuscar.Tag = "";
            this.BTNCCtrlChkOutBuscar.Text = "Buscar";
            this.BTNCCtrlChkOutBuscar.UseVisualStyleBackColor = false;
            this.BTNCCtrlChkOutBuscar.Click += new System.EventHandler(this.BTNCCtrlChkOutBuscar_Click);
            // 
            // TXT_CtrlChkOutDNI
            // 
            this.TXT_CtrlChkOutDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutDNI.Location = new System.Drawing.Point(29, 81);
            this.TXT_CtrlChkOutDNI.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlChkOutDNI.Name = "TXT_CtrlChkOutDNI";
            this.TXT_CtrlChkOutDNI.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlChkOutDNI.TabIndex = 38;
            // 
            // LBLdniCliente
            // 
            this.LBLdniCliente.AutoSize = true;
            this.LBLdniCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLdniCliente.Location = new System.Drawing.Point(29, 61);
            this.LBLdniCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLdniCliente.Name = "LBLdniCliente";
            this.LBLdniCliente.Size = new System.Drawing.Size(78, 17);
            this.LBLdniCliente.TabIndex = 39;
            this.LBLdniCliente.Text = "DNI cliente";
            // 
            // LBLCliente
            // 
            this.LBLCliente.AutoSize = true;
            this.LBLCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLCliente.Location = new System.Drawing.Point(30, 172);
            this.LBLCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLCliente.Name = "LBLCliente";
            this.LBLCliente.Size = new System.Drawing.Size(58, 17);
            this.LBLCliente.TabIndex = 41;
            this.LBLCliente.Text = "Cliente:";
            // 
            // LBLRetiro
            // 
            this.LBLRetiro.AutoSize = true;
            this.LBLRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLRetiro.Location = new System.Drawing.Point(30, 219);
            this.LBLRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLRetiro.Name = "LBLRetiro";
            this.LBLRetiro.Size = new System.Drawing.Size(49, 17);
            this.LBLRetiro.TabIndex = 42;
            this.LBLRetiro.Text = "Retiro:";
            // 
            // LBLDevolucion
            // 
            this.LBLDevolucion.AutoSize = true;
            this.LBLDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDevolucion.Location = new System.Drawing.Point(30, 267);
            this.LBLDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDevolucion.Name = "LBLDevolucion";
            this.LBLDevolucion.Size = new System.Drawing.Size(86, 17);
            this.LBLDevolucion.TabIndex = 43;
            this.LBLDevolucion.Text = "Devolucion:";
            // 
            // LBLcategoriaSeleccionada
            // 
            this.LBLcategoriaSeleccionada.AutoSize = true;
            this.LBLcategoriaSeleccionada.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLcategoriaSeleccionada.Location = new System.Drawing.Point(30, 312);
            this.LBLcategoriaSeleccionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLcategoriaSeleccionada.Name = "LBLcategoriaSeleccionada";
            this.LBLcategoriaSeleccionada.Size = new System.Drawing.Size(170, 17);
            this.LBLcategoriaSeleccionada.TabIndex = 44;
            this.LBLcategoriaSeleccionada.Text = "Categoria seleccionada:";
            // 
            // LBLDATOSCliente
            // 
            this.LBLDATOSCliente.AutoSize = true;
            this.LBLDATOSCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDATOSCliente.Location = new System.Drawing.Point(30, 189);
            this.LBLDATOSCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSCliente.Name = "LBLDATOSCliente";
            this.LBLDATOSCliente.Size = new System.Drawing.Size(45, 17);
            this.LBLDATOSCliente.TabIndex = 45;
            this.LBLDATOSCliente.Text = "datos";
            // 
            // LBLDATOSRetiro
            // 
            this.LBLDATOSRetiro.AutoSize = true;
            this.LBLDATOSRetiro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDATOSRetiro.Location = new System.Drawing.Point(30, 236);
            this.LBLDATOSRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSRetiro.Name = "LBLDATOSRetiro";
            this.LBLDATOSRetiro.Size = new System.Drawing.Size(45, 17);
            this.LBLDATOSRetiro.TabIndex = 46;
            this.LBLDATOSRetiro.Text = "datos";
            // 
            // LBLDATOSDevolucion
            // 
            this.LBLDATOSDevolucion.AutoSize = true;
            this.LBLDATOSDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDATOSDevolucion.Location = new System.Drawing.Point(30, 284);
            this.LBLDATOSDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSDevolucion.Name = "LBLDATOSDevolucion";
            this.LBLDATOSDevolucion.Size = new System.Drawing.Size(45, 17);
            this.LBLDATOSDevolucion.TabIndex = 47;
            this.LBLDATOSDevolucion.Text = "datos";
            // 
            // LBLDATOScategoria
            // 
            this.LBLDATOScategoria.AutoSize = true;
            this.LBLDATOScategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDATOScategoria.Location = new System.Drawing.Point(30, 329);
            this.LBLDATOScategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOScategoria.Name = "LBLDATOScategoria";
            this.LBLDATOScategoria.Size = new System.Drawing.Size(45, 17);
            this.LBLDATOScategoria.TabIndex = 48;
            this.LBLDATOScategoria.Text = "datos";
            // 
            // CBX_VehiculosDisponibles
            // 
            this.CBX_VehiculosDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_VehiculosDisponibles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBX_VehiculosDisponibles.FormattingEnabled = true;
            this.CBX_VehiculosDisponibles.Location = new System.Drawing.Point(33, 401);
            this.CBX_VehiculosDisponibles.Name = "CBX_VehiculosDisponibles";
            this.CBX_VehiculosDisponibles.Size = new System.Drawing.Size(264, 25);
            this.CBX_VehiculosDisponibles.TabIndex = 49;
            this.CBX_VehiculosDisponibles.SelectedIndexChanged += new System.EventHandler(this.CBX_VehiculosDisponibles_SelectedIndexChanged);
            // 
            // LBLvehiculos
            // 
            this.LBLvehiculos.AutoSize = true;
            this.LBLvehiculos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLvehiculos.Location = new System.Drawing.Point(30, 381);
            this.LBLvehiculos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLvehiculos.Name = "LBLvehiculos";
            this.LBLvehiculos.Size = new System.Drawing.Size(148, 17);
            this.LBLvehiculos.TabIndex = 50;
            this.LBLvehiculos.Text = "Vehículos disponibles:";
            // 
            // LBLkilometraje
            // 
            this.LBLkilometraje.AutoSize = true;
            this.LBLkilometraje.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLkilometraje.Location = new System.Drawing.Point(30, 448);
            this.LBLkilometraje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLkilometraje.Name = "LBLkilometraje";
            this.LBLkilometraje.Size = new System.Drawing.Size(131, 17);
            this.LBLkilometraje.TabIndex = 51;
            this.LBLkilometraje.Text = "Kilometraje actual:";
            // 
            // TXT_CtrlChkOutKmAct
            // 
            this.TXT_CtrlChkOutKmAct.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutKmAct.Location = new System.Drawing.Point(33, 478);
            this.TXT_CtrlChkOutKmAct.Name = "TXT_CtrlChkOutKmAct";
            this.TXT_CtrlChkOutKmAct.Size = new System.Drawing.Size(265, 23);
            this.TXT_CtrlChkOutKmAct.TabIndex = 52;
            // 
            // LBLreservasCliente
            // 
            this.LBLreservasCliente.AutoSize = true;
            this.LBLreservasCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLreservasCliente.Location = new System.Drawing.Point(29, 115);
            this.LBLreservasCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.CBX_ReservasCliente.Location = new System.Drawing.Point(29, 135);
            this.CBX_ReservasCliente.Name = "CBX_ReservasCliente";
            this.CBX_ReservasCliente.Size = new System.Drawing.Size(264, 25);
            this.CBX_ReservasCliente.TabIndex = 53;
            this.CBX_ReservasCliente.SelectedIndexChanged += new System.EventHandler(this.CBX_ReservasCliente_SelectedIndexChanged);
            // 
            // BTNCCtrlChkOutGenerar
            // 
            this.BTNCCtrlChkOutGenerar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTNCCtrlChkOutGenerar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BTNCCtrlChkOutGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCCtrlChkOutGenerar.Location = new System.Drawing.Point(861, 592);
            this.BTNCCtrlChkOutGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCCtrlChkOutGenerar.Name = "BTNCCtrlChkOutGenerar";
            this.BTNCCtrlChkOutGenerar.Size = new System.Drawing.Size(145, 33);
            this.BTNCCtrlChkOutGenerar.TabIndex = 55;
            this.BTNCCtrlChkOutGenerar.Tag = "";
            this.BTNCCtrlChkOutGenerar.Text = "Generar contrato";
            this.BTNCCtrlChkOutGenerar.UseVisualStyleBackColor = false;
            this.BTNCCtrlChkOutGenerar.Click += new System.EventHandler(this.BTNCCtrlChkOutGenerar_Click);
            // 
            // LBLTarifaDiaria
            // 
            this.LBLTarifaDiaria.AutoSize = true;
            this.LBLTarifaDiaria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLTarifaDiaria.Location = new System.Drawing.Point(702, 85);
            this.LBLTarifaDiaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTarifaDiaria.Name = "LBLTarifaDiaria";
            this.LBLTarifaDiaria.Size = new System.Drawing.Size(176, 17);
            this.LBLTarifaDiaria.TabIndex = 56;
            this.LBLTarifaDiaria.Text = "Tarifa diaria de categoría:";
            // 
            // LBLDiasEstimado
            // 
            this.LBLDiasEstimado.AutoSize = true;
            this.LBLDiasEstimado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDiasEstimado.Location = new System.Drawing.Point(702, 159);
            this.LBLDiasEstimado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDiasEstimado.Name = "LBLDiasEstimado";
            this.LBLDiasEstimado.Size = new System.Drawing.Size(109, 17);
            this.LBLDiasEstimado.TabIndex = 57;
            this.LBLDiasEstimado.Text = "Días estimados:";
            // 
            // LBLDATOSTarifaDiaria
            // 
            this.LBLDATOSTarifaDiaria.AutoSize = true;
            this.LBLDATOSTarifaDiaria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDATOSTarifaDiaria.Location = new System.Drawing.Point(702, 102);
            this.LBLDATOSTarifaDiaria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSTarifaDiaria.Name = "LBLDATOSTarifaDiaria";
            this.LBLDATOSTarifaDiaria.Size = new System.Drawing.Size(45, 17);
            this.LBLDATOSTarifaDiaria.TabIndex = 58;
            this.LBLDATOSTarifaDiaria.Text = "datos";
            // 
            // LBLDATOSDiasEstimado
            // 
            this.LBLDATOSDiasEstimado.AutoSize = true;
            this.LBLDATOSDiasEstimado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLDATOSDiasEstimado.Location = new System.Drawing.Point(702, 176);
            this.LBLDATOSDiasEstimado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLDATOSDiasEstimado.Name = "LBLDATOSDiasEstimado";
            this.LBLDATOSDiasEstimado.Size = new System.Drawing.Size(45, 17);
            this.LBLDATOSDiasEstimado.TabIndex = 59;
            this.LBLDATOSDiasEstimado.Text = "datos";
            // 
            // LBLMontoGarantia
            // 
            this.LBLMontoGarantia.AutoSize = true;
            this.LBLMontoGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLMontoGarantia.Location = new System.Drawing.Point(702, 229);
            this.LBLMontoGarantia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLMontoGarantia.Name = "LBLMontoGarantia";
            this.LBLMontoGarantia.Size = new System.Drawing.Size(197, 17);
            this.LBLMontoGarantia.TabIndex = 60;
            this.LBLMontoGarantia.Text = "Monto de garantia a retener:";
            // 
            // TXT_CtrlChkOutGarantia
            // 
            this.TXT_CtrlChkOutGarantia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutGarantia.Location = new System.Drawing.Point(705, 250);
            this.TXT_CtrlChkOutGarantia.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlChkOutGarantia.Name = "TXT_CtrlChkOutGarantia";
            this.TXT_CtrlChkOutGarantia.Size = new System.Drawing.Size(264, 23);
            this.TXT_CtrlChkOutGarantia.TabIndex = 61;
            // 
            // LBLObservaciones
            // 
            this.LBLObservaciones.AutoSize = true;
            this.LBLObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLObservaciones.Location = new System.Drawing.Point(698, 381);
            this.LBLObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLObservaciones.Name = "LBLObservaciones";
            this.LBLObservaciones.Size = new System.Drawing.Size(263, 17);
            this.LBLObservaciones.TabIndex = 62;
            this.LBLObservaciones.Text = "Observaciones del estado del vehiculo:";
            // 
            // TXT_CtrlChkOutObservaciones
            // 
            this.TXT_CtrlChkOutObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TXT_CtrlChkOutObservaciones.Location = new System.Drawing.Point(701, 402);
            this.TXT_CtrlChkOutObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_CtrlChkOutObservaciones.Multiline = true;
            this.TXT_CtrlChkOutObservaciones.Name = "TXT_CtrlChkOutObservaciones";
            this.TXT_CtrlChkOutObservaciones.Size = new System.Drawing.Size(268, 182);
            this.TXT_CtrlChkOutObservaciones.TabIndex = 63;
            // 
            // LBLMetodoPago
            // 
            this.LBLMetodoPago.AutoSize = true;
            this.LBLMetodoPago.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LBLMetodoPago.Location = new System.Drawing.Point(702, 301);
            this.LBLMetodoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.CBX_MetodoPago.Location = new System.Drawing.Point(705, 321);
            this.CBX_MetodoPago.Name = "CBX_MetodoPago";
            this.CBX_MetodoPago.Size = new System.Drawing.Size(264, 25);
            this.CBX_MetodoPago.TabIndex = 64;
            // 
            // FrmCTRLCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 638);
            this.Controls.Add(this.LBLMetodoPago);
            this.Controls.Add(this.CBX_MetodoPago);
            this.Controls.Add(this.TXT_CtrlChkOutObservaciones);
            this.Controls.Add(this.LBLObservaciones);
            this.Controls.Add(this.TXT_CtrlChkOutGarantia);
            this.Controls.Add(this.LBLMontoGarantia);
            this.Controls.Add(this.LBLDATOSDiasEstimado);
            this.Controls.Add(this.LBLDATOSTarifaDiaria);
            this.Controls.Add(this.LBLDiasEstimado);
            this.Controls.Add(this.LBLTarifaDiaria);
            this.Controls.Add(this.BTNCCtrlChkOutGenerar);
            this.Controls.Add(this.LBLreservasCliente);
            this.Controls.Add(this.CBX_ReservasCliente);
            this.Controls.Add(this.TXT_CtrlChkOutKmAct);
            this.Controls.Add(this.LBLkilometraje);
            this.Controls.Add(this.LBLvehiculos);
            this.Controls.Add(this.CBX_VehiculosDisponibles);
            this.Controls.Add(this.LBLDATOScategoria);
            this.Controls.Add(this.LBLDATOSDevolucion);
            this.Controls.Add(this.LBLDATOSRetiro);
            this.Controls.Add(this.LBLDATOSCliente);
            this.Controls.Add(this.LBLcategoriaSeleccionada);
            this.Controls.Add(this.LBLDevolucion);
            this.Controls.Add(this.LBLRetiro);
            this.Controls.Add(this.LBLCliente);
            this.Controls.Add(this.BTNCCtrlChkOutBuscar);
            this.Controls.Add(this.TXT_CtrlChkOutDNI);
            this.Controls.Add(this.LBLdniCliente);
            this.Controls.Add(this.BTNvolveralmenu);
            this.Controls.Add(this.LBLidiomas);
            this.Controls.Add(this.CBXidiomas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCTRLCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCTRLCheckOut";
            this.Load += new System.EventHandler(this.FrmCTRLCheckOut_Load);
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
    }
}