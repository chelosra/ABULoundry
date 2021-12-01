using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using InputKey;

namespace Loundry
{
    class abmempleado
    {
        public static void refresh(ref DataGridView dgv)
        {
            string consulta = "select Cempl, Apellido, Nombre, Telefono, Celular, Email, Cargo from empleados order by apellido";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos2 = { "Cargo" };
            configuracion.dgvocultacolumna(ref dgv, campos2);
        }

        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese empleado");
            string consulta = "select * from empleados where apellido like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }

        public static void alta(ref TextBox cempl, ref TextBox apellido, ref TextBox nombre, ref TextBox telefono, 
                                ref TextBox celular, ref TextBox mail, ref TextBox cargo, ref DataGridView dgv)
        {
            dgv.Tag = "0";
            cempl.Text = libreriabase.newreg("Select * from empleados order by cempl desc limit 1", "Cempl", 4);
            cempl.ReadOnly = true;
            apellido.Text = string.Empty;
            nombre.Text = string.Empty;
            telefono.Text = string.Empty;
            celular.Text = string.Empty;
            mail.Text = string.Empty;
            //cargo.Text = string.Empty;
            apellido.Focus();
        }
        public static void modif(ref TextBox cempl, ref TextBox apellido, ref TextBox nombre, ref TextBox telefono, 
                                 ref TextBox celular, ref TextBox mail, ref TextBox cargo, ref DataGridView dgv, string dato)
        {
            dgv.Tag = "1";
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from empleados where cempl='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            cempl.ReadOnly = true;
            cempl.Text = reg["cempl"].ToString(); ;
            apellido.Text = reg["apellido"].ToString();
            nombre.Text = reg["nombre"].ToString();
            telefono.Text = reg["telefono"].ToString();
            cargo.Text = reg["cargo"].ToString();
            celular.Text = reg["celular"].ToString();
            mail.Text = reg["email"].ToString();
            apellido.Focus();
        }

        public static void graba(string cempl, string apellido, string nombre, string telefono, string celular, string email,string cargo, ref DataGridView dgv)
        {
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into empleados ";
                    break;
                case "1":
                    preconsulta = "update empleados ";
                    where = " where cempl='" + cempl + "'";
                    break;
            }
            set = "set cempl='" + cempl + "', apellido='" + apellido + "', nombre='" + nombre + "'" +
                    ", telefono='" + telefono + "', celular='" + celular + "'" +
                    ", email='" + email +  "', cargo='" + cargo +"'";
            bdcomun.ejecuta(preconsulta + set + where);
           
            conectar.Close();
            configuracion.mensaje("Empleado grabado");
            abmproveedor.refresh(ref dgv);
        }
        public static void borra(string dato, ref DataGridView dgv)
        {
            if (dato != "0000" && dato != string.Empty)
            {
                if (MessageBox.Show("Desea Borrar el Empleado?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bdcomun.ejecuta("delete from empleados where cempl='" + dato + "'");
                    configuracion.mensaje("Empleado borrado");
                    abmproveedor.refresh(ref dgv);
                }
                else configuracion.mensaje("Proceso cancelado");
            }
        }
    }
}
