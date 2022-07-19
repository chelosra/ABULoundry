using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Loundry
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]


        static void Main()
        {
            bool ejecucion;
            ejecucion = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1;
            if (!ejecucion)
            {
                bdcomun.changeip(null);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                Application.Run(new frmppal());
            }
            else
            {
                MessageBox.Show("La aplicación ya se está ejecutando");
                Application.Exit();
            }
        }
    }
}
