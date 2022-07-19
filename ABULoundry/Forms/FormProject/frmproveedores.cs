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
    public partial class frmproveedores : Form
    {
        public int puntero;
        public frmproveedores()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmproveedor.refresh(ref dgvproveedor);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            abmproveedor.alta(ref txtcprov, ref txtrsocial, ref txtcontacto, ref txttelefono, ref txtfax, ref txtcelular, ref txtmail, ref dgvproveedor);
            grpabm.Visible = true;
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvproveedor.CurrentRow.Index;
            string dato = this.dgvproveedor.Rows[puntero].Cells["cprov"].Value.ToString();
            if (dato != "0000")
                abmproveedor.modif(ref txtcprov, ref txtrsocial, ref txtcontacto, ref txttelefono, ref txtfax, ref txtcelular, ref txtmail, ref dgvproveedor, dato);
            grpabm.Visible = true;
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            puntero = dgvproveedor.CurrentRow.Index;
            string dato = this.dgvproveedor.Rows[puntero].Cells["cprov"].Value.ToString();
            if (dato != "0000")
                abmproveedor.borra(dato, ref dgvproveedor);
            else
                configuracion.mensaje("No puede borrar DISTRIBUIDORA EJC"); 
        }

        private void dgvproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                puntero = dgvproveedor.CurrentRow.Index;
            }
            catch
            {
                puntero = -1;
            }
        }

        private void frmproveedores_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvproveedor, "", 9, true);
            dgvproveedor.MouseClick += new MouseEventHandler(dgvproveedor_MouseClick);
            configuracion.grupobox(grpabm);
            configuracion.tabcontrol(tabControl1);

            btnrefresh.PerformClick();
        }

        private void dgvproveedor_MouseClick(object sender, MouseEventArgs e)
        {
            //  throw new NotImplementedException();
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int fila = dgvproveedor.HitTest(e.X, e.Y).RowIndex;
                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name = "Nue";
                    m.Items.Add("Modificar").Name = "Mod";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Buscar").Name = "Bus";
                }
                m.Show(dgvproveedor, new Point(e.X, e.Y));
                //evento
                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
            }
        }

        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //throw new NotImplementedException();
            switch (e.ClickedItem.Name.ToString())
            {
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

        private void btngraba_Click(object sender, EventArgs e)
        {
            abmproveedor.graba(txtcprov.Text, txtrsocial.Text, txtcontacto.Text, txttelefono.Text, txtfax.Text, txtcelular.Text, txtmail.Text, ref dgvproveedor);
            grpabm.Visible = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmproveedor.buscar(ref dgvproveedor);
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
        }

        private void dgvproveedor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
    }
}
