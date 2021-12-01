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
    public partial class frmcheque : Form
    {
        public int puntero;
        public string ccliente;
        public string ccaja;
        public string cform;
        public string nroform;
        private string fechform = DateTime.Now.ToString("yyyy-MM-dd");
        public string total;
        public string retornavalor;

        public frmcheque()
        {
            InitializeComponent();
        }

        private void frmcheque_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvcheques, "", 9, true);
            configuracion.grupobox(grpabm);
            btnrefresh.PerformClick();

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmcheque.refresh(ref dgvcheques,ccliente,cform,nroform,txtsubtotal);
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtimporte, e);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            abmcheque.alta(ref txtccliente, ref txtcaja, ref dtpfechform, ref txtcform, ref txtnroform, ref txtbanco, ref txtnrocheque,
                ref txtimporte, ref dtpfechcheque, ref dgvcheques, ccliente, ccaja, fechform, cform, nroform, total);
            grpabm.Visible = true;
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
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
            abmcheque.graba(txtccliente.Text, txtcaja.Text, dtpfechform.Value.ToString("yyyy-MM-dd"), txtcform.Text, txtnroform.Text, txtbanco.Text, txtnrocheque.Text,
                            txtimporte.Text, dtpfechcheque.Value.ToString("yyyy-MM-dd"), ref dgvcheques, dato,txtsubtotal);
            grpabm.Visible = false;
            abmcheque.totalcomanda(ccliente, cform, nroform, ref txtsubtotal);
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            try
            {
                puntero = dgvcheques.CurrentRow.Index;
                string dato = this.dgvcheques.Rows[puntero].Cells["pk"].Value.ToString();
                abmcheque.modif(ref txtccliente, ref txtcaja, ref dtpfechform, ref txtcform, ref txtnroform, ref txtbanco, ref txtnrocheque, ref txtimporte,
                                ref dtpfechcheque, ref dgvcheques, dato);
                grpabm.Visible = true;
            }
            catch { }
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            puntero = dgvcheques.CurrentRow.Index;
            string dato = this.dgvcheques.Rows[puntero].Cells["pk"].Value.ToString();
            abmcheque.borra(dato, ref dgvcheques,ccliente,cform,nroform,txtsubtotal);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmcheque.buscar(ref dgvcheques);
        }

        private void btnaceptacheques_Click(object sender, EventArgs e)
        {
            retornavalor = txtsubtotal.Text;
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }

        private void frmcheque_Leave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
