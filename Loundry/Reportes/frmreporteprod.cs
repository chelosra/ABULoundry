using Microsoft.Reporting.WinForms;
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
    public partial class frmreporteprod : Form
    {
        public string consulta;
        public string cliente;
        public string fecha;

        public frmreporteprod()
        {
            InitializeComponent();
        }

        private void frmreporteprod_Load(object sender, EventArgs e)
        {
            System.Drawing.Printing.PageSettings pg = bdcomun.reportepagina();
            reportViewer1.SetPageSettings(pg);

            //parametros
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ParamFecha", fecha);
            parameters[1] = new ReportParameter("ParamCliente", cliente);

            bdcomun.reporte(reportViewer1, "Listprecio.rdlc", consulta, 0, "DSListadoPrecios", parameters);
        }
    }
}
