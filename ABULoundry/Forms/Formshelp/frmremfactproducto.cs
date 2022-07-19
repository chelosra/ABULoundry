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
    public partial class frmremfactproducto : Form
    {
        public string retornacprod;
        public string retornacrubro;
        public string retornapcosto;

        public frmremfactproducto()
        {
            InitializeComponent();
        }

        private void frmremfactproducto_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvproductos, "", 9, true);
            refreshprod(ref dgvproductos);
        }

        private static void refreshprod(ref DataGridView dgv)
        {
            string consulta = "select Cprod, Productos.Detalle, Stmin, Stact, Pcosto, Pventa, Pventa1, Pventa2, rubros.detalle as Rubro, Productos.Crubro " +
                              " from productos " +
                              "Inner join rubros on (rubros.crubro=productos.crubro) " +
                              " order by Productos.detalle";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        private static void buscarprod(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese producto");
            string consulta = "select * from productos where detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        private void dgvproductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int puntero = dgvproductos.CurrentRow.Index;
            string dato = this.dgvproductos.Rows[puntero].Cells["cprod"].Value.ToString();
            retornacprod = dato;
            retornacrubro = bdcomun.ejecuta("select * from productos where cprod='" + dato + "'", "crubro");
            retornapcosto = bdcomun.ejecuta("select * from productos where cprod='" + dato + "'", "pcosto");
            DialogResult = DialogResult.OK; //cierra el formulario
            this.Close();
        }

        private void btnbuscaprod_Click(object sender, EventArgs e)
        {
            buscarprod(ref dgvproductos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshprod(ref dgvproductos);
        }
    }
}
