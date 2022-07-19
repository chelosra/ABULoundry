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

namespace Loundry
{
    public partial class frmrubros : Form
    {
        public int puntero;
        public frmrubros()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmrubros_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvrubros, "", 9, true);
            dgvrubros.MouseClick += new MouseEventHandler(dgvrubros_MouseClick);
            configuracion.grupobox(grpabm);
            configuracion.tabcontrol(tabControl1);

            btnrefresh.PerformClick();
        }

        private void dgvrubros_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();

                int fila = dgvrubros.HitTest(e.X, e.Y).RowIndex;

                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name="Nue";
                    m.Items.Add("Modificar").Name="Mod";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Buscar").Name="Bus";
                }

                m.Show(dgvrubros, new Point(e.X, e.Y));
                //evento
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
            }
        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.ClickedItem.Name.ToString()) {
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmrubro.refresh(ref dgvrubros);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            abmrubro.alta(ref txtcrubro, ref txtdetalle, ref txtxdescuento, ref txtxmostrador, ref txtxminorista, ref txtxmayorista, ref dgvrubros);
            grpabm.Visible = true;
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvrubros.CurrentRow.Index;
            string dato = this.dgvrubros.Rows[puntero].Cells["crubro"].Value.ToString();
            abmrubro.modif(ref txtcrubro, ref txtdetalle, ref txtxdescuento, ref txtxmostrador, ref txtxminorista, ref txtxmayorista, ref dgvrubros, dato);
            grpabm.Visible = true;
        }

        private void dgvrubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                puntero = dgvrubros.CurrentRow.Index;
            }
            catch
            {
                puntero = -1;
            }
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            puntero = dgvrubros.CurrentRow.Index;
            string dato = this.dgvrubros.Rows[puntero].Cells["crubro"].Value.ToString();
            abmrubro.borra(dato, ref dgvrubros); ;
        }

        private void btngraba_Click(object sender, EventArgs e)
        {
            abmrubro.graba(txtcrubro.Text, txtdetalle.Text, txtxdescuento.Text, txtxmostrador.Text, txtxminorista.Text, txtxmayorista.Text, ref dgvrubros);
            grpabm.Visible = false;
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
        }

        private void txtcrubro_Leave(object sender, EventArgs e)
        {
            /*
            string aux = txtcrubro.Text;
            txtcrubro.Text = libreria.rellena(aux, 4);
            //buscar si existe
            if (libreriabase.existe("select * from rubros where crubro='"+txtcrubro.Text +"'"))
            {
                configuracion.mensaje("El registro existe");
                txtcrubro.Text = string.Empty;
                txtcrubro.Focus();
            }
            btnrefresh.PerformClick();
            */
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmrubro.buscar(ref dgvrubros);
        }

        private void txtxmostrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxmostrador, e);
        }

        private void txtxmostrador_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxmostrador);
        }

        private void txtxminorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxminorista, e);
        }

        private void txtxminorista_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxminorista);
        }

        private void txtxmayorista_Leave(object sender, EventArgs e)
        {
            libreria.textboxvacioxcero(txtxmayorista);
        }

        private void txtxmayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textboxdecimal(txtxmayorista, e);
        }

        private void dgvrubros_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
    }
}
