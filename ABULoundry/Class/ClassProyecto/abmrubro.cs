using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using InputKey;


namespace Loundry
{
    class abmrubro
    {
        public static void refresh(ref DataGridView dgv)
        {
            string consulta = "select * from rubros order by detalle";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos2 = { "crubro", "detalle","xmostrador","xminorista","xmayorista"};
            string[] nombres = { "Código Rubro", "Rubro","% Venta Mostrador","% Venta Minorista","% Venta Mayorista"};
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
            string[] campos = { "xmostrador", "xminorista", "xmayorista","xdescuento" };
            configuracion.dgvocultacolumna(ref dgv, campos);
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese rubro");
            string consulta = "select * from rubros where detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void alta(ref TextBox crubro, ref TextBox detalle, ref TextBox xdescuento, ref TextBox xmostrador, 
                                ref TextBox xminorista, ref TextBox xmayorista, ref DataGridView dgv)
        {
            dgv.Tag = "0";
            crubro.Text = libreriabase.newreg("Select * from rubros where crubro<>'9999' order by crubro desc limit 1", "Crubro", 4);
            crubro.ReadOnly = true;
            detalle.Text = string.Empty;
            xdescuento.Text = "0";
            xmostrador.Text = "0";
            xminorista.Text = "0";
            xmayorista.Text = "0";
            detalle.Focus();
        }
        public static void modif(ref TextBox crubro, ref TextBox detalle, ref TextBox xdescuento, ref TextBox xmostrador,
                                 ref TextBox xminorista, ref TextBox xmayorista, ref DataGridView dgv, string dato)
        {
            dgv.Tag = "1";
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from rubros where crubro='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            crubro.ReadOnly = true;
            crubro.Text = reg["crubro"].ToString(); ;
            detalle.Text = reg["detalle"].ToString();
            xdescuento.Text = reg["xdescuento"].ToString();
            xmostrador.Text = reg["xmostrador"].ToString();
            xminorista.Text = reg["xminorista"].ToString();
            xmayorista.Text = reg["xmayorista"].ToString();
            detalle.Focus();
        }

        public static void graba(string crubro, string detalle, string xdescuento,string xmostrador, string xminorista, string xmayorista, ref DataGridView dgv)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into rubros ";
                    break;
                case "1":
                    preconsulta = "update rubros ";
                    where=" where crubro='" + crubro + "'";
                    break;
            }
            set = "set crubro = '" + crubro + "', detalle = '" + detalle +
                       "', xdescuento = '" + xdescuento +
                       "', xmostrador='"+ xmostrador+
                       "', xminorista='"+xminorista+
                       "', xmayorista='"+xmayorista+"'";
            bdcomun.ejecuta(preconsulta+set+where);
          
            conectar.Close();
            configuracion.mensaje("Rubro grabado");
            abmrubro.refresh(ref dgv);
        }
        public static void borra(string dato, ref DataGridView dgv)
        {
            if (MessageBox.Show("Desea Borrar el Rubro?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bdcomun.ejecuta("delete from rubros where crubro='" + dato + "'");
                configuracion.mensaje("Rubro borrado");
                abmrubro.refresh(ref dgv);
            }
            else configuracion.mensaje("Proceso cancelado");
        }
    }
}
