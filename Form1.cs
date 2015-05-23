﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

namespace input
{
    public partial class Form1 : Form
    {
        //this.FormClosing += new FormClosingEventHandler(myForm_FormClosing);
        //form.FormClosed += new Form.FormClosedEventHandler( myForm_FormClosing() );

        public Process subProcess;

        private string ARGUMENTS;

        private double st1, st2, st3, azi, ell, dop, pow, ms;


        public void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (sbProcess != null)
            {
                try
                {
                    subProcess.Close();
                    return;
                }
                catch (NullReferenceException)
                {
                    // Everything is fine.
                }

            }


            //System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            //messageBoxCS.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            //messageBoxCS.AppendLine();
            //MessageBox.Show(messageBoxCS.ToString(), "FormClosed Event");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void parseArgs()
        {
            string IP, PORT, SLOT, COMM, BOOT, WRITE_TO_FILE, FILENAME,DEF_WAVELENGTH, BASIC_MEAS_SPEED, PERIODS_PER_BUFFER, BUFFERS_PER_FFT, FFT_PER_RESULT;

            IP = IPBox.Text;
            PORT = portBox.Value.ToString();
            SLOT = slotBox.Value.ToString();
            COMM = commBox.Value.ToString();
            BOOT = bootBox.Value.ToString();
            WRITE_TO_FILE = writeToFileBox.Value.ToString();
            FILENAME = fileNameBox.Text;
            DEF_WAVELENGTH = wavelengthBox.Value.ToString();
            BASIC_MEAS_SPEED = speedBox.Value.ToString();
            PERIODS_PER_BUFFER = periodsBox.Value.ToString();
            BUFFERS_PER_FFT = buffersBox.Value.ToString();
            FFT_PER_RESULT = fftBox.Value.ToString();

            ARGUMENTS = IP + " " + PORT + " " + SLOT + " " + DEF_WAVELENGTH + " " + COMM + " " + BOOT + " " + WRITE_TO_FILE + " " + FILENAME + " " + BASIC_MEAS_SPEED + " " + PERIODS_PER_BUFFER + " " + BUFFERS_PER_FFT + " " + FFT_PER_RESULT;

            textBoxArgs.Text = ARGUMENTS;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StartProcessing();
        }

        private void StartProcessing()
        {
            try
            {
                if (Process.GetProcessById(subProcess.Id) != null)
                {
                    textBoxOutput.AppendText("Error: Process already running.\n");
                    return;
                }
            }
            catch (NullReferenceException)
            {
                // Everything is fine.
            }
            catch (InvalidOperationException)
            {
                // Everything is fine.
            }


            subProcess = new Process();
            subProcess.EnableRaisingEvents = true;

            ProcessStartInfo subProcessStartInfo = new ProcessStartInfo(textBoxFile.Text, ARGUMENTS);
            subProcessStartInfo.UseShellExecute = false;
            subProcessStartInfo.CreateNoWindow = true;

            subProcessStartInfo.RedirectStandardOutput = true;
            subProcessStartInfo.RedirectStandardError = true;

            subProcess.StartInfo = subProcessStartInfo;

            subProcess.OutputDataReceived += OutputDataReceivedEventHandler;
            subProcess.ErrorDataReceived += ErrorDataReceivedEventHandler;
            subProcess.Exited += ProcessExited;

            subProcess.Start();
            subProcess.BeginOutputReadLine();
            subProcess.BeginErrorReadLine();
        }

        private void ProcessMeasurements(string s)
        {
            if (s == null)
                return;

            string[] mesurments = s.Split('\t');
            if (mesurments.Length != 8)
            {
                textBoxOutput.AppendText("Error: Expected string separated by tab containing 7 values but got "  + mesurments.Length + "\n");
                return;
            }

            st1 = Convert.ToDouble(mesurments[0]); // Stokes1
            st2 = Convert.ToDouble(mesurments[1]); // Stokes2
            st3 = Convert.ToDouble(mesurments[2]); // Stokes3
            azi = Convert.ToDouble(mesurments[3]); // Azimuth
            ell = Convert.ToDouble(mesurments[4]); // Ellipt
            dop = Convert.ToDouble(mesurments[5]); // DOP
            pow = Convert.ToDouble(mesurments[6]); // Power
            ms  = Convert.ToDouble(mesurments[7]); // Ms

            // **************************************************
            //  INSERT CODE HERE TO DO SOMETHING WITH THE VALUES
            // **************************************************

            /*
             * A few interesting libraries:
             * http://puremidi.codeplex.com/
             * https://code.google.com/p/midi-dot-net/
             * http://naudio.codeplex.com/
             * And many many more...
             */

            // Debug
            textBoxOutput.AppendText(s + "\n");
        }


        private void OutputDataReceivedEventHandler(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    ProcessMeasurements(e.Data);
                }));
        }

        private void ErrorDataReceivedEventHandler(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    textBoxOutput.AppendText("Error: " + e.Data  + "\n");
                }));
        }


        private void ProcessExited(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                textBoxOutput.AppendText("Process exited\n");
                subProcess.Close();
                if (checkBoxRestart.Checked)
                    StartProcessing();

            }));
   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                subProcess.Kill();
            }
            catch (Exception ex)
            {
                textBoxOutput.AppendText("Error: " + ex.Message + "\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void numArg1_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void numArg2_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void numArg3_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void numArg4_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void numArg5_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void numArg6_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void textBoxFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void portBox_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
