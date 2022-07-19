using FEAFIPLib;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loundry
{
    class FactWeb
    {
        /// <summary>
        /// carga datos de vendedor
        /// </summary>
        /// <param name="memo"></param>
        public static string CuitEmpresa()
        {
            string cuit = string.Empty;
            //buscar datos de negocio
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from negocio", cnn);
            if (reg.HasRows)
            {
                reg.Read();
                cuit = reg["nrodoc"].ToString();
            }
            reg.Close();
          
            cnn.Close();
            return cuit;
        }
        /// <summary>
        /// busca el numero de comprobante segun tipo comprobante
        /// </summary>
        /// <param name="nroform">para poner el numero de form</param>
        /// <param name="cpventa">para buscar cform en auxmovimiento3</param>
        /// <returns>string de numero de form</returns>
        public static string buscanroform(ref TextBox nroform, string cpventa)
        {
            /*
            //busco q tipo de cform figura en auxmovimiento3
            string cform = bdcomun.ejecuta("select * from auxmovimiento3 where cpventa='" + cpventa + "'", "cform");
            //busco x cform en tabla afiptipoform el codigo
            int TipoComp = Convert.ToInt32(bdcomun.ejecuta("select * from afiptipoform where cform='" + cform + "'", "codigo"));
            string URLWSW = Properties.Settings.Default.URLWSW;
            string URLWSAA = Properties.Settings.Default.URLWSAA;
            int PtoVta = Convert.ToInt32(bdcomun.ejecuta("select * from negocio limit 1", "PtoVenta"));
            double nro = 0;
            wsfev1 lwsfev1 = new wsfev1();
            lwsfev1.CUIT = Convert.ToInt64(CuitEmpresa()); // 20939802593; // Cuit del vendedor
            lwsfev1.URL = URLWSW;
            if (lwsfev1.login("certificado.crt", "clave.key", URLWSAA))
            {
                if (lwsfev1.RecuperaLastCMP(PtoVta, TipoComp, out nro) == false)
                {
                    MessageBox.Show(lwsfev1.ErrorDesc);
                }
                else
                {
                    nro = nro + 1;
                }
                nroform.Text = nro.ToString();
            }
            */
            return nroform.Text;

        }
        /// <summary>
        /// halla el total de la factura desde auxmovimiento3
        /// </summary>
        /// <param name="cmbcpventa"></param>
        /// <returns>string total</returns>
        public static string total(ComboBox cmbcpventa)
        {
            string total = "0";
            MySqlConnection cnn = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("SELECT sum(Pventa*Cantidad) as total FROM auxmovimiento3 where cpventa = '" +
                                                 cmbcpventa.Text + "'", cnn);
            if (reg.HasRows)
            {
                reg.Read();
                total = reg["total"].ToString().Trim();
            }
            reg.Close();
          
            cnn.Close();
            return total;
        }
        public static double HallaNeto(double valor, double porc)
        {
            double pventa = valor / ((porc / 100) + 1);
            decimal pv = Convert.ToDecimal(pventa);
            pv = decimal.Round(pv, 2);
            pventa = Convert.ToDouble(pv);
            return pventa;
        }
        /// <summary>
        /// graba un movimiento por item de la factura
        /// </summary>
        /// <param name="reg">registro de auxmovimiento3</param>
        /// <param name="nroform">nro de form obtenido en factfinal</param>
        /// <param name="ctacte">bool si el movimiento se registra con cform ctacte</param>
        /// <summary>
        /// Actualiza el stock en productos en base a auxmovimiento3
        /// </summary>
        /// <param name="cprod"></param>
        public static void actualizastock(MySqlDataReader reg)
        {
            string cprod = reg["cprod"].ToString();
            string cantidad = reg["cantidad"].ToString();
            string stact = bdcomun.ejecuta("select * from productos where cprod='" + cprod + "'", "stact",0); //busca en 0
            decimal stnuevo = Convert.ToDecimal(stact) - Convert.ToDecimal(cantidad);
            stact = libreria.decimalastringconpunto(stnuevo);
            string consulta = "update productos set stact='" + stact + "' where cprod='" + cprod + "'";
            bdcomun.ejecuta(consulta);
            //configuracion.mensaje("Stock actualizado");
        }
        public static void actualizastock2(MySqlDataReader reg)
        {
            string cprod = reg["cprod"].ToString();
            string cantidad = reg["cantidad"].ToString();
            //consultar stock en 0
            string stact = bdcomun.ejecuta("select * from productos where cprod='" + cprod + "'", "stact",0); //busca en 0 no actualizado aun
            decimal stnuevo = Convert.ToDecimal(stact) - Convert.ToDecimal(cantidad);
            stact = libreria.decimalastringconpunto(stnuevo);
            //verificar si existe en 1 y sino insertar
            string consulta = "update productos set stact='" + stact + "' where cprod='" + cprod + "'";
            bdcomun.ejecuta(consulta,0);
            //acutalizar en 0
            //configuracion.mensaje("Stock actualizado");
        }
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
                              "',lp='" + reg["lp"].ToString()+
                              "'";
            bdcomun.ejecuta(consulta);
            configuracion.mensaje("Movimiento grabado");
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
                           string txtpago1, string cmbcfpago2, string totalfactura, string impneto, string impiva,string xiva, TextBox txtxdto, 
                           TextBox txtsaldocliente, string cae)
        {
            string cform = "0TK0";
            decimal dtxtpago = libreria.stringadecimalconpunto(txtpago);
            decimal dtxtpago1 = libreria.stringadecimalconpunto(txtpago1);
            switch (itka.Tag.ToString())
            {
                case "1":
                    cform = "0TK1";
                    break;
                case "0":
                    cform = "0TK0";
                    break;
            }
            if (txtsaldocliente.Text.Trim() == string.Empty)
                txtsaldocliente.Text = "0";
            String espacio = " ";
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
                "', neto='" + impneto +
                "', iva='" + impiva +
                "', Xiva='"+ xiva+
                "', total='" + totalfactura +
                "', ccliente='" + reg["cliente"].ToString() +
                "', cempl='" + reg["cempl"].ToString() +
                "', xdto='" + txtxdto.Text +
                "', cae='" + cae +
                "', facturaanul='"+espacio+
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
    }
}
