using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Loundry
{
    public partial class Frmcreausu : Form
    {
        private MySqlConnection conectar;
        public Frmcreausu()
        {
            InitializeComponent();
        }
        private void Frmcreausu_Load(object sender, EventArgs e)
        {
            musu.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mpass.Text.Trim() == mpassr.Text.Trim())
            {
                //Label control = (Label)this.MdiParent.Controls["musuario"];
                //string usu = control.Text.Trim();
                string sector = msector.SelectedItem.ToString().Trim();
                switch (sector)
                {
                    case "Administrador":
                        sector = "99";
                        break;
                    case "Usuario":
                        sector = "00";
                        break;
                    default:
                        sector = "00";
                        break;
                }
                string clave = libreria.Encriptar(mpassr.Text.Trim());
                string consulta = "insert into Loundry.usuario (nickname,clave,sector) values ('" + musu.Text.Trim() + "', '" + clave + "','" + sector + "')";
                bdcomun.ejecuta(consulta);
                configuracion.mensaje("Usuario Creado");
                musu.Text = string.Empty;
                mpass.Text = string.Empty;
                mpassr.Text = string.Empty;
                libreria.seleccionaitemcombo(ref msector, "");
            }
            else
            {
                configuracion.mensaje("Las claves no coinciden");
            }
        }

        private void musu_TextChanged(object sender, EventArgs e)
        {
            string consulta = "select nickname from Loundry.usuario where nickname='" + musu.Text.Trim() + "'";
            conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            if (reg.HasRows)
            {
                configuracion.mensaje("El usuario ya existe");
                musu.Text = " ";
                musu.Focus();
            }
            reg.Close();
        
            conectar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
