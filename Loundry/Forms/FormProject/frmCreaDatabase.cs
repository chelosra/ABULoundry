using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    public partial class frmCreaDatabase : Form
    {
        private int puntero;
        public frmCreaDatabase()
        {
            InitializeComponent();
        }

        private void btnCreaanio_Click(object sender, EventArgs e)
        {
            if (txtcrubro.Text != string.Empty)
            {
                string detalle = "cocheria" + txtDetalle.Text;
                string consulta = "insert into "+Properties.Settings.Default.Backup+".anios set " +
                                  "crubro='" + txtcrubro.Text + "', " +
                                  "detalle='" + detalle + "'";
                bdcomun.ejecuta(consulta);
                bdcomun.ejecuta("create database " + detalle);
                //bdcomun.ejecuta("CREATE TABLE " + detalle + ".dpfallecido LIKE cocheriaconf.dpfallecido");
                grp.Visible = false;
                configuracion.mensaje("Período creado");
                refresh();
            }
        }

        private void refresh()
        {
            bdcomun.dgv(dgv, "Select * from "+Properties.Settings.Default.Backup+".anios");
            configuracion.confdgv(dgv, "", 10, true);
        }

        private void frmCreaDatabase_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //grp.Visible = true;
            //txtcrubro.Text = libreriabase.newreg("Select * from "+Properties.Settings.Default.Backup+".anios order by crubro desc", "Crubro", 4);
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            grp.Visible = false;
            txtcrubro.Text = "";
            txtDetalle.Text = "";
        }

        private void btnBorraDatabase_Click(object sender, EventArgs e)
        {
            /* 
            string detalle = libreria.valorcelda(puntero, dgv, "detalle", "");
            string crubro = libreria.valorcelda(puntero, dgv, "crubro", "");
            string consulta = "DROP DATABASE " + detalle;
            DialogResult dialogo = MessageBox.Show("¿ Confirma borrado período " + detalle,
           "Confirma Borrado?", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                bdcomun.ejecuta(consulta);
                consulta = "delete from "+Properties.Settings.Default.Backup +".anios where crubro='" + crubro + "'";
                bdcomun.ejecuta(consulta);
                configuracion.mensaje("Período Eliminado");
                refresh();
            }
            */
        }
        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            puntero = dgv.CurrentRow.Index;
            //throw new NotImplementedException();
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int fila = dgv.HitTest(e.X, e.Y).RowIndex;
                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name = "Nue";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Backup").Name = "Bac";
                    m.Items.Add("Restore").Name = "Res";
                }

                m.Show(dgv, new Point(e.X, e.Y));
                //evento
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
            }
        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Nue":
                    btnCrea.PerformClick();
                    break;
                case "Bor":
                    if (libreria.valorcelda(puntero, dgv, "crubro", "0") != "0000")
                        btnBorraDatabase.PerformClick();
                    break;
                case "Bac":
                    btnBackup.PerformClick();
                    break;
                case "Res":
                    btnRestore.PerformClick();
                    break;
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            string detalle = libreria.valorcelda(puntero, dgv, "detalle", "");
            picture.Visible = true;
            Backup(detalle);
            picture.Visible = false;
        }


        private void Backup(string detalle)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "SQL BACKUP|*.sql";
            sf.Title = "BACKUP SQL";
            sf.ShowDialog();
            if (sf.FileName != "")
            {
                string filename = sf.FileName;
                //string constring = "server=localhost;user=root;pwd=apache;database=" + detalle + ";";
                // Important Additional Connection Options
                //constring += "charset=utf8;convertzerodatetime=true;";
                MySqlConnection conn = bdcomun.Conexion(detalle);
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup mb = new MySqlBackup(cmd);
                cmd.Connection = conn;
                //conn.Open();
                mb.ExportToFile(filename);
                conn.Close();
                configuracion.mensaje("Backup realizado");
            }
        }

        private void Restore(string detalle)
        {
            // Important Additional Connection Options
            //string constring = "server=localhost;user=root;pwd=apache;database=" + detalle + ";";
            //constring += "charset=utf8;convertzerodatetime=true;";
            string file = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciones archivo origen de restauración";
            ofd.Filter = "SQL BACKUP|*.sql";
            DialogResult result = ofd.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                file = ofd.FileName;
                MySqlConnection conn = bdcomun.Conexion(detalle);
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup mb = new MySqlBackup(cmd);
                cmd.Connection = conn;
                //conn.Open();
                mb.ImportFromFile(file);
                conn.Close();
                configuracion.mensaje("Datos restaurados");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string detalle = libreria.valorcelda(puntero, dgv, "detalle", "");
            DialogResult dialogo = MessageBox.Show("Va a restaurar el período " + detalle+" borrando datos existentes",
                                   "Confirma Restauración?", MessageBoxButtons.YesNo);
            picture.Visible = true;
            if (dialogo == DialogResult.Yes)
                Restore(detalle);
            picture.Visible = false;
        }

        private void txtcrubro_TextChanged(object sender, EventArgs e)
        {
            string dato = libreria.rellena(txtcrubro.Text, 4);
            if (libreriabase.existe("Select * from "+Properties.Settings.Default.Backup+".anios where crubro='" + dato + "'"))
            {
                configuracion.mensaje("Código existente");
                //txtcrubro.Text = libreriabase.newreg("Select * from cocheriaconf.anios order by crubro desc", "Crubro", 4);
            }
        }

        private void txtcrubro_Leave(object sender, EventArgs e)
        {
            string dato = libreria.rellena(txtcrubro.Text, 4);
            if (libreriabase.existe("Select * from hsi2.anios where crubro='" + dato + "'"))
            {
                configuracion.mensaje("Código existente, vuelva a ingresarlo");
                txtcrubro.Text = string.Empty;
                //txtcrubro.Text = libreriabase.newreg("Select * from cocheriaconf.anios order by crubro desc", "Crubro", 4);
            }
        }
    }
}
