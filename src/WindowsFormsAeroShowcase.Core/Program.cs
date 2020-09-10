using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAeroShowcase.Core
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Compatibility check
            if (!WindowsFormsAero.OsSupport.IsVistaOrLater)
            {
                if (MessageBox.Show("It appears you are not running on Windows Vista (or later). The controls and dialogs implemented in this application might not work or crash.\n\nDo you want to continue?", "Windows Vista or later required", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                {
                    return;
                }
            }

            Application.Run(new Main());
        }
    }
}
