using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmMail : Form
    {
        public string archivo;
        public frmMail()
        {
            InitializeComponent();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient(txtSmtp.Text); //smtp.hotmail.com
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(txtUsuario.Text, txtPassword.Text);
            smtp.Port = Convert.ToInt16(txtPort.Text);//25;
            smtp.Host = txtHostSmtp.Text; //"smtp.live.com";
            smtp.EnableSsl = true;
            //Añade credenciales si el servidor lo requiere.
            //smtp.Credentials = CredentialCache.DefaultNetworkCredentials;

            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailAddress from = new MailAddress(txtUsuario.Text);
            MailAddress to = new MailAddress(txtDestino.Text);
            MailMessage mensaje = new MailMessage();
            mensaje.From = from;
            mensaje.To.Add(to);
            string FilePath = txtAdjunto.Text; //archivo;
                                               
            string file = Path.GetFileName(FilePath);
            mensaje.Subject = txtAsunto.Text + "Archivo Adjunto: " + file; // file;
            mensaje.Attachments.Add(new Attachment(FilePath));
            mensaje.Body = txtBody.Text;
            //Envía el mensaje.
            try
            {
                smtp.Send(mensaje);
                configuracion.mensaje("Factura enviada");
            }
            catch
            {
                configuracion.mensaje("No se pudo envia la factura. Verifique conección a internet");
            }
            this.Close();
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            configuracion.grupobox(groupBox1);
            txtAdjunto.Text = archivo;
        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            string FilePath = string.Empty;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FilePath = Path.GetDirectoryName(openFileDialog1.FileName) + "\\" +
                           Path.GetFileName(openFileDialog1.FileName);

            txtAdjunto.Text = FilePath;
            string file = Path.GetFileName(FilePath);
            txtAsunto.Text= "Enviamos adjunto de su factura: " + file;
        }
    }
}
