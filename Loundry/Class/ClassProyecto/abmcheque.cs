using InputKey;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    class abmcheque
    {
        public static void refresh(ref DataGridView dgv, string codclie, string cform, string nroform,TextBox txtsubtotal)
        {
            string consulta = "SELECT * " +
                              "FROM auxcheques " +
                              "where ccliente='" + codclie + "' and cform='" + cform + "' and nroform='" + nroform + "'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            totalcomanda(codclie, cform, nroform, ref txtsubtotal);
            
            //string[] campos2 = { "crubro", "detalle", "xmostrador", "xminorista", "xmayorista" };
            //string[] nombres = { "Código Rubro", "Rubro", "% Venta Mostrador", "% Venta Minorista", "% Venta Mayorista" };
            //configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
            //string[] campos = { "xmostrador", "xminorista", "xmayorista", "xdescuento" };
            //configuracion.dgvocultacolumna(ref dgv, campos);
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Banco");
            string consulta = "select * from auxcheques where banco like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void alta(ref TextBox ccliente, ref TextBox caja, ref DateTimePicker fechform, ref TextBox cform,
                                ref TextBox nroform, ref TextBox banco, ref TextBox nrocheque, ref TextBox importe, ref DateTimePicker fechcheque, ref DataGridView dgv,
                                string codclie, string codcaja, string fechaform, string cformu, string nroformu, string total)
        {
            dgv.Tag = "0";
            ccliente.Text = codclie; 
            caja.Text = codcaja;
            fechaform = DateTime.Now.ToShortDateString(); 
            cform.Text = cformu;
            nroform.Text = nroformu;
            banco.Text = string.Empty;
            nrocheque.Text = string.Empty;
            importe.Text = total;
            fechcheque = fechform;
            banco.Focus();
        }
        public static void modif(ref TextBox ccliente, ref TextBox caja, ref DateTimePicker fechform, ref TextBox cform,
                                ref TextBox nroform, ref TextBox banco, ref TextBox nrocheque, ref TextBox importe, ref DateTimePicker fechcheque, ref DataGridView dgv,
                                string dato)
        {
            dgv.Tag = "1";
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from auxcheques where pk='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            ccliente.Text = reg["ccliente"].ToString();
            caja.Text = reg["nrocaja"].ToString(); ;
            fechform.Text = reg["fechform"].ToString();
            cform.Text = reg["cform"].ToString();
            nroform.Text = reg["nroform"].ToString();
            banco.Text = reg["banco"].ToString();
            nrocheque.Text = reg["ncheque"].ToString();
            importe.Text = reg["importe"].ToString();
            fechcheque.Text = reg["fechcheque"].ToString();
            banco.Focus();
        }

        public static void graba(string ccliente, string caja, string fechform, string cform, string nroform, string banco,
                           string nrocheque, string importe, string fechcheque, ref DataGridView dgv, string dato, TextBox txtsubtotal)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into auxcheques ";
                    break;
                case "1":
                    preconsulta = "update auxcheques ";
                    where = " where pk='" + dato + "'";
                    break;
            }
            set = "set ccliente = '" + ccliente + "', nrocaja = '" + caja +
                       "', fechform = '" + fechform +
                       "', cform='" + cform +
                       "', nroform='" + nroform +
                       "', banco='" + banco +
                       "', ncheque='" + nrocheque +
                       "', importe='" + importe +
                       "', fechcheque='" + fechcheque + "'";
            bdcomun.ejecuta(preconsulta + set + where);
          
            conectar.Close();
            configuracion.mensaje("Cheque grabado");
            abmcheque.refresh(ref dgv,ccliente,cform,nroform,txtsubtotal);
        }
        public static void borra(string dato, ref DataGridView dgv, string codclie, string cform, string nroform, TextBox txtsubtotal)
        {
            if (MessageBox.Show("Desea Borrar el Cheque?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bdcomun.ejecuta("delete from auxcheques where pk='" + dato + "'");
                configuracion.mensaje("Cheque borrado");
                abmcheque.refresh(ref dgv,codclie,cform,nroform,txtsubtotal);
            }
            else configuracion.mensaje("Proceso cancelado");
        }

        public static void totalcomanda(string codclie, string cform, string nroform, ref TextBox txtsubtotal)
        {
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "SELECT SUM(importe) as subtotal " +
                              "FROM auxcheques " +
                              "where ccliente='" + codclie + "' and cform='"+cform+"' and nroform='"+nroform+"'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            if (reg.HasRows)
            {
                reg.Read();

                txtsubtotal.Text = libreria.stringdecimalastring2dec(reg["subtotal"].ToString());
                //txtdto.Text = libreria.stringdecimalastring2dec(reg["dto"].ToString());
                //txttotal.Text = libreria.stringdecimalastring2dec(reg["total"].ToString());
            }
            reg.Close();
          
            conectar.Close();
        }
    }
}
