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
    class abmchequespresenta
    {
        public static void refresh(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "SELECT * FROM cheques where ccliente>'0000' order by pk desc ";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);

            //totalcomanda(ref txtsubtotal);
            string[] campos = { "hora", "nrocaja", "cform", "nroform", "pk" };
            configuracion.dgvocultacolumna(ref dgv, campos);

            string[] campos2 = { "ccliente", "fechform", "banco", "ncheque", "importe", "fechcheque", "presentado" };
            string[] nombres = { "Cliente", "Fecha", "Banco", "Nº cheque", "Importe", "Fecha Depósito", "Depositado?" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Banco");
            string consulta = "select * from cheques where banco like '%" + dato + "%' and ccliente>'0000' order by pk desc";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        public static void modif(ref TextBox ccliente, ref TextBox caja, ref DateTimePicker fechform, ref TextBox cform,
                                ref TextBox nroform, ref TextBox banco, ref TextBox nrocheque, ref TextBox importe, ref DateTimePicker fechcheque, ref ComboBox cmbpresenta, ref DataGridView dgv,
                                string dato)
        {
            dgv.Tag = "1";
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from cheques where pk='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            if (reg.HasRows)
            {
                ccliente.Text = reg["ccliente"].ToString();
                caja.Text = reg["nrocaja"].ToString(); ;
                fechform.Text = reg["fechform"].ToString();
                cform.Text = reg["cform"].ToString();
                nroform.Text = reg["nroform"].ToString();
                banco.Text = reg["banco"].ToString();
                nrocheque.Text = reg["ncheque"].ToString();
                importe.Text = reg["importe"].ToString();
                fechcheque.Text = reg["fechcheque"].ToString();
                libreria.seleccionaitemcombo(ref cmbpresenta, reg["presentado"].ToString());
                banco.Focus();
            }
        }

        public static void graba(string ccliente, string caja, string fechform, string cform, string nroform, string banco,
                           string nrocheque, string importe, string fechcheque, string presentado, ref DataGridView dgv, string dato, TextBox txtsubtotal)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into cheques ";
                    break;
                case "1":
                    preconsulta = "update cheques ";
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
                       "', fechcheque='" + fechcheque +
                       "', presentado='" + presentado +
                       "'";
            bdcomun.ejecuta(preconsulta + set + where);
           
            conectar.Close();
            configuracion.mensaje("Cheque grabado");
            abmcheque.refresh(ref dgv, ccliente, cform, nroform, txtsubtotal);
        }
        public static void borra(string dato, ref DataGridView dgv, string codclie, string cform, string nroform, TextBox txtsubtotal)
        {
            if (MessageBox.Show("Desea Borrar el Cheque?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bdcomun.ejecuta("delete from auxcheques where pk='" + dato + "'");
                configuracion.mensaje("Cheque borrado");
                abmcheque.refresh(ref dgv, codclie, cform, nroform, txtsubtotal);
            }
            else configuracion.mensaje("Proceso cancelado");
        }

    }
}
