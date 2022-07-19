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
    public partial class frmchequespresenta : Form
    {
        private int puntero;
        public frmchequespresenta()
        {
            InitializeComponent();
        }

        private void frmchequespresenta_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvcheques, "", 9, true);
            configuracion.confdgv(dgvconsulta, "", 9, true);
            configuracion.tabcontrol(tabControl1);
            
            configuracion.grupobox(grpabm);
            btnrefresh.PerformClick();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string fdesde = libreria.fechaamysql(dtpfechdesde.Value.ToString());
            string fhasta = libreria.fechaamysql(dtpfechhasta.Value.ToString());
            string consulta = "select * from cheques " +
                              "where (fechform between '" + fdesde + "' and '" + fhasta + "')  ";
            abmchequespresenta.refresh(ref dgvcheques, consulta);
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            try
            {
                puntero = dgvcheques.CurrentRow.Index;
                string dato = this.dgvcheques.Rows[puntero].Cells["pk"].Value.ToString();
                abmchequespresenta.modif(ref txtccliente, ref txtcaja, ref dtpfechform, ref txtcform, ref txtnroform, ref txtbanco, ref txtnrocheque, ref txtimporte,
                                         ref dtpfechcheque, ref cmbpresentado, ref dgvcheques, dato);
                dgvcheques.Tag = 1;
                grpabm.Visible = true;
            }
            catch { }
        }

        private void btngraba_Click(object sender, EventArgs e)
        {
            string dato = "";
            try
            {
                puntero = dgvcheques.CurrentRow.Index;
                dato = this.dgvcheques.Rows[puntero].Cells["pk"].Value.ToString();
            }
            catch { }
            
            abmchequespresenta.graba(txtccliente.Text, txtcaja.Text, dtpfechform.Value.ToString("yyyy-MM-dd"), txtcform.Text, txtnroform.Text, txtbanco.Text, txtnrocheque.Text,
                                     txtimporte.Text, dtpfechcheque.Value.ToString("yyyy-MM-dd"), cmbpresentado.Text, ref dgvcheques, dato, txtsubtotal);
            grpabm.Visible = false;
            abmchequespresenta.refresh(ref dgvcheques, "");
        }

        private void btnborra_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmchequespresenta.buscar(ref dgvcheques);
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = string.Empty;
            string fdesde = libreria.fechaamysql(dtpfechdesde.Value.ToString());
            string fhasta = libreria.fechaamysql(dtpfechhasta.Value.ToString());
            consulta = "select * from cheques " +
                "where (fechform between '" + fdesde + "' and '" + fhasta + "') and " +
                "(ccliente > '0000') and " +
                "(presentado='" + cmbestado.Text.Substring(0, 1) + "') order by fechcheque";
            abmchequespresenta.refresh(ref dgvconsulta, consulta);

            consulta = "select sum(importe) as total from cheques " +
                "where (fechform between '" + fdesde + "' and '" + fhasta + "') and " +
                "(ccliente > '0000') and " +
                "(presentado='" + cmbestado.Text.Substring(0, 1) + "') order by fechcheque";

            txtsubtotal.Text = bdcomun.contenidocampo(consulta, "total");

            txtcliente.Text = string.Empty;
            groupBox2.Text = cmbestado.Text;
        }

        private void txtcliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmbestado.SelectedIndex = 0;
            string fdesde = libreria.fechaamysql(dtpfechdesde.Value.ToString());
            string fhasta = libreria.fechaamysql(dtpfechhasta.Value.ToString());
            frmprocesocliente frm = new frmprocesocliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtcliente.Text = frm.retornaccliente;
                lblgcliente.Text = bdcomun.contenidocampo("select * from cliente where codigo='" + txtcliente.Text + "'", "rsocial");
            }
            string consulta = "Select * from cheques " +
                       "where (fechform between '" + fdesde + "' and '" + fhasta + "') and ccliente ='" + txtcliente.Text + "' " +
                       "order by pk desc";
            abmchequespresenta.refresh(ref dgvconsulta, consulta);
            consulta = "Select sum(importe) as total from cheques " +
            "where (fechform between '" + fdesde + "' and '" + fhasta + "') and ccliente ='" + txtcliente.Text + "' " +
            "order by pk desc";
            txtsubtotal.Text = bdcomun.contenidocampo(consulta, "total");
            groupBox2.Text = lblgcliente.Text;
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
        }

        private void dgvcheques_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvconsulta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
    }
}
