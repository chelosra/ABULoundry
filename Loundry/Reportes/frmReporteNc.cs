using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmReporteNc : Form
    {
        public string consulta;
        public string ccliente;
        public string total;
        public string nomcliente;
        public string domcliente;
        public string fecha;
        public string cform;
        public string nroform;
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
        public string TKX;

        public frmReporteNc()
        {
            InitializeComponent();
        }

        private void frmReporteNc_Load(object sender, EventArgs e)
        {
            //string puesto = bdcomun.contenidocampo("select * from negocio limit 1", "PtoVenta");
            //puesto = libreria.rellena(puesto, 4);
            //nrofact = libreria.rellena(nrofact, 8);
            //nrofact = puesto + "-" + nrofact;

            if (!Properties.Settings.Default.afipmodoproduccion)
            {
                cform = "P" + cform;
                cae = "0";
            }
            tipofactura = "C";
            //    cae = "0";

            ivacliente = bdcomun.contenidocampo("Select * from afiptiporesponsable where codigosra='" + ivacliente + "'", "descripcion");
            ivacliente = ivacliente.Substring(2, ivacliente.Length - 2);
            PageSettings pg = bdcomun.reportepagina();
            reportViewer1.SetPageSettings(pg);

            if (domcliente == string.Empty) domcliente = "...";
            //parametros
            ReportParameter[] parameters = new ReportParameter[17];
            parameters[0] = new ReportParameter("ParamCcliente", ccliente);
            parameters[1] = new ReportParameter("ParamTotal", total);
            parameters[2] = new ReportParameter("ParamFecha", fecha);
            parameters[3] = new ReportParameter("ParamNomcliente", nomcliente);
            parameters[4] = new ReportParameter("ParamDomcliente", domcliente);
            parameters[5] = new ReportParameter("ParamNrofact", nroform);
            parameters[6] = new ReportParameter("ParamDescuento", dto);
            parameters[7] = new ReportParameter("ParamSubtotal", subtotal);
            parameters[8] = new ReportParameter("ParamIvaCliente", ivacliente);
            parameters[9] = new ReportParameter("ParamCuitCliente", cuitcliente);
            parameters[10] = new ReportParameter("Param105", iva105);
            parameters[11] = new ReportParameter("Param21", iva21);
            parameters[12] = new ReportParameter("ParamIvaSubtotal", ivasubtotal);
            parameters[13] = new ReportParameter("ParamTipoFactura", cform);
            parameters[14] = new ReportParameter("ParamCae", cae);
            parameters[15] = new ReportParameter("ParamVencimiento", vto);
            parameters[16] = new ReportParameter("ParamTkx", TKX);

            ReportViewer rpt = new ReportViewer();

            rpt = bdcomun.reporte(reportViewer1, "Ncredito.rdlc", consulta, 0, "DataSetNc", parameters);


            //exporta a pdf
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;
            byte[] bytePDF = rpt.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);
            FileStream fileStreamPDF = null;
            //string nomeArquivoPDF = Path.GetTempPath() + "notaFiscal" + DateTime.Now.ToString("dd_MM_yyyy-HH_mm_ss") + ".pdf";
            string archivopdf = Properties.Settings.Default.afipfacttmp + cform+tipofactura+nroform + " " +
                                DateTime.Now.ToString("dd_MM_yyyy") + ".pdf";
            fileStreamPDF = new FileStream(archivopdf, FileMode.Create);
            fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            fileStreamPDF.Close();
            //Process.Start(archivopdf);

            /*
            DialogResult dialogo = MessageBox.Show("¿ Envía la Factura por Mail?",
                             "Envío de Factura por Correo Electrónico", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                mail(archivopdf);
            */
            this.reportViewer1.RefreshReport();
        }
        private void mail(string archivo)
        {
            frmMail frm = new frmMail();
            frm.archivo = archivo;
            frm.ShowDialog();
        }
    }
}
