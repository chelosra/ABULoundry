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
    public partial class frmnegocio : Form
    {
        public int puntero;
        public frmnegocio()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmnegocio.refresh(ref dgvnegocio);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //abmnegocio.alta(ref txtcnegocio, ref txtpropietario, ref txtrsocial, ref txtdomicilio, ref txttelefono, ref cmbdocumento, ref txtnumerodoc,
            //                ref cmbiva, ref txtnroib, ref dgvnegocio);
            //grpabm.Visible = true;
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvnegocio.CurrentRow.Index;
            string dato = this.dgvnegocio.Rows[puntero].Cells["codigo"].Value.ToString();
            abmnegocio.modif(ref txtcnegocio, ref txtpropietario, ref txtrsocial, ref txtdomicilio, ref txttelefono, ref cmbdocumento, ref txtnumerodoc,
                ref cmbiva, ref txtnroib, ref dgvnegocio, dato);
            grpabm.Visible = true;
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            //puntero = dgvnegocio.CurrentRow.Index;
            //string dato = this.dgvnegocio.Rows[puntero].Cells["codigo"].Value.ToString();
            //abmnegocio.borra(dato, ref dgvnegocio);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmnegocio.buscar(ref dgvnegocio);
        }

        private void frmnegocio_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvnegocio, "", 9, true);
            configuracion.grupobox(grpabm);
            configuracion.tabcontrol(tabControl1);
            btnrefresh.PerformClick();
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
        }

        private void btngraba_Click(object sender, EventArgs e)
        {
            abmnegocio.graba(txtcnegocio.Text,txtpropietario.Text,txtrsocial.Text,
                txtdomicilio.Text,txttelefono.Text,cmbdocumento.Text,txtnumerodoc.Text,cmbiva.Text,txtnumerodoc.Text, ref dgvnegocio);
            grpabm.Visible = false;
            abmnegocio.refresh(ref dgvnegocio);

        }
    }
}
