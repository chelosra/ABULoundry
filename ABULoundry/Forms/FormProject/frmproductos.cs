using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Loundry
{
    public partial class frmproductos : Form
    {
        public MySqlConnection conectar;
        public int puntero;
        public frmproductos()
        {
            InitializeComponent();
        }

        private void frmproductos_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvproductos, "", 9, true);
            dgvproductos.MouseClick += new MouseEventHandler(dgvproductos_MouseClick);
            configuracion.confdgv(dgvconsulta, "", 9, true);
            configuracion.grupobox(grpabm);
            configuracion.grupobox(grpAumentoPrecio);
            configuracion.tabcontrol(tabControl1);
            libreriabase.cargabox2(ref cmbRubroPrecio, "detalle", ref cmbCrubroPrecio, "crubro", "rubros", true, "");

            btnrefresh.PerformClick();
        }

        private void dgvproductos_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int fila = dgvproductos.HitTest(e.X, e.Y).RowIndex;

                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name = "Nue";
                    m.Items.Add("Modificar").Name = "Mod";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Buscar").Name = "Bus";
                }

                m.Show(dgvproductos, new Point(e.X, e.Y));
                //evento
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
            }
        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.ClickedItem.Name.ToString())
            {
                case "Nue":
                    btnnuevo.PerformClick();
                    break;
                case "Mod":
                    btnmodifica.PerformClick();
                    break;
                case "Bor":
                    btnborra.PerformClick();
                    break;
                case "Bus":
                    btnbuscar.PerformClick();
                    break;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
        }

        private void btngraba_Click(object sender, EventArgs e)
        {
            abmproducto.graba(txtcprod.Text, txtdetalle.Text, txtstmin.Text, txtstact.Text, txtpcosto.Text, txtpventa.Text, txtpventa1.Text,
                              txtpventa2.Text, cmbcrubro.Text, txtxmostrador.Text, txtxminorista.Text, txtxmayorista.Text, ref dgvproductos);
            grpabm.Visible = false;
        }

        private void cmbrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcrubro.SelectedIndex = cmbrubro.SelectedIndex;
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            /*
            string aux = txtcprod.Text;
            txtcprod.Text = libreria.rellena(aux, 20);
            //buscar si existe
            if (libreriabase.existe("select * from productos where crubro='"+ txtcprod.Text+"'"))
            {
                configuracion.mensaje("El producto existe");
                txtcprod.Text = string.Empty;
                txtcprod.Focus();
            }
            btnrefresh.PerformClick();
            */
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmproducto.refresh(ref dgvproductos, "");
        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                puntero = dgvproductos.CurrentRow.Index;
            }
            catch
            {
                puntero = -1;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            abmproducto.alta(ref txtcprod, ref txtdetalle, ref txtxmostrador, ref txtxminorista, ref txtxmayorista, ref txtstact, ref txtstmin,
                             ref txtpcosto, ref txtpventa, ref txtpventa1, ref txtpventa2, ref cmbrubro, ref cmbcrubro, ref dgvproductos);
            grpabm.Visible = true;
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            puntero = dgvproductos.CurrentRow.Index;
            string dato = this.dgvproductos.Rows[puntero].Cells["cprod"].Value.ToString();
            abmproducto.borra(dato, ref dgvproductos);
        }

        private void cmbcrubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbrubro.SelectedIndex = cmbcrubro.SelectedIndex;
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvproductos.CurrentRow.Index;
            string dato = this.dgvproductos.Rows[puntero].Cells["cprod"].Value.ToString();
            abmproducto.modif(ref txtcprod, ref txtdetalle, ref txtstmin, ref txtstact, ref txtpcosto, ref txtpventa, ref txtpventa1, ref txtpventa2,
                              ref cmbrubro, ref cmbcrubro, ref txtxmostrador, ref txtxminorista, ref txtxmayorista, ref dgvproductos, dato);
            grpabm.Visible = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmproducto.buscar(ref dgvproductos);
        }

        private void txtstmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtstmin, e);
        }

        private void txtstact_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtstact, e);
        }

        private void txtpcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpcosto, e);
        }

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa, e);
        }

        private void txtpventa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa1, e);
        }

        private void txtpventa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa2, e);
        }

        private void txtstmin_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtstmin);
        }

        private void txtstact_Layout(object sender, LayoutEventArgs e)
        {
            libreria.textboxvacioxcero(txtstact);
        }

        private void txtpcosto_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpcosto);
        }

        private void txtpventa_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpventa);
        }

        private void txtpventa1_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpventa1);
        }

        private void txtpventa2_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpventa2);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtpcosto_TextChanged(object sender, EventArgs e)
        {
            //busco en rubros cada porcentaje y los guardo en variables
            if (txtxmostrador.Text != string.Empty && txtxminorista.Text != string.Empty &&
                txtxmayorista.Text != string.Empty && txtpcosto.Text != string.Empty)
            {
                int pmos = Convert.ToInt16(txtxmostrador.Text);
                int pmin = Convert.ToInt16(txtxminorista.Text);
                int pmay = Convert.ToInt16(txtxmayorista.Text);
                txtpventa.Text = libreria.incrementaporc(txtpcosto.Text, pmos, "+");
                txtpventa1.Text = libreria.incrementaporc(txtpcosto.Text, pmin, "+");
                txtpventa2.Text = libreria.incrementaporc(txtpcosto.Text, pmay, "+");
            }
            else
            {
                configuracion.mensaje("Verifique precio de costo y porcentajes");
                txtpcosto.Text = "0";
            }
        }

        private void txtxmostrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxmostrador, e);
        }

        private void txtxminorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxminorista, e);
        }

        private void txtxmayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxmayorista, e);
        }

        private void txtxmostrador_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxmostrador);
        }

        private void txtxminorista_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxminorista);
        }

        private void txtxmayorista_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxminorista);
        }

        private void txtccliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmbconsulta.SelectedIndex = 0;
            frmprocesocliente frm = new frmprocesocliente();
            if (frm.ShowDialog() == DialogResult.OK)
                txtccliente.Text = frm.retornaccliente;
            string lp = bdcomun.contenidocampo("select * from cliente where codigo='" + txtccliente.Text + "'", "lp");
            lblgrsocial.Text = bdcomun.contenidocampo("select * from cliente where codigo='" + txtccliente.Text + "'", "rsocial");
            abmproducto.refreshconsulta(ref dgvconsulta, lp);
            groupBox2.Text = lblgrsocial.Text;
        }

        private void btnimprime_Click(object sender, EventArgs e)
        {
            string lp = bdcomun.contenidocampo("Select * from cliente where codigo='" + txtccliente.Text + "'", "lp");
            string kampo = string.Empty;
            switch (lp)
            {
                case "0":
                    kampo = "pventa";
                    break;
                case "1":
                    kampo = "pventa1";
                    break;
                case "2":
                    kampo = "pventa2";
                    break;
            }
            string consulta = "select Cprod, Productos.Detalle, " + kampo + " as pventa, rubros.detalle as Rubro " +
                              " from productos " +
                              "Inner join rubros on (rubros.crubro=productos.crubro) " +
                              " order by Rubros.detalle, Productos.detalle";

            frmreporteprod frm = new frmreporteprod();
            frm.consulta = consulta;
            frm.fecha = DateTime.Now.ToString("dd/MM/yyyy");
            frm.cliente = bdcomun.contenidocampo("Select * from cliente where codigo='" + txtccliente.Text + "'", "rsocial"); ;
            frm.Show();
        }

        private void txtccliente_TextChanged(object sender, EventArgs e)
        {
            if (txtccliente.Text != string.Empty)
            {
                grpaccion2.Visible = true;
                lblgrsocial.Visible = true;
            }
            else
            {
                grpaccion2.Visible = false;
                lblgrsocial.Visible = false;
            }
        }

        private void cmbconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = string.Empty;
            int ind = cmbconsulta.SelectedIndex;
            switch (ind)
            {
                case 1:
                    consulta = "Select * from productos where stact<=stmin order by crubro";
                    abmproducto.refresh(ref dgvconsulta, consulta);
                    break;
                case 2:
                    consulta = "Select * from productos where pcosto='' order by crubro";
                    abmproducto.refresh(ref dgvconsulta, consulta);
                    break;
            }
            txtccliente.Text = string.Empty;
            lblgrsocial.Text = string.Empty;
            groupBox2.Text = cmbconsulta.Text;
        }

        private void dgvproductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvconsulta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void cmbRubroPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCrubroPrecio.SelectedIndex = cmbRubroPrecio.SelectedIndex;
        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            string dato = cmbCrubroPrecio.Text;
            if (dato != string.Empty)
            {
                string consulta = "select * from productos where crubro='" + dato + "'";
                int cantidad = 100; // bdcomun.ejecuta(consulta);

                MySqlConnection conectar = bdcomun.Conexion();
                MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
                if (reg.HasRows)
                {
                    pgBarPrecio.Value = 0;
                    pgBarPrecio.Maximum = cantidad;
                    pgBarPrecio.Visible = true;
                    cantidad = 0;
                    while (reg.Read())
                    {
                        string cprod = reg["cprod"].ToString(); ;
                        string detalle = reg["detalle"].ToString();
                        string stmin = reg["stmin"].ToString();
                        string stact = reg["stact"].ToString();
                        string crubro = reg["crubro"].ToString();
                        string xmostrador = reg["xmostrador"].ToString();
                        string xminorista = reg["xminorista"].ToString();
                        string xmayorista = reg["xmayorista"].ToString();
                        string pcosto = reg["pcosto"].ToString();
                        string pventa = reg["pventa"].ToString();
                        string pventa1 = reg["pventa1"].ToString();
                        string pventa2 = reg["pventa2"].ToString();

                        if (xmostrador != string.Empty && xminorista != string.Empty &&
                            xmayorista != string.Empty && pcosto != string.Empty)
                        {
                            pcosto = libreria.incrementaporc(pcosto, Convert.ToInt32(txtPcostoaumento.Text), "+");
                            int pmos = Convert.ToInt16(xmostrador);
                            int pmin = Convert.ToInt16(xminorista);
                            int pmay = Convert.ToInt16(xmayorista);
                            pventa = libreria.incrementaporc(pcosto, pmos, "+");
                            pventa1 = libreria.incrementaporc(pcosto, pmin, "+");
                            pventa2 = libreria.incrementaporc(pcosto, pmay, "+");
                            dgvproductos.Tag = 1; //modifica
                            abmproducto.graba(cprod, detalle, stmin, stact, pcosto, pventa, pventa1, pventa2, crubro, xmostrador,
                                              xminorista, xmayorista, ref dgvproductos);
                            //configuracion.mensaje("Precios actualizados del rubro " + cmbRubroPrecio.Text);
                        }
                        else
                            configuracion.mensaje("Verifique precio de costo y porcentajes de " + detalle);
                        cantidad++;
                        pgBarPrecio.Value++;
                    }
                    pgBarPrecio.Value = 0;
                    pgBarPrecio.Visible = false;
                }
                cmbRubroPrecio.SelectedIndex = -1;
                txtPcostoaumento.Text = "0";
                configuracion.mensaje("Fin proceso de actualización de precios. Se actualizaron " + cantidad.ToString() + " Productos");
            }
        }

        private void txtPcostoaumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtPcostoaumento, e);
        }

        private void txtPcostoaumento_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtPcostoaumento);
        }
    }
}

