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
    class abmcliente
    {
        public static void CF_ingresa()
        {
            string ndni = bdcomun.contenidocampo("Select * from cliente where codigo='0000'","ndni");
            string rsocial = bdcomun.contenidocampo("Select * from cliente where codigo='0000'", "rsocial");
            string domicilio = bdcomun.contenidocampo("Select * from cliente where codigo='0000'", "domicilio");
            ndni = InputDialog.mostrar("Ingrese DNI del cliente (SIN PUNTOS, SOLO NUMEROS)");
            ndni = ndni.Replace(".", "");
            ndni = ndni.Replace(",", "");
            if (ndni.Length > 8)
                ndni = ndni.Substring(0, 8);
            rsocial = InputDialog.mostrar("Ingrese Apellido y nombre");
            domicilio = InputDialog.mostrar("Ingrese Domicilio");
            CF_actualiza(ndni, rsocial, domicilio, false);

        }
        public static void CF_actualiza(string ndni, string rsocial, string domicilio, bool limpia)
        {
            if (limpia)
            {
                ndni = "11111111";
                rsocial = "CONSUMIDOR FINAL";
                domicilio = "XX";
            }

            //lo grabo en base cliente
            string consulta = "update cliente set "+
                              "ndni='" + ndni + "', "+
                              "rsocial='" + rsocial + "', " +
                              "domicilio='" + domicilio + "'" +
                              " where codigo='0000'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Consumidor Final Actualizado");

        }
        public static void refresh(ref DataGridView dgv)
        {
            string consulta = "select * from cliente order by rsocial";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            //string[] campos2 = { "crubro", "detalle", "xmostrador", "xminorista", "xmayorista" };
            //string[] nombres = { "Código Rubro", "Rubro", "% Venta Mostrador", "% Venta Minorista", "% Venta Mayorista" };
            //configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Razón Social");
            string consulta = "select * from cliente where rsocial like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void alta(ref TextBox cliente, ref TextBox rsocial, ref TextBox domicilio, ref TextBox telefono,
                                ref TextBox email, ref ComboBox documento, ref TextBox ncuit, ref TextBox ndni, ref ComboBox iva,
                                ref ComboBox CondIva, ref ComboBox lp, ref DataGridView dgv)
        {
            dgv.Tag = "0";
            libreriabase.cargabox(ref CondIva, "Codigo;Descripcion", "afipcondiva", true);
            libreriabase.cargabox(ref iva, "Descripcion", "afiptiporesponsable", true);
            cliente.Text = libreriabase.newreg("Select * from cliente where codigo<>'0000' order by codigo desc limit 1", "codigo", 4);
            cliente.ReadOnly = true;
            rsocial.Text = string.Empty;
            domicilio.Text = string.Empty;
            telefono.Text = string.Empty;
            email.Text = string.Empty;
            documento.SelectedIndex=2;
            ncuit.Text = string.Empty;
            ndni.Text = string.Empty;
            iva.SelectedIndex = -1;
            CondIva.SelectedIndex =3;
            lp.SelectedIndex = -1;
            rsocial.Focus();
        }
        public static void modif(ref TextBox cliente, ref TextBox rsocial, ref TextBox domicilio, ref TextBox telefono,
                                 ref TextBox email, ref ComboBox documento, ref TextBox ncuit, ref TextBox ndni, ref ComboBox iva,
                                 ref ComboBox CondIva, ref ComboBox lp, ref DataGridView dgv, string dato)
        {
            dgv.Tag = "1";
            libreriabase.cargabox(ref CondIva, "Codigo;Descripcion", "afipcondiva", true);
            libreriabase.cargabox(ref iva, "Descripcion", "afiptiporesponsable", true);

            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from cliente where codigo='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            cliente.ReadOnly = true;
            cliente.Text = reg["codigo"].ToString(); ;
            rsocial.Text = reg["rsocial"].ToString();
            domicilio.Text = reg["domicilio"].ToString();
            telefono.Text = reg["telefono"].ToString();
            email.Text = reg["email"].ToString();
            libreria.seleccionaitemcombo(ref documento, reg["dni"].ToString());
            ncuit.Text = reg["ncuit"].ToString();
            ndni.Text = reg["ndni"].ToString();
            libreria.seleccionaitemcombo(ref iva, reg["iva"].ToString());
            libreria.seleccionaitemcombo(ref CondIva, reg["Condiva"].ToString());
            libreria.seleccionaitemcombo(ref lp, reg["lp"].ToString());
            rsocial.Focus();
        }

        public static void graba(string cliente, string rsocial, string domicilio, string telefono,string email, string documento, 
            string ncuit, string ndni, string iva, string condiva, string lp, ref DataGridView dgv)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into cliente ";
                    break;
                case "1":
                    preconsulta = "update cliente ";
                    where = " where codigo='" + cliente + "'";
                    break;
            }
            set = "set codigo = '" + cliente + "', rsocial = '" + rsocial +
                       "', domicilio = '" + domicilio +
                       "', telefono='" + telefono +
                       "', email='" + email +
                       "', dni='" + documento +
                       "', ncuit='" + ncuit +
                       "', ndni='" + ndni +
                       "', iva='" + iva +
                       "', condiva='"+ condiva+
                       "', lp='" + lp + "'";
            bdcomun.ejecuta(preconsulta + set + where);
           
            conectar.Close();
            configuracion.mensaje("Cliente grabado");
            abmcliente.refresh(ref dgv);
        }
        public static void borra(string dato, ref DataGridView dgv)
        {
            if (MessageBox.Show("Desea Borrar el Cliente?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bdcomun.ejecuta("delete from cliente where codigo='" + dato + "'");
                configuracion.mensaje("Cliente borrado");
                abmcliente.refresh(ref dgv);
            }
            else configuracion.mensaje("Proceso cancelado");
        }
        public static void refreshctacte(ref DataGridView dgv,string dato)
        {
            string consulta = "select ctactecliente.ccliente, ctactecliente.fechform, formularios.detalle, ctactecliente.cform, ctactecliente.nroform, ctactecliente.nrocaja, importe "+
                "from ctactecliente "+
                "inner join formularios on (formularios.cform=ctactecliente.cform ) "+
                "where ccliente='"+dato+"'  order by pk desc";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos = { "ccliente","cform" };
            configuracion.dgvocultacolumna(ref dgv, campos);
            string[] campos2 = { "fechform", "detalle", "nroform", "nrocaja", "importe" };
            string[] nombres = { "Fecha", "Formulario", "Nro. Form", "Nro Caja", "Saldo" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        public static void refreshcheques(ref DataGridView dgv, string cliente, string nrocaja, string cform, string nroform)
        {
            string consulta = "select * " +
                "from cheques " +
 //               "inner join formularios on (formularios.cform=ctactecliente.cform ) " +
                "where ccliente='"+cliente+"' and nrocaja='" + nrocaja + "' and cform='"+cform+"' and nroform='"+nroform+"'  order by pk desc";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos2 = { "fechform", "detalle", "nroform", "nrocaja", "importe" };
            string[] nombres = { "Fecha", "Formulario", "Nro. Form", "Nro Caja", "Saldo" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
    }
}
