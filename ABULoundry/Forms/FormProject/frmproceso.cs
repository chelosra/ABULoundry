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
using FiscalNET;
using System.Threading;
using FEAFIPLib;
using System.Net.Mail;
using System.IO;

namespace Loundry
{
    public partial class frmproceso : Form
    {
        public int puntero;
        public string recibecheque = "0";
        public frmproceso()
        {
            InitializeComponent();
        }

        private void frmfacturacion_Load(object sender, EventArgs e)
        {

            abmproceso.activa(ref cmbpventa, ref cmbcpventa, ref cmbfpago1, ref cmbcfpago1,
                              ref cmbfpago2, ref cmbcfpago2, ref dgvcomanda,
                              ref txtccliente,
                              ref txtsubtotal, ref txtdto, ref txttotal, ref cmbtkt, ref cmbctkt,
                              ref btnitka, ref btnitkc, ref lblrsocial, ref lbliva, ref txtXiva, ref txtIva);
            //chkiva.Checked = true;
            configuracion.confdgv(dgvcomanda, "", 12, true);
            cmbpventa.SelectedIndex = 2;
        }
        private void cmbpventa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind;
            ind = cmbpventa.SelectedIndex;
            cmbcpventa.SelectedIndex = ind;
            abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);
            string cliente = txtccliente.Text;
            if (dgvcomanda.RowCount > 0)
            {
                if (dgvcomanda.Rows[0].Cells["cliente"].Value != null)
                    cliente = dgvcomanda.Rows[0].Cells["cliente"].Value.ToString();
            }
            txtccliente.Text = bdcomun.ejecuta("select * from cliente where codigo='" + cliente + "'", "codigo");
            txtccliente.Focus();
            SendKeys.Send("{TAB}");
            abmproceso.totalcomanda(ref cmbcpventa, ref txtsubtotal, ref txtxdto, ref txtdto, ref txttotal, ref txtccliente, ref txtXiva, ref txtIva);
        }
        private void cmbfpago1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfpago1.Text == "CHEQUE")
            {
                configuracion.mensaje("Para cheque selecciones el box siguiente");
                cmbfpago1.SelectedIndex = 0;
            }
            cmbcfpago1.SelectedIndex = cmbfpago1.SelectedIndex;
        }
        private void cmbfpago2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcfpago2.SelectedIndex = cmbfpago2.SelectedIndex;
        }
        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            abmproceso.restocomanda(ref txttotal, ref txtpago, ref txtpago1, ref txtresto, ref txtsaldocliente);
        }
        private void txtpago1_TextChanged(object sender, EventArgs e)
        {
            abmproceso.restocomanda(ref txttotal, ref txtpago, ref txtpago1, ref txtresto, ref txtsaldocliente);
        }
        private void cmbctkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtkt.SelectedIndex = cmbctkt.SelectedIndex;
        }
        private void btnitkc_Click(object sender, EventArgs e)
        {
            if (dgvcomanda.RowCount > 0)
            {
                richtxtmemo.Clear();
                libreriaproceso.funencabezado(ref richtxtmemo);
                string nro = libreriaproceso.buscanroform(ref txtnroform, cmbcpventa.Text);
                txtsubtotal.Text = libreriaproceso.total(cmbcpventa);
                libreriaproceso.memoadd(richtxtmemo, librefiscal.tiqueabre(nro));
                decimal totalfactura = 0;
                MySqlConnection cnn = bdcomun.Conexion();
                MySqlDataReader reg = bdcomun.leereg("SELECT * FROM auxmovimiento3 where cpventa = '" + cmbcpventa.Text + "'", cnn);
                if (reg.HasRows)
                {
                    while (reg.Read())
                    {
                        libreriaproceso.actualizastock(reg);
                        libreriaproceso.memoadd(richtxtmemo, librefiscal.tiqueitem(txtsubtotal, lbliva));
                        libreriaproceso.grabamovimiento(reg, nro, false);
                        totalfactura = totalfactura +
                                       (Convert.ToDecimal(reg["pventa"].ToString())
                                       *
                                       Convert.ToDecimal(reg["cantidad"].ToString()));
                    }
                }
                libreriaproceso.grabafacturacionfinal(reg, btnitka, nro, txtpago.Text, cmbcfpago1.Text,
                                                      txtpago1.Text, cmbcfpago2.Text, totalfactura,
                                                      txtxdto, txtsaldocliente);
                if (txtdiferencia.Text != "0" && txtdiferencia.Text != string.Empty)
                    libreriaproceso.grabactacte(txtccliente.Text, btnitka, txtnroform.Text, txtdiferencia.Text, "PROCESO");
                reg.Close();
                //grabo cheques
                bdcomun.ejecuta("insert into cheques (ccliente, fechform, hora,nrocaja, cform, nroform, banco, ncheque, importe, fechcheque,presentado) " +
                                "select ccliente, fechform, hora,nrocaja, cform, nroform, banco, ncheque, importe, fechcheque,presentado from auxcheques");
                bdcomun.ejecuta("truncate auxcheques");
                //limpliar auxmovimiento3
                bdcomun.ejecuta("delete from auxmovimiento3 where cpventa='" + cmbcpventa.Text + "'");
                abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);
                configuracion.mensaje("Puesto de venta actualizado");

                cnn.Close();
                libreriaproceso.memoadd(richtxtmemo, librefiscal.tiquepago("", "00.00"));
                libreriaproceso.memoadd(richtxtmemo, librefiscal.tiquecierra(""));
                txtsubtotal.Text = "0";
                //ver los checkbox ak
            }
        }
        private void btnimprimetkt_Click(object sender, EventArgs e)
        {
            if (dgvcomanda.RowCount > 0)
            {
                if (Convert.ToDecimal(txtresto.Text) == 0)
                {
                    Form frm = this.MdiChildren.FirstOrDefault(x => x is frmcheque); //Frmcreausu
                    if (frm != null)
                    {
                        configuracion.mensaje("La chequera está abierta");
                        frm.BringToFront(); // ...la pongo en primer plano
                        frm.WindowState = FormWindowState.Normal;
                    }
                    else  // Sino...
                    {
                        btncomanda.PerformClick();
                        //if (btnitka.Tag.ToString() == "1")
                        //    btnitka.PerformClick();
                        //else
                        btnitkc.PerformClick();
                        #region blanqueo txt
                        txtsubtotal.Text = "0";
                        txtdto.Text = "0";
                        txttotal.Text = "0";
                        txtpago.Text = "0";
                        txtpago1.Text = "0";
                        txtresto.Text = "0";
                        txtdiferencia.Text = "0";
                        txtsaldocliente.Text = "0";
                        cmbfpago1.SelectedIndex = 0;
                        cmbfpago2.SelectedIndex = 0;
                        #endregion
                    }
                }
                else { configuracion.mensaje("Verifique el pago"); }
            }
            else { configuracion.mensaje("No hay Items para facturark"); }
        }
        private void grabaitem(string cprod, string xcantidad, string pventa, string lp, string ccliente, string xdto, bool bandera)
        {
            if (cprod != string.Empty & libreria.stringadecimalconpunto(xcantidad) > 0 & libreria.stringadecimalconpunto(pventa) > 0 & bandera)
            {
                //chkListmesas.SelectedIndex = cmbpventa.SelectedIndex;
                //chkListmesas.Text = chkListmesas.Text + " - " + DateTime.Now.ToString("H:mm:ss");
                string consulta = "";
                string cprov = bdcomun.contenidocampo("select * from documento where cprod='" + cprod + "' order by fechform desc limit 1", "cprov");
                string nrocaja = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1 ", "nrocaja");
                string cempl = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1 ", "ccajero");
                string crubro = bdcomun.contenidocampo("select * from productos where cprod='" + cprod + "'", "crubro");
                if (libreriabase.existe("Select * from auxmovimiento3 where cprod='" + cprod + "' and cpventa='" + cmbcpventa.Text +
                                        "' and cliente='" + ccliente + "'") == false)
                {
                    decimal cantidad = libreria.stringadecimalconpunto(xcantidad);
                    decimal spventa = libreria.stringadecimalconpunto(pventa);
                    decimal subtotal = spventa * cantidad;

                    //alta
                    consulta = "insert into auxmovimiento3 " +
                               "(Fechform, cform,nroform,cprod,pventa,cantidad,cprov,hora,cpventa,cempl,nrocaja,cliente,crubro,subtotal,lp,xdto) values " +
                               "('" + DateTime.Now.ToString("yyyy-MM-dd") +
                               "','" + cmbctkt.Text +
                               "','" + txtnroform.Text +
                               "','" + cprod +
                               "','" + pventa +
                               "','" + xcantidad +
                               "','" + cprov +
                               "','" + DateTime.Now.ToString("H:mm:ss") +
                               "','" + cmbcpventa.Text +
                               "','" + cempl +
                               "','" + nrocaja +
                               "','" + txtccliente.Text +
                               "','" + crubro +
                               "','" + libreria.decimalastringconpunto(subtotal) +
                               "','" + lp +
                               "','" + xdto +
                               "')";
                }
                else
                {
                    MySqlConnection cnn = bdcomun.Conexion();
                    MySqlDataReader reg = bdcomun.leereg("select * from auxmovimiento3 where cprod='" + cprod + "' and cpventa='" + cmbcpventa.Text +
                                                         "' and cliente='" + ccliente + "'", cnn);
                    reg.Read();

                    chkedicion.Checked = true;
                    decimal cantidad = libreria.stringadecimalconpunto(xcantidad);
                    if (!chkedicion.Checked)
                        cantidad = libreria.stringadecimalconpunto(reg["cantidad"].ToString()) + libreria.stringadecimalconpunto(xcantidad);
                    decimal spventa = libreria.stringadecimalconpunto(pventa);//libreria.stringadecimalconpunto(reg["pventa"].ToString());
                    decimal subtotal = spventa * cantidad;
                    reg.Close();

                    cnn.Close();

                    //hallar cantidad y subtotal
                    consulta = "update auxmovimiento3 set " +
                               "pventa='" + pventa + "', " +
                               "xdto='" + xdto + "', " +
                               "cantidad='" + libreria.decimalastringconpunto(cantidad) + "', " +
                               "subtotal='" + libreria.decimalastringconpunto(subtotal) + "', " +
                               "lp='" + lp + "' " +
                               "where cprod='" + cprod + "' and cpventa = '" + cmbcpventa.Text + "' and Cliente='" + txtccliente.Text + "'";
                }
                bdcomun.ejecuta(consulta);
                configuracion.mensaje("auxmovimiento grabado");
                //grabarcomanda ...

                chkedicion.Checked = false;
                abmproceso.totalcomanda(ref cmbcpventa, ref txtsubtotal, ref txtxdto, ref txtdto, ref txttotal, ref txtccliente, ref txtXiva, ref txtIva);
                abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);

            }
            else { configuracion.mensaje("Stock en 0 o Precio de venta en 0"); }
        }
        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpago, e);
        }
        private void txtpago1_KeyPress(object sender, KeyPressEventArgs e)
        {
            configuracion.mensaje("El monto solo se actualiza ingresando cheques. Haga Dbl click sobre el box");
            libreria.textboxdecimal(txtpago1, e);
            txtpago1.Text = "0";
        }
        private void btnfiscal_Click(object sender, EventArgs e)
        {
            if (dgvcomanda.RowCount > 0)
            {
                richtxtmemo.Clear();
                #region fiscal
                EpsonTicket impfiscal1 = new EpsonTicket();
                //impfiscal1.IF_TRACE(1);
                impfiscal1.IF_OPEN(bdcomun.ejecuta("select * from impfiscal", "puertocom"),
                                   Convert.ToInt32(bdcomun.ejecuta("select * from impfiscal", "velocidad")));
                impfiscal1.SerialNumber = "27-0163848-435";
                #endregion

                if (impfiscal1.IF_WRITE("@ESTADO|N") == 0)
                {
                    //ak imprimer presupuesto
                    if (btnitkc.Tag == "1")
                    {
                        txtnroform.Text = librefiscal.buscanroformfiscal(impfiscal1, 5);
                        libreriaproceso.procitk(txtnroform, richtxtmemo, lbliva, txtccliente, cmbcpventa, btnitka, txtpago, cmbcfpago1, txtpago1,
                                                cmbcfpago2, txtsubtotal, txtxdto, txtsaldocliente);
                        if (richtxtmemo.Lines[0].ToString() != "ERROR")
                        {
                            librefiscal.imprimefisal(richtxtmemo, impfiscal1);

                            configuracion.mensaje("Estado impresora: " + Convert.ToString(impfiscal1.IF_ERROR1(0)) +
                                                  " Estado controlador: " + Convert.ToString(impfiscal1.IF_ERROR2(0)) +
                                                  " Nro de documento impreso: " + impfiscal1.IF_READ(3));
                        }
                        else configuracion.mensaje("Error en los datos. Vuelva a emitir la factura");
                    }
                    impfiscal1.IF_CLOSE();
                }
                else
                {
                    configuracion.mensaje("El controloador fiscal no esta preparado. Verifique control Z y Control X");
                    impfiscal1.IF_CLOSE();
                }
            }
            else configuracion.mensaje("No hay items por facturar");

        }
        private void btnborra_Click(object sender, EventArgs e)
        {
            try
            {
                puntero = dgvcomanda.CurrentRow.Index;
                string dato = this.dgvcomanda.Rows[puntero].Cells["cprod"].Value.ToString();
                abmproceso.borraitem(dato, ref dgvcomanda, cmbcpventa, ref txtccliente);
                abmproceso.totalcomanda(ref cmbcpventa, ref txtsubtotal, ref txtxdto, ref txtdto, ref txttotal, ref txtccliente, ref txtXiva, ref txtIva);
            }
            catch { }
        }
        private void btnmodifica_Click(object sender, EventArgs e)
        {
            if (dgvcomanda.Rows.Count > 0)
            {
                puntero = dgvcomanda.CurrentRow.Index;
                chkedicion.Checked = true;
                frmItemFactura frm = new frmItemFactura();
                frm.tag = 1;
                frm.ccliente = this.dgvcomanda.Rows[puntero].Cells["cliente"].Value.ToString();
                frm.cprod = this.dgvcomanda.Rows[puntero].Cells["cprod"].Value.ToString();
                frm.cantidad = dgvcomanda.Rows[puntero].Cells["cantidad"].Value.ToString();
                frm.pventa = dgvcomanda.Rows[puntero].Cells["pventa"].Value.ToString();
                frm.lp = dgvcomanda.Rows[puntero].Cells["lp"].Value.ToString();
                frm.xdto = dgvcomanda.Rows[puntero].Cells["xdto"].Value.ToString();
                frm.aplicaiva = chkiva.Checked;
                if (frm.ShowDialog() == DialogResult.OK)
                    grabaitem(frm.cprod, frm.cantidad, frm.pventa, frm.lp, txtccliente.Text, frm.xdto, frm.bandera);
                chkedicion.Checked = false;
            }
            else
                configuracion.mensaje("No hay items cargados");
        }
        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            txtresto.Text = txttotal.Text;
            abmproceso.restocomanda(ref txttotal, ref txtpago, ref txtpago1, ref txtresto, ref txtsaldocliente);

            numeroaletra nl = new numeroaletra();
            txtImporteLetra.Text = nl.Convertir(txttotal.Text, true);
        }
        private void btncomanda_Click(object sender, EventArgs e)
        {
            imprimefact("F", txtccliente.Text);
        }

        private void txtxdto_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxdto);
        }
        private void txtxdto_TextChanged(object sender, EventArgs e)
        {
            /*
            int xdto = Convert.ToInt16(txtxdto.Text);
            txtdto.Text = libreria.porcentaje(txtsubtotal.Text, xdto);
            txttotal.Text = libreria.incrementaporc(txtsubtotal.Text, xdto, "-");
            int xiva = Convert.ToInt16(txtXiva.Text);
            txtIva.Text = libreria.porcentaje(txtsubtotal.Text, xiva);
            txttotal.Text = libreria.incrementaporc(txtsubtotal.Text, xiva, "+");
            */
            if (txtxdto.Text == string.Empty)
                txtxdto.Text = "0";
            abmproceso.totalcomanda(ref cmbcpventa, ref txtsubtotal, ref txtxdto,
                                    ref txtdto, ref txttotal, ref txtccliente, ref txtXiva, ref txtIva);
        }
        private void cmbtkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtnroform.Text = libreriaproceso.buscanroform(ref txtnroform, cmbcpventa.Text);
            newcomprobante();
        }
        private void txtsaldocliente_TextChanged(object sender, EventArgs e)
        {
            abmproceso.restocomanda(ref txttotal, ref txtpago, ref txtpago1, ref txtresto, ref txtsaldocliente);
        }
        private void frmproceso_Leave(object sender, EventArgs e)
        {
            bdcomun.ejecuta("truncate auxcheques");
        }
        private void txtpago1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cmbfpago2.Text == "CHEQUE")
            {
                frmcheque frm = new frmcheque();
                frm.ccliente = txtccliente.Text;
                frm.ccaja = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1 ", "nrocaja");
                frm.cform = bdcomun.contenidocampo("select * from auxmovimiento3 where cpventa='" + cmbcpventa.Text + "'", "cform");
                frm.nroform = txtnroform.Text;
                frm.total = txtresto.Text;
                if (frm.ShowDialog() == DialogResult.OK)
                    txtpago1.Text = frm.retornavalor;

                decimal resto = libreria.stringadecimalconpunto(txtresto.Text);
                decimal diferencia = resto * (-1);

                decimal pago1 = libreria.stringadecimalconpunto(txtpago1.Text) + resto;
                txtpago1.Text = libreria.decimalastringconpunto(pago1);
                txtdiferencia.Text = libreria.decimalastringconpunto(diferencia);
            }
        }
        private void btnpresupuesto_Click(object sender, EventArgs e)
        {
            imprimefact("P", txtccliente.Text);
        }
        private void dgvcomanda_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            int ind;
            frmprocesocliente frm = new frmprocesocliente();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtccliente.Text = frm.retornaccliente;
                txtRsocial.Text = frm.retornaRsocial;
                txtDomicilio.Text = frm.retornaDomicilio;
                txtCuit.Text = frm.retornaNcuit;
                lbliva.Text = frm.retornaIva;
                txtLp.Text = frm.retornaLp;
                txtsaldocliente.Text = frm.retornasaldocliente;
                txtccliente.Focus();
                cmbpventa.SelectedIndex = Convert.ToInt16(txtLp.Text);
                decimal saldocliente = libreria.stringadecimalconpunto(txtsaldocliente.Text);
                if (saldocliente >= 0)
                    txtsaldocliente.BackColor = Color.LightSeaGreen;
                else
                    txtsaldocliente.BackColor = Color.LightSalmon;
                abmproceso.datoscliente(ref cmbtkt, ref cmbctkt, ref txtccliente, ref btnitka, ref btnitkc, ref cmbcpventa,
                                        ref lblrsocial, ref lbliva, false); //no permito actualizar el cliente de la comanda
                abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);
                if (cmbtkt.SelectedIndex == 0)
                    chkiva.Checked = true;
                else
                    chkiva.Checked = false;
            }
            else
                abmcliente.CF_actualiza(" ", " ", "", true); //
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtRsocial.Text != string.Empty && txtDomicilio.Text != string.Empty)
            {
                frmItemFactura frm = new frmItemFactura();
                frm.tag = 0;
                frm.ccliente = txtccliente.Text;
                frm.cmbcpventa = cmbcpventa.Text;
                frm.lp = cmbLP.SelectedIndex.ToString(); //cmbcpventa.Text;
                frm.xdto = "0";
                frm.aplicaiva = chkiva.Checked;
                if (frm.ShowDialog() == DialogResult.OK)
                    grabaitem(frm.cprod, frm.cantidad, frm.pventa, frm.lp, txtccliente.Text, frm.xdto, frm.bandera);
            }
            else configuracion.mensaje("Complete Razón Social y domicilio");
        }
        private void btnFacturaWeb_Click(object sender, EventArgs e)
        {
            if (dgvcomanda.RowCount > 0 && Convert.ToDecimal(txtresto.Text) == 0)
            {
                DatosFactura lst = FacturaWeb();

                if (lst.cae != null && lst.cae != string.Empty)
                {
                    imprimefactfiscal(lst.nroform, lst.cae, lst.vencimiento, txtccliente.Text);
                    #region esto que sigue si la factura se hizo bien
                    MySqlConnection cnn = bdcomun.Conexion();
                    int tiempo = cnn.ConnectionTimeout;
                    MySqlDataReader reg = bdcomun.leereg("SELECT * FROM auxmovimiento3 where cpventa = '" + cmbcpventa.Text +
                                                         "' and cliente='" + txtccliente.Text + "'", cnn);
                    if (reg.HasRows)
                    {
                        while (reg.Read())
                        {
                            FactWeb.actualizastock(reg);
                            if (!Properties.Settings.Default.afipmodoproduccion)
                                FactWeb.actualizastock2(reg);
                            FactWeb.grabamovimiento(reg, txtnroform.Text, false);
                        }
                    }
                    FactWeb.grabafacturacionfinal(reg, btnitka, txtnroform.Text, txtpago.Text, cmbcfpago1.Text,
                                                  txtpago1.Text, cmbcfpago2.Text, lst.imptotal, lst.impneto, lst.impiva, lst.porciva,
                                                  txtxdto, txtsaldocliente, lst.cae);
                    if (txtdiferencia.Text != "0" && txtdiferencia.Text != string.Empty)
                        FactWeb.grabactacte(txtccliente.Text, btnitka, txtnroform.Text, txtdiferencia.Text, "PROCESO");
                    reg.Close();
                    //grabo cheques
                    bdcomun.ejecuta("insert into cheques (ccliente, fechform, hora,nrocaja, cform, nroform, banco, ncheque, importe, fechcheque,presentado) " +
                                    "select ccliente, fechform, hora,nrocaja, cform, nroform, banco, ncheque, importe, fechcheque,presentado from auxcheques");
                    bdcomun.ejecuta("truncate auxcheques");
                    //limpliar auxmovimiento3
                    bdcomun.ejecuta("delete from auxmovimiento3 where cpventa='" + cmbcpventa.Text + "' and cliente='" + txtccliente.Text + "'");
                    abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);
                    configuracion.mensaje("Puesto de venta actualizado s/clietne");

                    cnn.Close();
                    limpiafacturapantalla();
                    //limpia dni de cliente 0000
                    //string consulta = "update cliente set ndni='' where codigo='0000'";
                    //bdcomun.ejecuta(consulta);
                    abmcliente.CF_actualiza("11111111", "CONSUMIDOR FINAL", "XX", true);
                    //ver los checkbox ak

                    #endregion
                }
            }
            else configuracion.mensaje("Verifique el pago");

        }
        private void limpiafacturapantalla()
        {
            txtsubtotal.Text = "0";
            txtccliente.Text = string.Empty;
            txtRsocial.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtCuit.Text = string.Empty;
            lbliva.Text = string.Empty;
            txtLp.Text = string.Empty;
            txtsaldocliente.Text = string.Empty;
            txttotal.Text = "0";
            txtpago.Text = "0";
            txtpago1.Text = "0";
            txtdiferencia.Text = "0";
            txtxdto.Text = "0";
            txtdto.Text = "0";
            txtIva.Text = "0";
            cmbLP.SelectedIndex = -1;
            lblrsocial.Text = "...";
            //chkiva.Checked = true;
        }
        /// <summary>
        /// Halla en nuevo comprobante de la afip
        /// </summary>
        private void newcomprobante()
        {
            //buscarlo en afiptipoform con cform y obtener codigo 
            int TipoComp = Convert.ToInt16(bdcomun.contenidocampo("Select * from afiptipoform where cform='" + cmbctkt.Text + "'", "codigo"));
            long nroComprobante = 0;
            FEAFIPLib.BIWSFEV1 wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
            string aux = Properties.Settings.Default.afipcertificado;
            string aux2 = Properties.Settings.Default.afippassword;
            int aux3 = Properties.Settings.Default.afipptoventa;
            if (wsfev1.login(@Properties.Settings.Default.afipcertificado, Properties.Settings.Default.afippassword))
            {
                if (wsfev1.recuperaLastCMP(Properties.Settings.Default.afipptoventa, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    txtnroform.Text = libreria.rellena(Properties.Settings.Default.afipptoventa.ToString(), 4) + "-" +
                                      libreria.rellena(nroComprobante.ToString(), 8);
                    wsfev1.reset();
                }
                else MessageBox.Show(wsfev1.ErrorDesc);
            }
            else            MessageBox.Show(wsfev1.ErrorDesc);
        }
        /// <summary>
        /// retorna CAE si esta bien
        /// </summary>
        /// <returns></returns>
        private DatosFactura FacturaWeb()
        {
            DatosFactura lst = new DatosFactura();
            try
            {
                //buscarlo en afiptipoform con cform y obtener codigo 
                int TipoComp = Convert.ToInt16(bdcomun.contenidocampo("Select * from afiptipoform where cform='" + cmbctkt.Text + "'", "codigo"));
                //buscarlo en afipconceptofactura x descripcion y obtener codigo 
                int Concepto = Convert.ToInt16(bdcomun.contenidocampo("Select * from afipconceptofactura where descripcion='" + "SERVICIOS" + "'", "codigo"));
                //buscarlo en afiptipodocclie x descripcion y obtener codigo 

                //para saber si es cuit o dni, buscar el cliente y si el cuit esta vacio es dni
                #region documento
                string nrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + txtccliente.Text + "'", "ncuit");
                string tipodoc = "CUIT";
                if (nrodoc.Trim() != string.Empty)
                    tipodoc = "CUIT";
                else
                {
                    nrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + txtccliente.Text + "'", "ndni");
                    tipodoc = "DNI";
                }
                #endregion
                int TipoDoc = Convert.ToInt16(bdcomun.contenidocampo("Select * from afiptipodocclie where descripcion='" + tipodoc + "'", "codigo"));
                //buscarlo en cliente x codigo y obtener condiva 
                int CondIva = Convert.ToInt16(bdcomun.contenidocampo("Select * from cliente where codigo = '" + txtccliente.Text + "'", "condiva"));
                long NroDoc = Convert.ToInt64(nrodoc);

                double ImpTotal = Convert.ToDouble(txttotal.Text);
                double ImpNeto = 0;
                double porciva = 0;
                switch (CondIva)
                {
                    case 2:
                    case 3:
                        porciva = 0;
                        break;
                    case 4:
                        porciva = 0.105;
                        break;
                    case 5:
                        porciva = 0.21;
                        break;
                }
                //ImpNeto = libreria.truncadecimales(ImpTotal / (1 + porciva), 2);
                //double ImpIva = libreria.truncadecimales(ImpTotal - ImpNeto, 2);
                ImpNeto = Math.Round(ImpTotal / (1 + porciva), 2);
                double ImpIva = libreria.truncadecimales(ImpTotal - ImpNeto, 2);

                long nroComprobante = 0;
                DateTime FechaComp = DateTime.Now;
                string cae = "";
                DateTime vencimiento = default(DateTime);
                string resultado = "";

                FEAFIPLib.BIWSFEV1 wsfev1 = new FEAFIPLib.BIWSFEV1();
                wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
                if (wsfev1.login(Properties.Settings.Default.afipcertificado, Properties.Settings.Default.afippassword))
                {
                    if (wsfev1.recuperaLastCMP(Properties.Settings.Default.afipptoventa, TipoComp, ref nroComprobante))
                    {
                        nroComprobante += 1;
                        txtnroform.Text = libreria.rellena(Properties.Settings.Default.afipptoventa.ToString(), 4) + "-" +
                                          libreria.rellena(nroComprobante.ToString(), 8);
                        wsfev1.reset();
                       // wsfev1.agregaFactura(Concepto, TipoDoc, NroDoc, nroComprobante, nroComprobante, FechaComp,
                       //                      ImpTotal, 0, ImpNeto, 0, null, null, null, "PES", 1);

                        wsfev1.agregaFactura(Concepto, TipoDoc, NroDoc, nroComprobante, nroComprobante, FechaComp,
                                             ImpTotal, 0, ImpNeto, 0,FechaComp, FechaComp,FechaComp, "PES", 1);

                        switch (TipoComp)
                        {
                            case 1:  //fa factura
                            case 6:  //fb
                            case 3:  //ca  credito
                            case 8:  //cb
                                wsfev1.agregaIVA(CondIva, ImpNeto, ImpIva);
                                break;

                            case 11:  //fc
                            case 12: //dc
                            case 13:  //cc
                               //NO INFORMA OBJETO IVA 
                                //wsfev1.agregaIVA(CondIva, ImpNeto, 0);
                                break;
                            case 2:  //da  debito
                            case 7:  //db 
                                wsfev1.agregaIVA(CondIva, ImpNeto, ImpIva);
                                break;
                            case 4:  //ra  recibo
                            case 9:  //rb
                                wsfev1.agregaIVA(CondIva, ImpNeto, ImpIva);
                                break;
                        }
                        if (wsfev1.autorizar(Properties.Settings.Default.afipptoventa, TipoComp))
                        {
                            wsfev1.autorizarRespuesta(0, ref cae, ref vencimiento, ref resultado);
                            if (resultado == "A")
                            {
                                txtCae.Text = cae;
                                byte TipoCompBytes = Convert.ToByte(TipoComp);
                                byte PtoVtaBytes = Convert.ToByte(Properties.Settings.Default.afipptoventa);

                                string xxcae = TBarcodeBitmap.generarCodigoBarras(NroDoc, TipoCompBytes, PtoVtaBytes, txtCae.Text.Trim(),
                                                                                vencimiento, 10, 30,
                                                                                Properties.Settings.Default.afipcaefac + "\\cae.bmp");
                                configuracion.mensaje("Comprobante Nº: " + nroComprobante +
                                                      " CAE:" + cae + "VENCIMIENTO: " + vencimiento +
                                                      " AUTORIZACION: " + resultado);

                                lst.nroform = txtnroform.Text;
                                lst.cae = xxcae;
                                lst.vencimiento = vencimiento.ToString("dd/MM/yyyy");
                                lst.imptotal = ImpTotal.ToString();
                                lst.impneto = ImpNeto.ToString();
                                lst.impiva = ImpIva.ToString();
                                lst.porciva = (porciva * 100).ToString();
                            }
                            else
                                MessageBox.Show(wsfev1.autorizarRespuestaObs(0));
                        }
                        else
                            MessageBox.Show(wsfev1.ErrorDesc);
                    }
                    else
                        MessageBox.Show(wsfev1.ErrorDesc);
                }
                else
                    MessageBox.Show(wsfev1.ErrorDesc);
            }
            catch { configuracion.mensaje("ERROR!!! No se generó la factura. Verifique los datos de la empresa"); }
            return lst;
        }
        void imprimefact(string factpre, string ccliente)
        {
            Frmreportefactura frm = new Frmreportefactura();
            frm.consulta = "Select Fechform, auxmovimiento3.cprod, auxmovimiento3.cantidad, auxmovimiento3.pventa, auxmovimiento3.subtotal," +
                           "productos.detalle, auxmovimiento3.xdto " +
                           "from auxmovimiento3 " +
                           "inner join productos on (productos.cprod=auxmovimiento3.cprod) " +
                           " where auxmovimiento3.cpventa='" + cmbcpventa.Text + "' and cliente='" + ccliente + "'";
            frm.fecha = DateTime.Now.ToString("dd/MM/yyyy");
            frm.nrofact = txtnroform.Text;
            frm.ccliente = txtccliente.Text;
            frm.subtotal = txtsubtotal.Text;
            frm.dto = txtdto.Text;
            frm.total = txttotal.Text;
            frm.piva = txtXiva.Text;

            frm.cae = "AA0123456789012345678901234567890123456789AZ";
            frm.vto = DateTime.Now.ToString("dd/MM/yyyy");
            frm.ImporteLetra = txtImporteLetra.Text;

            switch (cmbtkt.SelectedIndex.ToString())
            {
                case "0":
                    frm.iva105 = "0";
                    frm.iva21 = "0";
                    frm.ivasubtotal = frm.subtotal;
                    frm.tipofactura = "C";
                    break;
                case "1":
                    frm.iva105 = "0";
                    frm.iva21 = txtIva.Text; // libreria.porcentaje(txttotal.Text, 21);
                    frm.ivasubtotal = txtsubtotal.Text; // libreria.incrementaporc(txttotal.Text, 21, "-");
                    frm.tipofactura = "AA";
                    break;
            }
            if (factpre == "P")
            {
                frm.tipofactura = "P";
                frm.nrofact = "Presupuesto";
                frm.iva21 = "0";
                frm.iva105 = "0";
                frm.total = frm.subtotal;
                frm.ImporteLetra = " ";
            }
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from cliente where codigo='" + txtccliente.Text + "'", cnn);
            reg.Read();
            frm.ivacliente = reg["iva"].ToString();
            if (reg["ncuit"].ToString() != string.Empty)
                frm.cuitcliente = reg["ncuit"].ToString();
            else frm.cuitcliente = " ";
            frm.nomcliente = reg["Rsocial"].ToString();
            frm.domcliente = reg["Domicilio"].ToString();
            if (txtccliente.Text == "0000")
            {
                frm.cuitcliente = ".";
                frm.nomcliente = txtRsocial.Text;
                frm.domcliente = txtDomicilio.Text;
            }
            reg.Close();

            cnn.Close();
            frm.Show();
        }
        void imprimefactfiscal(string nroform, string cae, string vto, string ccliente)
        {
            Frmreportefactura frm = new Frmreportefactura();
            frm.consulta = "Select Fechform, auxmovimiento3.cprod, auxmovimiento3.cantidad, auxmovimiento3.pventa, auxmovimiento3.subtotal," +
                "productos.detalle " +
                "from auxmovimiento3 " +
                "inner join productos on (productos.cprod=auxmovimiento3.cprod) " +
                " where auxmovimiento3.cpventa='" + cmbcpventa.Text + "' and cliente='" + ccliente + "'";
            frm.fecha = DateTime.Now.ToString("dd/MM/yyyy");
            frm.nrofact = nroform; // txtnroform.Text;
            frm.ccliente = txtccliente.Text;
            frm.subtotal = txtsubtotal.Text;
            frm.dto = txtdto.Text;
            frm.total = txttotal.Text;
            frm.cae = cae;
            frm.vto = vto;
            frm.ImporteLetra = txtImporteLetra.Text;
            frm.piva = txtXiva.Text;
            switch (cmbtkt.SelectedIndex.ToString())
            {
                case "0":
                    frm.iva105 = "0";
                    frm.iva21 = "0";
                    frm.ivasubtotal = frm.subtotal;
                    frm.tipofactura = "B";
                    break;
                case "1":
                    frm.ivasubtotal = FactWeb.HallaNeto(Convert.ToDouble(frm.total), 21).ToString();
                    frm.iva21 = (Convert.ToDouble(txttotal.Text) - Convert.ToDouble(frm.ivasubtotal)).ToString();
                    frm.iva105 = "0";
                    frm.tipofactura = "A";
                    break;
            }
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from cliente where codigo='" + txtccliente.Text + "'", cnn);
            reg.Read();
            frm.ivacliente = reg["iva"].ToString();
            if (reg["ncuit"].ToString() != string.Empty)
                frm.cuitcliente = reg["ncuit"].ToString();
            else frm.cuitcliente = " ";
            frm.nomcliente = txtRsocial.Text;// reg["Rsocial"].ToString();
            frm.domcliente = txtDomicilio.Text; // reg["Domicilio"].ToString();
            reg.Close();

            cnn.Close();
            frm.Show();
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            frm.archivo = string.Empty;
            frm.ShowDialog();
        }

        private void txtLp_TextChanged(object sender, EventArgs e)
        {
            if (txtLp.Text != "")
                cmbLP.SelectedIndex = Convert.ToInt16(txtLp.Text);
            else
                cmbLP.SelectedIndex = -1;
        }

        private void txtccliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grpInfoFact.Visible = true)
                grpInfoFact.Visible = false;
            else
                grpInfoFact.Visible = true;
        }

        private void txtXiva_TextChanged(object sender, EventArgs e)
        {
            cambiaPrecio(txtccliente.Text, txtXiva.Text);
            abmproceso.totalcomanda(ref cmbcpventa, ref txtsubtotal, ref txtxdto,
                                    ref txtdto, ref txttotal, ref txtccliente, ref txtXiva, ref txtIva);
        }

        private void cambiaPrecio(string cCliente, string iva)
        {
            string consulta = string.Empty;
            switch (iva)
            {
                case "21":
                    //saca 10.5
                    consulta = "UPDATE auxmovimiento3 as a " +
                              "set a.Pventa = ROUND((a.Pventa / 1.105), 2), " +
                                  "a.Subtotal = ROUND((a.Pventa * Cantidad), 2) " +
                              "WHERE Cpventa = '" + cmbcpventa.Text + "' and cliente ='" + cCliente + "'";
                    break;
                case "10.5":
                    //pone 10.5
                    consulta = "UPDATE auxmovimiento3 as a " +
                              "set a.Pventa = ROUND((a.Pventa * 1.105), 2), " +
                                  "a.Subtotal = ROUND((a.Pventa * Cantidad), 2) " +
                              "WHERE Cpventa = '" + cmbcpventa.Text + "' and cliente ='" + cCliente + "'";
                    break;
            }
            if (consulta != string.Empty)
                bdcomun.ejecuta(consulta);
            abmproceso.refrescomanda(ref dgvcomanda, ref cmbcpventa, ref txtccliente);

        }

        private void txtXiva_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtXiva);
        }

        private void txtxdto_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxdto, e);
        }

        private void txtXiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtXiva, e);
        }

        private void chkiva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkiva.Checked)
                txtXiva.Text = "0";
            else
                txtXiva.Text = "21";
        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtccliente_TextChanged(object sender, EventArgs e)
        {
            if (txtccliente.Text == "0000")
                txtCuit.Enabled = true;
            else
                txtCuit.Enabled = false;

        }

        private void labelGradient1_Click(object sender, EventArgs e)
        {
            /*
            if (txtXiva.Text == "21")
                txtXiva.Text = "10.5";
            else
                txtXiva.Text = "21";
            */
        }

        private void btnPagaefec_Click(object sender, EventArgs e)
        {
            txtpago.Text = txttotal.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmcliente frm = new frmcliente();
            frm.ShowDialog();
        }
    }
}
