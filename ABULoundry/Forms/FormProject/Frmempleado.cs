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
    public partial class Frmempleado : Form
    {
        public int puntero;
        public Frmempleado()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmempleado.refresh(ref dgvempleado);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            abmempleado.alta(ref txtcempl, ref txtapellido, ref txtnombre, ref txttelefono, ref txtcelular, ref txtmail, ref txtcargo, ref dgvempleado);
            grpabm.Visible = true;
        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvempleado.CurrentRow.Index;
            string dato = this.dgvempleado.Rows[puntero].Cells["cempl"].Value.ToString();
            abmempleado.modif(ref txtcempl, ref txtapellido, ref txtnombre, ref txttelefono, ref txtcelular, ref txtmail, ref txtcargo, ref dgvempleado, dato);
            grpabm.Visible = true;
            abmempleado.refresh(ref dgvempleado);
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            puntero = dgvempleado.CurrentRow.Index;
            string dato = this.dgvempleado.Rows[puntero].Cells["cempl"].Value.ToString();
            abmempleado.borra(dato, ref dgvempleado);
            abmempleado.refresh(ref dgvempleado);
        }

        private void dgvempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                puntero = dgvempleado.CurrentRow.Index;
            }
            catch
            {
                puntero = -1;
            }
        }

        private void Frmempleado_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvempleado, "", 9, true);
            configuracion.tabcontrol(tabControl1);
            dgvempleado.MouseClick += new MouseEventHandler(dgvempleado_MouseClick);
            configuracion.grupobox(grpabm);
            btnrefresh.PerformClick();
        }

        private void dgvempleado_MouseClick(object sender, MouseEventArgs e)
        {
            // throw new NotImplementedException();
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int fila = dgvempleado.HitTest(e.X, e.Y).RowIndex;
                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name = "Nue";
                    m.Items.Add("Modificar").Name = "Mod";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Buscar").Name = "Bus";
                }
                m.Show(dgvempleado, new Point(e.X, e.Y));
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
            abmempleado.graba(txtcempl.Text, txtapellido.Text, txtnombre.Text, txttelefono.Text, txtcelular.Text, txtmail.Text, txtcargo.Text, ref dgvempleado);
            grpabm.Visible = false;
            abmempleado.refresh(ref dgvempleado);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmempleado.buscar(ref dgvempleado);
        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            grpabm.Visible = false;
        }

        private void dgvempleado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
    }
}
