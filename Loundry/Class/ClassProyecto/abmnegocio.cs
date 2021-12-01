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
    class abmnegocio
    {
        public static void refresh(ref DataGridView dgv)
        {
            string consulta = "select * from negocio order by rsocial";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            //string[] campos2 = { "crubro", "detalle", "xmostrador", "xminorista", "xmayorista" };
            //string[] nombres = { "Código Rubro", "Rubro", "% Venta Mostrador", "% Venta Minorista", "% Venta Mayorista" };
            //configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Razón Social");
            string consulta = "select * from negocio where razonsocial like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void alta(ref TextBox codigo, ref TextBox propietario, ref TextBox rsocial, ref TextBox domicilio, ref TextBox telefono,
                                ref ComboBox documento, ref TextBox nrodoc, ref ComboBox iva, ref TextBox nib, ref DataGridView dgv)
        {
            dgv.Tag = "0";
            codigo.Text = libreriabase.newreg("Select * from negocio where codigo<>'0000' order by codigo desc limit 1", "codigo", 4);
            codigo.ReadOnly = true;
            propietario.Text = string.Empty;
            rsocial.Text = string.Empty;
            domicilio.Text = string.Empty;
            telefono.Text = string.Empty;
            documento.SelectedIndex = -1;
            nrodoc.Text = string.Empty;
            iva.SelectedIndex = -1;
            nib.Text=string.Empty;
            rsocial.Focus();
        }
        public static void modif(ref TextBox codigo,ref TextBox propietario, ref TextBox rsocial, ref TextBox domicilio, ref TextBox telefono,
                                 ref ComboBox documento, ref TextBox nrodoc, ref ComboBox iva, ref TextBox nib, ref DataGridView dgv, string dato)
        {
            dgv.Tag = "1";
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from negocio where codigo='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            codigo.ReadOnly = true;
            codigo.Text = reg["codigo"].ToString();
            propietario.Text = reg["propietario"].ToString();
            rsocial.Text = reg["rsocial"].ToString();
            domicilio.Text = reg["direccion"].ToString();
            telefono.Text = reg["telefono"].ToString();
            libreria.seleccionaitemcombo(ref documento, reg["documento"].ToString());
            nrodoc.Text = reg["nrodoc"].ToString();
            libreria.seleccionaitemcombo(ref iva, reg["iva"].ToString());
            nib.Text = reg["ib"].ToString();
            propietario.Focus();
        }

        public static void graba(string codigo,string propietario, string rsocial, string domicilio, string telefono, string documento, string nrodoc,
                                 string iva, string nib, ref DataGridView dgv)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into negocio ";
                    break;
                case "1":
                    preconsulta = "update negocio ";
                    where = " where codigo='" + codigo + "'";
                    break;
            }
            set = "set codigo = '" + codigo + "', propietario = '" + propietario +
                       "', rsocial = '" + rsocial +
                       "', direccion = '" + domicilio +
                       "', telefono='" + telefono +
                       "', documento='" + documento +
                       "', nrodoc='" + nrodoc +
                       "', iva='" + iva +
                       "', ib='" + nib + "'";
            bdcomun.ejecuta(preconsulta + set + where);
          
            conectar.Close();
            configuracion.mensaje("Cliente grabado");
            abmnegocio.refresh(ref dgv);
        }
        public static void borra(string dato, ref DataGridView dgv)
        {
            if (MessageBox.Show("Desea Borrar el Negocio?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bdcomun.ejecuta("delete from Negocio where codigo='" + dato + "'");
                configuracion.mensaje("Negocio borrado");
                abmcliente.refresh(ref dgv);
            }
            else configuracion.mensaje("Proceso cancelado");
        }
    }
}
