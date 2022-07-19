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
using FEAFIPLib;

namespace Loundry
{
    public partial class frmremfact : Form
    {
        public int puntero, puntero2;
        public string proceso;
        public string afcform;
        public string afnroform;
        public frmremfact()
        {
            InitializeComponent();
        }

        private void cmbprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcprov.SelectedIndex = cmbprov.SelectedIndex;
        }

        private void frmremfact_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvitem, "", 9, true);
            dgvitem.MouseClick += new MouseEventHandler(dgvitem_MouseClick);

            configuracion.confdgv(dgvencabezados, "", 9, true);
            configuracion.confdgv(dgvitems, "", 9, true);
            configuracion.grupobox(grpencabezado);
            configuracion.grupobox(grpitems);
            configuracion.grupobox(grpabm);
            configuracion.tabcontrol(tabControl1);

            libreriabase.cargabox2(ref cmbprov, "rsocial", ref cmbcprov, "cprov", "proveedores", false, "");
            abmremfact.refresh(ref dgvitem, "TRUNCATE TABLE auxmovimiento");
            abmremfact.refresh(ref dgvitem, "");
            abmremfact.refreshtab2(ref dgvencabezados, "");
            if (proceso == "ANULA FACTURA")
            {
                this.Text = "Anulación de Factura";

                configuracion.confdgv(dgvFactura, "", 9, true);
                configuracion.confdgv(dgvItemfactura, "", 9, true);
                bdcomun.dgv(dgvFactura, "select * from factfinal where cform='" + afcform + "' and nroform='" + afnroform + "'");
                bdcomun.dgv(dgvItemfactura, "select * from movimiento where cform='" + afcform + "' and nroform='" + afnroform + "'");
                libreria.seleccionaitemcombo(ref cmbio, "ENTRADA");
                libreria.seleccionaitemcombo(ref cmbprov, "LAVADERO ESPARZA 92");
                libreria.seleccionaitemcombo(ref cmbform, "NC");
                lblFactura.Text = "Fact: " + libreria.valorcelda(0, dgvFactura, "Nroform", "0");
                btnAnula.PerformClick();
            }

        }

        private void dgvitem_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int fila = dgvitem.HitTest(e.X, e.Y).RowIndex;
                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name = "Nue";
                    m.Items.Add("Modificar").Name = "Mod";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Buscar").Name = "Bus";
                }
                m.Show(dgvitem, new Point(e.X, e.Y));
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

        private void cmbio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbprov.SelectedIndex = -1;
            cmbform.SelectedIndex = -1;
            switch (cmbio.Text)
            {
                case "ENTRADA":
                    libreriabase.cargabox2filtrada(ref cmbform, "detalle", ref cmbcform, "cform", "formularios", "tform", "E");
                    break;
                case "SALIDA":
                    libreriabase.cargabox2filtrada(ref cmbform, "detalle", ref cmbcform, "cform", "formularios", "tform", "S");
                    break;
                case "INVENTARIO":
                    libreria.seleccionaitemcombo(ref cmbprov, "DISTRIBUIDORA EJC");
                    libreriabase.cargabox2filtrada(ref cmbform, "detalle", ref cmbcform, "cform", "formularios", "tform", "I");
                    break;
            }

            txtnroform.Text = "0";
            txtimporte.Text = "0";
            abmremfact.refresh(ref dgvitem, "TRUNCATE TABLE auxmovimiento");
            abmremfact.refresh(ref dgvitem, "");
            btngrabaformulario.Text = "Graba proceso ";
        }

        private void cmbform_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbcform.SelectedIndex = cmbform.SelectedIndex;
            if (proceso == "ANULA FACTURA")
            {
                txtnroform.Text = hallanronotacredito()[0].ToString();
            }
            else txtnroform.Text = abmremfact.hallanro(cmbcform.Text, cmbcprov.Text);
            txtnroform.Focus();
        }


        private void txtnroform_Leave(object sender, EventArgs e)
        {
            txtnroform.Text = libreria.rellena(txtnroform.Text, 12);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtimporte, e);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmremfact.refresh(ref dgvitem, "");
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (cmbio.Text != "" && cmbcprov.Text != "" && cmbcform.Text != "" && txtnroform.Text != "")
            {
                grpabm.Visible = true;
                abmremfact.altaitem(ref txtcprod, ref txtcantidad, ref txtpventa, ref txtpcosto, ref txtpventa1, ref txtpventa2, ref btngrabaformulario, ref lbldetprod,
                                    ref dgvitem);
            }
            else
            {
                configuracion.mensaje("Complete el encabezado");
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtcantidad, e);
        }

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa, e);
        }

        private void txtpcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpcosto, e);
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
            txtcprod.Text = string.Empty;
            txtpcosto.Text = string.Empty;
            btngrabaformulario.Visible = true;
        }

        private void btngraba_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtcantidad.Text) > 0)
            {
                string fecha = dtpfechform.Value.ToString("yyyy-MM-dd");
                abmremfact.grabaitem(fecha, cmbcform.Text, txtnroform.Text, cmbcprov.Text, txtcprod.Text, txtcantidad.Text, txtpventa.Text, txtpcosto.Text,
                                     txtpventa1.Text, txtpventa2.Text, ref dgvitem);
                grpabm.Visible = false;
                btngrabaformulario.Visible = true;
            }
            else configuracion.mensaje("No puede graba un item con cantidad 0");
        }

        private void dgvitem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                puntero = dgvitem.CurrentRow.Index;
            }
            catch
            {
                puntero = -1;
            }
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvitem.CurrentRow.Index;
            if (this.dgvitem.Rows[puntero].Cells["cprod"].Value.ToString() != null)
            {
                string dato = this.dgvitem.Rows[puntero].Cells["cprod"].Value.ToString();
                grpabm.Visible = true;
                abmremfact.modiitem(ref txtcprod, ref txtcantidad, ref txtpventa, ref txtpcosto, ref txtpventa1, ref txtpventa2, dato, ref btngrabaformulario,
                                    ref dgvitem);
            }
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            string dato = this.dgvitem.Rows[puntero].Cells["cprod"].Value.ToString();
            abmremfact.borraitem(dato, ref dgvitem);
        }

        private void btngrabaformulario_Click(object sender, EventArgs e)
        {
            if (dgvitem.RowCount != 0)
            {
                bool bandera = false;
                if (proceso == "ANULA FACTURA")
                {
                    //grabo factfinal
                    string[] nc = notacredito();
                    if (nc[0] != null && nc[1] != null)
                    {
                        imprimenc("NC", nc[0], nc[1], nc[2]);
                        grabafacturacionfinal(nc[0], nc[1]);
                        bandera = true;
                    }
                    else
                        bandera = false;
                }
                else
                    bandera = true;
                if (bandera)
                {
                    string stocknuevo = string.Empty;
                    string fecha = dtpfechform.Value.ToString("yyyy-MM-dd");
                    abmremfact.grabaencabezado(fecha, cmbcform.Text, txtnroform.Text, cmbcprov.Text, txtimporte.Text, ref dgvitem);
                    MySqlConnection cnn = bdcomun.Conexion();
                    string consulta = "select * from auxmovimiento";
                    string consulta2 = string.Empty;
                    MySqlDataReader regm = bdcomun.leereg(consulta, cnn);
                    while (regm.Read())
                    {
                        MySqlConnection conectar2 = bdcomun.Conexion();
                        MySqlDataReader regp;
                        consulta2 = "select * from productos where cprod='" + regm["cprod"].ToString() + "'";
                        regp = bdcomun.leereg(consulta2, conectar2);
                        if (regp.HasRows)
                        {
                            regp.Read();
                            stocknuevo = abmremfact.actualizapreciostock(regm, regp, ref cmbio);
                            abmremfact.grabodocumento(fecha, cmbcform.Text, txtnroform.Text, regm, stocknuevo);
                            abmremfact.grabomovimiento(fecha, cmbcform.Text, txtnroform.Text, regm, stocknuevo);
                        }
                        regp.Close();
                        conectar2.Close();
                        abmremfact.refreshtab2(ref dgvencabezados, "");
                    }
                    cmbio.SelectedIndex = -1;
                    cmbprov.SelectedIndex = -1;
                    cmbform.SelectedIndex = -1;
                    txtnroform.Text = "";
                    txtimporte.Text = "0";
                    abmremfact.refresh(ref dgvitem, "TRUNCATE TABLE auxmovimiento");
                    regm.Close();
                 
                    cnn.Close();
                }
                if (proceso == "ANULA FACTURA" && bandera)
                {
                    this.Close();
                }
            }
            else { configuracion.mensaje("No existen items para grabar"); }
        }

        void imprimenc(string cform, string nroform, string cae, string vencimiento)
        {
            frmReporteNc frm = new frmReporteNc();
            frm.consulta = "Select * from factfinal " +
                           " where cform='" + libreria.valorcelda(0, dgvFactura, "cform", "") +
                           "' and nroform='" + libreria.valorcelda(0, dgvFactura, "nroform", "") + "'";
            if (libreria.valorcelda(0, dgvFactura, "cform", "") == "0TK0")
                frm.TKX = "B";
            else
                frm.TKX = "A";
            frm.fecha = DateTime.Now.ToString("dd/MM/yyyy");
            frm.cform = cform;// de NC;
            frm.nroform = nroform; // de NC
            frm.ccliente = libreria.valorcelda(0, dgvFactura, "ccliente", "");
            frm.subtotal = libreria.valorcelda(0, dgvFactura, "total", "");
            frm.dto = "0";
            frm.total = frm.subtotal;
            frm.cae = cae;
            frm.vto = vencimiento;
            frm.iva105 = "0";
            frm.iva21 = "0";
            frm.ivasubtotal = frm.subtotal;
            string xcform = libreria.valorcelda(0, dgvFactura, "cform", "").Trim();
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


        private void txtcprod_Leave(object sender, EventArgs e)
        {
            abmremfact.cprodexit(ref txtcprod, ref lbldetprod, ref lblstock, ref txtpventa, ref txtpventa1, ref txtpventa2);

        }

        private void btnrefreshtab2_Click(object sender, EventArgs e)
        {
            abmremfact.refreshtab2(ref dgvencabezados, "");
        }

        private void dgvencabezados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            puntero2 = dgvencabezados.CurrentRow.Index;
            if (this.dgvencabezados.Rows[puntero2].Cells["fechform"].Value.ToString() != null)
            {
                //DateTime fecha = Convert.ToDateTime( this.dgvencabezados.Rows[puntero].Cells["fechform"].Value.ToString());
                //string dat1 = fecha.ToString("yyyy-MM-dd");
                string dat1 = this.dgvencabezados.Rows[puntero2].Cells["cprov"].Value.ToString();
                string dat2 = this.dgvencabezados.Rows[puntero2].Cells["cform"].Value.ToString();
                string dat3 = this.dgvencabezados.Rows[puntero2].Cells["nroform"].Value.ToString();
                abmremfact.buscaitems(ref dgvitems, dat1, dat2, dat3);
                grpdatos.Text = "Items del Formulario Nro " + dat3;
            }
        }

        private void dgvencabezados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnrefreshtab2.PerformClick();
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtcantidad);
        }

        private void txtpventa_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpventa);
        }

        private void txtpcosto_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpcosto);
        }

        private void txtnroform_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtnroform, e);
        }

        private void txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtimporte, e);
        }

        private void txtpventa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa1, e);
        }

        private void txtpventa1_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpventa1);
        }

        private void txtpventa2_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtpventa2);
        }

        private void txtpventa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtpventa2, e);
        }

        private void txtcprod_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmremfactproducto frm = new frmremfactproducto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtcprod.Text = frm.retornacprod;
                txtcrubro.Text = frm.retornacrubro;
                txtpcosto.Text = frm.retornapcosto;
            }
            txtcprod.Focus();
            SendKeys.Send("{TAB}");
        }

        private void txtpcosto_TextChanged(object sender, EventArgs e)
        {
            if (txtcprod.Text != string.Empty && txtpcosto.Text != string.Empty)
            {
                int pmos = Convert.ToInt16(bdcomun.ejecuta("select * from productos where cprod='" + txtcprod.Text + "'", "xmostrador"));
                int pmin = Convert.ToInt16(bdcomun.ejecuta("select * from productos where cprod='" + txtcprod.Text + "'", "xminorista"));
                int pmay = Convert.ToInt16(bdcomun.ejecuta("select * from productos where cprod='" + txtcprod.Text + "'", "xmayorista"));
                txtpventa.Text = libreria.incrementaporc(txtpcosto.Text, pmos, "+");
                txtpventa1.Text = libreria.incrementaporc(txtpcosto.Text, pmin, "+");
                txtpventa2.Text = libreria.incrementaporc(txtpcosto.Text, pmay, "+");
            }
        }

        private void txtcrubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtcrubro, e);
        }

        private void dgvitem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvencabezados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvFactura_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvItemfactura_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            btngrabaformulario.Text = "Anula Factura";
            dtpfechform.Enabled = false;
            cmbio.Enabled = false;
            cmbprov.Enabled = false;
            cmbform.Enabled = false;
            txtnroform.Enabled = false;
            txtimporte.Enabled = false;
            dgvitem.Tag = 0;
            string fecha = dtpfechform.Value.ToString("yyyy-MM-dd");
            for (int i = 0; i < dgvItemfactura.Rows.Count; i++)
            {
                string cprod = libreria.valorcelda(i, dgvItemfactura, "cprod", "0");
                string cantidad = libreria.valorcelda(i, dgvItemfactura, "cantidad", "0");
                string pcosto = bdcomun.contenidocampo("Select * from productos where cprod='" + cprod + "'", "pcosto");
                string pventa = bdcomun.contenidocampo("Select * from productos where cprod='" + cprod + "'", "pventa");
                string pventa1 = bdcomun.contenidocampo("Select * from productos where cprod='" + cprod + "'", "pventa1");
                string pventa2 = bdcomun.contenidocampo("Select * from productos where cprod='" + cprod + "'", "pventa2");
                abmremfact.grabaitem(fecha, cmbcform.Text, txtnroform.Text, cmbcprov.Text,
                                     cprod, cantidad, pventa, pcosto,
                                     pventa1, pventa2, ref dgvitem);
            }
        }

        private string[] notacredito()
        {
            string[] retorna = new string[3];
            string xNroComprobante = string.Empty;
            string xcae = string.Empty;
            string xvencimiento = string.Empty;
            string formu; string xdoc; string xnrodoc;
            string ccliente = libreria.valorcelda(0, dgvFactura, "ccliente", "");
            if (libreria.valorcelda(0, dgvFactura, "cform", "") == "0TK1")
            {
                formu = "NOTAS DE CREDITO A";
                xdoc = "CUIT";
                xnrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + ccliente + "'", "ncuit");
            }
            else
            {
                formu = "NOTAS DE CREDITO C";
                xdoc = "DNI";
                xnrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + ccliente + "'", "ndni");
            }
            string aux = bdcomun.contenidocampo("Select * from afiptipoform where descripcion='" + formu + "'", "codigo");
            int TipoComp = Convert.ToInt16(aux);
            aux = bdcomun.contenidocampo("select * from afipconceptofactura where descripcion='SERVICIOS'", "codigo");
            int Concepto = Convert.ToInt16(aux);

            int TipoDoc = Convert.ToInt16(bdcomun.contenidocampo("select * from afiptipodocclie where descripcion='" + xdoc + "'", "codigo"));
            long NroDoc = Convert.ToInt64(xnrodoc);
            int CondIva = Convert.ToInt32("03");
            int PtoVta = Properties.Settings.Default.afipptoventa;

            double ImpTotal = Convert.ToDouble(libreria.valorcelda(0, dgvFactura, "total", ""));
            double ImpNeto = 0;
            switch (CondIva)
            {
                case 2:
                    ImpNeto = libreria.truncadecimales(ImpTotal / 1.0, 2);
                    break;
                case 3:
                    ImpNeto = ImpTotal;
                    break;
                case 4:
                    ImpNeto = libreria.truncadecimales(ImpTotal / 1.105, 2);
                    break;
                case 5:
                    ImpNeto = libreria.truncadecimales(ImpTotal / 1.21, 2);
                    break;
            }


            double ImpIva = libreria.truncadecimales(ImpTotal - ImpNeto, 2);


            long nroComprobante = 0;
            DateTime FechaComp = DateTime.Now;
            string cae = "";
            DateTime vencimiento = default(DateTime);
            string resultado = "";
            //comprobante asociado
            string CompAsocTipo = bdcomun.contenidocampo("Select Codigo from afiptipoform where Cform='" +
                                           libreria.valorcelda(0, dgvFactura, "cform", "") + "'", "Codigo");
            string[] CompAsocNroSplit = libreria.valorcelda(0, dgvFactura, "NroForm", "").Split('-');
            string CompAsocNro = CompAsocNroSplit[1];


            FEAFIPLib.BIWSFEV1 wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
            if (wsfev1.login(Properties.Settings.Default.afipcertificado, Properties.Settings.Default.afippassword))
            {

                if (wsfev1.recuperaLastCMP(PtoVta, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    xNroComprobante = libreria.rellena(PtoVta.ToString(), 4) + "-" + libreria.rellena(nroComprobante.ToString(), 8);
                    wsfev1.reset();
                    wsfev1.agregaFactura(Concepto, TipoDoc, NroDoc, nroComprobante, nroComprobante, FechaComp,
                                         ImpTotal, 0, ImpNeto, 0,FechaComp,FechaComp,FechaComp, "PES", 1);
                    //Agrega Comprobante Asociado
                    wsfev1.agregaCbteAsoc(Convert.ToInt32(CompAsocTipo), PtoVta, Convert.ToInt64(CompAsocNro));

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
                    if (wsfev1.autorizar(PtoVta, TipoComp))
                    {
                        wsfev1.autorizarRespuesta(0, ref cae, ref vencimiento, ref resultado);
                        if (resultado == "A")
                        {
                            xcae = cae;
                            byte TipoCompBytes = Convert.ToByte(TipoComp);
                            byte PtoVtaBytes = Convert.ToByte(PtoVta);

                            string xxcae = TBarcodeBitmap.generarCodigoBarras(NroDoc, TipoCompBytes, PtoVtaBytes, xcae.Trim(),
                                                                              vencimiento, 10, 30,
                                                                              Properties.Settings.Default.afipcaenc + "\\cae.bmp");
                            xvencimiento = vencimiento.ToString();
                            configuracion.mensaje("Comprobante Nº: " + nroComprobante +
                                                  " CAE:" + cae + "VENCIMIENTO: " + vencimiento +
                                                  " AUTORIZACION: " + resultado);

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

            retorna[0] = xNroComprobante;
            retorna[1] = xcae;
            retorna[2] = xvencimiento;
            return retorna;
        }

        private string[] hallanronotacredito()
        {
            string[] retorna = new string[3];
            string xNroComprobante = string.Empty;
            string xcae = string.Empty;
            string xvencimiento = string.Empty;
            string formu; string xdoc; string xnrodoc;
            string ccliente = libreria.valorcelda(0, dgvFactura, "ccliente", "");
            if (libreria.valorcelda(0, dgvFactura, "cform", "") == "0TK1")
            {
                formu = "NOTAS DE CREDITO A";
                xdoc = "CUIT";
                xnrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + ccliente + "'", "ncuit");
            }
            else
            {
                formu = "NOTAS DE CREDITO C";
                xdoc = "DNI";
                xnrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + ccliente + "'", "ndni");
                if (xnrodoc.Trim() == string.Empty) {
                    //si xnrodoc esta vacio cargar ndni, rsocial, domicilio a mano
                    MessageBox.Show("Se le va a pedir datos del cliente debido a que es un consumidor final");
                    abmcliente.CF_ingresa();
                    xnrodoc = bdcomun.contenidocampo("Select * from cliente where codigo='" + ccliente + "'", "ndni");
                }
            }
            string aux = bdcomun.contenidocampo("Select * from afiptipoform where descripcion='" + formu + "'", "codigo");
            int TipoComp = Convert.ToInt16(aux);
            aux = bdcomun.contenidocampo("select * from afipconceptofactura where descripcion='SERVICIOS'", "codigo");
            int Concepto = Convert.ToInt16(aux);

            int TipoDoc = Convert.ToInt16(bdcomun.contenidocampo("select * from afiptipodocclie where descripcion='" + xdoc + "'", "codigo"));
            long NroDoc = Convert.ToInt64(xnrodoc);
            int CondIva = Convert.ToInt32("05");
            int PtoVta = Properties.Settings.Default.afipptoventa;

            double ImpTotal = Convert.ToDouble(libreria.valorcelda(0, dgvFactura, "total", ""));
            double ImpNeto = 0;
            switch (CondIva)
            {
                case 2:
                    ImpNeto = libreria.truncadecimales(ImpTotal / 1.0, 2);
                    break;
                case 4:
                    ImpNeto = libreria.truncadecimales(ImpTotal / 1.105, 2);
                    break;
                case 5:
                    ImpNeto = libreria.truncadecimales(ImpTotal / 1.21, 2);
                    break;
            }
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

                if (wsfev1.recuperaLastCMP(PtoVta, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    xNroComprobante = libreria.rellena(PtoVta.ToString(), 4) + "-" + libreria.rellena(nroComprobante.ToString(), 8);
                }
                else
                    MessageBox.Show(wsfev1.ErrorDesc);
            }
            else
                MessageBox.Show(wsfev1.ErrorDesc);

            retorna[0] = xNroComprobante;
            return retorna;
        }
        public void grabafacturacionfinal(string pnroform, string pcae)
        {
            string xcform = libreria.valorcelda(0, dgvFactura, "cform", "").Trim();
            string tipofactura;
            if (xcform == "0TK0")
                tipofactura = "C";
            else
                tipofactura = "A";
            string cform = "ANUL";
            string nroform = pnroform;
            string cae = pcae;
            decimal dtxtpago = libreria.stringadecimalconpunto(libreria.valorcelda(0, dgvFactura, "pago", "0")) * -1;
            decimal dtxtpago1 = libreria.stringadecimalconpunto(libreria.valorcelda(0, dgvFactura, "pago1", "0")) * -1;
            string xfecha = dtpfechform.Value.ToString("yyyy-MM-dd");
            string consulta = "insert into factfinal set " +
                "nrocaja='" + libreria.valorcelda(0, dgvFactura, "nrocaja", "0").ToString() +
                "', fechform='" + DateTime.Now.ToString("yyyy-MM-dd") +
                "', horaform='" + DateTime.Now.ToString("H:mm:ss") +
                "', cform='" + cform +
                "', nroform='" + nroform +
                "', pago='" + dtxtpago +
                "', cfpago='" + libreria.valorcelda(0, dgvFactura, "cfpago", "0") +
                "', pago1='" + dtxtpago1 +
                "', cfpago1='" + libreria.valorcelda(0, dgvFactura, "cfpago1", "0") +
                "', pago2='" + "0" +
                "', cfpago2='" + "CTTE" +
                "', neto='" + Convert.ToDecimal(libreria.valorcelda(0, dgvFactura, "neto", "0")) * -1 +
                "', iva='" + Convert.ToDecimal(libreria.valorcelda(0, dgvFactura, "iva", "0")) * -1 +
                "', Xiva='" + libreria.valorcelda(0, dgvFactura, "xiva", "0") +
                "', total='" + Convert.ToDecimal(libreria.valorcelda(0, dgvFactura, "total", "0")) * -1 +
                "', ccliente='" + libreria.valorcelda(0, dgvFactura, "ccliente", "0") +
                "', cempl='" + libreria.valorcelda(0, dgvFactura, "cempl", "0") +
                "', xdto='" + Convert.ToDecimal(libreria.valorcelda(0, dgvFactura, "xdto", "0")) * -1 +
                "', cae='" + cae +
                "', facturaanul='" + tipofactura + lblFactura.Text.Substring(6, 13) +
                "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Nota de credito grabada");
            //marca la factura como anulada
            consulta = "update factfinal set " +
                       "caeanul='" + cae + "' " +
                       "where cform='" + libreria.valorcelda(0, dgvFactura, "cform", "0") +
                       "' and nroform='" + libreria.valorcelda(0, dgvFactura, "nroform", "0") + "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Factura actualizada");
        }

        private void txtcrubro_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtcrubro);
        }
    }
}
