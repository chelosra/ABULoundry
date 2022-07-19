using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmFtp : Form
    {
        /*
        private string dire = @"ftp://50.28.15.203/";
        private string user = "avefenix";
        private string pass = "21K1edtTw3";
        */
        private string dire = @"ftp://srasistemas.sytes.net/";
        private string user = "sra";
        private string pass = "sra17254";
        public frmFtp()
        {
            InitializeComponent();
        }

        private void frmFtp_Load(object sender, EventArgs e)
        {
            txtFtpCarpeta.Text = Properties.Settings.Default.FtpCarpeta.Trim();
            if (Properties.Settings.Default.Usuario == "sra")
            {
                btnCreaDirectorios.Visible = true;
                btnSubeReportes.Visible = true;
            }
        }
        private void btnCreaDirectorios_Click(object sender, EventArgs e)
        {
            libreriaproyecto.CreaDirectorios();
        }

        private void btnSubeReportes_Click(object sender, EventArgs e)
        {
            try
            {
                //ftp ftpClient = new ftp(@"ftp://186.22.157.47/", "chelo", "sra17254");
                ftp ftpClient = new ftp(@dire, user, pass);

                for (int i = 0; i < lstArchivos.Items.Count; i++)
                {
                    lstArchivos.SetSelected(i, true);
                    string destinoremoto = txtFtpCarpeta.Text.Trim() + lstArchivos.Items[i].ToString().Trim();
                    string archivoasubir = @Properties.Settings.Default.FtpSubeDesde.Trim() + 
                                            lstArchivos.Items[i].ToString().Trim();  //Factura.rdlc";
                    ftpClient.upload(destinoremoto, archivoasubir);
                }
                ftpClient = null;
            }
            catch (Exception ex)
            {
                configuracion.mensaje(ex.ToString());
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                //ftp ftpClient = new ftp(@"ftp://186.22.157.47/", "chelo", "sra17254");
                ftp ftpClient = new ftp(@dire, user, pass);

                string origenremoto = "";
                string archivoabajar = "";
                for (int i = 0; i < lstArchivos.Items.Count; i++)
                {
                    lstArchivos.SetSelected(i, true);
                    origenremoto = txtFtpCarpeta.Text.Trim() + lstArchivos.Items[i].ToString().Trim();
                    archivoabajar = @Properties.Settings.Default.PathReport.Trim() + lstArchivos.Items[i].ToString().Trim();// Factura.rdlc";
                    ftpClient.download(origenremoto, archivoabajar);
                }
                origenremoto = txtFtpCarpeta.Text.Trim() + "conf.xml";
                archivoabajar = @"C:\sracsharp\Hsi\" + "conf.xml";
                ftpClient.download(origenremoto, archivoabajar);
                ftpClient = null;
            }
            catch (Exception ex)
            {
                configuracion.mensaje(ex.ToString());
            }

        }


        private void xx()
        {
            /* Create Object Instance */
            ftp ftpClient = new ftp(@"ftp://186.22.157.47/", "chelo", "sra17254");

            /* Upload a File */
            ftpClient.upload("chelo/htdocs/test.txt", @"C:\php\test.txt");


            /* Download a File */
            ftpClient.download("etc/test.txt", @"C:\Users\metastruct\Desktop\test.txt");

            /* Delete a File */
            ftpClient.delete("etc/test.txt");

            /* Rename a File */
            ftpClient.rename("etc/test.txt", "test2.txt");

            /* Create a New Directory */
            ftpClient.createDirectory("etc/test");

            /* Get the Date/Time a File was Created */
            string fileDateTime = ftpClient.getFileCreatedDateTime("etc/test.txt");
            Console.WriteLine(fileDateTime);

            /* Get the Size of a File */
            string fileSize = ftpClient.getFileSize("etc/test.txt");
            Console.WriteLine(fileSize);

            /* Get Contents of a Directory (Names Only) */
            string[] simpleDirectoryListing = ftpClient.directoryListDetailed("/etc");
            for (int i = 0; i < simpleDirectoryListing.Count(); i++) { Console.WriteLine(simpleDirectoryListing[i]); }

            /* Get Contents of a Directory with Detailed File/Directory Info */
            string[] detailDirectoryListing = ftpClient.directoryListDetailed("/etc");
            for (int i = 0; i < detailDirectoryListing.Count(); i++) { Console.WriteLine(detailDirectoryListing[i]); }
            /* Release Resources */

            ftpClient = null;

        }

        private void btnSubeConf_Click(object sender, EventArgs e)
        {

        }
    }
}
