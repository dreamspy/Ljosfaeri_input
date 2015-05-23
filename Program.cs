using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace input
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            form.FormClosing += new FormClosingEventHandler(form.Form1_FormClosing);
            Application.Run(form);
        }

        static void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            // insert code to run here after form has closed
        }



    }



}
