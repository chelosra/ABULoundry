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
    public partial class frmcliente : Form
    {
        private int puntero;
        
        public frmcliente()
        {
            InitializeComponent();
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvclientes, "", 9, true);
            dgvclientes.MouseClick += new MouseEventHandler(dgvclientes_MouseClick);
            configuracion.confdgv(dgvctacte, "", 9, true);
            configuracion.confdgv(dgvdetalleopera, "", 9, true);
            configuracion.tabcontrol(tabControl1);
            btnrefresh.PerformClick();
        }

        private void dgvclientes_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int fila = dgvclientes.HitTest(e.X, e.Y).RowIndex;
                if (fila >= 0)
                {
                    m.Items.Add("Nuevo").Name = "Nue";
                    m.Items.Add("Modificar").Name = "Mod";
                    m.Items.Add("Borrar").Name = "Bor";
                    m.Items.Add("Buscar").Name = "Bus";
                }
                m.Show(dgvclientes, new Point(e.X, e.Y));
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmcliente.refresh(ref dgvclientes);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            frmabmcliente frm = new frmabmcliente();
            frm.tag = 0;
            frm.dgvclientes = dgvclientes;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }

        }

        private void btnmodifica_Click(object sender, EventArgs e)
        {
            puntero = dgvclientes.CurrentRow.Index;
            string dato = this.dgvclientes.Rows[puntero].Cells["codigo"].Value.ToString();
            frmabmcliente frm = new frmabmcliente();
            frm.tag = 1;
            frm.dgvclientes = dgvclientes;
            frm.dato = dato;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnborra_Click(object sender, EventArgs e)
        {
            puntero = dgvclientes.CurrentRow.Index;
            string dato = this.dgvclientes.Rows[puntero].Cells["codigo"].Value.ToString();
            if (Convert.ToInt64(dato) > 1)
                abmcliente.borra(dato, ref dgvclientes);
            else
                configuracion.mensaje("No se puede borrar el Consumidor Final ni la Propia Empresa");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abmcliente.buscar(ref dgvclientes);
        }


        private void dgvclientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            puntero = dgvclientes.CurrentRow.Index;
            //string dato = this.dgvclientes.Rows[puntero].Cells["codigo"].Value.ToString();
            //abmcliente.refreshctacte(ref dgvctacte, dato);
            //tabControl1.SelectedIndex = 1;
        }

        private void dgvctacte_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                puntero = dgvctacte.CurrentRow.Index;
                string cliente = this.dgvctacte.Rows[puntero].Cells["ccliente"].Value.ToString();
                string nrocaja = this.dgvctacte.Rows[puntero].Cells["nrocaja"].Value.ToString();
                string cform = this.dgvctacte.Rows[puntero].Cells["cform"].Value.ToString();
                string nroform = this.dgvctacte.Rows[puntero].Cells["nroform"].Value.ToString();
                abmcliente.refreshcheques(ref dgvdetalleopera, cliente, nrocaja, cform, nroform);
                tabControl1.SelectedIndex = 2;
            }
            catch { }
        }

        private void dgvclientes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvctacte_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvdetalleopera_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
    }
}
