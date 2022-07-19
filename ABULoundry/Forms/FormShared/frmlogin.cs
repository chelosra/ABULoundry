using System;
using System.Windows.Forms;
using Loundry.Class;
using MySql.Data.MySqlClient;

namespace Loundry
{
    public partial class frmlogin : Form
    {
        private MySqlConnection conectar;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            AnimatedGif an = new AnimatedGif(@Properties.Settings.Default.Gif);
            foreach (var a in an.Images)
            {
                this.pictureBox1.BackgroundImage = a.Image;
                this.pictureBox1.Refresh();
                System.Threading.Thread.Sleep(50);
            }
            try
            {
                conectar = bdcomun.Conexion();
                string clave = libreria.Encriptar(txtpass.Text.Trim());

                /*
  AQAAAAEAACcQAAAAEOyGWm4tXdNw+Uf07s+cp/W5FPC4w+NW+4/GEl+YJRAsmm3JXhiZmFr/i5WL/Jkwgg==

 AQAAAAEAACcQAAAAEFc8JtawagGeqrBgDkE3I3DBlcXWyV4g5WXRCO0iomuLGQOe5/k/gXU7RErGO4iAcw==
  */
                string consulta = "select * from GLoundry.usuario where nickname = '" + txtusuario.Text.Trim() + "'And clave = '" + clave + "' "; //bQBhAHMAaAB1AA==
                MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
                //evaluando que la contraseña y usuario sean correctos
                string acceso = " ";
                if (reg.HasRows)
                {
                    while (reg.Read())
                        acceso = reg["sector"].ToString();
                    this.Hide();

                    string[] ip = libreria.leerxml(Properties.Settings.Default.DirectorioConf);
                    string xontrol = "[" + txtusuario.Text.Trim() + "]-[" + ip[0] + "]-[" + ip[1] + "]";
                    if (Properties.Settings.Default.afippassword == "Bea")
                        xontrol += "-[Producción]";
                    else
                        xontrol += "-[Prueba]";
                    Label control = (Label)this.MdiParent.Controls["lblusuario"];
                    control.Text = xontrol;
                    Properties.Settings.Default.Usuario = txtusuario.Text;
                    //segun usuario aqui defino visibilidad
                    MenuStrip control2 = (MenuStrip)this.MdiParent.Controls["menuppal"];

                    switch (acceso)
                    {
                        case "99":
                            control2.Visible = true;
                            if (txtusuario.Text.Trim() == "chelo" || txtusuario.Text.Trim() == "sra")
                                control2.Items[5].Visible = true;
                            else
                                control2.Items[5].Visible = false;
                            break;
                        case "00":
                            control2.Visible = true;
                            control2.Items[3].Visible = false;
                            break;
                        default:
                            break;

                    }
                    reg.Close();
                    this.Close();
                }
                else { configuracion.mensaje("Verifique Usuario y contraseña"); }

            }
            catch
            {
                configuracion.mensaje("Error de conexión");
            }
            finally
            {
            
                conectar.Close();
            }

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            btniniciar.Enabled = true;
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            configuracion.grupobox(grplogin);
            pictureBox1.Visible = true;
            //modoingreso();
            //Properties.Settings.Default.conf = coneccionxml();
        }

        private string coneccionxml()
        {
            string res = "confn.xml";
            DialogResult dialogo = MessageBox.Show("Configuración de red?",
                                  "Seleccione configuración", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.No)
                res = "confl.xml";
            else
                res = "confn.xml";
            return res;
        }
        private string modoingreso()
        {
            string res = "confn.xml";
            DialogResult dialogo = MessageBox.Show("Modo Produccion?",
                                  "Seleccione configuración", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.No)
            {
                Properties.Settings.Default.afipcertificado = "c:/sracsharp/Loundry/key/certificado.pfx";
                Properties.Settings.Default.afippassword = "feafip";
                Properties.Settings.Default.afipmodoproduccion = false;
            }
            else
            {
                Properties.Settings.Default.afipcertificado = "c:/sracsharp/Loundry/key/FEEJC.pfx";
                Properties.Settings.Default.afippassword = "ejc";
                Properties.Settings.Default.afipmodoproduccion = true;
            }
            res = "";
            return res;
        }
    }
}
