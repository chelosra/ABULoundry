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
    public partial class Frmreseteausu : Form
    {
        private MySqlConnection conectar;
        public Frmreseteausu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (mclave.Text.Trim() == mclaver.Text.Trim())
            {
                //grabo nueva clave para el usuario
                //Label control = (Label)this.MdiParent.Controls["musuario"];
                //string usu = control.Text.Trim();
                string usu = musu.Text.Trim();
                string clave = libreria.Encriptar(mclaver.Text.Trim());
                string consulta = "update Loundry.usuario set clave='" + clave + "' where nickname='" + usu + "'";
                bdcomun.ejecuta(consulta);
                configuracion.mensaje("Password reseteada");
                musu.Text = string.Empty;
                mclave.Text = string.Empty;
                mclaver.Text = string.Empty;
            }
            else
            {
                configuracion.mensaje("Las claves no coinciden");
            }
          
            conectar.Close();
        }

        private void musu_TextChanged(object sender, EventArgs e)
        {
            // tomo el valor del usuario del mdi
//            Label control = (Label)this.MdiParent.Controls["musuario"];
//            string usu = control.Text.Trim();
//            string clave = sralibreria.Encriptar(mClave.Text.Trim());
            string usu = musu.Text.Trim();
            string consulta = "select nickname, clave from Loundry.usuario where nickname='" + usu + "'";
            conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg(consulta,conectar);
            if (reg.HasRows)
            {
                mclave.Enabled = true;
                mclaver.Enabled = true;
            }
     
            conectar.Close();
        }

        private void Frmreseteausu_Load(object sender, EventArgs e)
        {
            musu.Focus();
        }
    }
}
