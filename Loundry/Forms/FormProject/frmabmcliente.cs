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
    public partial class frmabmcliente : Form
    {
        public int tag;
        public DataGridView dgvclientes;
        public string dato;
        public frmabmcliente()
        {
            InitializeComponent();
        }

        private void frmabmcliente_Load(object sender, EventArgs e)
        {
            if (tag == 0) { 
                abmcliente.alta(ref txtccliente, ref txtrsocial, ref txtdomicilio, ref txttelefono, ref txtmail, ref cmbdocumento, ref txtcuit,
                    ref txtdni, ref cmbResponsable, ref cmbCondIva, ref cmblprecio, ref dgvclientes);
                cmbResponsable.SelectedIndex = 5;
                cmbdocumento.SelectedIndex = 2;
                cmblprecio.SelectedIndex = 0;
            }
            if (tag == 1)
                abmcliente.modif(ref txtccliente, ref txtrsocial, ref txtdomicilio, ref txttelefono, ref txtmail, ref cmbdocumento, ref txtcuit,
                 ref txtdni, ref cmbResponsable, ref cmbCondIva, ref cmblprecio, ref dgvclientes, dato);
        }

        private void btngraba_Click(object sender, EventArgs e)
        {

            abmcliente.graba(txtccliente.Text, txtrsocial.Text, txtdomicilio.Text, txttelefono.Text, txtmail.Text, cmbdocumento.Text,
                 txtcuit.Text, txtdni.Text, cmbResponsable.Text.Substring(0, 1), cmbCondIva.Text.Substring(0, 2),
                 cmblprecio.Text.Substring(0, 1),
                 ref dgvclientes);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancela_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaCuit_Click(object sender, EventArgs e)
        {
            frmConsultaCuit frm = new frmConsultaCuit();
            frm.retornaCuit = txtcuit.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtrsocial.Text = frm.retornaNombreclie;
                txtdomicilio.Text = frm.retornaDireccion;
                txtcuit.Text = frm.retornaIdPersona;
                txtdni.Text = frm.retornaNroDocClie;
                string condiva = string.Empty;
                switch (frm.retornaCondIva)
                {
                    case "1":
                        condiva = "I";
                        break;
                    case "2":
                        condiva = "R";
                        break;
                    case "3":
                        if (frm.retornaDescIva.Contains("Consumidor Final"))
                            condiva = "F";
                        else
                            condiva = "N";
                        break;
                    case "4":
                        condiva = "E";
                        break;
                    case "5":
                        condiva = "F";
                        break;
                    case "6":
                        condiva = "M";
                        break;
                    default:
                        condiva = "O";
                        break;
                }
                libreria.seleccionaitemcombo(ref cmbResponsable, condiva);
            }
        }

        private void CmbResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txtcuit_TextChanged(object sender, EventArgs e)
        {
            if (txtcuit.Text != string.Empty)
                cmbdocumento.SelectedIndex = 2;

        }

        private void Txtdni_TextChanged(object sender, EventArgs e)
        {
            if (txtdni.Text != string.Empty)
                cmbdocumento.SelectedIndex = 1;
            else cmbdocumento.SelectedIndex = 2;
            
        }
    }
}
