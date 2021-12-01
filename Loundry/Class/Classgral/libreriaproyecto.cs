using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loundry
{
    public class libreriaproyecto
    {
        public static void CreaDirectorios()
        {
            string caefac = Properties.Settings.Default.afipcaefac;
            string caeenc = Properties.Settings.Default.afipcaenc;
            string facttmp = Properties.Settings.Default.afipfacttmp;
            lascarpetas(caefac);
            lascarpetas(caeenc);
            lascarpetas(facttmp);
        }

        private static void lascarpetas(string xx)
        {
            string[] dire = xx.Split('\\');
            string carpeta = dire[0] + "\\" + dire[1];
            creacarpeta(carpeta);
            for (int i = 2; i < dire.Length; i++)
            {
                carpeta = carpeta + "\\" + dire[i];
                creacarpeta(carpeta);
            }
        }
        private static void creacarpeta(string carpeta)
        {
            try
            {
                if (Directory.Exists(carpeta))
                {
                    configuracion.mensaje("Ya existe");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(carpeta);
                configuracion.mensaje(Directory.GetCreationTime(carpeta).ToString());

                // Delete the directory.
                //di.Delete();
            }
            catch { }
        }
    }
}
