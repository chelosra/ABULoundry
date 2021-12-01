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
    public partial class frmcajaproveedor : Form
    {
        public string retornacprov;

        public frmcajaproveedor()
        {
            InitializeComponent();
        }

        private void btnrefreshclie_Click(object sender, EventArgs e)
        {
            abmcaja.refresh(ref dgvproveedor, "Select * from proveedores");
        }

        private void btnbuscaclie_Click(object sender, EventArgs e)
        {
            abmcaja.buscarproveedor(ref dgvproveedor);
        }

        private void frmcajaproveedor_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvproveedor, "", 9, true);
            btnrefreshclie.PerformClick();
        }

        private void dgvproveedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int puntero = dgvproveedor.CurrentRow.Index;
            string dato = this.dgvproveedor.Rows[puntero].Cells["cprov"].Value.ToString();
            retornacprov = dato;
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }
    }
}
