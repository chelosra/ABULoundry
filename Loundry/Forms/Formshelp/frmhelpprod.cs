using InputKey;
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
    public partial class frmhelpprod : Form
    {
        public string retornacprod;
        public string retornacantidad;
        public string retornapventa;
        public string cmbcpventa;
        public string lp;
        public frmhelpprod()
        {
            InitializeComponent();
        }

        private void frmhelpprod_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgv, "", 12, true);
            refresh(ref dgv);
        }

        private static void refresh(ref DataGridView dgv)
        {
            string consulta = "select Detalle, Pventa, Cprod, Stact " +
                              " from productos " +
                              " order by detalle";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos2 = { "Cprod", "Stact" };
            configuracion.dgvocultacolumna(ref dgv, campos2);
        }
        private static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Descripción del Producto");
            string consulta = "select * from productos where detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int puntero = dgv.CurrentRow.Index;
            decimal stock = Convert.ToDecimal(libreria.valorcelda(puntero, dgv, "stact", "0"));
            if (stock > 0)
            {
                int lpint = Convert.ToInt16(lp);
                switch (lpint)
                {
                    case 0:
                        retornapventa = libreria.valorcelda(puntero, dgv, "pventa", "0");
                        break;
                    case 1:
                        retornapventa = libreria.valorcelda(puntero, dgv, "pventa1", "0");
                        break;
                    case 2:
                        retornapventa = libreria.valorcelda(puntero, dgv, "pventa2", "0");
                        break;
                }
                retornacprod = libreria.valorcelda(puntero, dgv, "cprod", "0");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                configuracion.mensaje("El producto no tiene Stock");
            }
        }

        private void btnbusca_Click(object sender, EventArgs e)
        {
            buscar(ref dgv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh(ref dgv);
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscaCprod_Click(object sender, EventArgs e)
        {
            string dato = InputDialog.mostrar("Ingrese Código Producto");
            string consulta = "select * from productos where cprod like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
    }
}
