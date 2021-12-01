using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmcaja : Form
    {
        public int puntero, puntero2;
        public frmcaja()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefreshcaja_Click(object sender, EventArgs e)
        {
            abmcaja.refreshcaja(ref dgvcaja, "");
        }

        private void frmcaja_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvcaja, "", 9, true);
            configuracion.confdgv(dgvdetcaja, "", 9, true);
            configuracion.confdgv(dgvfacturas, "", 9, true);
            configuracion.confdgv(dgvitemfactura, "", 9, true);
            configuracion.grupobox(grpabm);
            configuracion.grupobox(grpabmdetcaja);
            configuracion.tabcontrol(tabControl1);
            cmbfacnc.SelectedIndex = 0;
            btnrefreshcaja.PerformClick();
        }

        private void btnnuevacaja_Click(object sender, EventArgs e)
        {
            try
            {
                puntero = dgvcaja.CurrentRow.Index;
                string valor = this.dgvcaja.Rows[puntero].Cells["platacie"].Value.ToString();
            }
            catch
            {
                puntero = -1;
            }

            if (puntero <= 0) //if (!libreria.IsNumeric(valor))
            {
                btncierracaja.Enabled = true;
                abmcaja.alta(ref txtnrocaja, ref cmbempl, ref cmbcempl, ref txtplataini, ref txtplatacie, ref grpiniciacaja, ref grpcierracaja);
            }
            else
            {
                btncierracaja.Enabled = false;
                libreria.seleccionaitemcombo(ref cmbcempl, " ");
            }
        }

        private void btniniciocaja_Click(object sender, EventArgs e)
        {
            if (txtnrocaja.Text != string.Empty)
            {
                if (cmbcempl.Text != string.Empty)
                {
                    btniniciocaja.Enabled = true;
                    btncierracaja.Enabled = false;
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    string hora = DateTime.Now.ToString("H:mm:ss");
                    string plata = libreria.decimalastringconpunto(Convert.ToDecimal(txtplataini.Text));
                    string consulta = "insert into caja (fechini, horaini, plataini, nrocaja, ccajero) values " +
                                      "('" + fecha + "', '" + hora + "', '" + plata + "', '" + txtnrocaja.Text + "', '" + cmbcempl.Text + "')";
                    bdcomun.ejecuta(consulta);
                    btnrefreshcaja.PerformClick();
                    btniniciocaja.Enabled = false;
                    btncierracaja.Enabled = true;
                    configuracion.mensaje("La caja ha sido abierta");
                }
                else
                {
                    configuracion.mensaje("Debe ingresar un Cajero");
                }
            }
            else { configuracion.mensaje("Clickee la última caja cerrada"); }
        }

        private void btncierracaja_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("H:mm:ss");
            string plata = libreria.decimalastringconpunto(Convert.ToDecimal(txtplatacie.Text));
            string consulta = "update caja set fechcie='" + fecha + "', horacie='" + hora + "', platacie='" + plata + "' where nrocaja='" + txtnrocaja.Text + "'";
            bdcomun.ejecuta(consulta);
            btnrefreshcaja.PerformClick();
            btncierracaja.Enabled = false;
            btniniciocaja.Enabled = true;
            configuracion.mensaje("La caja ha sido cerrada");
        }

        private void cmbempl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcempl.SelectedIndex = cmbempl.SelectedIndex;
        }

        private void cmbcempl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbempl.SelectedIndex = cmbcempl.SelectedIndex;
        }

        private void dgvcaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                puntero = dgvcaja.CurrentRow.Index;
                //btnrefreshdetcaja.PerformClick();
                //btnrefreshfacturacion.PerformClick();
                if (this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value != null)
                {
                    string nrocaja = this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString();
                    grpdetcaja.Text = "Detalle caja Nro: " + nrocaja;
                    abmcaja.refreshdetcaja(ref dgvdetcaja, "Select * from detcaja where nrocaja='" + nrocaja + "'");
                    abmcaja.refreshfacturacion(ref dgvfacturas, "Select factfinal.cform, formularios.detalle, factfinal.nroform, total, neto, factfinal.iva, pago, pago1, " +
                                                "pago2, Cliente.Rsocial, xdto" +
                                                "from factfinal " +
                                                //"left join cheques on (cheques.cform=factfinal.cform and cheques.nroform=factfinal.nroform) " +
                                                "left join cliente on (cliente.codigo=factfinal.ccliente) " +
                                                "left join formularios on (formularios.cform=factfinal.cform) " +
                                                "where factfinal.nrocaja='" + nrocaja + "'");
                    /*
                                         abmcaja.refreshfacturacion(ref dgvfacturas, "Select factfinal.cform, formularios.detalle, factfinal.nroform, total, neto, factfinal.iva, pago, pago1, " +
                                                "pago2, cheques.importe, Cliente.Rsocial, xdto " +
                                                "from factfinal " +
                                                "left join cheques on (cheques.cform=factfinal.cform and cheques.nroform=factfinal.nroform) " +
                                                "left join cliente on (cliente.codigo=factfinal.ccliente) " +
                                                "left join formularios on (formularios.cform=factfinal.cform) " +
                                                "where factfinal.nrocaja='" + nrocaja + "'");

                     */
                    string[] campos = { "cform" };
                    configuracion.dgvocultacolumna(ref dgvfacturas, campos);
                    txtrecaudaefectivo.Text = bdcomun.contenidocampo("Select sum(pago) as efectivo from factfinal where nrocaja='" + nrocaja + "'", "efectivo");
                    txtrecaudachctacte.Text = bdcomun.contenidocampo("Select sum(pago1) as chctacte from factfinal where nrocaja='" + nrocaja + "'", "chctacte");

                    btnnuevacaja.PerformClick();
                }
            }
            catch
            {
                puntero = -1;
                configuracion.mensaje("No existen registros de caja");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            string valor = string.Empty;
            string nrocaja = "0";
            try
            {
                puntero = dgvcaja.CurrentRow.Index;
                valor = this.dgvcaja.Rows[puntero].Cells["platacie"].Value.ToString();
            }
            catch
            {
                nrocaja = "1";
                puntero = -1;
            }

            if (!libreria.IsNumeric(valor))
            {
                this.tabControl1.SelectedTab = tabPagemovimiento;
                if (puntero != -1)
                {
                    nrocaja = this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString();
                    //grpabmdetcaja.Visible = true;
                    grpabmdetcaja.Enabled = true;
                    abmcaja.abmdetcaja(ref cmboperacion, ref txtcprov, ref txtccliente, ref txtdinero, ref txtdetalle, ref txtxnrocaja, nrocaja, ref txtcheque);
                    btnrefreshdetcaja.PerformClick();
                }
            }
            else { configuracion.mensaje("La caja selecciona ya esta cerrada"); }
        }

        private void btnrefreshdetcaja_Click(object sender, EventArgs e)
        {
            try
            {
                puntero = dgvcaja.CurrentRow.Index;
                if (this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString() != null)
                {
                    string nrocaja = this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString();
                    grpdetcaja.Text = "Detalle caja Nro: " + nrocaja;
                    abmcaja.refreshdetcaja(ref dgvdetcaja, "Select * from detcaja where nrocaja='" + nrocaja + "'");
                }
            }
            catch
            {
                configuracion.mensaje("No hay caja disponible de movimiento");
            }
        }

        private void cmbprov_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            bdcomun.ejecuta("truncate auxcheques");
            lblgprov.Text = string.Empty;
            txtcprov.Text = string.Empty;
            txtccliente.Text = string.Empty;
            lblgcliente.Text = string.Empty;
            txtdinero.Text = "0";
            txtcheque.Text = "0";
            txtdetalle.Text = string.Empty;
            cmboperacion.SelectedIndex = 0;
            grpabmdetcaja.Enabled = false;
        }

        private void btngraba_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtcheque.Text) > 0)
            {
                libreriaproceso.grabactacte(txtccliente.Text, btncancela, txtnrocaja.Text, txtcheque.Text, "CAJA");
                bdcomun.ejecuta("insert into cheques (ccliente, fechform, hora,nrocaja, cform, nroform, banco, ncheque, importe, fechcheque,presentado) " +
                                "select ccliente, fechform, hora,nrocaja, cform, nroform, banco, ncheque, importe, fechcheque,presentado from auxcheques"); ;
            }
            abmcaja.grabadetcaja(ref txtdinero, ref txtcheque, ref cmboperacion, ref txtxnrocaja, ref txtdetalle, ref txtcprov, ref txtccliente);
            bdcomun.ejecuta("truncate auxcheques");
            txtplatacie.Text = abmcaja.cuantotienelacaja(txtxnrocaja.Text);
            //
            string nrocaja = this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString();
            grpdetcaja.Text = "Detalle caja Nro: " + nrocaja;
            abmcaja.refreshdetcaja(ref dgvdetcaja, "Select * from detcaja where nrocaja='" + nrocaja + "'");
            //
            //grpabmdetcaja.Visible = false;
            lblgprov.Text = string.Empty;
            txtcprov.Text = string.Empty;
            txtccliente.Text = string.Empty;
            lblgcliente.Text = string.Empty;
            txtdinero.Text = "0";
            txtcheque.Text = "0";
            txtdetalle.Text = string.Empty;
            cmboperacion.SelectedIndex = 0;
            grpabmdetcaja.Enabled = false;
        }

        private void cmboperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboperacion.Text == "INGRESO")
            {
                lblprov.Visible = false;
            }
            else
            {
                lblprov.Visible = true;
            }
        }

        private void btnrefreshfacturacion_Click(object sender, EventArgs e)
        {
            puntero = dgvcaja.CurrentRow.Index;
            if (this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString() != null)
            {
                string nrocaja = this.dgvcaja.Rows[puntero].Cells["nrocaja"].Value.ToString();
                switch (cmbfacnc.SelectedIndex)
                {
                    case 0:
                        abmcaja.refreshfacturacion(ref dgvfacturas, "Select a.fechform, a.cform, d.detalle, a.nroform, total, neto, a.iva, pago, pago1, " +
                                                    "pago2, b.importe, c.Rsocial, xdto, a.cae, a.caeanul,a.ccliente, a.facturaanul " +
                                                    "from factfinal as a " +
                                                    "left join cheques as b on (b.cform=a.cform and b.nroform=a.nroform) " +
                                                    "inner join cliente as c on (c.codigo=a.ccliente) " +
                                                    "inner join formularios as d on (d.cform=a.cform) " +
                                                    "where a.nrocaja='" + nrocaja + "' order by a.pk desc");
                        break;
                    case 1:
                        abmcaja.refreshfacturacion(ref dgvfacturas, "Select a.fechform, a.cform, d.detalle, a.nroform, total, neto, a.iva, pago, pago1, " +
                                                    "pago2, b.importe, c.Rsocial, xdto,a.cae,a.caeanul, a.ccliente, a.facturaanul " +
                                                    "from factfinal as a " +
                                                    "left join cheques as b on (b.cform=a.cform and b.nroform=a.nroform) " +
                                                    "inner join cliente as c on (c.codigo=a.ccliente) " +
                                                    "inner join formularios as d on (d.cform=a.cform) " +
                                                    "where a.nrocaja='" + nrocaja + "' and a.cform<>'ANUL' " +
                                                    " order by a.pk desc");
                        break;
                    case 2:
                        abmcaja.refreshfacturacion(ref dgvfacturas, "Select a.fechform, a.cform, d.detalle, a.nroform, total, neto, a.iva, pago, pago1, " +
                                                    "pago2, b.importe, c.Rsocial, xdto,a.cae,a.caeanul, a.ccliente,a.facturaanul " +
                                                    "from factfinal as a " +
                                                    "left join cheques as b on (b.cform=a.cform and b.nroform=a.nroform) " +
                                                    "inner join cliente as c on (c.codigo=a.ccliente) " +
                                                    "inner join formularios as d on (d.cform=a.cform) " +
                                                    "where a.nrocaja='" + nrocaja + "' and a.cform='ANUL' " +
                                                    " order by a.pk desc");
                        break;
                }
                string[] campos = { "cform" };
                configuracion.dgvocultacolumna(ref dgvfacturas, campos);
                decimal total = 0;
                for (int i = 0; i < dgvfacturas.Rows.Count; i++)
                    total += Convert.ToDecimal( libreria.valorcelda(i, dgvfacturas, "Total", "0"));
                txtrecaudaefectivo.Text = total.ToString();
            }
        }

        private void txtdinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtdinero, e);
        }

        private void cmboperacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void txtccliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtccliente.Text = string.Empty;
            frmprocesocliente frm = new frmprocesocliente();
            if (frm.ShowDialog() == DialogResult.OK)
                txtccliente.Text = frm.retornaccliente;
            lblgcliente.Text = bdcomun.contenidocampo("select * from cliente where codigo='" + txtccliente.Text + "'", "rsocial");
            if (txtccliente.Text != string.Empty)
            {
                txtcprov.Text = string.Empty;
                lblgprov.Text = string.Empty;
                txtcheque.Enabled = true;
            }
            else txtcheque.Enabled = false;
        }

        private void txtcprov_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtcprov.Text = string.Empty;
            frmcajaproveedor frm = new frmcajaproveedor();
            if (frm.ShowDialog() == DialogResult.OK)
                txtcprov.Text = frm.retornacprov;
            lblgprov.Text = bdcomun.contenidocampo("select * from proveedores where cprov='" + txtcprov.Text + "'", "rsocial");
            if (txtcprov.Text != string.Empty)
            {
                txtccliente.Text = string.Empty;
                lblgcliente.Text = string.Empty;
                txtcheque.Enabled = false;
            }
        }

        private void txtcheque_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmcheque frm = new frmcheque();
            frm.ccliente = txtccliente.Text;
            frm.ccaja = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1 ", "nrocaja");
            frm.cform = "KJAN";// bdcomun.contenidocampo("select * from auxmovimiento3 where cpventa='" + cmbcpventa.Text + "'", "cform");
            frm.nroform = frm.ccaja;//txtnroform.Text;
            frm.total = txtcheque.Text;
            if (frm.ShowDialog() == DialogResult.OK)
                txtcheque.Text = frm.retornavalor;
        }

        private void txtcheque_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtcheque);
        }

        private void txtcprov_Leave(object sender, EventArgs e)
        {
            if (txtcprov.Text != string.Empty)
            {
                txtccliente.Text = string.Empty;
                lblgcliente.Text = string.Empty;
            }
        }

        private void txtccliente_Leave(object sender, EventArgs e)
        {
            if (txtcprov.Text != string.Empty)
            {
                txtcprov.Text = string.Empty;
                lblgprov.Text = string.Empty;
            }
        }

        private void txtcprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            configuracion.mensaje("Dbl Click sobre el box para buscar proveedor");
            txtcprov.Text = string.Empty;
        }

        private void txtccliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            configuracion.mensaje("Dbl Click sobre el box para buscar cliente");
            txtccliente.Text = string.Empty;
        }

        private void txtcheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtcheque, e);
            configuracion.mensaje("Dbl Click sobre el box para ingresar cheques");
            txtcheque.Text = "0";
        }

        private void txtdinero_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtdinero);
        }

        private void dgvcaja_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvdetcaja_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvfacturas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void btnAnulaFactura_Click(object sender, EventArgs e)
        {
            string caeanul = libreria.valorcelda(puntero2, dgvfacturas, "caeanul", "");
            if (caeanul.Trim() == string.Empty)
            {
                frmremfact frm = new frmremfact();
                frm.proceso = "ANULA FACTURA";
                frm.afcform = libreria.valorcelda(puntero2, dgvfacturas, "cform", "");
                frm.afnroform = libreria.valorcelda(puntero2, dgvfacturas, "nroform", "");
                frm.ShowDialog();
            }
            else configuracion.mensaje("La factura ya fue anulada");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    btnrefreshfacturacion.PerformClick();
                    break;
            }
        }

        private void cmbfacnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnrefreshfacturacion.PerformClick();
        }

        private void btnReimprime_Click(object sender, EventArgs e)
        {
            puntero2 = dgvfacturas.CurrentRow.Index;
            if (this.dgvfacturas.Rows[puntero2].Cells["nroform"].Value.ToString() != null)
            {
                if (this.dgvfacturas.Rows[puntero2].Cells["cform"].Value.ToString() == "ANUL")
                {
                    string cform = this.dgvfacturas.Rows[puntero2].Cells["cform"].Value.ToString();
                    string nroform = this.dgvfacturas.Rows[puntero2].Cells["nroform"].Value.ToString();
                    string cae = this.dgvfacturas.Rows[puntero2].Cells["cae"].Value.ToString();
                    string fechform = this.dgvfacturas.Rows[puntero2].Cells["fechform"].Value.ToString();

                    imprimenc(cform, nroform, cae, fechform);
                }
                else
                {
                    string fechform = this.dgvfacturas.Rows[puntero2].Cells["fechform"].Value.ToString();
                    string cform = this.dgvfacturas.Rows[puntero2].Cells["cform"].Value.ToString();
                    string nroform = this.dgvfacturas.Rows[puntero2].Cells["nroform"].Value.ToString();
                    string ccliente = this.dgvfacturas.Rows[puntero2].Cells["ccliente"].Value.ToString();
                    string neto = this.dgvfacturas.Rows[puntero2].Cells["neto"].Value.ToString();
                    string iva = this.dgvfacturas.Rows[puntero2].Cells["iva"].Value.ToString();
                    string total = this.dgvfacturas.Rows[puntero2].Cells["total"].Value.ToString();
                    string cae = this.dgvfacturas.Rows[puntero2].Cells["cae"].Value.ToString();
                    imprimefact(fechform, cform, nroform, ccliente, neto, iva, total, cae);
                }
            }

        }

        void imprimenc(string cform, string nroform, string cae, string fechform)
        {
            string consulta = "select * from factfinal where trim(caeanul)='" + cae.Trim() + "' and cform<>'ANUL'";
            string xcform = bdcomun.contenidocampo(consulta, "cform");
            string xnroform = bdcomun.contenidocampo(consulta, "nroform");
            string xccliente = bdcomun.contenidocampo(consulta, "Ccliente");
            string xtotal = bdcomun.contenidocampo(consulta, "total");


            frmReporteNc frm = new frmReporteNc();
            frm.consulta = "Select * from factfinal " +
                           " where cform='" + xcform +
                           "' and nroform='" + xnroform + "'";
            if (xcform == "0TK0")
                frm.TKX = "B";
            else
                frm.TKX = "A";
            frm.fecha = libreria.fechalatina(fechform);// DateTime.Now.ToString("dd/MM/yyyy");
            frm.cform = "NC";// de NC;
            frm.nroform = nroform; // de NC
            frm.ccliente = xccliente;
            frm.subtotal = xtotal;
            frm.dto = "0";
            frm.total = frm.subtotal;
            frm.cae = cae;
            frm.vto = " ";
            frm.iva105 = "0";
            frm.iva21 = "0";
            frm.ivasubtotal = frm.subtotal;
            if (xcform == "0TK0")
                frm.tipofactura = "B";
            else
                frm.tipofactura = "A";

            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from cliente where codigo='" + frm.ccliente + "'", cnn);
            reg.Read();
            frm.ivacliente = reg["iva"].ToString();
            if (reg["ncuit"].ToString() != string.Empty)
                frm.cuitcliente = reg["ncuit"].ToString();
            else frm.cuitcliente = " ";
            frm.nomcliente = reg["Rsocial"].ToString();
            frm.domcliente = reg["Domicilio"].ToString();
            reg.Close();
          
            cnn.Close();
            frm.Show();
        }

        void imprimefact(string fechform, string cform, string nroform, string ccliente, string neto, string iva, string total,
            string cae)
        {
            Frmreportefactura frm = new Frmreportefactura();
            frm.consulta = "Select Fechform, movimiento.cprod, movimiento.cantidad, movimiento.pventa, "+
                           "format(movimiento.pventa * movimiento.cantidad,2) as subtotal," +
                           "productos.detalle " +
                           "from movimiento " +
                           "inner join productos on (productos.cprod=movimiento.cprod) " +
                           " where movimiento.cform='" + cform + "' and movimiento.nroform='" + nroform + "'";
            DateTime fecha = Convert.ToDateTime(fechform);
            frm.fecha = fecha.ToString("dd/MM/yyyy");
            frm.nrofact = nroform;
            frm.ccliente = ccliente;
            frm.subtotal = neto;
            frm.dto = "0";
            frm.total = total;

            frm.cae = cae;
            fecha = fecha.AddDays(10);
            frm.vto = fecha.ToString("dd/MM/yyyy");
            numeroaletra nl = new numeroaletra();
            frm.ImporteLetra = nl.Convertir(total, true);

            switch (cform)
            {
                case "0TK0":
                    frm.iva105 = "0";
                    frm.iva21 = "0";
                    frm.ivasubtotal = frm.subtotal;
                    frm.tipofactura = "B";
                    break;
                case "0TK1":
                    frm.iva105 = "0";
                    frm.iva21 = iva; // libreria.porcentaje(txttotal.Text, 21);
                    frm.ivasubtotal = neto; // libreria.incrementaporc(txttotal.Text, 21, "-");
                    frm.tipofactura = "A";
                    break;
            }
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from cliente where codigo='" + ccliente + "'", cnn);
            reg.Read();
            frm.ivacliente = reg["iva"].ToString();
            if (reg["ncuit"].ToString() != string.Empty)
                frm.cuitcliente = reg["ncuit"].ToString();
            else frm.cuitcliente = " ";
            frm.nomcliente = reg["Rsocial"].ToString();
            frm.domcliente = reg["Domicilio"].ToString();
            reg.Close();
          
            cnn.Close();
            frm.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            libreria.exportaDgvExcel(dgvfacturas);
        }

        private void dgvfacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            puntero2 = dgvfacturas.CurrentRow.Index;
            if (this.dgvfacturas.Rows[puntero2].Cells["nroform"].Value.ToString() != null)
            {
                string cform = this.dgvfacturas.Rows[puntero2].Cells["cform"].Value.ToString();
                string nroform = this.dgvfacturas.Rows[puntero2].Cells["nroform"].Value.ToString();
                abmcaja.refreshitemsfacturacion(ref dgvitemfactura, "Select movimiento.cprod,productos.detalle, movimiento.cantidad from movimiento " +
                    "inner join productos on (productos.cprod=movimiento.cprod) " +
                    "where movimiento.cform='" + cform + "' and movimiento.nroform='" + nroform + "'");

            }
        }
    }
}
