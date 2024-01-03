using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneApp
{
    static class Program
    {
        public static bool errorFlag;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                errorFlag = false;
                Application.Run(new Form1());
            }
            catch (Exception exc) 
            {
                // This is the exception handler of last resort.
                // Set flag so that the output file isn't written
                // upon error termination.
                errorFlag = true;
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
