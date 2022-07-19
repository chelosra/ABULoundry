using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FEAFIPLib;
using System.Net.Mail;
using System.Net;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Loundry
{
    public partial class frmejemfact : Form
    {
        public double cuitvendedor;
        public int PtoVta;
        public double cuitcomprador;
        public int TipoComp;
        public double imptotal;
        public double impneto;
        public string retornacae;
        public string retornanroform;
        public string retornavencimiento;
        public string retornaresultado;
        public string retornareproceso;
        private FEAFIPLib.BIWSFEV1 wsfev1;

        public frmejemfact()
        {
            InitializeComponent();
        }
        private void frmejemfact_Load(object sender, EventArgs e)
        {
            PtoVta = Properties.Settings.Default.afipptoventa;
            libreriabase.cargabox(ref cmbTipoFactura, "Codigo;Descripcion", "afiptipoform", true);
            libreriabase.cargabox(ref cmbConcepto, "Codigo;Descripcion", "afipconceptofactura", true);
            libreriabase.cargabox(ref cmbTipoDocClie, "Codigo;Descripcion", "afiptipodocclie", true);
            libreriabase.cargabox(ref cmbTipoResponsable, "Codigo;Descripcion", "afiptiporesponsable", true);
            libreriabase.cargabox(ref cmbCondIva, "Codigo;Descripcion", "afipcondiva", true);
            libreriabase.cargabox(ref cmbTipoFacturacbte, "Codigo;Descripcion", "afiptipoform", true);
            configuracion.confdgv(dgvCbte, "", 10, true);
            if (Properties.Settings.Default.Usuario != "sra")
                tabControl1.TabPages.Remove(tabPage1);
        }


        private void btnFacturaA_Click(object sender, EventArgs e)
        {
            TipoComp = 1;
            long nroComprobante = 0;
            int ptoVta = 101;
            System.DateTime FechaComp = System.DateTime.Now;
            string cae = "";
            System.DateTime vencimiento = default(System.DateTime);
            string resultado = "";

            wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = false;
            if (wsfev1.login("..\\..\\..\\certificado.pfx", "feafip"))
            {

                if (wsfev1.recuperaLastCMP(ptoVta, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    wsfev1.reset();

                    wsfev1.agregaFactura(1, 80, 20172544313, nroComprobante, nroComprobante, FechaComp, 121, 0, 100, 0, null, null, null, "PES", 1);
                    wsfev1.agregaIVA(5, 100, 21);
                    if (wsfev1.autorizar(ptoVta, TipoComp))
                    {
                        wsfev1.autorizarRespuesta(0, ref cae, ref vencimiento, ref resultado);
                        if (resultado == "A")
                        {
                            MessageBox.Show("Comprobante Nº: " + nroComprobante +
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
        }


        private void btnFacturaB_Click(object sender, EventArgs e)
        {
            long nroComprobante = 0;
            System.DateTime FechaComp = System.DateTime.Now;

            string cae = "";
            System.DateTime vencimiento = default(System.DateTime);
            string resultado = "";
            wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = false;
            if (wsfev1.login("..\\..\\..\\certificado.pfx", "feafip"))
            {
                if (wsfev1.recuperaLastCMP(PtoVta, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    wsfev1.reset();
                    wsfev1.agregaFactura(1, 80, 20172544313, nroComprobante, nroComprobante, FechaComp, 121, 0, 100, 0, null, null, null, "PES", 1);
                    wsfev1.agregaIVA(5, 100, 21);

                    if (wsfev1.autorizar(PtoVta, TipoComp))
                    {
                        wsfev1.autorizarRespuesta(0, ref cae, ref vencimiento, ref resultado);
                        if (resultado == "A")
                        {
                            MessageBox.Show("Comprobante Nº: " + nroComprobante +
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
        }

        private void btnFacturaX_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dialogo = MessageBox.Show("Tipo Factura A?",
                                  "Seleccione Facturación", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                TipoComp = 1; //a
            else 
                TipoComp = 6; //b
            */
            /*
            DialogResult dialogo = MessageBox.Show("Nota Credito A?",
                      "Seleccione Nota credito", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                TipoComp = 3; //ca
            else
                TipoComp = 8; //cb
            */
            /* 
            DialogResult dialogo = MessageBox.Show("Nota Debito A?",
                      "Seleccione Nota Debito", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                TipoComp = 2; //da
            else
                TipoComp = 7; //db
            */

            DialogResult dialogo = MessageBox.Show("Recibo A?",
                      "Seleccione Recibo", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                TipoComp = 4; //da
            else
                TipoComp = 9; //db



            long nroComprobante = 0;
            DateTime FechaComp = DateTime.Now;
            string cae = "";
            DateTime vencimiento = default(DateTime);
            string resultado = "";

            wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
            if (wsfev1.login(Properties.Settings.Default.afipcertificado, Properties.Settings.Default.afippassword))
            {

                if (wsfev1.recuperaLastCMP(PtoVta, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    wsfev1.reset();
                    wsfev1.agregaFactura(1, 80, 20172544313, nroComprobante, nroComprobante, FechaComp, 121, 0, 100, 0, null, null, null, "PES", 1);
                    switch (TipoComp)
                    {
                        case 1:  //fa
                        case 6:  //fb
                        case 3:  //ca
                        case 8:  //cb
                            wsfev1.agregaIVA(5, 100, 21);
                            break;
                        case 2:  //da
                        case 7:  //db 
                            wsfev1.agregaIVA(5, 100, 21);
                            break;
                        case 4:  //ra
                        case 9:  //rb
                            wsfev1.agregaIVA(5, 100, 21);
                            break;
                    }
                    if (wsfev1.autorizar(PtoVta, TipoComp))
                    {
                        wsfev1.autorizarRespuesta(0, ref cae, ref vencimiento, ref resultado);
                        if (resultado == "A")
                        {
                            MessageBox.Show("Comprobante Nº: " + nroComprobante +
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
        }

        private void btnConsCuit_Click(object sender, EventArgs e)
        {
            FEAFIPLib.BIWSFEV1 wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
            // En modo testing la consulta arroja que no hay resultados con infinidad de cuits
            // Debe agregarce en la ppagina de AFIP el web service de consulta padron A4. Desde el administrador de relaciones

            if (wsfev1.login(Properties.Settings.Default.afipcertificado,
                             Properties.Settings.Default.afippassword,
                             Properties.Settings.Default.afippadrona4))
            {
                ConsultaCuitResponse r = null;
                //30610171601
                if (wsfev1.ConsultaCUIT(Convert.ToInt64(txtCuit.Text), ref r))
                {
                    MessageBox.Show(" Nombre: " + r.nombre + " " + r.tipoDocumento + " " + r.numeroDocumento +
                                    " Persona: " + r.tipoPersona + " " + r.idPersona +
                                    " Domicilio: " + r.domicilioFiscal_direccion + r.domicilioFiscal_localidad +
                                                   r.domicilioFiscal_idProvincia + r.domicilioFiscal_codPostal +
                                    " Iva: " + r.condicionIVA + r.condicionIVADesc
                                    );
                    List<ClienteDatos> lst = new List<ClienteDatos>();
                    lst.Add(new ClienteDatos
                    {
                        nombre = r.nombre,
                        tipoDocumento = r.tipoDocumento,
                        nroDocumento = r.numeroDocumento,
                        tipoPersona = r.tipoPersona,
                        idPersona = r.idPersona.ToString(),
                        domicilioFiscal_direccion = r.domicilioFiscal_direccion,
                        domicilioFiscal_localidad = r.domicilioFiscal_localidad,
                        domicilioFiscal_idProvincia = r.domicilioFiscal_idProvincia.ToString(),
                        domicilioFiscal_codPostal = r.domicilioFiscal_codPostal,
                        condicionIVA = r.condicionIVA.ToString(),
                        condicionIVADesc = r.condicionIVADesc
                    });
                    txtNombreclie.Text = lst[0].nombre;
                    txtTipoDocClie.Text = lst[0].tipoDocumento;
                    txtNroDocClie.Text = lst[0].nroDocumento;
                    txtTipoPersona.Text = lst[0].tipoPersona;
                    txtIdPersona.Text = lst[0].idPersona;
                    txtDomicilio.Text = lst[0].domicilioFiscal_direccion + ", " + lst[0].domicilioFiscal_localidad + ", " +
                                      lst[0].domicilioFiscal_idProvincia.ToString() + ", " + lst[0].domicilioFiscal_codPostal;
                    txtCondIva.Text = lst[0].condicionIVA;
                    txtDescIva.Text = lst[0].condicionIVADesc;
                    libreria.seleccionaitemcombo(ref cmbTipoResponsable, libreria.rellena(txtCondIva.Text, 2));
                }
                else
                {
                    MessageBox.Show(wsfev1.ErrorDesc);
                }
            }
            else
            {
                MessageBox.Show(wsfev1.ErrorDesc);
            }
        }

        private void btnAlicuotaArba_Click(object sender, EventArgs e)
        {
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            TipoComp = Convert.ToInt16(cmbTipoFactura.Text.Substring(0, 3));
            int Concepto = Convert.ToInt16(cmbConcepto.Text.Substring(0, 2));
            int TipoDoc = Convert.ToInt16(cmbTipoDocClie.Text.Substring(0, 2));
            long NroDoc = Convert.ToInt64(txtCuit.Text);
            int CondIva = Convert.ToInt32(cmbCondIva.Text.Substring(0, 2));

            double ImpTotal = 1;
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


            wsfev1 = new FEAFIPLib.BIWSFEV1();
            wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
            if (wsfev1.login(Properties.Settings.Default.afipcertificado, Properties.Settings.Default.afippassword))
            {

                if (wsfev1.recuperaLastCMP(PtoVta, TipoComp, ref nroComprobante))
                {
                    nroComprobante += 1;
                    txtNroComprobante.Text = libreria.rellena(PtoVta.ToString(), 4) + "-" + libreria.rellena(nroComprobante.ToString(), 8);
                    wsfev1.reset();
                    wsfev1.agregaFactura(Concepto, TipoDoc, NroDoc, nroComprobante, nroComprobante, FechaComp,
                                         ImpTotal, 0, ImpNeto, 0, null, null, null, "PES", 1);

                    switch (TipoComp)
                    {
                        case 1:  //fa factura
                        case 6:  //fb
                        case 3:  //ca  credito
                        case 8:  //cb

                            wsfev1.agregaIVA(CondIva, ImpNeto, ImpIva);
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
                            txtCae.Text = cae;
                            byte TipoCompBytes = Convert.ToByte(TipoComp);
                            byte PtoVtaBytes = Convert.ToByte(PtoVta);

                            string xxcae = TBarcodeBitmap.generarCodigoBarras(NroDoc, TipoCompBytes, PtoVtaBytes, txtCae.Text.Trim(),
                                                                            vencimiento, 10, 30, "c:\\php\\cae.bmp");
                            MessageBox.Show("Comprobante Nº: " + nroComprobante +
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
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            /*
            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
	            string servidor = "smtp.gmail.com";
	            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
	            MailMessage mensaje = new MailMessage(
	               "chelosra@gmail.com",
	               "chelosra@hotmail.com",
	               "prueba",
	               "contenido");
	 
	            //Envía el mensaje.
	            SmtpClient cliente = new SmtpClient(servidor);

                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new System.Net.NetworkCredential ("chelosra@gmail.com", "mashu3010");
                cliente.Port = 587;
                cliente.Host = "smtp.gmail.com";
                cliente.EnableSsl = true;

            //Añade credenciales si el servidor lo requiere.
            //cliente.Credentials = CredentialCache.DefaultNetworkCredentials;
            */

            //crea y configura smtp
            SmtpClient smtp = new SmtpClient("smtp.hotmail.com");
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("chelosra@hotmail.com", "mashu3010");
            smtp.Port = 25;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            //Añade credenciales si el servidor lo requiere.
            //smtp.Credentials = CredentialCache.DefaultNetworkCredentials;

            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailAddress from = new MailAddress("chelosra@hotmail.com");
            MailAddress to = new MailAddress("chelosra@gmail.com");
            MailMessage mensaje = new MailMessage();
            mensaje.From = from;
            mensaje.To.Add(to);
            string FilePath = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FilePath = Path.GetDirectoryName(openFileDialog1.FileName) + "\\" +
                           Path.GetFileName(openFileDialog1.FileName);

            string file = Path.GetFileName(FilePath);
            mensaje.Subject = "Enviando " + file;
            mensaje.Attachments.Add(new Attachment(FilePath));
            mensaje.Body = "mensaje con adjunto";
            //Envía el mensaje.
            smtp.Send(mensaje);
        }

        private void btnConsultaCbte_Click(object sender, EventArgs e)
        {
            if (cmbTipoFacturacbte.Text != string.Empty)
            {
                string fechadesde = dtpFechaDesde.Value.ToString("yyyyMMdd");
                string fechahasta = dtpFechaHasta.Value.ToString("yyyyMMdd");
                PtoVta = Properties.Settings.Default.afipptoventa;
                TipoComp = Convert.ToInt16(cmbTipoFacturacbte.Text.Substring(0, 3));
                long nro = 1;

                List<ClassComprobante> cbt = new List<ClassComprobante>();
                List<ClassComprobante> cbt2 = new List<ClassComprobante>();

                FEAFIPLib.BIWSFEV1 wsfev1 = new FEAFIPLib.BIWSFEV1();
                wsfev1.ModoProduccion = Properties.Settings.Default.afipmodoproduccion;
                // Debe agregarce en la ppagina de AFIP el web service de consulta padron A4. Desde el administrador de relaciones
                if (wsfev1.login(Properties.Settings.Default.afipcertificado, Properties.Settings.Default.afippassword))
                {
                    for (int i = 1; i < 1000000; i++)
                    {
                        nro = i;
                        FEAFIPLib.wsfev1.FECompConsultaResponse cbte = null;
                        if (wsfev1.CmpConsultar(TipoComp, PtoVta, nro, ref cbte))
                        {
                            cbt.Add(new ClassComprobante
                            {
                                PtoVta = cbte.ResultGet.PtoVta.ToString(),
                                Nro = nro.ToString(),
                                ImpTotal = cbte.ResultGet.ImpTotal.ToString(),
                                CbteTipo = cbte.ResultGet.CbteTipo.ToString(),
                                DocTipo = cbte.ResultGet.DocTipo.ToString(),
                                DocNro = cbte.ResultGet.DocNro.ToString(),
                                FchVto = libreria.fechaamysql (cbte.ResultGet.FchVto.ToString(),false),
                                FchVtoPago = libreria.fechaamysql(cbte.ResultGet.FchVtoPago.ToString(),false),
                                ImpIVA = cbte.ResultGet.ImpIVA.ToString(),
                                ImpNeto = cbte.ResultGet.ImpNeto.ToString(),

                                Iva = (cbte.ResultGet.Iva != null) ? cbte.ResultGet.Iva.ToString() : "0",

                                Resultado = cbte.ResultGet.Resultado.ToString(),
                                CbteDesde = cbte.ResultGet.CbteDesde.ToString(),
                                CbteHasta = cbte.ResultGet.CbteHasta.ToString(),
                                CbteFch = cbte.ResultGet.CbteFch.ToString(), //libreria.fechaamysql(cbte.ResultGet.CbteFch.ToString(), true),
                                CodAutorizacion = cbte.ResultGet.CodAutorizacion.ToString(),
                                Concepto = cbte.ResultGet.Concepto.ToString(),
                                FchProceso = libreria.fechaamysql(cbte.ResultGet.FchProceso.ToString(),false),
                                FchServDesde = libreria.fechaamysql(cbte.ResultGet.FchServDesde.ToString(),false),
                                FchServHasta = libreria.fechaamysql(cbte.ResultGet.FchServHasta.ToString(),false),
                                ImpOpEx = cbte.ResultGet.ImpOpEx.ToString(),
                                ImpTotConc = cbte.ResultGet.ImpTotConc.ToString(),
                                ImpTrib = cbte.ResultGet.ImpTrib.ToString(),
                                MonCotiz = cbte.ResultGet.MonCotiz.ToString(),
                                MonId = cbte.ResultGet.MonId.ToString()
                            });
                            //      MessageBox.Show(cbte.ResultGet.CodAutorizacion);
                        }
                        else
                        {
                            configuracion.mensaje(wsfev1.ErrorDesc);
                            break;
                        }
                    }
                }
                else
                {
                    configuracion.mensaje(wsfev1.ErrorDesc);
                }
                decimal imptotal = 0;
                for (int i = 0; i < cbt.Count; i++)
                {
                    if (Convert.ToInt64(cbt[i].CbteFch.ToString()) >= Convert.ToInt64(fechadesde.ToString()) &&
                        Convert.ToInt64(cbt[i].CbteFch.ToString()) <= Convert.ToInt64(fechahasta.ToString()))
                    {
                        cbt2.Add(cbt[i]);
                        imptotal = imptotal + Convert.ToDecimal(cbt[i].ImpTotal);
                    }
                }
                dgvCbte.DataSource = cbt2;
                txtTotalFacturas.Text = imptotal.ToString();
                txtCantFact.Text = cbt2.Count.ToString();
            }
            else configuracion.mensaje("Seleccione comprobante a mostrar");
        }

        private void btnExceil_Click(object sender, EventArgs e)
        {
            // ExportarDataGridViewExcel(dgvCbte);
            //Exportar exp = new Exportar();
            //exp.ExportarDataGridViewExcel(dgvCbte,cmbTipoFacturacbte.Text);
            libreria.exportaDgvExcel(dgvCbte);

        }

     }
}

