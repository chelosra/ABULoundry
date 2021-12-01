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
    class abmcaja
    {
        public static void buscarproveedor(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese Razón Social");
            string consulta = "select * from proveedores where rsocial like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void refresh(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "Select * " +
                           "from Caja " +
                           "order by nrocaja desc ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void refreshcaja(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "Select * " +
                           "from Caja " +
                           "order by nrocaja desc ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos = { "ccajero"};
            configuracion.dgvocultacolumna(ref dgv, campos);
            string[] campos2 = { "nrocaja", "fechini", "horaini", "plataini","fechcie", "horacie", "platacie" };
            string[] nombres = { "Caja", "Fecha Inicio", "Hora Inicio", "$ apertura", "Fecha Cierre", "Hora Cierre","$ Cierre" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }
        public static void alta(ref TextBox nrocaja, ref ComboBox cmbempl, ref ComboBox cmbcempl, ref TextBox plataini, 
                                ref TextBox platacie, ref GroupBox grpiniciocaja, ref GroupBox grpcierracaja)
        {
            MySqlConnection conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from caja order by nrocaja desc limit 1", conectar);
            if (reg.HasRows) {
                reg.Read();
                if (reg["fechcie"].ToString()==string.Empty)
                    nrocaja.Text = reg["nrocaja"].ToString();
                else
                    nrocaja.Text = libreriabase.newreg("Select * from caja order by nrocaja desc limit 1", "nrocaja",4);
            }else
            {
                nrocaja.Text = libreriabase.newreg("Select * from caja order by nrocaja desc limit 1", "nrocaja", 4);
            }
            reg.Close();

            nrocaja.ReadOnly = true;
            libreriabase.cargabox2filtrada(ref cmbempl, "apellido", ref cmbcempl, "cempl", "empleados", "Cargo", "CAJERO");
            reg = bdcomun.leereg("Select * from caja order by nrocaja desc limit 1", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                if (reg["fechcie"].ToString() != string.Empty)
                {
                    plataini.Text = reg["platacie"].ToString();
                    if (plataini.Text == string.Empty)
                        plataini.Text = "0";
                    grpiniciocaja.Enabled = true;
                    grpcierracaja.Enabled = false;
                    cmbempl.Focus();
                }
                else
                {
                    cmbcempl.Text = reg["ccajero"].ToString().Trim();
                    plataini.Text = reg["plataini"].ToString();
                    grpiniciocaja.Enabled = false;
                    grpcierracaja.Enabled = true;
                }
            }
            reg.Close();
            platacie.Text= abmcaja.cuantotienelacaja(nrocaja.Text);
        }

        public static string cuantotienelacaja(string caja)
        {
            decimal ingreso = 0, egreso = 0, venta = 0, total = 0, plataini = 0;
            MySqlConnection conectar = bdcomun.Conexion();
            #region detallecaja
            MySqlDataReader reg = bdcomun.leereg("Select sum(plata) as plata from detcaja where nrocaja ='"+caja+"' and operacion='INGRESO'", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                ingreso = libreria.stringadecimalconpunto(reg["plata"].ToString());
            }
            reg.Close();
            reg = bdcomun.leereg("Select sum(plata) as plata from detcaja where nrocaja ='" + caja + "' and operacion<>'INGRESO'", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                egreso = libreria.stringadecimalconpunto(reg["plata"].ToString());
            }
            reg.Close();
            #endregion
            #region factfinal
            reg = bdcomun.leereg("select sum(total) as total from factfinal where cform<>'00R0' and cform <> '0CCT' and nrocaja='"+caja+"'", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                venta = libreria.stringadecimalconpunto(reg["total"].ToString());
            }
            reg.Close();
            #endregion
            total = ingreso - egreso + venta;
            //sumar plataincial
            #region plata inicial
            reg = bdcomun.leereg("select plataini from caja where nrocaja='"+caja+"' ", conectar);
            if (reg.HasRows)
            {
                reg.Read();
                plataini = libreria.stringadecimalconpunto(reg["plataini"].ToString());
            }
            reg.Close();
            #endregion
         
            conectar.Close();
            total = total + plataini;
            return libreria.decimalastringconpunto(total);
        }
        public static void nolousoaperturacierre(ref ComboBox cempl, ref TextBox txtplataini, ref TextBox txtplatacie)
        {
            MySqlConnection conectar = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("Select * from caja order by nrocaja desc limit 1", conectar);
            if (reg.HasRows)
            {
                if (reg["fechini"].ToString() != string.Empty & reg["fechcie"].ToString() == string.Empty)
                {
                    cempl.Text = reg["ccajero"].ToString();
                    txtplataini.Text = reg["plataini"].ToString();
                    txtplatacie.Text = reg["platacie"].ToString();
                }
                else
                {
                    //estoy en apertura de caja
                    txtplataini.Text = reg["platacie"].ToString();
                    if (txtplataini.Text == string.Empty)
                        txtplataini.Text = "0";
                    txtplatacie.Text = txtplataini.Text;
                }
            }
            reg.Close();
         
            conectar.Close();
        }
        public static void refreshdetcaja(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "Select * " +
                           "from detCaja " +
                           "order by nrocaja desc ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos = { "empleado", "ccliente", "cprov", "pk" };
            configuracion.dgvocultacolumna(ref dgv, campos);
        }

        public static void abmdetcaja(ref ComboBox cmboperacion,ref TextBox txtcprov,ref TextBox txtccliente, ref TextBox txtdinero, 
                                      ref TextBox txtdetalle, ref TextBox txtxnrocaja, string nrocaja, ref TextBox txtcheque)
        {
            cmboperacion.SelectedIndex = -1;
            txtcprov.Text = string.Empty;
            txtccliente.Text = string.Empty;
            txtdinero.Text = "0";
            txtcheque.Text = "0";
            txtdetalle.Text = string.Empty;
            txtxnrocaja.Text = nrocaja;
        }

        public static void grabadetcaja(ref TextBox txtdinero, ref TextBox txtcheque, ref ComboBox cmboperacion, ref TextBox txtxnrocaja, ref TextBox txtdetalle, ref TextBox txtcprov,
            ref TextBox txtcliente)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("H:mm:ss");
            string plata;
            if (txtcheque.Text=="0" || txtcheque.Text==string.Empty)
                plata = libreria.decimalastringconpunto(Convert.ToDecimal(txtdinero.Text));
            else
                plata = libreria.decimalastringconpunto(Convert.ToDecimal(txtcheque.Text));
            if (cmboperacion.Text != string.Empty)
            {
                string consulta = "insert into detcaja (nrocaja, fecha, hora, detalle, plata, operacion,cprov,ccliente ) values " +
                                 "('" + txtxnrocaja.Text +
                                 "','" + fecha +
                                 "','" + hora +
                                 "','" + txtdetalle.Text +
                                 "','" + plata +
                                 "','" + cmboperacion.Text +
                                 "','" + txtcprov.Text +
                                 "','" + txtcliente.Text +
                                 "')";
                bdcomun.ejecuta(consulta);
                //actualizar platacie
            }
        }
        public static void refreshfacturacion(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "Select * " +
                           "from detCaja " +
                           "order by nrocaja desc ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            //string[] campos = { "cfpago2","cautorizacion","cempl","pk","ccliente","nrocaja","Cfpago","Cfpago1" };
            //configuracion.dgvocultacolumna(ref dgv, campos);
            string[] campos2 = {  "detalle",      "nroform", "total"      ,"pago"    ,"pago1"      ,"pago2"  };
            string[] nombres = {  "Formulario", "Nro"    , "$ facturado","Efectivo","Cheq/CtaCte","Saldo Ant"};
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }

        public static void refreshitemsfacturacion(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "Select * " +
                           "from detCaja " +
                           "order by nrocaja desc ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);

        }

    }
}
