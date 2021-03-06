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

        public Process subProcess;

        private string ARGUMENTS;

        private double st1, st2, st3, azi, ell, dop, pow, ms, aziNorm, ellNorm;
        private int aziMax=-90, aziMin=90, ellMax=-45, ellMin=45;
        private int counter = 0;
        private int _x, _y, x_initPos, y_initPos, x_width, y_width,
            x_gridDivisions, y_gridDivisions, x_gridPosition, y_gridPosition, x_pos, y_pos;
                      
        public Form1()
        {
            InitializeComponent();
            /*width of frame*/
            x_width = 500;
            y_width = 500;

            /*grid divisions*/
            x_gridDivisions = (int)x_divBox.Value;
            y_gridDivisions = (int)y_divBox.Value;

            /*position of (0,0), top left corner*/
            x_initPos = 800;
            y_initPos = 100;


            /*initial grid position*/
            x_gridPosition = 0;
            y_gridPosition = 0;

            /*current position relative to the whole form, starts in top left*/
            _x = x_initPos;
            _y = y_initPos;


        }

        public void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (IsRunning(subProcess))
            {
                try
                {
                    subProcess.Kill();
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

        public static bool IsRunning(Process process) //used to check if process is running
        {
            if (process != null)
            {
                try { Process.GetProcessById(process.Id); }
                catch (InvalidOperationException) { return false; }
                catch (ArgumentException) { return false; }
                return true;
            }
            return false;
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

            // copy measurements to variables
            st1 = Convert.ToDouble(mesurments[0]); // Stokes1
            st2 = Convert.ToDouble(mesurments[1]); // Stokes2
            st3 = Convert.ToDouble(mesurments[2]); // Stokes3
            azi = Convert.ToDouble(mesurments[3]); // Azimuth
            ell = Convert.ToDouble(mesurments[4]); // Ellipt
            dop = Convert.ToDouble(mesurments[5]); // DOP
            pow = Convert.ToDouble(mesurments[6]); // Power
            ms  = Convert.ToDouble(mesurments[7]); // Ms

            //Monitor maximum and minimum angles
            if (azi > aziMax)
            {
                aziMax = (int)azi;
                textAziMax.Text = aziMax.ToString();
            }

            if (azi < aziMin)
            {
                aziMin = (int)azi;
                textAziMin.Text = aziMin.ToString();
            }

            if (ell > ellMax)
            {
                ellMax = (int)ell;
                textEllMax.Text = ellMax.ToString();
            }

            if (ell < ellMin)
            {
                ellMin = (int)ell;
                textEllMin.Text = ellMin.ToString();
            }
            

            //measurements run counter
            counter++;
            textBoxCounter.Text = counter.ToString();

            // ***************************************
            //   draw dot based on azi and ell values
            // ***************************************

            //update gridDivisions
            if (x_gridDivisions - 1 < x_gridPosition) 
                x_gridPosition = x_gridDivisions - 1;
            if (y_gridDivisions - 1 < y_gridPosition)
                y_gridPosition = y_gridDivisions - 1;
            x_gridDivisions = (int)x_divBox.Value;
            y_gridDivisions = (int)y_divBox.Value;

            //check if jumping between divisions
            if (Math.Abs(azi / 180 - aziNorm) > 0.5)
            {
                if ((azi / 180 - aziNorm) > 0)
                {
                    if (x_gridPosition != 0)
                    {
                        x_gridPosition += -1;
                    }
                    else
                    {
                        x_gridPosition = x_gridDivisions - 1;
                    }
                }

                if ((azi / 180 - aziNorm) < 0)
                {
                    if (x_gridPosition != x_gridDivisions - 1)
                    {
                        x_gridPosition += 1;
                    }
                    else
                    {
                        x_gridPosition = 0;
                    }
                }
            }

            if (Math.Abs(ell / 90 - ellNorm) > 0.5)
            {
                if ((ell / 180 - ellNorm) > 0)
                {
                    if (y_gridPosition != 0)
                    {
                        y_gridPosition += -1;
                    }
                    else
                    {
                        y_gridPosition = y_gridDivisions - 1;
                    }
                }

                if ((ell / 180 - ellNorm) < 0)
                {
                    if (y_gridPosition != y_gridDivisions - 1)
                    {
                        y_gridPosition += 1;
                    }
                    else
                    {
                        y_gridPosition = 0;
                    }
                }
            }
                

            // azi and ell are between -90 and 90, normalize to -1..1
            aziNorm = azi / 180 ;
            ellNorm = ell / 90 ;

            /*Calculate position coordinates, x=0..x_width, same for y*/
            x_pos = Convert.ToInt32((aziNorm * x_width + x_width / 2 ) / x_gridDivisions );
            y_pos = Convert.ToInt32((ellNorm * y_width + y_width / 2 ) / y_gridDivisions);

            //output variables
            textAzi.Text = azi.ToString();
            textEll.Text = ell.ToString();
            textAziNorm.Text = aziNorm.ToString();
            textEllNorm.Text = ellNorm.ToString();

            //draw
            //pictureBox1.Image = null;
            //drawDot(aziNorm, ellNorm);

            //update position
            _x = x_initPos + x_gridPosition * x_width / x_gridDivisions + x_pos;
            _y = y_initPos + y_gridPosition * y_width / y_gridDivisions + y_pos;
            Invalidate();



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
            if (IsRunning(subProcess))
            {
                this.BeginInvoke(new MethodInvoker(() =>
                {
                    textBoxOutput.AppendText("Process exited\n");
                    subProcess.Close();
                    if (checkBoxRestart.Checked)
                        StartProcessing();

                }));
            }
   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsRunning(subProcess))
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
            else
            {
                textBoxOutput.AppendText("Error: No process running\n");
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
            parseArgs();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void portBox_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void slotBox_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void wavelengthBox_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void commBox_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void bootBox_ValueChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {
            parseArgs();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 10, 10);
            //e.Graphics.DrawImage(new Bitmap("mushroom.png"), _x, _y, 32, 32);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_x += 1;
            //_y += 1;
            //Invalidate();
        }


    }
}
