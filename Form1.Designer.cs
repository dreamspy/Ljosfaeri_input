namespace input
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
            this.buttonRunProcess = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.writeToFileBox = new System.Windows.Forms.NumericUpDown();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.periodsBox = new System.Windows.Forms.NumericUpDown();
            this.buffersBox = new System.Windows.Forms.NumericUpDown();
            this.fftBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.bootBox = new System.Windows.Forms.NumericUpDown();
            this.commBox = new System.Windows.Forms.NumericUpDown();
            this.wavelengthBox = new System.Windows.Forms.NumericUpDown();
            this.slotBox = new System.Windows.Forms.NumericUpDown();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.textAzi = new System.Windows.Forms.TextBox();
            this.textEll = new System.Windows.Forms.TextBox();
            this.textEllNorm = new System.Windows.Forms.TextBox();
            this.textAziNorm = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textEllMax = new System.Windows.Forms.TextBox();
            this.textAziMax = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textEllMin = new System.Windows.Forms.TextBox();
            this.textAziMin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.y_divBox = new System.Windows.Forms.NumericUpDown();
            this.x_divBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.writeToFileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buffersBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavelengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_divBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_divBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRunProcess
            // 
            this.buttonRunProcess.Location = new System.Drawing.Point(12, 12);
            this.buttonRunProcess.Name = "buttonRunProcess";
            this.buttonRunProcess.Size = new System.Drawing.Size(107, 23);
            this.buttonRunProcess.TabIndex = 0;
            this.buttonRunProcess.Text = "Run Process";
            this.buttonRunProcess.UseVisualStyleBackColor = true;
            this.buttonRunProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(78, 44);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(454, 20);
            this.textBoxFile.TabIndex = 1;
            this.textBoxFile.Text = "../../../SingleMeas/Debug/SingleMeas.exe";
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 479);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(726, 189);
            this.textBoxOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Program";
            // 
            // textBoxArgs
            // 
            this.textBoxArgs.Location = new System.Drawing.Point(78, 76);
            this.textBoxArgs.Name = "textBoxArgs";
            this.textBoxArgs.ReadOnly = true;
            this.textBoxArgs.Size = new System.Drawing.Size(454, 20);
            this.textBoxArgs.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arguments";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // writeToFileBox
            // 
            this.writeToFileBox.AccessibleName = "writeToFileBox";
            this.writeToFileBox.Location = new System.Drawing.Point(357, 4);
            this.writeToFileBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.writeToFileBox.Name = "writeToFileBox";
            this.writeToFileBox.Size = new System.Drawing.Size(72, 20);
            this.writeToFileBox.TabIndex = 8;
            this.writeToFileBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.writeToFileBox.ValueChanged += new System.EventHandler(this.numArg1_ValueChanged);
            // 
            // speedBox
            // 
            this.speedBox.AccessibleName = "speedBox";
            this.speedBox.Location = new System.Drawing.Point(355, 63);
            this.speedBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(72, 20);
            this.speedBox.TabIndex = 10;
            this.speedBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.speedBox.ValueChanged += new System.EventHandler(this.numArg3_ValueChanged);
            // 
            // periodsBox
            // 
            this.periodsBox.AccessibleName = "periodsBox";
            this.periodsBox.Location = new System.Drawing.Point(356, 94);
            this.periodsBox.Name = "periodsBox";
            this.periodsBox.Size = new System.Drawing.Size(72, 20);
            this.periodsBox.TabIndex = 11;
            this.periodsBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.periodsBox.ValueChanged += new System.EventHandler(this.numArg4_ValueChanged);
            // 
            // buffersBox
            // 
            this.buffersBox.AccessibleName = "buffersBox";
            this.buffersBox.Location = new System.Drawing.Point(354, 123);
            this.buffersBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.buffersBox.Name = "buffersBox";
            this.buffersBox.Size = new System.Drawing.Size(72, 20);
            this.buffersBox.TabIndex = 12;
            this.buffersBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.buffersBox.ValueChanged += new System.EventHandler(this.numArg5_ValueChanged);
            // 
            // fftBox
            // 
            this.fftBox.AccessibleName = "fftBox";
            this.fftBox.Location = new System.Drawing.Point(353, 153);
            this.fftBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fftBox.Name = "fftBox";
            this.fftBox.Size = new System.Drawing.Size(72, 20);
            this.fftBox.TabIndex = 13;
            this.fftBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.fftBox.ValueChanged += new System.EventHandler(this.numArg6_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "WAVELENGTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "BASIC_MEAS_SPEED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "PERIODS_PER_BUFFER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "BUFFERS_PER_FFT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "FFT_PER_RESULT";
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.AutoSize = true;
            this.checkBoxRestart.Location = new System.Drawing.Point(18, 102);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(140, 17);
            this.checkBoxRestart.TabIndex = 20;
            this.checkBoxRestart.Text = "Restart process if it exits";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            // 
            // bootBox
            // 
            this.bootBox.AccessibleName = "bootBox";
            this.bootBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.bootBox.Location = new System.Drawing.Point(124, 153);
            this.bootBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bootBox.Name = "bootBox";
            this.bootBox.Size = new System.Drawing.Size(72, 20);
            this.bootBox.TabIndex = 21;
            this.bootBox.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.bootBox.ValueChanged += new System.EventHandler(this.bootBox_ValueChanged);
            // 
            // commBox
            // 
            this.commBox.AccessibleName = "commBox";
            this.commBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.commBox.Location = new System.Drawing.Point(124, 123);
            this.commBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.commBox.Name = "commBox";
            this.commBox.Size = new System.Drawing.Size(72, 20);
            this.commBox.TabIndex = 22;
            this.commBox.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.commBox.ValueChanged += new System.EventHandler(this.commBox_ValueChanged);
            // 
            // wavelengthBox
            // 
            this.wavelengthBox.AccessibleName = "wavelengthBox";
            this.wavelengthBox.Location = new System.Drawing.Point(124, 94);
            this.wavelengthBox.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.wavelengthBox.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.wavelengthBox.Name = "wavelengthBox";
            this.wavelengthBox.Size = new System.Drawing.Size(72, 20);
            this.wavelengthBox.TabIndex = 23;
            this.wavelengthBox.Value = new decimal(new int[] {
            1570,
            0,
            0,
            0});
            this.wavelengthBox.ValueChanged += new System.EventHandler(this.wavelengthBox_ValueChanged);
            // 
            // slotBox
            // 
            this.slotBox.AccessibleName = "slotBox";
            this.slotBox.Location = new System.Drawing.Point(124, 63);
            this.slotBox.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.slotBox.Name = "slotBox";
            this.slotBox.Size = new System.Drawing.Size(72, 20);
            this.slotBox.TabIndex = 24;
            this.slotBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.slotBox.ValueChanged += new System.EventHandler(this.slotBox_ValueChanged);
            // 
            // portBox
            // 
            this.portBox.AccessibleName = "portBox";
            this.portBox.Location = new System.Drawing.Point(124, 34);
            this.portBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.portBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(72, 20);
            this.portBox.TabIndex = 25;
            this.portBox.Value = new decimal(new int[] {
            2402,
            0,
            0,
            0});
            this.portBox.ValueChanged += new System.EventHandler(this.portBox_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "IP_ADDRESS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "PORT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "SLOT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "COMM TIMEOUT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "BOOT TIMEOUT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(258, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "WRITE TO FILE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "FILENAME";
            // 
            // IPBox
            // 
            this.IPBox.AccessibleName = "IPBox";
            this.IPBox.Location = new System.Drawing.Point(124, 4);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(72, 20);
            this.IPBox.TabIndex = 34;
            this.IPBox.Text = "localhost";
            // 
            // fileNameBox
            // 
            this.fileNameBox.AccessibleName = "fileNameBox";
            this.fileNameBox.Location = new System.Drawing.Point(356, 34);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(72, 20);
            this.fileNameBox.TabIndex = 35;
            this.fileNameBox.Text = "output.txt";
            this.fileNameBox.TextChanged += new System.EventHandler(this.fileNameBox_TextChanged);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(403, 375);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(100, 20);
            this.textBoxCounter.TabIndex = 37;
            // 
            // textAzi
            // 
            this.textAzi.Location = new System.Drawing.Point(115, 375);
            this.textAzi.Name = "textAzi";
            this.textAzi.ReadOnly = true;
            this.textAzi.Size = new System.Drawing.Size(100, 20);
            this.textAzi.TabIndex = 40;
            // 
            // textEll
            // 
            this.textEll.Location = new System.Drawing.Point(250, 375);
            this.textEll.Name = "textEll";
            this.textEll.ReadOnly = true;
            this.textEll.Size = new System.Drawing.Size(100, 20);
            this.textEll.TabIndex = 41;
            // 
            // textEllNorm
            // 
            this.textEllNorm.Location = new System.Drawing.Point(250, 401);
            this.textEllNorm.Name = "textEllNorm";
            this.textEllNorm.ReadOnly = true;
            this.textEllNorm.Size = new System.Drawing.Size(100, 20);
            this.textEllNorm.TabIndex = 43;
            // 
            // textAziNorm
            // 
            this.textAziNorm.Location = new System.Drawing.Point(115, 401);
            this.textAziNorm.Name = "textAziNorm";
            this.textAziNorm.ReadOnly = true;
            this.textAziNorm.Size = new System.Drawing.Size(100, 20);
            this.textAziNorm.TabIndex = 42;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(135, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "AZIMUTH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 350);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "ELLIPTICAL";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 382);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "ANGLE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "NORMALIZED";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(405, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "MEASUREMENTS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 434);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 51;
            this.label20.Text = "MAXIMUM";
            // 
            // textEllMax
            // 
            this.textEllMax.Location = new System.Drawing.Point(251, 427);
            this.textEllMax.Name = "textEllMax";
            this.textEllMax.ReadOnly = true;
            this.textEllMax.Size = new System.Drawing.Size(100, 20);
            this.textEllMax.TabIndex = 50;
            // 
            // textAziMax
            // 
            this.textAziMax.Location = new System.Drawing.Point(116, 427);
            this.textAziMax.Name = "textAziMax";
            this.textAziMax.ReadOnly = true;
            this.textAziMax.Size = new System.Drawing.Size(100, 20);
            this.textAziMax.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 460);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "MINIMUM";
            // 
            // textEllMin
            // 
            this.textEllMin.Location = new System.Drawing.Point(251, 453);
            this.textEllMin.Name = "textEllMin";
            this.textEllMin.ReadOnly = true;
            this.textEllMin.Size = new System.Drawing.Size(100, 20);
            this.textEllMin.TabIndex = 53;
            // 
            // textAziMin
            // 
            this.textAziMin.Location = new System.Drawing.Point(116, 453);
            this.textAziMin.Name = "textAziMin";
            this.textAziMin.ReadOnly = true;
            this.textAziMin.Size = new System.Drawing.Size(100, 20);
            this.textAziMin.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fileNameBox);
            this.panel1.Controls.Add(this.IPBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.portBox);
            this.panel1.Controls.Add(this.slotBox);
            this.panel1.Controls.Add(this.wavelengthBox);
            this.panel1.Controls.Add(this.commBox);
            this.panel1.Controls.Add(this.bootBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fftBox);
            this.panel1.Controls.Add(this.buffersBox);
            this.panel1.Controls.Add(this.periodsBox);
            this.panel1.Controls.Add(this.speedBox);
            this.panel1.Controls.Add(this.writeToFileBox);
            this.panel1.Location = new System.Drawing.Point(19, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 191);
            this.panel1.TabIndex = 55;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 13);
            this.label22.TabIndex = 56;
            this.label22.Text = "Process Parameters";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(494, 183);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "Y divisions";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(494, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "X divisions";
            // 
            // y_divBox
            // 
            this.y_divBox.AccessibleName = "periodsBox";
            this.y_divBox.Location = new System.Drawing.Point(563, 179);
            this.y_divBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.y_divBox.Name = "y_divBox";
            this.y_divBox.Size = new System.Drawing.Size(72, 20);
            this.y_divBox.TabIndex = 37;
            this.y_divBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // x_divBox
            // 
            this.x_divBox.AccessibleName = "speedBox";
            this.x_divBox.Location = new System.Drawing.Point(562, 148);
            this.x_divBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x_divBox.Name = "x_divBox";
            this.x_divBox.Size = new System.Drawing.Size(72, 20);
            this.x_divBox.TabIndex = 36;
            this.x_divBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 699);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.y_divBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.x_divBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textEllMin);
            this.Controls.Add(this.textAziMin);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textEllMax);
            this.Controls.Add(this.textAziMax);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textEllNorm);
            this.Controls.Add(this.textAziNorm);
            this.Controls.Add(this.textEll);
            this.Controls.Add(this.textAzi);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonRunProcess);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Ljósfæri (c# demo)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.writeToFileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buffersBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bootBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wavelengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y_divBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_divBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRunProcess;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown writeToFileBox;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.NumericUpDown periodsBox;
        private System.Windows.Forms.NumericUpDown buffersBox;
        private System.Windows.Forms.NumericUpDown fftBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxRestart;
        private System.Windows.Forms.NumericUpDown bootBox;
        private System.Windows.Forms.NumericUpDown commBox;
        private System.Windows.Forms.NumericUpDown wavelengthBox;
        private System.Windows.Forms.NumericUpDown slotBox;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.TextBox textAzi;
        private System.Windows.Forms.TextBox textEll;
        private System.Windows.Forms.TextBox textEllNorm;
        private System.Windows.Forms.TextBox textAziNorm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textEllMax;
        private System.Windows.Forms.TextBox textAziMax;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textEllMin;
        private System.Windows.Forms.TextBox textAziMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown y_divBox;
        private System.Windows.Forms.NumericUpDown x_divBox;
    }
}

