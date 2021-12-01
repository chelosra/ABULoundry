using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using InputKey;

namespace Loundry
{
    class abmproducto
    {
        public static void refresh(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "select Cprod, Productos.Detalle, Pventa, Pventa1, Pventa2, Stmin, Stact, Pcosto, rubros.detalle as Rubro, Productos.Crubro, " +
                               "Productos.xmostrador, Productos.xminorista, Productos.xmayorista " +
                               " from productos " +
                               "Inner join rubros on (rubros.crubro=productos.crubro) " +
                               " order by Productos.detalle";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos = { "crubro" };
            configuracion.dgvocultacolumna(ref dgv, campos);
            string[] campos2 = { "cprod", "detalle", "pventa", "pventa1", "pventa2", "stmin", "stact", "pcosto", "xmostrador", "xminorista", "xmayorista" };
            string[] nombres = { "Código", "Producto", "$ Mostrador", "$ Minorista", "$ Mayorista", "Stock Min", "Stock Actual", "$ Costo", "% Mostrador", "% Minorista", "% Mayorista" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }

        public static void refreshconsulta(ref DataGridView dgv, string lp)
        {
            string kampo = string.Empty;
            switch (lp)
            {
                case "0":
                    kampo = "pventa";
                    break;
                case "1":
                    kampo = "pventa1";
                    break;
                case "2":
                    kampo = "pventa2";
                    break;
                default: kampo = "pventa"; break;
            }
            string consulta = "select Cprod, Productos.Detalle, " + kampo + " as pventa, rubros.detalle as Rubro " +
                              " from productos " +
                              "Inner join rubros on (rubros.crubro=productos.crubro) " +
                              " order by Productos.detalle";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos2 = { "cprod", "detalle", "pventa", "Rubro" };
            string[] nombres = { "Código", "Producto", "$ ", "Categoria" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese producto");
            string consulta = "select * from productos where detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        public static void alta(ref TextBox cprod, ref TextBox detalle, ref TextBox xmostrador, ref TextBox xminorista, ref TextBox xmayorista,
            ref TextBox stact, ref TextBox stmin, ref TextBox pcosto, ref TextBox pventa, ref TextBox pventa1, ref TextBox pventa2,
            ref ComboBox cmbrubro, ref ComboBox cmbcrubro, ref DataGridView dgv)
        {
            dgv.Tag = "0";
            cprod.Text = libreriabase.newreg("Select * from productos where cprod BETWEEN 1 AND 19 "+
                "order by cprod desc limit 1", "Cprod", 20);
            cprod.ReadOnly = true;
            detalle.Text = string.Empty;
            detalle.CharacterCasing = CharacterCasing.Upper;
            libreriabase.cargabox2(ref cmbrubro, "detalle", ref cmbcrubro, "crubro", "rubros", true, "");
            xmostrador.Text = "0";
            xminorista.Text = "0";
            xmayorista.Text = "0";
            stact.Text = "0";
            stmin.Text = "0";
            pcosto.Text = "0";
            pventa.Text = "0";
            pventa1.Text = "0";
            pventa2.Text = "0";

            detalle.Focus();
        }
        public static void modif(ref TextBox cprod, ref TextBox detalle, ref TextBox stmin, ref TextBox stact, ref TextBox pcosto,
                                 ref TextBox pventa, ref TextBox pventa1, ref TextBox pventa2, ref ComboBox cmbrubro, ref ComboBox cmbcrubro,
                                 ref TextBox xmostrador, ref TextBox xminorista, ref TextBox xmayorista, ref DataGridView dgv, string dato)
        {
            dgv.Tag = "1";
            libreriabase.cargabox2(ref cmbrubro, "detalle", ref cmbcrubro, "crubro", "rubros", true, "");
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from productos where cprod='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            cprod.Text = reg["cprod"].ToString(); ;
            detalle.Text = reg["detalle"].ToString();
            stmin.Text = reg["stmin"].ToString();
            stact.Text = reg["stact"].ToString();
            libreria.seleccionaitemcombo(ref cmbcrubro, reg["crubro"].ToString());
            xmostrador.Text = reg["xmostrador"].ToString();
            xminorista.Text = reg["xminorista"].ToString();
            xmayorista.Text = reg["xmayorista"].ToString();
            pcosto.Text = reg["pcosto"].ToString();
            pventa.Text = reg["pventa"].ToString();
            pventa1.Text = reg["pventa1"].ToString();
            pventa2.Text = reg["pventa2"].ToString();
            cmbcrubro.SelectedIndex = cmbrubro.SelectedIndex;
            detalle.CharacterCasing = CharacterCasing.Upper;
        }

        public static void graba(string cprod, string detalle, string stmin, string stact, string pcosto, string pventa, string pventa1, string pventa2,
                                 string crubro, string xmostrador, string xminorista, string xmayorista, ref DataGridView dgv)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into productos ";
                    break;
                case "1":
                    preconsulta = "update productos ";
                    where = " where cprod='" + cprod + "'";
                    break;
            }
            set = "set cprod='" + cprod + "', detalle='" + detalle + "', crubro='" + crubro + "', " +
                  "stmin = '" + stmin + "', stact = '" + stact + "', pcosto='" + pcosto + "', " +
                  "pventa = '" + pventa + "', pventa1 = '" + pventa1 + "', pventa2 = '" + pventa2 + "', " +
                  "xmostrador='" + xmostrador + "', xminorista='" + xminorista + "', xmayorista='" + xmayorista +
                   "'";

            bdcomun.ejecuta(preconsulta + set + where);
          
            conectar.Close();
            configuracion.mensaje("Producto grabado");
            abmproducto.refresh(ref dgv,"");
        }
        public static void borra(string dato, ref DataGridView dgv)
        {
            if (MessageBox.Show("Desea Borrar el Producto?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bdcomun.ejecuta("delete from productos where cprod='" + dato + "'");
                configuracion.mensaje("Producto borrado");
                abmproducto.refresh(ref dgv,"");
            }
            else
            {
                configuracion.mensaje("Proceso cancelado");
            }
        }


    }
}
