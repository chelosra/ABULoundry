using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Loundry
{
    public partial class frmconfiguracion : Form
    {
        public frmconfiguracion()
        {
            InitializeComponent();
        }


        private static frmconfiguracion fconf;
        public static frmconfiguracion verificonull()
        {
            if (fconf == null)
                fconf = new frmconfiguracion();
            return fconf;
        }

        private void frmconfiguracion_Load(object sender, EventArgs e)
        {

        }

        private void frmconfiguracion_Leave(object sender, EventArgs e)
        {
            fconf = null;
        }

        private void btncrea_Click(object sender, EventArgs e)
        {
            if (txtservidor.Text != string.Empty && txtdatabase.Text != string.Empty &&
                txtusuario.Text != string.Empty && txtpassword.Text != string.Empty)
            {
                libreria.creaxml(txtservidor.Text, txtdatabase.Text, txtusuario.Text, txtpassword.Text, txtdirectorio.Text, txtnomarch.Text);
                libreria.MessageBoxTemporal.Show("Archivo creado", configuracion.titulomensaje(), 1, true);
            }
        }

        private void txtnomarch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiabases_Click(object sender, EventArgs e)
        {
            /*
            bdcomun.ejecuta("truncate auxmovimiento");
            bdcomun.ejecuta("truncate auxmovimiento3");
            bdcomun.ejecuta("truncate caja");
            bdcomun.ejecuta("truncate detcaja");
            bdcomun.ejecuta("truncate cheques");
            bdcomun.ejecuta("truncate ctactecliente");
            bdcomun.ejecuta("truncate documento");
            bdcomun.ejecuta("truncate documentoenc");
            bdcomun.ejecuta("truncate factfinal");
            bdcomun.ejecuta("truncate movimiento");
            bdcomun.ejecuta("update productos set stact='0'");
            configuracion.mensaje("Limpieza completa");
            */
        }

        private void btnCreaDirectorios_Click(object sender, EventArgs e)
        {
            libreriaproyecto.CreaDirectorios();
        }
    }
}
