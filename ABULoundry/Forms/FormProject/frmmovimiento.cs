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
    public partial class frmmovimiento : Form
    {
        public frmmovimiento()
        {
            InitializeComponent();
        }

        private void frmmovimiento_Load(object sender, EventArgs e)
        {
            configuracion.confdgv(dgvmovimientos, "", 9, true);
            configuracion.confdgv(dgvconsulta, "", 9, true);
            configuracion.grupobox(groupBox2);
            configuracion.tabcontrol(tabControl1);

            abmmovimientos.refresh(ref dgvmovimientos, dtpfechdesde, dtpfechhasta);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            abmmovimientos.refresh(ref dgvmovimientos, dtpfechdesde, dtpfechhasta);
        }

        private void cmbventas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cmbventas.SelectedIndex;
            if (ind != 0)
            {
                string fdesde = libreria.fechaamysql(dtpfechdesde.Value.ToString());
                string fhasta = libreria.fechaamysql(dtpfechhasta.Value.ToString());
                string consulta = string.Empty;
                switch (ind)
                {
                    case 1:
                        consulta = "Select rubros.detalle as Rubro, sum(cantidad) as cantidad, truncate(sum(pventa*cantidad),2) as venta from movimiento " +
                            "left join rubros on (rubros.crubro=movimiento.crubro) " +
                                   "where fechform between '" + fdesde + "' and '" + fhasta + "' and " +
                                          "(cform='0TK0' OR cform='0TK1') " +
                                   "group by movimiento.crubro order by movimiento.cantidad desc";
                        break;
                    case 2:
                        consulta = "Select productos.detalle as Producto, sum(movimiento.cantidad) as cantidad, truncate(sum(movimiento.pventa*movimiento.cantidad),2) as venta "+
                            "from movimiento " +
                            "left join productos on (productos.cprod=movimiento.cprod) " +
                                   "where (fechform between '" + fdesde + "' and '" + fhasta + "') and " +
                                         "(cform='0TK0' OR cform='0TK1') " +
                                   "group by movimiento.cprod order by movimiento.cantidad desc";
                        break;
                    case 3:
                        consulta = "Select cliente, cliente.Rsocial, truncate(sum(pventa*cantidad),2) as venta from movimiento " +
                            "left join cliente on (cliente.codigo=movimiento.cliente) " +
                                   "where (fechform between '" + fdesde + "' and '" + fhasta + "') and cliente <>'' " +
                                   "group by movimiento.cliente order by venta desc";
                        break;
                    case 4:
                        consulta = "SELECT Truncate( SUM(movimiento.pventa * movimiento.cantidad),2) as Venta, "+
                                   "truncate ("+
                                     "( select sum(ganancia) from ( "+
                                     "SELECT sum(movimiento.cantidad) as cantidad, " +
                                     "case Cliente.Lp " +
                                     "     WHEN 0 then " +
                                     "            (SUM(movimiento.pventa * movimiento.cantidad) * Xmostrador) / 100 " +
                                     "     WHEN 1 then " +
                                     "            (SUM(movimiento.pventa * movimiento.cantidad) * Xminorista) / 100 " +
                                     "     WHEN 2 then " +
                                     "            (SUM(movimiento.pventa * movimiento.cantidad) * Xmayorista) / 100 " +
                                     "end as ganancia " +
                                     "from movimiento " +
                                     "LEFT JOIN cliente ON (cliente.Codigo = movimiento.Cliente) " +
                                     "LEFT JOIN productos ON(productos.Cprod = movimiento.Cprod) " +
                                     "where cform = '0TK0' OR Cform = '0TK1' " +
                                     "GROUP BY movimiento.Cprod " +
                                     ")s1 " +
                                   "),2) as Ganancia " +
                                   "from movimiento " +
                                   "where cform = '0TK0' OR Cform = '0TK1' "  ;
              
                        break;
                }
                abmmovimientos.refreshopciones(ref dgvconsulta, consulta);
                txtcprod.Text = string.Empty;
                txtccliente.Text = string.Empty;
                consulta = "Select truncate(sum(pventa*cantidad),2) as venta from movimiento " +
                           "where fechform between '" + fdesde + "' and '" + fhasta + "' and " +
                           "(cform='0TK0' OR cform='0TK1') ";
                txttotalventa.Text = bdcomun.contenidocampo(consulta, "venta");
                txtcprod.Text = string.Empty;
                txtccliente.Text = string.Empty;
                lblgproducto.Text = "...";
                lblgcliente.Text = "...";
                groupBox3.Text = cmbventas.Text;
            }
        }

        private void txtcprod_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fdesde = libreria.fechaamysql(dtpfechdesde.Value.ToString());
            string fhasta = libreria.fechaamysql(dtpfechhasta.Value.ToString());
            frmremfactproducto frm = new frmremfactproducto();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtcprod.Text = frm.retornacprod;
                lblgproducto.Text = bdcomun.contenidocampo("select * from productos where cprod='" + txtcprod.Text + "'","detalle");
            }
            string consulta = "Select fechform, cform, nroform, cantidad, stock " +
                       "from movimiento " +
                       "where (fechform between '" + fdesde + "' and '" + fhasta + "') and cprod ='" + txtcprod.Text + "' " +
                       "order by pk";
            abmmovimientos.refreshopciones(ref dgvconsulta, consulta);
            consulta = "Select truncate(sum(pventa),2) as venta " +
                       "from movimiento " +
                      "where (fechform between '" + fdesde + "' and '" + fhasta + "') and cprod ='" + txtcprod.Text + "' ";
            txttotalventa.Text = bdcomun.contenidocampo(consulta, "venta");
            cmbventas.SelectedIndex = 0;
            txtccliente.Text = string.Empty;
            txttotalventa.Text = "0";
            txtccliente.Text = string.Empty;
            lblgcliente.Text = "...";
            cmbventas.SelectedIndex = 0;
            groupBox3.Text = lblgproducto.Text;
        }

        private void txtccliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fdesde = libreria.fechaamysql(dtpfechdesde.Value.ToString());
            string fhasta = libreria.fechaamysql(dtpfechhasta.Value.ToString());
            frmprocesocliente frm = new frmprocesocliente();
            if (frm.ShowDialog() == DialogResult.OK) { 
                txtccliente.Text = frm.retornaccliente;
                lblgcliente.Text=bdcomun.contenidocampo("select * from cliente where codigo='"+txtccliente.Text+"'","rsocial");
            }
            string consulta = "Select fechform, cform, nroform, cantidad, pventa , truncate((pventa*cantidad),2) as Total " +
                       "from movimiento " +
                       "where (fechform between '" + fdesde + "' and '" + fhasta + "') and cliente ='" + txtccliente.Text + "' " +
                       "order by pk";
            abmmovimientos.refreshopciones(ref dgvconsulta, consulta);
            cmbventas.SelectedIndex = 0;
            txtcprod.Text = string.Empty;
            consulta = "Select truncate(sum(pventa*cantidad),2) as venta " +
                      "from movimiento " +
                      "where (fechform between '" + fdesde + "' and '" + fhasta + "') and cliente ='" + txtccliente.Text + "' ";
            txttotalventa.Text = bdcomun.contenidocampo(consulta, "venta");
            txtcprod.Text = string.Empty;
            lblgproducto.Text = "...";
            cmbventas.SelectedIndex = 0;
            groupBox3.Text = lblgcliente.Text;
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            abmmovimientos.refresh(ref dgvmovimientos, dtpfechdesde, dtpfechhasta);
        }

        private void dgvmovimientos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }

        private void dgvconsulta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try { } catch { }
        }
    }
}
