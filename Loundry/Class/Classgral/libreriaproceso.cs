using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loundry
{
    class libreriaproceso
    {
        public static void memoadd(RichTextBox richText, string line)
        {
            richText.Text += line + '\n';
        }

        /// <summary>
        /// carga un richtextbox con el encabezado de la factura desde la tabla negocio
        /// </summary>
        /// <param name="memo"></param>
        public static void funencabezado(ref RichTextBox memo)
        {
            // F0x normal
            // F1x resaltado
            // F2x doble alto
            // F4x doble ancho
            // F8x subrayado
            //buscar datos de negocio
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from negocio", cnn);
            if (reg.HasRows)
            {
                reg.Read();
                memoadd(memo, "@PONEENCABEZADO|1|[F4x; " + reg["rsocial"].ToString().Trim() + " [F0x;");
                //memoadd(memo,"@PONEENCABEZADO|2|");
                //memoadd(memo,"@PONEENCABEZADO|3|");
                //memoadd(memo,"@PONEENCABEZADO|3|" + reg["propietario"].ToString().Trim());
                memoadd(memo, "@PONEENCABEZADO|4|" + reg["direccion"].ToString().Trim());
                //memoadd(memo, "@PONEENCABEZADO|5|" + reg["Localidad"].ToString().Trim());
                //memoadd(memo, "@PONEENCABEZADO|6| CP: " + reg["Cp"].ToString().Trim());
                memoadd(memo, "@PONEENCABEZADO|7| Tel: " + reg["Telefono"].ToString().Trim());
                //memoadd(memo,"@PONEENCABEZADO|8|[F1x; www.cocheriarodriguez.com.ar"+" [F0x" );
                memoadd(memo, "@PONEENCABEZADO|9|" + reg["documento"].ToString().Trim() + " " + reg["nrodoc"].ToString().Trim());
                memoadd(memo, "@PONEENCABEZADO|10|" + reg["Ib"].ToString().Trim());
                memoadd(memo, "@PONEENCABEZADO|11| Dirección Cliente: ");

            }
            reg.Close();
         
            cnn.Close();
        }

        /// <summary>
        /// busca el ultimo nro del cform correspondiente en la tabla factfinal
        /// </summary>
        /// <param name="nroform"></param>
        /// <param name="cform"></param>
        /// <returns></returns>
        public static string buscanroform(ref TextBox nroform, string cpventa)
        {
            string cform = bdcomun.ejecuta("select * from auxmovimiento3 where cpventa='" + cpventa + "'", "cform");
            nroform.Text = "0";
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from factfinal where cform='" + cform + "' order by nroform desc", cnn);
            if (reg.HasRows)
            {
                reg.Read();
                nroform.Text = reg["nroform"].ToString().Trim();
            }
            reg.Close();
         
            cnn.Close();
            Int32 nro=0;
            if (nroform.Text == "0")
                nro = Convert.ToInt32(nroform.Text);
            else
            {
                string sufijo = nroform.Text.Substring(5, 8);
                nro = Convert.ToInt32(sufijo);
            }
            nro++;
            nroform.Text = Convert.ToString(nro);
            nroform.Text = libreria.rellena(Properties.Settings.Default.afipptoventa.ToString(), 4) + "-" +
                           libreria.rellena(nroform.Text, 8);
            return nroform.Text;
        }
        /// <summary>
        /// Halla el total de la comanda consultando auxmovimiento3 x cpventa 
        /// </summary>
        /// <param name="cmbcpventa"></param>
        /// <returns></returns>

        public static string total(ComboBox cmbcpventa)
        {
            string total = "0";
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("SELECT sum(Pventa*Cantidad) as total FROM auxmovimiento3 where cpventa = '" + cmbcpventa.Text + "'", cnn);
            if (reg.HasRows)
            {
                reg.Read();
                total = reg["total"].ToString().Trim();
            }
            reg.Close();
         
            cnn.Close();
            return total;
        }

        /// <summary>
        /// graba un movimiento por item de la factura
        /// </summary>
        /// <param name="reg">registro de auxmovimiento3</param>
        /// <param name="nroform">nro de form obtenido en factfinal</param>
        /// <param name="ctacte">bool si el movimiento se registra con cform ctacte</param>
        public static void grabamovimiento(MySqlDataReader reg, string nroform, bool ctacte)
        {
            string cform = "0CCT"; //ctacte
            if (!ctacte)
                cform = reg["cform"].ToString();

            string xfecha = libreria.fechaamysql(reg["fechform"].ToString());
            string stock = bdcomun.contenidocampo("select * from productos where cprod='" + reg["cprod"].ToString() + "'", "stact");
            string consulta = "insert into movimiento set " +
                              "cform='" + cform +
                              "',fechform='" + xfecha +
                              "',nroform='" + nroform +
                              "',cprod='" + reg["cprod"].ToString() +
                              "',pventa='" + reg["pventa"].ToString() +
                              "',cantidad='" + reg["cantidad"].ToString() +
                              "',cprov='" + reg["cprov"].ToString() +
                              "',hora='" + reg["hora"].ToString() +
                              "',cpventa='" + reg["cpventa"].ToString() +
                              "',cempl='" + reg["cempl"].ToString() +
                              "',nrocaja='" + reg["nrocaja"].ToString() +
                              "',crubro='" + reg["crubro"].ToString() +
                              "',cliente='" + reg["cliente"].ToString() +
                              "',stock='" + stock +
                              "',comentario='" + reg["comentario"].ToString() +
                              "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Movimiento grabado");
        }
        /// <summary>
        /// Actualiza el stock en productos en base a auxmovimiento3
        /// </summary>
        /// <param name="cprod"></param>
        public static void actualizastock(MySqlDataReader reg)
        {
            string cprod = reg["cprod"].ToString();
            string cantidad = reg["cantidad"].ToString();
            string stact = bdcomun.ejecuta("select * from productos where cprod='" + cprod + "'", "stact");
            decimal stnuevo = Convert.ToDecimal(stact) - Convert.ToDecimal(cantidad);
            stact = libreria.decimalastringconpunto(stnuevo);
            string consulta = "update productos set stact='" + stact + "' where cprod='" + cprod + "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Stock actualizado");
        }

        /// <summary>
        /// Graba la facturacion final
        /// </summary>
        /// <param name="reg"></param>
        /// <param name="itka"></param>
        /// <param name="nroform"></param>
        /// <param name="txtpago"></param>
        /// <param name="cmbcfpago1"></param>
        /// <param name="txtpago1"></param>
        /// <param name="cmbcfpago2"></param>
        /// <param name="totalfactura"></param>
        public static void grabafacturacionfinal(MySqlDataReader reg, Button itka, string nroform, string txtpago, string cmbcfpago1,
                           string txtpago1, string cmbcfpago2, decimal totalfactura, TextBox txtxdto, TextBox txtsaldocliente)
        {
            string cform = "0TK0";
            string neto = "0";
            string iva = "0";
            decimal dtxtpago = libreria.stringadecimalconpunto(txtpago);
            decimal dtxtpago1 = libreria.stringadecimalconpunto(txtpago1);
            switch (itka.Tag.ToString())
            {
                case "1":
                    cform = "0TK1";
                    //neto = totalfactura - (totalfactura * decimal.Parse("0.21"));
                    //iva = totalfactura * decimal.Parse("0.21");
                    neto = libreria.incrementaporc(Convert.ToString(totalfactura), 21, "-");
                    iva = libreria.porcentaje(Convert.ToString(totalfactura), 21);
                    break;
                case "0":
                    cform = "0TK0";
                    break;
            }

            string xfecha = libreria.fechaamysql(reg["fechform"].ToString());
            string consulta = "insert into factfinal set " +
                "nrocaja='" + reg["nrocaja"].ToString() +
                "', fechform='" + xfecha +
                "', horaform='" + reg["hora"].ToString() +
                "', cform='" + cform +
                "', nroform='" + nroform +
                "', pago='" + dtxtpago +
                "', cfpago='" + cmbcfpago1 +
                "', pago1='" + dtxtpago1 +
                "', cfpago1='" + cmbcfpago2 +
                "', pago2='" + txtsaldocliente.Text +
                "', cfpago2='" + "CTTE" +
                "', neto='" + neto +
                "', iva='" + iva +
                "', total='" + totalfactura +
                "', ccliente='" + reg["cliente"].ToString() +
                "', cempl='" + reg["cempl"].ToString() +
                "', xdto='" + txtxdto.Text +
                "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Facturación actualizada");
        }

        public static void grabactacte(string ccliente, Button itka, string nroform, string diferencia, string desdedonde)
        {
            string cform = "";
            if (desdedonde == "PROCESO")
            {
                switch (itka.Tag.ToString())
                {
                    case "1":
                        cform = "0TK1";
                        //neto = totalfactura - (totalfactura * decimal.Parse("0.21"));
                        //iva = totalfactura * decimal.Parse("0.21");
                        break;
                    case "0":
                        cform = "0TK0";
                        break;
                }
            }
            else
            {
                cform = "KJAN";
            }

            string xfecha = libreria.fechaamysql(DateTime.Now.ToString());
            string nrocaja = bdcomun.contenidocampo("select * from caja order by nrocaja desc limit 1", "nrocaja");
            string consulta = "insert into ctactecliente set " +
                "ccliente='" + ccliente +
                "', fechform='" + xfecha +
                "', cform='" + cform +
                "', nroform='" + nroform +
                "', nrocaja='" + nrocaja +
                "', importe='" + diferencia +
                "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Cta Cte actualizada");
        }
        ///
        public static void procitk(TextBox nroform, RichTextBox memo, Label lbliva, TextBox ccliente, ComboBox cmbcpventa,
                                   Button btnitka, TextBox txtpago, ComboBox cmbcfpago1, TextBox txtpago1, ComboBox cmbcfpago2,
                                   TextBox txtsubtotal, TextBox txtxdto, TextBox txtsaldocliente)
        {
            procfunencabezado();
            string nro = nroform.Text;
            memoadd(memo, librefiscal.factabre(lbliva, ccliente));

            decimal totalfactura = 0;
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("SELECT * FROM auxmovimiento3 where cpventa = '" + cmbcpventa.Text + "'", cnn);
            if (reg.HasRows)
            {
                while (reg.Read())
                {
                    libreriaproceso.grabamovimiento(reg, nro, false);
                    memoadd(memo, librefiscal.factitem(lbliva, txtsubtotal));
                    libreriaproceso.actualizastock(reg);
                    totalfactura = totalfactura + (Convert.ToDecimal(reg["pventa"].ToString()) * Convert.ToDecimal(reg["cantidad"].ToString()));
                }
            }
            libreriaproceso.grabafacturacionfinal(reg, btnitka, nro, txtpago.Text, cmbcfpago1.Text, txtpago1.Text, cmbcfpago2.Text, totalfactura, txtxdto, txtsaldocliente);
            reg.Close();
            memoadd(memo, librefiscal.factpago("0"));
            memoadd(memo, librefiscal.factcierra(lbliva));
        }

        public static void procfunencabezado() { }



    }
}
