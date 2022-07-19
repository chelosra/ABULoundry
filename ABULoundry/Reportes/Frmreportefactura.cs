using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class Frmreportefactura : Form
    {
        public string consulta;
        public string ccliente;
        public string total;
        public string nomcliente;
        public string domcliente;
        public string fecha;
        public string nrofact;
        public string subtotal;
        public string dto;
        public string ivacliente;
        public string cuitcliente;
        public string iva105;
        public string iva21;
        public string ivasubtotal;
        public string tipofactura;
        public string cae;
        public string vto;
        public string ImporteLetra;
        public string piva;

        public Frmreportefactura()
        {
            InitializeComponent();
        }

        private string qr(string xcae)
        {
            QrEncoder qr = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrc = new QrCode();
            qr.TryEncode(xcae, out qrc);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrc.Matrix, ImageFormat.Png, ms);
            var imagetemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagetemporal, new Size(new Point(50, 50)));

            //pictureBox1.BackgroundImage = imagen;
            //Image clone = (Image)pictureBox1.BackgroundImage.Clone();


            Image clone = (Image)imagen.Clone();
            string archurl = @Properties.Settings.Default.Qr;
            File.Delete(archurl);
            clone.Save(archurl, ImageFormat.Png);
            clone.Dispose();

            return archurl;
        }
        private void Frmreportefactura_Load(object sender, EventArgs e)
        {
            //string puesto = bdcomun.contenidocampo("select * from negocio limit 1", "PtoVenta");
            //puesto = libreria.rellena(puesto, 4);
            //nrofact = libreria.rellena(nrofact, 8);
            //nrofact = puesto + "-" + nrofact;

            //
            string textqr = "20-04272871 / PALMADESSA OSVALDO / RESPONSABLE INSCRIPTO / LOCACIONES DE SERVICIO / ALBERTI 86 CAPITAL FEDERAL (C.P. 1082) CABA / CAE: " + cae;

            string archurl = qr(textqr);
            archurl = "file:\\" + archurl;
            if (cuitcliente == "20111111112")
                cuitcliente = ".";
            if (!Properties.Settings.Default.afipmodoproduccion)
            {
                tipofactura = "P" + tipofactura;
                cae = "P" + cae;
            }

            string ndni = bdcomun.contenidocampo("Select * from cliente where codigo='" + ccliente + "'", "ndni");
            cuitcliente += " " + ndni;


            string caenro = cae.Substring(19, 14);
            ivacliente = bdcomun.contenidocampo("Select * from afiptiporesponsable where codigosra='" + ivacliente + "'", "descripcion");
            ivacliente = ivacliente.Substring(2, ivacliente.Length - 2);
            PageSettings pg = bdcomun.reportepagina();
            reportViewer1.SetPageSettings(pg);

            if (domcliente == string.Empty) domcliente = "...";
            piva = "IVA " + piva + "$";
            //parametros
            ReportParameter[] parameters = new ReportParameter[20];
            parameters[0] = new ReportParameter("ParamCcliente", ccliente);
            parameters[1] = new ReportParameter("ParamTotal", total);
            parameters[2] = new ReportParameter("ParamFecha", fecha);
            parameters[3] = new ReportParameter("ParamNomcliente", nomcliente);
            parameters[4] = new ReportParameter("ParamDomcliente", domcliente);
            parameters[5] = new ReportParameter("ParamNrofact", nrofact);
            parameters[6] = new ReportParameter("ParamDescuento", dto);
            parameters[7] = new ReportParameter("ParamSubtotal", subtotal);
            parameters[8] = new ReportParameter("ParamIvaCliente", ivacliente);
            parameters[9] = new ReportParameter("ParamCuitCliente", cuitcliente);
            parameters[10] = new ReportParameter("Param105", iva105);
            parameters[11] = new ReportParameter("Param21", iva21);
            parameters[12] = new ReportParameter("ParamIvaSubtotal", ivasubtotal);
            parameters[13] = new ReportParameter("ParamTipoFactura", tipofactura);
            parameters[14] = new ReportParameter("ParamCae", cae);
            parameters[15] = new ReportParameter("ParamVencimiento", vto);
            parameters[16] = new ReportParameter("ParamImporteLetra", ImporteLetra);
            parameters[17] = new ReportParameter("ParamCaeNro", caenro);
            parameters[18] = new ReportParameter("ParamPIva", piva);
            parameters[19] = new ReportParameter("ParamQr", @archurl);

            ReportViewer rpt = new ReportViewer();

            rpt = bdcomun.reporte(reportViewer1, "Factura.rdlc", consulta, 0, "DSPresupuestoFactura2", parameters);
            
            //impresionDirecta(rpt);

            //exporta a pdf
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;
            byte[] bytePDF = rpt.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);
            FileStream fileStreamPDF = null;
            //string nomeArquivoPDF = Path.GetTempPath() + "notaFiscal" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";
            if (tipofactura == String.Empty)
                tipofactura="B";
            string archivopdf = Properties.Settings.Default.afipfacttmp + tipofactura + nrofact + " " +
                                DateTime.Now.ToString("dd_MM_yyyy") + ".pdf";
            fileStreamPDF = new FileStream(archivopdf, FileMode.Create);
            fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            fileStreamPDF.Close();
            //Process.Start(archivopdf);

            //DialogResult dialogo = MessageBox.Show("¿ Envía la Factura por Mail?",
            //                 "Envío de Factura por Correo Electrónico", MessageBoxButtons.YesNo);
            //if (dialogo == DialogResult.Yes)
            //    mail(archivopdf);

        }
        #region impre directa
        private void impresionDirecta(ReportViewer rpt)
        {
            Export(rpt.LocalReport);
            if (pages == null || pages.Count == 0)
                return;
            PrintDocument printDocument = new PrintDocument();
            //printDocument.PrinterSettings.PrinterName = "RICOH MP 402SPF";
            if (!printDocument.PrinterSettings.IsValid)
                return; //ImpresoraNoEncontrada
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            //printDocument.PrinterSettings.Copies= Convert.ToInt16(Copias);
            printDocument.Print();
            //this.Close();

        }

        //nuevo
        private IList<Stream> pages = new List<Stream>();
        private int currentPageIndex;
        /// <summary>
        /// Handler que es llamado para cada página que se va a imprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            // Se crea un objeto Metafile que define un grafico
            // en base a la información contenida en un stream
            Metafile pageImage = new Metafile(pages[currentPageIndex]);

            // Se dibuja la página en el reporte
            ev.Graphics.DrawImage(pageImage, ev.PageBounds);

            // Se procesan las paginas siguientes
            currentPageIndex++;
            ev.HasMorePages = (currentPageIndex < pages.Count);
        }
        /// <summary>
        /// Export the given report as an EMF (Enhanced Metafile) file.
        /// </summary>
        /// <param name="report"></param>
        private void Export(LocalReport report)
        {
            string deviceInfo =
                "<DeviceInfo>" +
                "  <OutputFormat>EMF</OutputFormat>" +
                "  <PageWidth>8.27in</PageWidth>" +
                "  <PageHeight>11.69in</PageHeight>" +
                "  <MarginTop>0in</MarginTop>" +
                "  <MarginLeft>0in</MarginLeft>" +
                "  <MarginRight>0in</MarginRight>" +
                "  <MarginBottom>0in</MarginBottom>" +
                "</DeviceInfo>";

            Warning[] warnings;

            try
            {
                // El método render es el encargado de crear el stream
                // (llamando a CreateStream) en el formato especificado,
                // usando el stream proveido por la funcion de callback
                // en este caso, un aun archivo EMF con ciertas medidas
                report.Render("Image", deviceInfo, CreateStream, out warnings);

                // Se encarga de resetear la posicion de
                // todos los stream al inicio de los mismos
                foreach (Stream stream in pages)
                    stream.Position = 0;
            }
            catch (LocalProcessingException ex)
            {
                throw ex;
            }
        }
        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            // Creamos un MemoryStream para no tener que grabar en el
            // disco duro cada una de las páginas que pudiera haber
            Stream stream = new MemoryStream();

            // Se añade el stream al listado
            pages.Add(stream);

            return stream;
        }
        #endregion




        private void mail(string archivo)
        {
            frmMail frm = new frmMail();
            frm.archivo = archivo;
            frm.ShowDialog();
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            //consulta = "Select * from auxmovimiento3";
            //bdcomun.reporte(reportViewer1,"Report1.rdlc", consulta, 0, "DSPresupuestoFactura");
        }
    }
}
