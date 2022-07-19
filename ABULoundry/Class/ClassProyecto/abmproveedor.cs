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
    class abmproveedor
    {
        public static void refresh(ref DataGridView dgv)
        {
            string consulta = "select * from proveedores order by Rsocial";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos2 = { "crubro"};
            configuracion.dgvocultacolumna(ref dgv, campos2);
        }

        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese proveedor");
            string consulta = "select * from proveedores where rsocial like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        public static void alta(ref TextBox cprov, ref TextBox rsocial, ref TextBox contacto, ref TextBox telefono, ref TextBox fax,
                                ref TextBox celular, ref TextBox mail, ref DataGridView dgv)
        {
            dgv.Tag = "0";
            cprov.Text = libreriabase.newreg("Select * from proveedores where cprov<>'9999' order by cprov desc limit 1", "Cprov", 4);
            cprov.ReadOnly = true;
            rsocial.Text = string.Empty;
            contacto.Text = string.Empty;
            telefono.Text = string.Empty;
            fax.Text = string.Empty;
            celular.Text = string.Empty;
            mail.Text = string.Empty;
            rsocial.Focus();
        }
        public static void modif(ref TextBox cprov, ref TextBox rsocial, ref TextBox contacto, ref TextBox telefono, ref TextBox fax,
                                 ref TextBox celular, ref TextBox mail, ref DataGridView dgv, string dato)
        {
            dgv.Tag = "1";
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from proveedores where cprov='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            cprov.ReadOnly = true;
            cprov.Text = reg["cprov"].ToString(); ;
            rsocial.Text = reg["rsocial"].ToString();
            contacto.Text = reg["contacto"].ToString();
            telefono.Text = reg["telefono"].ToString();
            fax.Text = reg["fax"].ToString();
            celular.Text = reg["celular"].ToString();
            mail.Text = reg["email"].ToString();
            rsocial.Focus();
        }

        public static void graba(string cprov, string rsocial, string contacto, string telefono, string fax, string celular, string email, ref DataGridView dgv)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into proveedores ";
                    break;
                case "1":
                    preconsulta = "update proveedores ";
                    where = " where cprov='" + cprov + "'";
                    break;
            }
            set = "set cprov='" + cprov + "', rsocial='" + rsocial + "', contacto='" + contacto + "'" +
                    ", telefono='" + telefono + "', fax='" + fax + "', celular='" + celular + "'" +
                    ", email='" + email + "'";
            bdcomun.ejecuta(preconsulta + set + where);
           
            conectar.Close();
            configuracion.mensaje("Proveedor grabado");
            abmproveedor.refresh(ref dgv);
        }
        public static void borra(string dato, ref DataGridView dgv)
        {
            if (dato != "0000" && dato!=string.Empty)
            {
                if (MessageBox.Show("Desea Borrar el Proovedor?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bdcomun.ejecuta("delete from proveedores where cprov='" + dato + "'");
                    configuracion.mensaje("Proveedor borrado");
                    abmproveedor.refresh(ref dgv);
                }
                else configuracion.mensaje("Proceso cancelado");
            }
        }
    }

}

