using InputKey;
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
    public partial class frmItemFactura : Form
    {
        public string cprod;
        public string cantidad;
        public string pventa;
        public string xdto;
        public string cmbcpventa;
        public string lp;
        public bool bandera;
        public int tag;
        public bool aplicaiva;
        public string ccliente;
        public frmItemFactura()
        {
            InitializeComponent();
        }

        private void btngrabaitem_Click(object sender, EventArgs e)
        {
            bandera = true;
            if (txtcprod.Text == string.Empty | cprod == libreria.rellena("0", 20))
            {
                txtcprod.Focus();
                bandera = false;
            }
            if (libreria.stringadecimalconpunto(txtcantidad.Text) == 0)
            {
                txtcantidad.Focus();
                bandera = false;
            }
            if (libreria.stringadecimalconpunto(txtpventa.Text) == 0)
            {
                txtpventa.Focus();
                bandera = false;
            }
            if (bandera)
            {
                ///
                if (chkGrabaLp.Checked)
                    GrabaClientePreProd();
                cprod = txtcprod.Text;
                cantidad = txtcantidad.Text;
                pventa = txtpventa.Text;
                xdto = txtxdto.Text;
                bandera = true;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void GrabaClientePreProd()
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            //string xlp = listapreciograbado();

            if (libreriabase.existe("select * from clientepreprod where codigo='" + ccliente +
                                "' and cprod='" + txtcprod.Text + "'"))
            {
                preconsulta = "update clientepreprod ";
                where = " where codigo='" + ccliente + "' and cprod='" + txtcprod.Text + "'";
            }
            else
                preconsulta = "insert into clientepreprod ";
            /*
            switch (lp)
            {
                case "":
                    preconsulta = "insert into clientepreprod ";
                    break;
                default:
                    preconsulta = "update clientepreprod ";
                    where = " where codigo='" + ccliente + "' and cprod='" + txtcprod.Text + "'";
                    //lp = xlp;
                    break;
            }
            */
            set = "set codigo = '" + ccliente + "', cprod = '" + txtcprod.Text +
                       "', lp = '" + lp + "', dto='"+txtxdto.Text+"'";
            bdcomun.ejecuta(preconsulta + set + where);
            configuracion.mensaje("Listado precio grabado");
        }

        private void txtcprod_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.F7:
                    break;
            }
        }

        private void txtcprod_Leave(object sender, EventArgs e)
        {
            abmproceso.cprodexit(ref txtcprod, ref txtpventa, ref txtcantidad, ref lblproductodet);
        }

        private string preciograbado()
        {
            //busco x cliente y producto en clientepreprod
            string consulta = "Select * from clientepreprod " +
                              " where codigo='" + ccliente + "' and cprod='" + txtcprod.Text + "' ";
            string xlp = bdcomun.contenidocampo(consulta, "lp");
            string precio = txtPrecioProducto.Text;
            switch (xlp)
            {
                case "":
                    break;
                case "0":
                    consulta = "Select * from productos " +
                               " where cprod='" + txtcprod.Text + "' ";
                    precio = bdcomun.contenidocampo(consulta, "pventa");
                    break;
                case "1":
                    consulta = "Select * from productos " +
                               " where cprod='" + txtcprod.Text + "' ";
                    precio = bdcomun.contenidocampo(consulta, "pventa1");
                    break;
                case "2":
                    consulta = "Select * from productos " +
                               " where cprod='" + txtcprod.Text + "' ";
                    precio = bdcomun.contenidocampo(consulta, "pventa2");
                    break;
            }
            return precio;
        }
        private string[] listapreciograbado()
        {
            //busco x cliente y producto en clientepreprod
            string consulta = "Select * from clientepreprod " +
                              " where codigo='" + ccliente + "' and cprod='" + txtcprod.Text + "' ";
            string[] xlp = { bdcomun.contenidocampo(consulta, "lp"), bdcomun.contenidocampo(consulta, "Dto") };
            return xlp;
        }
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtcantidad, e);
        }

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa, e);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmhelpprod frm = new frmhelpprod();
            frm.lp = lp;
            frm.cmbcpventa = cmbcpventa;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPrecioProducto.Text = frm.retornapventa; //solo para mostrar precio base
                txtcprod.Text = frm.retornacprod;
                //txtpventa.Text = frm.retornapventa;
                txtPrecioProducto.Text = preciograbado();
                txtpventa.Text = txtPrecioProducto.Text;
                if (listapreciograbado()[0] != string.Empty) { 
                    lp = listapreciograbado()[0];
                    txtxdto.Text = listapreciograbado()[1];
                }
                cmbLP.SelectedIndex = Convert.ToInt16(lp);
                if (chkiva.Checked)
                {
                    chkiva.Checked = false;
                    chkiva.Checked = true;
                }
                else
                {
                    chkiva.Checked = true;
                    chkiva.Checked = false;
                }

                txtcprod.Focus();
                SendKeys.Send("{TAB}");
                txtcantidad.Text = "1";
            }
        }

        private void frmItemFactura_Load(object sender, EventArgs e)
        {
            if (tag == 0)
            {
                txtcprod.Text = string.Empty;
                txtcantidad.Text = "0";
                txtPrecioProducto.Text = "0";
                txtpventa.Text = "0";
                txtxdto.Text = "0";
                btnProducto.Enabled = true;
            }
            else
            {
                btnProducto.Enabled = false;
                lblproductodet.Text = bdcomun.contenidocampo("select * from productos where cprod='" + cprod + "'", "detalle");
                txtcprod.Text = cprod;
                txtcantidad.Text = cantidad;
                //if (listapreciograbado() != string.Empty)
                //    lp = listapreciograbado();
                txtPrecioProducto.Text = preciobase(lp, txtcprod.Text);
                txtpventa.Text = pventa;
                txtxdto.Text = xdto;

                //txtcprod.Focus();
                //SendKeys.Send("{TAB}");
                txtcantidad.Focus();
            }
            chkiva.Checked = aplicaiva;
            cmbLP.SelectedIndex = Convert.ToInt16(lp);
        }

        private string preciobase(string lp, string cprod)
        {
            string preciobase = string.Empty;
            int lpint = Convert.ToInt16(lp);
            switch (lpint)
            {
                case 0:
                    preciobase = bdcomun.contenidocampo("select * from productos where cprod='" + cprod + "'", "pventa");
                    break;
                case 1:
                    preciobase = bdcomun.contenidocampo("select * from productos where cprod='" + cprod + "'", "pventa1");
                    break;
                case 2:
                    preciobase = bdcomun.contenidocampo("select * from productos where cprod='" + cprod + "'", "pventa2");
                    break;
            }
            return preciobase;
        }

        private void txtxdto_TextChanged(object sender, EventArgs e)
        {
            if (txtxdto.Text == string.Empty)
                txtxdto.Text = "0";
        }

        private void btnAplica_Click(object sender, EventArgs e)
        {
            txtxdto.Text = txtxdto.Text.Replace(',', '.');
            decimal pvta = Convert.ToDecimal(txtxdto.Text);
            switch (txtxdto.Text)
            {
                case "0":
                    if (chkiva.Checked)
                        txtpventa.Text = libreria.incrementaporc(txtPrecioProducto.Text, 21, "+");
                    else
                        txtpventa.Text = txtPrecioProducto.Text;
                    break;
                default:
                    if (chkiva.Checked)
                    {
                        txtpventa.Text = libreria.incrementaporc(txtPrecioProducto.Text, 21, "+");
                        txtpventa.Text = libreria.incrementaporc(txtpventa.Text, pvta, "-");
                    }
                    else
                        txtpventa.Text = libreria.incrementaporc(txtPrecioProducto.Text, pvta, "-");
                    break;
            }
        }

        private void txtxdto_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxdto, e);
        }

        private void chkiva_CheckedChanged(object sender, EventArgs e)
        {
            //btnAplica.PerformClick();
        }

        private void cmbLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecioProducto.Text = preciobase(cmbLP.SelectedIndex.ToString(), txtcprod.Text);
            txtpventa.Text = txtPrecioProducto.Text;
            lp = cmbLP.SelectedIndex.ToString();
        }

        private void txtcprod_TextChanged(object sender, EventArgs e)
        {
            abmproceso.cprodexit(ref txtcprod, ref txtpventa, ref txtcantidad, ref lblproductodet);
            switch (txtcprod.Text)
            {
                case "00000000000000000001":
                    pictureBox1.BackgroundImage = Loundry.Properties.Resources.LC;
                    break;
                case "00000000000000000002":
                    pictureBox1.BackgroundImage = Loundry.Properties.Resources.LG;
                    break;
                case "00000000000000000003":
                    pictureBox1.BackgroundImage = Loundry.Properties.Resources.SECADO;
                    break;
                case "00000000000000000020":
                case "00000000000000000021":
                case "00000000000000000022":
                case "00000000000000000023":
                    pictureBox1.BackgroundImage = Loundry.Properties.Resources.servicioValet;
                    txtPrecioProducto.Text = InputDialog.mostrar("Ingrese Precio de venta)");
                    txtpventa.Text = txtPrecioProducto.Text;
                    break;
                default:
                    pictureBox1.BackgroundImage = Loundry.Properties.Resources.interrogacion;
                    break;
            }
        }

        private void chkGrabaLp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpventa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
