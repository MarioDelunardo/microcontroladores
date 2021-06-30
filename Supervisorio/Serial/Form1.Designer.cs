namespace Serial
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.labelSelecPorta = new System.Windows.Forms.Label();
            this.groupBoxComSerial = new System.Windows.Forms.GroupBox();
            this.labelSaidaDados = new System.Windows.Forms.Label();
            this.labelEntradaDados = new System.Windows.Forms.Label();
            this.labelMed6 = new System.Windows.Forms.Label();
            this.labelMed5 = new System.Windows.Forms.Label();
            this.labelMed1 = new System.Windows.Forms.Label();
            this.labelMed4 = new System.Windows.Forms.Label();
            this.labelMed2 = new System.Windows.Forms.Label();
            this.labelMed3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArquivotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjudaStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGauge1 = new AGauge.AGauge();
            this.aGauge2 = new AGauge.AGauge();
            this.labelGauge2 = new System.Windows.Forms.Label();
            this.labelGauge1 = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.groupBoxMedicoes = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMed14 = new System.Windows.Forms.Label();
            this.labelMed13 = new System.Windows.Forms.Label();
            this.labelMed8 = new System.Windows.Forms.Label();
            this.labelMed12 = new System.Windows.Forms.Label();
            this.labelMed9 = new System.Windows.Forms.Label();
            this.labelMed11 = new System.Windows.Forms.Label();
            this.MedicoesTextBox = new System.Windows.Forms.RichTextBox();
            this.labelMed10 = new System.Windows.Forms.Label();
            this.labelMed7 = new System.Windows.Forms.Label();
            this.groupBoxTemperaturas = new System.Windows.Forms.GroupBox();
            this.GroupBoxGraficos = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonnvCXI = new System.Windows.Forms.Button();
            this.buttonnvCXS = new System.Windows.Forms.Button();
            this.buttonBomba = new System.Windows.Forms.Button();
            this.buttonModo = new System.Windows.Forms.Button();
            this.labelnvCXI = new System.Windows.Forms.Label();
            this.labelnvCXS = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelModo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.aChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageComunic = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageMed = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSensor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerChart1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxComSerial.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMedicoes.SuspendLayout();
            this.groupBoxTemperaturas.SuspendLayout();
            this.GroupBoxGraficos.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aChart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageComunic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageMed.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(6, 72);
            this.textBoxEntrada.Multiline = true;
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(619, 195);
            this.textBoxEntrada.TabIndex = 1;
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Location = new System.Drawing.Point(7, 296);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.Size = new System.Drawing.Size(344, 34);
            this.textBoxSaida.TabIndex = 2;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(558, 268);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(67, 23);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Location = new System.Drawing.Point(357, 307);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 4;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(202, 24);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 8;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelSelecPorta
            // 
            this.labelSelecPorta.AutoSize = true;
            this.labelSelecPorta.Location = new System.Drawing.Point(8, 28);
            this.labelSelecPorta.Name = "labelSelecPorta";
            this.labelSelecPorta.Size = new System.Drawing.Size(93, 13);
            this.labelSelecPorta.TabIndex = 10;
            this.labelSelecPorta.Text = "Selecione a porta:";
            // 
            // groupBoxComSerial
            // 
            this.groupBoxComSerial.Controls.Add(this.labelSaidaDados);
            this.groupBoxComSerial.Controls.Add(this.labelEntradaDados);
            this.groupBoxComSerial.Controls.Add(this.labelSelecPorta);
            this.groupBoxComSerial.Controls.Add(this.comboBox1);
            this.groupBoxComSerial.Controls.Add(this.buttonAtualizar);
            this.groupBoxComSerial.Controls.Add(this.textBoxEntrada);
            this.groupBoxComSerial.Controls.Add(this.buttonLimpar);
            this.groupBoxComSerial.Controls.Add(this.textBoxSaida);
            this.groupBoxComSerial.Controls.Add(this.buttonEnviar);
            this.groupBoxComSerial.Location = new System.Drawing.Point(8, 6);
            this.groupBoxComSerial.Name = "groupBoxComSerial";
            this.groupBoxComSerial.Size = new System.Drawing.Size(631, 341);
            this.groupBoxComSerial.TabIndex = 11;
            this.groupBoxComSerial.TabStop = false;
            this.groupBoxComSerial.Text = "Comunicação Serial";
            // 
            // labelSaidaDados
            // 
            this.labelSaidaDados.AutoSize = true;
            this.labelSaidaDados.Location = new System.Drawing.Point(6, 277);
            this.labelSaidaDados.Name = "labelSaidaDados";
            this.labelSaidaDados.Size = new System.Drawing.Size(88, 13);
            this.labelSaidaDados.TabIndex = 12;
            this.labelSaidaDados.Text = "Saída de Dados:";
            // 
            // labelEntradaDados
            // 
            this.labelEntradaDados.AutoSize = true;
            this.labelEntradaDados.Location = new System.Drawing.Point(6, 56);
            this.labelEntradaDados.Name = "labelEntradaDados";
            this.labelEntradaDados.Size = new System.Drawing.Size(96, 13);
            this.labelEntradaDados.TabIndex = 11;
            this.labelEntradaDados.Text = "Entrada de Dados:";
            // 
            // labelMed6
            // 
            this.labelMed6.AutoSize = true;
            this.labelMed6.Location = new System.Drawing.Point(163, 179);
            this.labelMed6.MaximumSize = new System.Drawing.Size(40, 13);
            this.labelMed6.Name = "labelMed6";
            this.labelMed6.Size = new System.Drawing.Size(13, 13);
            this.labelMed6.TabIndex = 29;
            this.labelMed6.Text = "0";
            // 
            // labelMed5
            // 
            this.labelMed5.AutoSize = true;
            this.labelMed5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed5.Location = new System.Drawing.Point(163, 153);
            this.labelMed5.MaximumSize = new System.Drawing.Size(32, 20);
            this.labelMed5.Name = "labelMed5";
            this.labelMed5.Size = new System.Drawing.Size(13, 13);
            this.labelMed5.TabIndex = 22;
            this.labelMed5.Text = "0";
            // 
            // labelMed1
            // 
            this.labelMed1.AutoSize = true;
            this.labelMed1.Location = new System.Drawing.Point(163, 49);
            this.labelMed1.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed1.Name = "labelMed1";
            this.labelMed1.Size = new System.Drawing.Size(13, 13);
            this.labelMed1.TabIndex = 18;
            this.labelMed1.Text = "0";
            // 
            // labelMed4
            // 
            this.labelMed4.AutoSize = true;
            this.labelMed4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed4.Location = new System.Drawing.Point(163, 127);
            this.labelMed4.MaximumSize = new System.Drawing.Size(32, 20);
            this.labelMed4.Name = "labelMed4";
            this.labelMed4.Size = new System.Drawing.Size(13, 13);
            this.labelMed4.TabIndex = 21;
            this.labelMed4.Text = "0";
            // 
            // labelMed2
            // 
            this.labelMed2.AutoSize = true;
            this.labelMed2.Location = new System.Drawing.Point(163, 75);
            this.labelMed2.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed2.Name = "labelMed2";
            this.labelMed2.Size = new System.Drawing.Size(13, 13);
            this.labelMed2.TabIndex = 19;
            this.labelMed2.Text = "0";
            // 
            // labelMed3
            // 
            this.labelMed3.AutoSize = true;
            this.labelMed3.Location = new System.Drawing.Point(163, 101);
            this.labelMed3.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed3.Name = "labelMed3";
            this.labelMed3.Size = new System.Drawing.Size(13, 13);
            this.labelMed3.TabIndex = 20;
            this.labelMed3.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(75, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Cx Sup";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArquivotoolStripMenuItem,
            this.AjudaStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArquivotoolStripMenuItem
            // 
            this.ArquivotoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ArquivotoolStripMenuItem.Name = "ArquivotoolStripMenuItem";
            this.ArquivotoolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ArquivotoolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // AjudaStripMenuItem
            // 
            this.AjudaStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.AjudaStripMenuItem.Name = "AjudaStripMenuItem";
            this.AjudaStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.AjudaStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.Window;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 180;
            this.aGauge1.BaseArcSweep = 180;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(100, 100);
            this.aGauge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge1.Location = new System.Drawing.Point(19, 21);
            this.aGauge1.MaxValue = 100F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Red;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.Red;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 100F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Turquoise,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        90F,
        100F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        90F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 90F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(207, 113);
            this.aGauge1.TabIndex = 14;
            this.aGauge1.Text = "\\";
            this.aGauge1.Value = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.SystemColors.Window;
            this.aGauge2.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 180;
            this.aGauge2.BaseArcSweep = 180;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(1));
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "";
            this.aGauge2.Center = new System.Drawing.Point(100, 100);
            this.aGauge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge2.Location = new System.Drawing.Point(19, 177);
            this.aGauge2.MaxValue = 100F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Red;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(0));
            this.aGauge2.RangeColor = System.Drawing.Color.Turquoise;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 90F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Turquoise,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        90F,
        100F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        90F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 0F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(207, 113);
            this.aGauge2.TabIndex = 15;
            this.aGauge2.Text = "aGauge2";
            this.aGauge2.Value = 0F;
            // 
            // labelGauge2
            // 
            this.labelGauge2.AutoSize = true;
            this.labelGauge2.Location = new System.Drawing.Point(85, 290);
            this.labelGauge2.Name = "labelGauge2";
            this.labelGauge2.Size = new System.Drawing.Size(68, 13);
            this.labelGauge2.TabIndex = 16;
            this.labelGauge2.Text = "Caixa Inferior";
            // 
            // labelGauge1
            // 
            this.labelGauge1.AutoSize = true;
            this.labelGauge1.Location = new System.Drawing.Point(85, 137);
            this.labelGauge1.Name = "labelGauge1";
            this.labelGauge1.Size = new System.Drawing.Size(75, 13);
            this.labelGauge1.TabIndex = 17;
            this.labelGauge1.Text = "Caixa Superior";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(818, 594);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 19;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(908, 594);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 20;
            this.buttonFinalizar.Text = "Limpar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // groupBoxMedicoes
            // 
            this.groupBoxMedicoes.Controls.Add(this.label9);
            this.groupBoxMedicoes.Controls.Add(this.labelMed14);
            this.groupBoxMedicoes.Controls.Add(this.labelMed13);
            this.groupBoxMedicoes.Controls.Add(this.labelMed8);
            this.groupBoxMedicoes.Controls.Add(this.labelMed12);
            this.groupBoxMedicoes.Controls.Add(this.labelMed9);
            this.groupBoxMedicoes.Controls.Add(this.labelMed11);
            this.groupBoxMedicoes.Controls.Add(this.MedicoesTextBox);
            this.groupBoxMedicoes.Controls.Add(this.labelMed10);
            this.groupBoxMedicoes.Controls.Add(this.labelMed7);
            this.groupBoxMedicoes.Controls.Add(this.labelMed6);
            this.groupBoxMedicoes.Controls.Add(this.labelMed1);
            this.groupBoxMedicoes.Controls.Add(this.label18);
            this.groupBoxMedicoes.Controls.Add(this.labelMed5);
            this.groupBoxMedicoes.Controls.Add(this.labelMed2);
            this.groupBoxMedicoes.Controls.Add(this.labelMed4);
            this.groupBoxMedicoes.Controls.Add(this.labelMed3);
            this.groupBoxMedicoes.Location = new System.Drawing.Point(273, 304);
            this.groupBoxMedicoes.Name = "groupBoxMedicoes";
            this.groupBoxMedicoes.Size = new System.Drawing.Size(202, 318);
            this.groupBoxMedicoes.TabIndex = 56;
            this.groupBoxMedicoes.TabStop = false;
            this.groupBoxMedicoes.Text = "Histórico de Medições";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cx Inf";
            // 
            // labelMed14
            // 
            this.labelMed14.AutoSize = true;
            this.labelMed14.Location = new System.Drawing.Point(103, 205);
            this.labelMed14.MaximumSize = new System.Drawing.Size(40, 13);
            this.labelMed14.Name = "labelMed14";
            this.labelMed14.Size = new System.Drawing.Size(13, 13);
            this.labelMed14.TabIndex = 42;
            this.labelMed14.Text = "0";
            // 
            // labelMed13
            // 
            this.labelMed13.AutoSize = true;
            this.labelMed13.Location = new System.Drawing.Point(103, 179);
            this.labelMed13.MaximumSize = new System.Drawing.Size(40, 13);
            this.labelMed13.Name = "labelMed13";
            this.labelMed13.Size = new System.Drawing.Size(13, 13);
            this.labelMed13.TabIndex = 41;
            this.labelMed13.Text = "0";
            // 
            // labelMed8
            // 
            this.labelMed8.AutoSize = true;
            this.labelMed8.Location = new System.Drawing.Point(103, 49);
            this.labelMed8.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed8.Name = "labelMed8";
            this.labelMed8.Size = new System.Drawing.Size(13, 13);
            this.labelMed8.TabIndex = 36;
            this.labelMed8.Text = "0";
            // 
            // labelMed12
            // 
            this.labelMed12.AutoSize = true;
            this.labelMed12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed12.Location = new System.Drawing.Point(103, 153);
            this.labelMed12.MaximumSize = new System.Drawing.Size(32, 20);
            this.labelMed12.Name = "labelMed12";
            this.labelMed12.Size = new System.Drawing.Size(13, 13);
            this.labelMed12.TabIndex = 40;
            this.labelMed12.Text = "0";
            // 
            // labelMed9
            // 
            this.labelMed9.AutoSize = true;
            this.labelMed9.Location = new System.Drawing.Point(103, 75);
            this.labelMed9.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed9.Name = "labelMed9";
            this.labelMed9.Size = new System.Drawing.Size(13, 13);
            this.labelMed9.TabIndex = 37;
            this.labelMed9.Text = "0";
            // 
            // labelMed11
            // 
            this.labelMed11.AutoSize = true;
            this.labelMed11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMed11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMed11.Location = new System.Drawing.Point(103, 127);
            this.labelMed11.MaximumSize = new System.Drawing.Size(32, 20);
            this.labelMed11.Name = "labelMed11";
            this.labelMed11.Size = new System.Drawing.Size(13, 13);
            this.labelMed11.TabIndex = 39;
            this.labelMed11.Text = "0";
            // 
            // MedicoesTextBox
            // 
            this.MedicoesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MedicoesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicoesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MedicoesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicoesTextBox.Location = new System.Drawing.Point(6, 49);
            this.MedicoesTextBox.Name = "MedicoesTextBox";
            this.MedicoesTextBox.ReadOnly = true;
            this.MedicoesTextBox.Size = new System.Drawing.Size(74, 187);
            this.MedicoesTextBox.TabIndex = 22;
            this.MedicoesTextBox.Text = "Medição 1:\n\nMedição 2:\n\nMedição 3:\n\nMedição 4:\n\nMedição 5:\n\nMedição 6:\n\nMedição 7" +
    ":";
            // 
            // labelMed10
            // 
            this.labelMed10.AutoSize = true;
            this.labelMed10.Location = new System.Drawing.Point(103, 101);
            this.labelMed10.MaximumSize = new System.Drawing.Size(28, 13);
            this.labelMed10.Name = "labelMed10";
            this.labelMed10.Size = new System.Drawing.Size(13, 13);
            this.labelMed10.TabIndex = 38;
            this.labelMed10.Text = "0";
            // 
            // labelMed7
            // 
            this.labelMed7.AutoSize = true;
            this.labelMed7.Location = new System.Drawing.Point(163, 205);
            this.labelMed7.MaximumSize = new System.Drawing.Size(40, 13);
            this.labelMed7.Name = "labelMed7";
            this.labelMed7.Size = new System.Drawing.Size(13, 13);
            this.labelMed7.TabIndex = 35;
            this.labelMed7.Text = "0";
            // 
            // groupBoxTemperaturas
            // 
            this.groupBoxTemperaturas.Controls.Add(this.labelGauge1);
            this.groupBoxTemperaturas.Controls.Add(this.aGauge1);
            this.groupBoxTemperaturas.Controls.Add(this.aGauge2);
            this.groupBoxTemperaturas.Controls.Add(this.labelGauge2);
            this.groupBoxTemperaturas.Location = new System.Drawing.Point(6, 304);
            this.groupBoxTemperaturas.Name = "groupBoxTemperaturas";
            this.groupBoxTemperaturas.Size = new System.Drawing.Size(261, 318);
            this.groupBoxTemperaturas.TabIndex = 58;
            this.groupBoxTemperaturas.TabStop = false;
            this.groupBoxTemperaturas.Text = "Níveis";
            // 
            // GroupBoxGraficos
            // 
            this.GroupBoxGraficos.Controls.Add(this.groupBox6);
            this.GroupBoxGraficos.Controls.Add(this.label15);
            this.GroupBoxGraficos.Controls.Add(this.label14);
            this.GroupBoxGraficos.Controls.Add(this.groupBoxTemperaturas);
            this.GroupBoxGraficos.Controls.Add(this.aChart2);
            this.GroupBoxGraficos.Controls.Add(this.groupBoxMedicoes);
            this.GroupBoxGraficos.Controls.Add(this.aChart1);
            this.GroupBoxGraficos.Controls.Add(this.buttonIniciar);
            this.GroupBoxGraficos.Controls.Add(this.buttonFinalizar);
            this.GroupBoxGraficos.Location = new System.Drawing.Point(3, 6);
            this.GroupBoxGraficos.Name = "GroupBoxGraficos";
            this.GroupBoxGraficos.Size = new System.Drawing.Size(989, 627);
            this.GroupBoxGraficos.TabIndex = 59;
            this.GroupBoxGraficos.TabStop = false;
            this.GroupBoxGraficos.Text = "Home";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonnvCXI);
            this.groupBox6.Controls.Add(this.buttonnvCXS);
            this.groupBox6.Controls.Add(this.buttonBomba);
            this.groupBox6.Controls.Add(this.buttonModo);
            this.groupBox6.Controls.Add(this.labelnvCXI);
            this.groupBox6.Controls.Add(this.labelnvCXS);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.labelEstado);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.labelModo);
            this.groupBox6.Location = new System.Drawing.Point(481, 304);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(502, 284);
            this.groupBox6.TabIndex = 62;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Comandos";
            // 
            // buttonnvCXI
            // 
            this.buttonnvCXI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnvCXI.Location = new System.Drawing.Point(316, 216);
            this.buttonnvCXI.Name = "buttonnvCXI";
            this.buttonnvCXI.Size = new System.Drawing.Size(145, 49);
            this.buttonnvCXI.TabIndex = 11;
            this.buttonnvCXI.Text = "Aumentar +10%";
            this.buttonnvCXI.UseVisualStyleBackColor = true;
            this.buttonnvCXI.Click += new System.EventHandler(this.buttonnvCXI_Click);
            // 
            // buttonnvCXS
            // 
            this.buttonnvCXS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnvCXS.Location = new System.Drawing.Point(316, 75);
            this.buttonnvCXS.Name = "buttonnvCXS";
            this.buttonnvCXS.Size = new System.Drawing.Size(145, 49);
            this.buttonnvCXS.TabIndex = 10;
            this.buttonnvCXS.Text = "Aumentar +10%";
            this.buttonnvCXS.UseVisualStyleBackColor = true;
            this.buttonnvCXS.Click += new System.EventHandler(this.buttonnvCXS_Click);
            // 
            // buttonBomba
            // 
            this.buttonBomba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBomba.Location = new System.Drawing.Point(10, 216);
            this.buttonBomba.Name = "buttonBomba";
            this.buttonBomba.Size = new System.Drawing.Size(145, 49);
            this.buttonBomba.TabIndex = 9;
            this.buttonBomba.Text = "Ligar / Desligar";
            this.buttonBomba.UseVisualStyleBackColor = true;
            this.buttonBomba.Click += new System.EventHandler(this.buttonBomba_Click);
            // 
            // buttonModo
            // 
            this.buttonModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModo.Location = new System.Drawing.Point(10, 75);
            this.buttonModo.Name = "buttonModo";
            this.buttonModo.Size = new System.Drawing.Size(145, 49);
            this.buttonModo.TabIndex = 8;
            this.buttonModo.Text = "Alterar Modo\r\nde Operação";
            this.buttonModo.UseVisualStyleBackColor = true;
            this.buttonModo.Click += new System.EventHandler(this.buttonModo_Click);
            // 
            // labelnvCXI
            // 
            this.labelnvCXI.AutoSize = true;
            this.labelnvCXI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvCXI.Location = new System.Drawing.Point(437, 163);
            this.labelnvCXI.Name = "labelnvCXI";
            this.labelnvCXI.Size = new System.Drawing.Size(45, 20);
            this.labelnvCXI.TabIndex = 7;
            this.labelnvCXI.Text = "0000";
            // 
            // labelnvCXS
            // 
            this.labelnvCXS.AutoSize = true;
            this.labelnvCXS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvCXS.Location = new System.Drawing.Point(437, 21);
            this.labelnvCXS.Name = "labelnvCXS";
            this.labelnvCXS.Size = new System.Drawing.Size(45, 20);
            this.labelnvCXS.TabIndex = 6;
            this.labelnvCXS.Text = "0000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(312, 163);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 40);
            this.label20.TabIndex = 5;
            this.label20.Text = "Nível Máximo\r\nCx. Inf.:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(312, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 40);
            this.label19.TabIndex = 4;
            this.label19.Text = "Nível Máximo\r\nCx. Sup.:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(161, 163);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(45, 20);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Estado da Bomba:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Modo de Operação:";
            // 
            // labelModo
            // 
            this.labelModo.AutoSize = true;
            this.labelModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModo.Location = new System.Drawing.Point(161, 21);
            this.labelModo.Name = "labelModo";
            this.labelModo.Size = new System.Drawing.Size(45, 20);
            this.labelModo.TabIndex = 0;
            this.labelModo.Text = "0000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(567, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "Nível - Caixa Inferior";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(66, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Nível - Caixa Superior";
            // 
            // aChart2
            // 
            chartArea5.AxisY.Maximum = 100D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.aChart2.ChartAreas.Add(chartArea5);
            legend5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.aChart2.Legends.Add(legend5);
            this.aChart2.Location = new System.Drawing.Point(502, 19);
            this.aChart2.Name = "aChart2";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Nível - Caixa Inferior";
            series5.YValuesPerPoint = 2;
            this.aChart2.Series.Add(series5);
            this.aChart2.Size = new System.Drawing.Size(481, 284);
            this.aChart2.TabIndex = 22;
            this.aChart2.Text = "chart1";
            // 
            // aChart1
            // 
            chartArea6.AxisY.Maximum = 100D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.Name = "ChartArea1";
            this.aChart1.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.aChart1.Legends.Add(legend6);
            this.aChart1.Location = new System.Drawing.Point(6, 19);
            this.aChart1.Name = "aChart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Legend = "Legend1";
            series6.Name = "Nível - Caixa Superior";
            this.aChart1.Series.Add(series6);
            this.aChart1.Size = new System.Drawing.Size(481, 284);
            this.aChart1.TabIndex = 21;
            this.aChart1.Text = "aChart";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageComunic);
            this.tabControl1.Controls.Add(this.tabPageMed);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 665);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPageComunic
            // 
            this.tabPageComunic.Controls.Add(this.groupBox1);
            this.tabPageComunic.Controls.Add(this.groupBoxComSerial);
            this.tabPageComunic.Location = new System.Drawing.Point(4, 22);
            this.tabPageComunic.Name = "tabPageComunic";
            this.tabPageComunic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComunic.Size = new System.Drawing.Size(998, 639);
            this.tabPageComunic.TabIndex = 0;
            this.tabPageComunic.Text = "Comunicação";
            this.tabPageComunic.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(645, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 341);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplo de Recepção de Dados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(15, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 68);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "0000";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Modo:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(15, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(140, 68);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ADC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "ADC1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "ADC0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "0000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(15, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 68);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nível Máximo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(103, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Caixa Inferior";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Caixa Superior";
            // 
            // tabPageMed
            // 
            this.tabPageMed.Controls.Add(this.GroupBoxGraficos);
            this.tabPageMed.Location = new System.Drawing.Point(4, 22);
            this.tabPageMed.Name = "tabPageMed";
            this.tabPageMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMed.Size = new System.Drawing.Size(998, 639);
            this.tabPageMed.TabIndex = 1;
            this.tabPageMed.Text = "Medições";
            this.tabPageMed.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewSensor);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 639);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Sensores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSensor
            // 
            this.dataGridViewSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridViewSensor.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewSensor.Name = "dataGridViewSensor";
            this.dataGridViewSensor.RowHeadersWidth = 62;
            this.dataGridViewSensor.Size = new System.Drawing.Size(952, 626);
            this.dataGridViewSensor.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medição 1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medição 2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Medição 3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Medição 4";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Medição 5";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Medição 6";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Medição 7";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Medição 8";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Medição 9";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // timerChart1
            // 
            this.timerChart1.Interval = 1000;
            this.timerChart1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1009, 705);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Supervisório Xbee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxComSerial.ResumeLayout(false);
            this.groupBoxComSerial.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMedicoes.ResumeLayout(false);
            this.groupBoxMedicoes.PerformLayout();
            this.groupBoxTemperaturas.ResumeLayout(false);
            this.groupBoxTemperaturas.PerformLayout();
            this.GroupBoxGraficos.ResumeLayout(false);
            this.GroupBoxGraficos.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aChart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageComunic.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageMed.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonEnviar;
        //private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonAtualizar;
        //private DadosSensoresDataSet dadosSensoresDataSet1;
        private System.Windows.Forms.Label labelSelecPorta;
        private System.Windows.Forms.GroupBox groupBoxComSerial;
        private System.Windows.Forms.Label labelSaidaDados;
        private System.Windows.Forms.Label labelEntradaDados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArquivotoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjudaStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label labelMed5;
        private System.Windows.Forms.Label labelMed4;
        private System.Windows.Forms.Label labelMed3;
        private System.Windows.Forms.Label labelMed2;
        private System.Windows.Forms.Label labelMed1;
        private System.Windows.Forms.Label labelMed6;
        private System.Windows.Forms.Label label18;
        private AGauge.AGauge aGauge1;
        private AGauge.AGauge aGauge2;
        private System.Windows.Forms.Label labelGauge2;
        private System.Windows.Forms.Label labelGauge1;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.GroupBox groupBoxMedicoes;
        private System.Windows.Forms.GroupBox groupBoxTemperaturas;
        private System.Windows.Forms.GroupBox GroupBoxGraficos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageComunic;
        private System.Windows.Forms.TabPage tabPageMed;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMed7;
        private System.Windows.Forms.RichTextBox MedicoesTextBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart aChart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart aChart2;
        private System.Windows.Forms.Timer timerChart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMed14;
        private System.Windows.Forms.Label labelMed13;
        private System.Windows.Forms.Label labelMed8;
        private System.Windows.Forms.Label labelMed12;
        private System.Windows.Forms.Label labelMed9;
        private System.Windows.Forms.Label labelMed11;
        private System.Windows.Forms.Label labelMed10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonnvCXI;
        private System.Windows.Forms.Button buttonnvCXS;
        private System.Windows.Forms.Button buttonBomba;
        private System.Windows.Forms.Button buttonModo;
        private System.Windows.Forms.Label labelnvCXI;
        private System.Windows.Forms.Label labelnvCXS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelModo;
    }
}

