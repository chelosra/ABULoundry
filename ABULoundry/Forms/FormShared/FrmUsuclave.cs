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
    public partial class FrmUsuclave : Form
    {
        private static FrmUsuclave fcclave;
        private MySqlConnection conectar;
        public FrmUsuclave()
        {
            InitializeComponent();
        }

        public static FrmUsuclave verificonull()
        {
            if (fcclave == null)
                fcclave = new FrmUsuclave();
            return fcclave;
        }

        private void FrmUsuclave_Leave(object sender, EventArgs e)
        {
            fcclave = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mclaven.Text.Trim() == mclaver.Text.Trim()) 
            {
                //grabo nueva clave para el usuario
                Label control = (Label)this.MdiParent.Controls["lblusuario"];
                string usu=control.Text.Trim();
                string clave = libreria.Encriptar(mclaver.Text.Trim());
                string consulta = "update Loundry.usuario set clave='"+ clave+"' where nickname='" + usu + "'";
                bdcomun.ejecuta(consulta);
                configuracion.mensaje("Password actualizada");
            }
            else 
            {
                configuracion.mensaje("Las claves no coinciden");
            }

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // tomo el valor del usuario del mdi
            Label control = (Label)this.MdiParent.Controls["lblusuario"];
            string usu = control.Text.Trim();
            string clave =libreria.Encriptar(mClave.Text.Trim());
            string consulta = "select nickname, clave from Loundry.usuario where nickname='" + usu + "' and clave='" + clave + "'";
            conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg(consulta,conectar);
            if (reg.HasRows)
            {
                mclaven.Enabled = true;
                mclaver.Enabled = true;
            }
            reg.Close();
          
            conectar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
