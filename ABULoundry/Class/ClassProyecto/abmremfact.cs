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
    class abmremfact
    {
        public static string hallanro(string cmbcform, string cmbcprov)
        {
            string aux = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from documentoenc where cform='" + cmbcform + "' and cprov='" + cmbcprov + "' order by nroform desc limit 1";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            if (reg.HasRows)
            {
                reg.Read();
                aux = reg["nroform"].ToString();
            }
            else
            {
                aux = "0";
            }
            reg.Close();
          
            conectar.Close();
            Int64 nro = Convert.ToInt64(aux) + 1;
            aux = libreria.rellena(nro.ToString(), 12);
            return aux;
        }
        public static void refresh(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "select a.cprod, p.detalle, cantidad, a.pventa, a.pventa1, a.pventa2, a.pcosto " +
                           "from auxmovimiento as a " +
                           "left join productos as p on (a.cprod=p.cprod) ";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            if (consulta.Contains("select"))
            {
                string[] campos = { "detalle", "pventa", "pventa1", "pventa2", "pcosto" };
                string[] nombres = { "Producto", "$ Mostrador", "$ Minorista", "$ Mayorista", "$ Costo" };
                configuracion.dgvocultacolumna(ref dgv, campos, nombres);
                string[] oculta = { "cprod" };
                configuracion.dgvocultacolumna(ref dgv, oculta);
            }
        }
        public static void buscar(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese producto");
            string consulta = "select a.cprod, productos.detalle, cantidad, a.pventa, a.pcosto " +
                              "from auxmovimiento as a " +
                              "inner join productos as p on (a.cprod=p.cprod) " +
                              "where p.detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void altaitem(ref TextBox cprod, ref TextBox cantidad, ref TextBox pventa, ref TextBox pcosto, ref TextBox pventa1,
                                    ref TextBox pventa2, ref Button btngrabaformulario, ref LabelGradient lbldetprod, ref DataGridView dgv)
        {
            dgv.Tag = 0;
            cprod.Text = string.Empty;
            cantidad.Text = "0";
            pventa.Text = "0";
            pventa1.Text = "0";
            pventa2.Text = "0";
            pcosto.Text = "0";
            lbldetprod.Text = "...";
            cprod.ReadOnly = false;
            cprod.Focus();
            btngrabaformulario.Visible = false;
        }
        public static void modiitem(ref TextBox cprod, ref TextBox cantidad, ref TextBox pventa, ref TextBox pcosto, ref TextBox pventa1,
                                    ref TextBox pventa2, string dato, ref Button btngrabaformulario, ref DataGridView dgv)
        {
            dgv.Tag = 1;
            MySqlConnection conectar = bdcomun.Conexion();
            string consulta = "select * from auxmovimiento where cprod='" + dato + "'";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            reg.Read();
            cprod.ReadOnly = true;
            cprod.Text = reg["cprod"].ToString();
            cantidad.Text = reg["cantidad"].ToString(); ;
            pventa.Text = reg["pventa"].ToString();
            pventa1.Text = reg["pventa1"].ToString();
            pventa2.Text = reg["pventa2"].ToString();
            pcosto.Text = reg["pcosto"].ToString();
            cantidad.Focus();
            btngrabaformulario.Visible = false;
        }
        public static void grabaitem(string fechform, string cform, string nroform, string cprov, string cprod, string cantidad, string pventa, string pcosto,
                                     string pventa1, string pventa2, ref DataGridView dgv)
        {
            string crubro = bdcomun.contenidocampo("select * from productos where cprod='" + cprod + "'", "crubro");
            string preconsulta = string.Empty;
            string set = string.Empty;
            string where = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            switch (dgv.Tag.ToString())
            {
                case "0":
                    preconsulta = "insert into auxmovimiento ";
                    break;
                case "1":
                    preconsulta = "update auxmovimiento ";
                     where="where cprod='" + cprod + "'";
                    break;
            }
            set = " set cprod='"+cprod+
                    "', fechform='" + fechform +
                    "', cform='" + cform +
                    "', nroform='" + nroform +
                    "', cprov='" + cprov +
                    "', cantidad='" + libreria.decimalastringconpunto(Convert.ToDecimal(cantidad)) +
                    "', pventa='" + pventa +
                    "', pcosto='" + pcosto +
                    "', pventa1='" + pventa1 +
                    "', pventa2='" + pventa2+
                    "', crubro='" + crubro +
                    "' ";
            bdcomun.ejecuta(preconsulta+set+where);
      
            conectar.Close();
            configuracion.mensaje("Item grabado");
            abmremfact.refresh(ref dgv, "");
        }
        public static void borraitem(string dato, ref DataGridView dgv)
        {
            if (MessageBox.Show("Desea Borrar el Item?", configuracion.titulomensaje(), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                bdcomun.ejecuta("delete from auxmovimiento where cprod='" + dato + "'");
                configuracion.mensaje("Item borrado");
                abmremfact.refresh(ref dgv, "");
            }
            else configuracion.mensaje("Proceso cancelado");
        }

        public static void grabaencabezado(string fechform, string cform, string nroform, string cprov, string importe, ref DataGridView dgv)
        {
            string consulta = string.Empty;
            consulta = "insert into documentoenc (fechform,cform,nroform,cprov,importe) " +
            "values ('" + fechform +
                    "','" + cform +
                    "','" + nroform +
                    "','" + cprov +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(importe)) +
                    "')";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Encabezado grabado");
            abmremfact.refresh(ref dgv, "");
        }
        public static string actualizapreciostock(MySqlDataReader regm, MySqlDataReader regp, ref ComboBox cmbio)
        {
            string consulta = string.Empty;
            decimal pventanuevo = 0, stocknuevo = 0, pcostonuevo=0;
            #region pventa
            if (regm["pcosto"].ToString() != "0")
            {
                pcostonuevo = Convert.ToDecimal(regm["pcosto"].ToString());
                consulta = "update productos set pcosto='" + libreria.decimalastringconpunto(pcostonuevo) + "' " +
                           "where cprod='" + regm["cprod"].ToString() + " '";
                bdcomun.ejecuta(consulta);
            }
            if (regm["pventa"].ToString() != "0")
            {
                pventanuevo = Convert.ToDecimal(regm["pventa"].ToString());
                consulta = "update productos set pventa='" + libreria.decimalastringconpunto(pventanuevo) + "' " +
                           "where cprod='" + regm["cprod"].ToString() + " '";
                bdcomun.ejecuta(consulta);
            }
            if (regm["pventa1"].ToString() != "0")
            {
                pventanuevo = Convert.ToDecimal(regm["pventa1"].ToString());
                consulta = "update productos set pventa1='" + libreria.decimalastringconpunto(pventanuevo) + "' " +
                           "where cprod='" + regm["cprod"].ToString() + " '";
                bdcomun.ejecuta(consulta);
            }
            if (regm["pventa2"].ToString() != "0")
            {
                pventanuevo = Convert.ToDecimal(regm["pventa2"].ToString());
                consulta = "update productos set pventa2='" + libreria.decimalastringconpunto(pventanuevo) + "' " +
                           "where cprod='" + regm["cprod"].ToString() + " '";
                bdcomun.ejecuta(consulta);
            }
            #endregion

            if (cmbio.Text == "ENTRADA")
            {
                stocknuevo = Convert.ToDecimal(regp["stact"].ToString()) + Convert.ToDecimal(regm["cantidad"].ToString());
            }
            if (cmbio.Text == "SALIDA")
            {
                stocknuevo = Convert.ToDecimal(regp["stact"].ToString()) - Convert.ToDecimal(regm["cantidad"].ToString());
            }
            if (cmbio.Text == "INVENTARIO")
            {
                stocknuevo = Convert.ToDecimal(regm["cantidad"].ToString());
            }
            consulta = "update productos set stact='" + libreria.decimalastringconpunto(stocknuevo) + "' " +
                              "where cprod='" + regm["cprod"].ToString() + " '";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Producto Actualizado");

            return stocknuevo.ToString();
        }
        public static void grabodocumento(string fechform, string cform, string nroform, MySqlDataReader regm, string stock)
        {
            string consulta = string.Empty;
            consulta = "insert into documento (fechform,cform,nroform,cprod,pventa,cantidad,cprov,pcosto,stock,pventa1,pventa2) " +
            "values ('" + fechform +
                    "','" + cform +
                    "','" + nroform +
                    "','" + regm["cprod"].ToString() +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pventa"].ToString())) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["cantidad"].ToString())) +
                    "','" + regm["cprov"].ToString() +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pcosto"].ToString())) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(stock)) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pventa1"].ToString())) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pventa2"].ToString())) +
                    "')";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Documento grabado");
        }
        public static void grabomovimiento(string fechform, string cform, string nroform, MySqlDataReader regm, string stock)
        {
            string consulta = string.Empty;
            consulta = "insert into movimiento (fechform,cform,nroform,cprod,pventa,cantidad,cprov,pcosto,stock,crubro,pventa1,pventa2) " +
            "values ('" + fechform +
                    "','" + cform +
                    "','" + nroform +
                    "','" + regm["cprod"].ToString() +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pventa"].ToString())) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["cantidad"].ToString())) +
                    "','" + regm["cprov"].ToString() +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pcosto"].ToString())) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(stock)) +
                    "','" + regm["crubro"].ToString() +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pventa1"].ToString())) +
                    "','" + libreria.decimalastringconpunto(Convert.ToDecimal(regm["pventa2"].ToString())) +
                    "')";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Movimiento grabado");
        }
        public static void cprodexit(ref TextBox txtcprod, ref LabelGradient lbldetprod, ref Label lblstock, ref TextBox txtpventa,
                                     ref TextBox txtpventa1, ref TextBox txtpventa2)
        {
            if (txtcprod.Text != string.Empty)
            {
                txtcprod.Text = libreria.rellena(txtcprod.Text, 20);
                MySqlConnection conectar = bdcomun.Conexion();
                MySqlDataReader reg = bdcomun.leereg("Select cprod, detalle, stact, pventa, pventa1, pventa2 from productos where cprod='" + txtcprod.Text + "'", conectar);
                if (reg.HasRows)
                {
                    reg.Read();
                    lbldetprod.Text = reg["detalle"].ToString();
                    lblstock.Text = reg["stact"].ToString();
                    txtpventa.Text = reg["pventa"].ToString();
                    txtpventa1.Text = reg["pventa1"].ToString();
                    txtpventa2.Text = reg["pventa2"].ToString();
                }
                else
                {
                    txtcprod.Text = string.Empty;
                    lbldetprod.Text = "...";
                    lblstock.Text = "...";
                    txtpventa.Text = "0";
                    txtpventa1.Text = "0";
                    txtpventa2.Text = "0";
                    configuracion.mensaje("El producto no existe");
                }
                reg.Close();
             
                conectar.Close();
            }
        }
        public static void cprodinexit(ref TextBox txtcprod)
        {
            txtcprod.Text = txtcprod.Text.Substring(0, 6);
            txtcprod.Text = libreria.rellena(txtcprod.Text, 6);
            if (txtcprod.Text.Substring(0, 1) == "0")
            {
                txtcprod.Text = txtcprod.Text.Substring(1, 5);
                txtcprod.Text = libreria.rellena(txtcprod.Text, 5);
                txtcprod.Text = "2" + txtcprod.Text;
            }
        }
        //

        public static void refreshprod(ref DataGridView dgv)
        {
            string consulta = "select Cprod, Productos.Detalle, Stmin, Stact, Pcosto, Pventa, Pventa1, Pventa2, rubros.detalle as Rubro, Productos.Crubro " +
                              " from productos " +
                              "Inner join rubros on (rubros.crubro=productos.crubro) " +
                              " order by Productos.detalle";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        public static void buscarprod(ref DataGridView dgv)
        {
            string dato = InputDialog.mostrar("Ingrese producto");
            string consulta = "select * from productos where detalle like '%" + dato + "%'";
            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
        }
        //

        public static void refreshtab2(ref DataGridView dgv, string consulta)
        {
            if (consulta == string.Empty)
                consulta = "select DATE_FORMAT(d.fechform,'%d/%m/%Y') as fechform , d.cform, f.detalle,d.nroform, d.cprov, p.rsocial, d.importe " +
                              "from documentoenc as d " +
                              "left join proveedores as p on (d.cprov=p.cprov) " +
                              "inner join formularios as f on (f.cform=d.cform) " +
                              "order by pk desc";

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            string[] campos = { "cprov"};
            configuracion.dgvocultacolumna(ref dgv, campos);
            string[]campos2 = { "fechform", "cform", "detalle", "nroform", "rsocial", "importe" };
            string[] nombres = { "Fecha", "Código Form", "Formulario", "Nro", "Proveedor", "Importe" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);

        }
        public static void buscaitems(ref DataGridView dgv, string cprov, string cform, string nroform)
        {
            string consulta = "select p.detalle, d.cantidad, d.stock, d.pcosto, d.pventa, d.pventa1, d.pventa2 " +
                              "from documento as d " +
                              "left join productos as p on (d.cprod=p.cprod) " +
                              "where d.cprov='" + cprov + "' and cform='" + cform + "' and nroform='" + nroform + "' " +
                              "order by p.detalle desc";
            //            "where DATE_FORMAT(d.fechform,'%Y-%m-%d')='" + fechform + "' and cform='" + cform + "' and nroform='" + nroform + "' " +

            bdcomun.dgv(dgv, consulta, "");
            libreria.alternacolorfila(ref dgv);
            
            string[] campos2 = { "detalle", "pcosto", "pventa", "pventa1", "pventa2" };
            string[] nombres = { "Producto", "$ Costo", "$ Mostrador", "$ Minorista", "$ Mayorista" };
            configuracion.dgvocultacolumna(ref dgv, campos2, nombres);
        }

    }
}
