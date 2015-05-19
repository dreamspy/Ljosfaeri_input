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
            this.buttonRunProcess = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArgs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numArg1 = new System.Windows.Forms.NumericUpDown();
            this.numArg2 = new System.Windows.Forms.NumericUpDown();
            this.numArg3 = new System.Windows.Forms.NumericUpDown();
            this.numArg4 = new System.Windows.Forms.NumericUpDown();
            this.numArg5 = new System.Windows.Forms.NumericUpDown();
            this.numArg6 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numArg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg6)).BeginInit();
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
            this.textBoxFile.Size = new System.Drawing.Size(205, 20);
            this.textBoxFile.TabIndex = 1;
            this.textBoxFile.Text = "../../../output/Debug/output.exe";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 133);
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
            this.textBoxArgs.Size = new System.Drawing.Size(205, 20);
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
            // numArg1
            // 
            this.numArg1.Location = new System.Drawing.Point(440, 15);
            this.numArg1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numArg1.Name = "numArg1";
            this.numArg1.Size = new System.Drawing.Size(71, 20);
            this.numArg1.TabIndex = 8;
            this.numArg1.Value = new decimal(new int[] {
            633,
            0,
            0,
            0});
            this.numArg1.ValueChanged += new System.EventHandler(this.numArg1_ValueChanged);
            // 
            // numArg2
            // 
            this.numArg2.DecimalPlaces = 1;
            this.numArg2.Location = new System.Drawing.Point(439, 44);
            this.numArg2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numArg2.Name = "numArg2";
            this.numArg2.Size = new System.Drawing.Size(72, 20);
            this.numArg2.TabIndex = 9;
            this.numArg2.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numArg2.ValueChanged += new System.EventHandler(this.numArg2_ValueChanged);
            // 
            // numArg3
            // 
            this.numArg3.Location = new System.Drawing.Point(438, 74);
            this.numArg3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArg3.Name = "numArg3";
            this.numArg3.Size = new System.Drawing.Size(73, 20);
            this.numArg3.TabIndex = 10;
            this.numArg3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numArg3.ValueChanged += new System.EventHandler(this.numArg3_ValueChanged);
            // 
            // numArg4
            // 
            this.numArg4.Location = new System.Drawing.Point(666, 15);
            this.numArg4.Name = "numArg4";
            this.numArg4.Size = new System.Drawing.Size(72, 20);
            this.numArg4.TabIndex = 11;
            this.numArg4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArg4.ValueChanged += new System.EventHandler(this.numArg4_ValueChanged);
            // 
            // numArg5
            // 
            this.numArg5.Location = new System.Drawing.Point(664, 47);
            this.numArg5.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numArg5.Name = "numArg5";
            this.numArg5.Size = new System.Drawing.Size(74, 20);
            this.numArg5.TabIndex = 12;
            this.numArg5.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numArg5.ValueChanged += new System.EventHandler(this.numArg5_ValueChanged);
            // 
            // numArg6
            // 
            this.numArg6.Location = new System.Drawing.Point(663, 77);
            this.numArg6.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numArg6.Name = "numArg6";
            this.numArg6.Size = new System.Drawing.Size(75, 20);
            this.numArg6.TabIndex = 13;
            this.numArg6.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numArg6.ValueChanged += new System.EventHandler(this.numArg6_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DEF_WAVELENGTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "BASIC_MEAS_SPEED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "PERIODS_PER_BUFFER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "BUFFERS_PER_FFT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "FFT_PER_RESULT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "NUM_MEASUREMENTS";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 334);
            this.Controls.Add(this.checkBoxRestart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numArg6);
            this.Controls.Add(this.numArg5);
            this.Controls.Add(this.numArg4);
            this.Controls.Add(this.numArg3);
            this.Controls.Add(this.numArg2);
            this.Controls.Add(this.numArg1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonRunProcess);
            this.Name = "Form1";
            this.Text = "Ljósfæri (c# demo)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numArg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArg6)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numArg1;
        private System.Windows.Forms.NumericUpDown numArg2;
        private System.Windows.Forms.NumericUpDown numArg3;
        private System.Windows.Forms.NumericUpDown numArg4;
        private System.Windows.Forms.NumericUpDown numArg5;
        private System.Windows.Forms.NumericUpDown numArg6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxRestart;
    }
}

