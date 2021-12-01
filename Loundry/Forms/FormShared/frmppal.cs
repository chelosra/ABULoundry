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
    public partial class frmppal : Form
    {
        public string nickname;
        public frmppal()
        {
            frmspash frm = new frmspash();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            InitializeComponent();
            System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmcaja);
            if (frm != null) // Si la instancia existe...
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmcaja(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void facturaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (bdcomun.ejecuta("SELECT * FROM caja WHERE ISNULL(Platacie)", false))
            {
                Form frm = this.MdiChildren.FirstOrDefault(x => x is frmproceso);
                if (frm != null) // Si la instancia existe...
                {
                    frm.BringToFront(); // ...la pongo en primer plano
                    frm.WindowState = FormWindowState.Normal;
                }
                else  // Sino...
                {
                    frm = new frmproceso(); // 
                    frm.MdiParent = this;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.Show();
                }
            }
            else { Loundry.configuracion.mensaje("Debe abrir una caja para ingresar"); }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void productosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmproductos);
            if (frm != null) // Si la instancia existe...
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmproductos(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmppal_Load(object sender, EventArgs e)
        {
            statusStrip1_MouseDoubleClick(null, null);
            frmlogin frm = new frmlogin();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmrubros);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmrubros(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmproveedores);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmproveedores(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void remitosFacturasDeProveedoresInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmremfact);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmremfact(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void menuppal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void accesoMysqlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Frmcreausu);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new Frmcreausu(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void reseteaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Frmreseteausu);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new Frmreseteausu(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }

        }

        private void cambioDePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void configurarGestorDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmconfiguracion);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmconfiguracion(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void cambioDePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is FrmUsuclave);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new FrmUsuclave(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is Frmempleado);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new Frmempleado(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void configuraciónRegionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentCulture.ToString());
            MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalDigits.ToString());
            MessageBox.Show(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern.ToString());
        }

        private void cambiarConfiguraciónRegionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmcliente);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmcliente(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmnegocio);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmnegocio(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmchequespresenta);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmchequespresenta(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void movimientosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmmovimiento);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmmovimiento(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void abreform(Form ppal)
        {
            Form frm = ppal.MdiChildren.FirstOrDefault(x => x is frmmovimiento);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmmovimiento(); // 
                frm.MdiParent = ppal;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void frmppal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmppal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea cerrar el programa?",
                      "Cerrar el programa", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmVersion);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmVersion(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmejemfact);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmejemfact(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void lblusuario_TextChanged(object sender, EventArgs e)
        {
            string[] dato = lblusuario.Text.Split('-');
            if (dato.Length > 1)
            {
                nickname = dato[0];
                tSSLusuario.Text = "USUARIO: " + dato[0];
                tSSLserver.Text = "SERVER: " + dato[1];
                tSSLDatabase.Text = "DATABASE: " + dato[2];
                tSSLVersion.Text = "v: "+Properties.Settings.Default.Version;
                tSSLModo.Text = "Modo: " + dato[3];
                lblusuario.Text = nickname;
            }
        }

        private void statusStrip1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            if (!bdcomun.changeip(this))
            {
                bool rta = false;
                DialogResult dialogo = MessageBox.Show("Cambio de gestor","Continúa?", MessageBoxButtons.YesNo);
                if (dialogo == DialogResult.Yes)
                    rta = true;
                if (rta)
                {
                    tSSLDatabase.ForeColor = Color.Orange;
                    Properties.Settings.Default.URLWSAA = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms";
                    Properties.Settings.Default.URLWSW = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx";
                    Properties.Settings.Default.afipcertificado = "c:/sracsharp/Loundry/key/certificado.pfx";
                    Properties.Settings.Default.afippassword = "feafip";
                    Properties.Settings.Default.afipmodoproduccion = false;
                    Properties.Settings.Default.afipptoventa = 101;
                    tSSLModo.Text = "[Prueba]";
                    libreriabase.backupUsb(pgBgral);
                }
            }
            else
            {
                */
                
                tSSLDatabase.ForeColor = Color.Black;
                Properties.Settings.Default.URLWSAA = "https://wsaa.afip.gov.ar/ws/services/LoginCms";
                                         //Producción: https://wsaa.afip.gov.ar/ws/services/LoginCms
            Properties.Settings.Default.URLWSW = "https://servicios1.afip.gov.ar/wsfev1/service.asmx";
                                   // Producción: https://servicios1.afip.gov.ar/wsfev1/service.asmx
            Properties.Settings.Default.afipcertificado = @"c:/sracsharp/Loundry/key/certificado.pfx";
                Properties.Settings.Default.afippassword = "Bea";
                Properties.Settings.Default.afipmodoproduccion = true;
                Properties.Settings.Default.afipptoventa = 3;
                tSSLModo.Text = "[Producción]"; 
                
            //}
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmCreaDatabase);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmCreaDatabase(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void actualizaReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmFtp);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmFtp(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void qrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmQR);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmQR(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void ejemFactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.FirstOrDefault(x => x is frmejemfact);
            if (frm != null)
            {
                frm.BringToFront(); // ...la pongo en primer plano
                frm.WindowState = FormWindowState.Normal;
            }
            else  // Sino...
            {
                frm = new frmejemfact(); // 
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
        }

        private void btnFacturar_Click_1(object sender, EventArgs e)
        {

        }

        private void frmppal_Activated(object sender, EventArgs e)
        {
         
        }

        private void frmppal_Deactivate(object sender, EventArgs e)
        {
         
        }
    }
}
