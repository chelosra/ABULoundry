using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using FiscalNET;


namespace Loundry
{
    class librefiscal
    {
        private static string p = "|";
        /// <summary>
        /// Abre un tiquet
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static string tiqueabre(string dato)
        {
            dato = "@TIQUEABRE" + p + dato;
            return dato;
        }

        /// <summary>
        /// toma los datos de un item desde movimiento
        /// </summary>
        /// <param name="subtotal"></param>
        /// <param name="lbliva"></param>
        /// <returns></returns>
        public static string tiqueitem(TextBox subtotal, Label lbliva)
        {
            string dato = "" + p;
            string producto = "detalle segun minuta" + p; // lo toma del movimiento recien grabado
            string cantidad = "1" + p;                    // lo toma del movimiento 
            string precio = subtotal.Text + p;          // lo toma del movimiento
            string iva = "";
            switch (lbliva.Text)
            {
                case "I":
                    iva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    break;
                case "J":
                    iva = bdcomun.ejecuta("select * from configuracion", "exento") + p;
                    break;
                case "F":
                    iva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    break;
            }
            string opera = "M" + p;
            string nose = "00001" + p;
            string nose2 = "00000000" + p;  //monto impuesto interno fijo
            string nose3 = "0" + p;
            string aux = "@TIQUEITEM" + dato + producto +
                         cantidad + precio + iva + opera +
                         nose + nose2 + nose3;
            return aux;
        }

        /// <summary>
        /// toma el dato del dinero con el que paga el cliente
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="pago"></param>
        /// <returns></returns>
        public static string tiquepago(string dato, string pago)
        {
            dato = "" + p;
            string texto = "Recibimos: ...." + p;
            string paga = pago + p; //verificar pago con . y dos decimales

            string opera = "T" + p;
            return "@TIQUEPAGO" + dato + texto + paga + opera;
        }

        /// <summary>
        /// cierra tiquet fiscal
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static string tiquecierra(string dato) {
            dato = "" + p;
            string opera = "P";
            return "@TIQUECIERRA" + p + dato + opera;
        }

        public static void imprimefisal(RichTextBox memo, FiscalNET.EpsonTicket impfiscal1)
        {
            for (int i = 0; i < memo.Lines.Length; i++) {
                string aux = memo.Lines[i].ToString();
                //int nError= impfiscal1.IF_WRITE(aux);
                //showmessage('error: '+inttostr(nerror) + 'linea: '+inttostr(i));
            }

        }

        /// <summary>
        /// Abre una factura fiscal
        /// </summary>
        /// <param name="lbliva"></param>
        /// <param name="ccliente"></param>
        /// <returns></returns>
        public static string factabre(Label lbliva, TextBox ccliente) {
            string td = string.Empty;
            switch (lbliva.Text) {
                case "I": //RI
                    td = "A";
                    break;
                case "J": //RIE
                    td = "A";
                    break; 
                case "R": //RNI
                    td = "A";
                    break;
                case "N": //RNI
                    td = "B";
                    break;
                case "E": //RIE
                    td = "B";
                    break;
                case "F": //CF
                    td = "B";
                    break;
                case "M": //CF
                    td = "B";
                    break;
            }
            //string dato= "00001";
            string ivav= bdcomun.ejecuta("select * from negocio" , "iva");

            string ivac= bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'","iva");
            switch (ivac) {
                case "E":
                    ivac = "F";
                    break;
                case "J":
                    ivac = "I";
                    break;
            }

            string nc1= bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'", "rsocial"); 
            string nc2= " ";

            string xcuit = string.Empty;
            string cuitc= bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'", "ncuit");
            if (cuitc == string.Empty)
            {
                cuitc= bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'", "ndni");
                xcuit = bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'", "dni"); //"DNI";
            }
            else
            {
                xcuit = xcuit = bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'", "dni"); ;// xcuit = "CUIT";
            }
            string dc1= bdcomun.ejecuta("select * from cliente where codigo='" + ccliente.Text + "'", "domicilio");
            string dc2= "";
            string dc3= "";
            string rt1= "Remito Nro.:";
            string rt2= "";
            string copias= "1";
            string aux= "@FACTABRE|T|C|" + td + "|" + copias + "|P|10|" + ivav + "|" + ivac + "|" + nc1 + "|" + nc2 + "|" + xcuit + "|" + 
                         cuitc + "|N|" + dc1 + "|" + dc2 + "|" + dc3 + "|" + rt1 + "|" + rt2 + "|C";

            return aux;

            #region parametros factura
            /*
  { 1-dato:=nro comprobante
    2-tipo documento:=T
    3-salida impresora:=C continuo / F suelta
    4-letra documento:= A/B/C
    5-cantidad de copias:=1
    6-tipo formulario:= F preimpreso / P dibuja impre / A autoimpreso
    7-tamano caracter:= 10/12/17
    8-iva vendedor: I ri / R rni / N nr / E ex / M mono
    9-iva comprador: I/R/N/E/M/F cons. final
   10-nombre comercial 1
   11-nombre comercial 2
   12-tipo documento: DNI / CUIT / CUIL
   13-nro documento
   14-bien de uso: B (leyenda Vta Bienes de uso) N (no imprime leyenda)
   15-domicilio comprador 1
   16-domicilio comprador 2
   17-domicilio comprador 3
   18-linea rto 1
   19-linea rto 2
   20-formato para almacenar datos: C (no realiza DFH p/farmacia) G (realiza DFH p/farmacia) }
            */
            #endregion
        }

        public static string factitem(Label lbliva, TextBox subtotal)
        {
            string tiva = string.Empty;
            decimal riva = 0;
            decimal pfa = 0;
            //string dato= "00001";
            string di= "Detalle s / Minuta" +p;
            string cant= "00001";
            switch (lbliva.Text) {
                case "I": //ri
                    tiva= bdcomun.ejecuta("select * from configuracion", "ivari") +p; //'0.21'+#124;
                    riva= (Convert.ToDecimal(subtotal.Text) / (1 + Convert.ToDecimal(tiva) / 100));
                    pfa= riva;//strtofloat(subtotal.Text)-riva;
                    break;
                case "R": //rni
                    tiva= bdcomun.ejecuta("select * from configuracion", "ivari") +p; //'0.21'+#124;
                    riva= (Convert.ToDecimal(subtotal.Text) / (1 + Convert.ToDecimal(tiva) / 100));
                    pfa= riva;//strtofloat(subtotal.Text)-riva;
                    break;
                case "J": //rie
                    tiva= bdcomun.ejecuta("select * from configuracion", "exento") + p; //'0.21'+#124;
                    riva= (Convert.ToDecimal(subtotal.Text) / (1 + Convert.ToDecimal(tiva) / 100));
                    pfa= riva; //strtofloat(subtotal.Text)-riva;
                    break;
                case "F": //cf
                    tiva= bdcomun.ejecuta("select * from configuracion", "ivari") +p; //'0.21'+#124;
                    pfa = Convert.ToDecimal(subtotal.Text);
                    break;
                case "E": //cf
                    tiva= bdcomun.ejecuta("select * from configuracion", "exento") + p; //'0.21'+#124;
                    pfa = Convert.ToDecimal(subtotal.Text);
                    break;
                case "M": //rni
                    tiva= bdcomun.ejecuta("select * from configuracion", "exento") + p; //'0.21'+#124;
                    break;
                case "N": //rni
                    tiva= bdcomun.ejecuta("select * from configuracion", "exento") + p;
                    pfa = Convert.ToDecimal(subtotal.Text);
                    break;
            }

            string prec = libreria.decimalastringconpunto(pfa); 
            string cb= cant;
            string ta= "00000000";
            string le1= "";
            string le2= "";
            string le3= "";
            string tivaa= "0";
            string mif= "00000000";
            //  aux:='@FACTITEM|'+di+'|'+cant+'|'+prec+'|'+tiva+'|M|'+cb+'|'+ta+'|'+le1+'|'+le2+'|'+le3+'|'+tivaa+'|'+mif;
            string aux= "@FACTITEM|" + di + cant + "|" + prec + "|" + tiva + "M|" + cb + "|" + ta + "|" + le1 + "|" + le2 + "|" + le3 + "|" + tivaa + "|" + mif;
            return aux;

            #region datofiscal
            /*
    1-comprobante
    2-descripcion item
    3-cantidad 5.3
    4-precio 7.2 A>sin iva B/C> con iva
    5-tasa iva> 2100
    6-calificador item M suma / m anula item / R bonifica / r anula bonif
    7-cantidad bultos 5
    8-tasa ajuste 8
    9-linea extra 1
   10-linea extra 2
   11-linea extra 3
   12-tasa iva acrecentam RNI 1050
   13-monto impuesto interno fijo 8 (ceros) }
             */
            #endregion
        }

        public static string factpago(string paga)
        {
            //string dato = "00001";
            string mensaje = "Recibimos: ...";
            string pago = libreria.cadenac2decimales(paga);
            string aux= "@FACTPAGO|" + mensaje + "|" + pago + "|T";
            return aux;
            /*
            1-comprobante
             2-descripcion
             3-monto de pago 7.2
              4-calificador pago> T>suma importe C>cancela tique t>anula pago c/tique D>descuento global R>recargo global }
             */
        }

        public static string factcierra(Label lbliva)
        {
            //string dato= "00001";
            string tiva = string.Empty;
            string td = string.Empty;
            switch (lbliva.Text) {
                case "I": //ri
                    tiva= bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    td= "A";
                    break;
                case "J": //rie
                    tiva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    td = "A";
                    break;
                case "R": //rie
                    tiva = bdcomun.ejecuta("select * from configuracion", "ivarni") + p;
                    td = "A";
                    break;
                case "E": //cf
                    tiva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    td = "B";
                    break;
                case "F": //cf
                    tiva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    td = "B";
                    break;
                case "M": //cf
                    tiva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    td = "B";
                    break;
                case "N": //cf
                    tiva = bdcomun.ejecuta("select * from configuracion", "ivari") + p;
                    td = "B";
                    break;
            }
            string dlt= "FINAL";
            string aux= "@FACTCIERRA|" + "M|" + td + "|" + dlt;
            return "";
            /*
  1-comprobante
   2-tipo doc. fiscal> F>factura fiscal / T>tique factura fiscal / R> recibo-factura
   3-letra doc. fiscal A/B/C
   descripcion linea total ej. FINAL }
  dato:='00001';
             */
        }
        #region proc
        #endregion

        /// <summary>
        /// Busca el numero de factura en la impresora fisal
        /// </summary>
        /// <param name="Nroform"></param>
        /// <param name="impfiscal1"></param>
        /// <param name="fact">5 para fact B y 6 para factura A</param>
        public static string buscanroformfiscal(FiscalNET.EpsonTicket impfiscal1, int fact) {

            int nerror= impfiscal1.IF_WRITE("@ESTADO|A");
            string aux= impfiscal1.IF_READ(fact);
            Int32 naux = Convert.ToInt32(aux) + 1;
            aux = Convert.ToString(naux);
            libreria.rellena(aux, 12);
            return aux;
        }
    }
}
