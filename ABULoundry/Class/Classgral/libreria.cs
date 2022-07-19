using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Xml;
using System.Security.Cryptography;
using System.Globalization;
using System.Deployment.Application;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.Drawing.Imaging;

namespace Loundry
{
    public class libreria
    {

        /// <summary>
        /// Exporta a Excel con formato
        /// </summary>
        /// <param name="tabla"></param>
        public static void exportaDgvExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        /// <summary>
        /// Genera codigo QR en la direccion especifica para ponerlo en impresion como imagen externa
        /// </summary>
        /// <param name="xcae">texto</param>
        /// <returns></returns>

        public static string qr(string xcae, string archivo)
        {
            QrEncoder qr = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrc = new QrCode();
            qr.TryEncode(xcae, out qrc);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrc.Matrix, ImageFormat.Png, ms);
            var imagetemporal = new Bitmap(ms);
            var imagen = new Bitmap(imagetemporal, new Size(new Point(50, 50)));

            //pictureBox1.BackgroundImage = imagen;
            //Image clone = (Image)pictureBox1.BackgroundImage.Clone();


            Image clone = (Image)imagen.Clone();
            string archurl = @archivo;
            File.Delete(archurl);
            clone.Save(archurl, ImageFormat.Png);
            clone.Dispose();

            return "file:\\" + archurl;
        }
        /// <summary>
        /// trunca valor double a dos decimales sin redondear
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="cantdec"></param>
        /// <returns></returns>
        public static double truncadecimales(double valor,int cantdec)
        {
            switch (cantdec)
            {
                case 2:
                    valor = Math.Truncate(valor * 100) / 100;
                    break;
                case 3:
                    valor = Math.Truncate(valor * 1000) / 1000;
                    break;
            }
            return valor;
        }
        /// <summary>
        /// Retorna el valor de la celda de un datagrid verificando si es null
        /// </summary>
        /// <param name="i">indice de la fila</param>
        /// <param name="dgv">datagridview</param>
        /// <param name="campo">columna a devolver</param>
        /// <param name="devuelve">espacio o 0</param>
        /// <returns></returns>
        public static string valorcelda(int i, DataGridView dgv, string campo, string devuelve)
        {
            string valor = devuelve.Trim();
            valor = libreria.strnull(dgv.Rows[i].Cells[campo].Value, devuelve);
            return valor;
        }
        /// <summary>
        /// devuelve empty si es null o el valor q tenga
        /// </summary>
        /// <param name="s"></param>
        /// <param name="devuelve">espacio o 0</param>
        /// <returns></returns>
        public static String strnull(object s, string devuelve)
        {
            string retorna = string.Empty;
            if (s == null)
                retorna = devuelve;
            else
            {
                if (s.ToString().Trim() == string.Empty && devuelve == "0")
                {
                    retorna = devuelve;
                }
                else retorna = s.ToString().Trim();

            }
            return retorna;
        }
        /// <summary>
        /// Retorna la versión de la app
        /// </summary>
        /// <returns></returns>
        public static string Version()
        {
            string ver = string.Empty;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                string major = ApplicationDeployment.CurrentDeployment.CurrentVersion.Major.ToString();
                string minor = ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor.ToString();
                string build = ApplicationDeployment.CurrentDeployment.CurrentVersion.Build.ToString();
                string revision = ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision.ToString();
                ver = major + "." + minor + "." + build + "." + revision;
            }
            return ver;
        }
        /// <summary>
        /// Halla el porcentaje de un numero dado
        /// </summary>
        /// <param name="pcosto">numero que se pasa</param>
        /// <param name="porc">porcentaje a calcular</param>
        /// <returns></returns>
        public static string porcentaje(string pcosto, decimal porc)
        {
            decimal pventa = 0;
            pventa =decimal.Round( (Convert.ToDecimal(pcosto) * porc) / 100,2);
            string xpventa = libreria.decimalastringconpunto(pventa);
            return xpventa;
        }
        /// <summary>
        /// Incrementa un valor por el porcentaje pasado
        /// </summary>
        /// <param name="pcosto">valor</param>
        /// <param name="porc">%</param>
        /// <param name="opera">+ o - segun se desea</param>
        /// <returns></returns>
        public static string incrementaporc(string pcosto, decimal porc, string opera)
        {
            decimal pventa = 0;
            if (opera == "+")
                pventa =decimal.Round( Convert.ToDecimal(pcosto) + (Convert.ToDecimal(pcosto) * porc) / 100,2);
            else
                pventa = decimal.Round( Convert.ToDecimal(pcosto) - (Convert.ToDecimal(pcosto) * porc) / 100,2);
            string xpventa = libreria.decimalastringconpunto(pventa);
            return xpventa;
        }

        /// <summary>
        /// Adapta la fecha para ser grabada en mysql
        /// </summary>
        /// <param name="lafecha"></param>
        /// <returns></returns>
        public static string fechaamysql(string lafecha)
        {
            DateTime fecha = Convert.ToDateTime(lafecha);
            string xfecha = fecha.ToString("yyyy-MM-dd");
            return xfecha;
        }
        public static string fechaamysql(string lafecha,bool dato)
        { string xfecha;
            if (dato)
            xfecha = lafecha.Substring(0,4)+"-"+lafecha.Substring(4,2)+"-"+lafecha.Substring(6,2);
            else
                xfecha =  lafecha.Substring(6, 2)+"-"+lafecha.Substring(4, 2) + "-" +lafecha.Substring(0, 4);
            return xfecha;
        }
        /// <summary>
        /// Adapta la fecha para mostrarla como dd/mm/aaaa
        /// </summary>
        /// <param name="lafecha"></param>
        /// <returns></returns>
        public static string fechalatina(string lafecha)
        {
            DateTime fecha = Convert.ToDateTime(lafecha);
            string xfecha = fecha.ToString("dd/MM/yyyy");
            return xfecha;
        }
        /// <summary>
        /// devuelve true si una expresion es numerica
        /// </summary>
        /// <param name="Expression"></param>
        /// <returns></returns>
        public static bool IsNumeric(string Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        /// <summary>
        /// reemplaza vacio por cero en txtbox
        /// </summary>
        /// <param name="txt"></param>
        public static void textboxvacioxcero(TextBox txt)
        {
            if (txt.Text == string.Empty)
                txt.Text = "0";
        }
        /// <summary>
        /// valida que solo se ingrese numeros y punto
        /// </summary>
        /// <param name="textBox1"></param>
        /// <param name="e"></param>
        public static void textboxdecimal(TextBox textBox1, KeyPressEventArgs e)
        {
            if (textBox1.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                    //           libreria.MessageBoxTemporal.Show("Solo puede ingresar números y punto", configuracion.titulomensaje(), 1, false);
                }
            }
        }
        /// <summary>
        /// valida que solo se ingrese numeros
        /// </summary>
        /// <param name="textBox1"></param>
        /// <param name="e"></param>
        public static void textboxnumero(TextBox textBox1, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            else e.Handled = false;
        }
        /// <summary>
        /// Posiciona un combobox en el item segun la cadena
        /// </summary>
        /// <param name="combo">combo donde se busca item</param>
        /// <param name="cadena">cadena a buscar</param>
        public static void seleccionaitemcombo(ref ComboBox combo, string cadena)
        {
            int index = combo.FindString(cadena);
            
            combo.SelectedIndex = index;
        }
        /// <summary>
        /// genera grafico para celda datagridview
        /// </summary>
        /// <param name="e">e DataGridViewCellPaintingEventArgs</param>
        /// <param name="c1">color</param>
        /// <param name="c2">color</param>
        /// <param name="c3">color</param>
        /// <param name="figura">1 rectangulo</param>
        public static void pintaceldadgv(DataGridViewCellPaintingEventArgs e, Color c1, Color c2, Color c3, int figura, string nuevo)
        {
            LinearGradientBrush br = new LinearGradientBrush(e.CellBounds, c1, c3, 90, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.5, 1 };
            cb.Colors = new[] { c1, c2, c3 };
            br.InterpolationColors = cb;
            //
            Rectangle rec = new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width, e.CellBounds.Height);
            if (figura == 1)
                e.Graphics.FillRectangle(br, rec);
            else
                e.Graphics.FillRectangle(br, rec);

            e.PaintContent(e.ClipBounds);
            e.Handled = true;
        }
        public static void pintaceldadgv(DataGridViewCellPaintingEventArgs e, Color c1, Color c2, Color c3, int figura)
        {
            LinearGradientBrush br = new LinearGradientBrush(e.CellBounds, c1, c3, 90, true);
            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, (float)0.5, 1 };
            cb.Colors = new[] { c1, c2, c3 };
            br.InterpolationColors = cb;
            if (figura == 1)
                e.Graphics.FillRectangle(br, e.CellBounds);
            else
                e.Graphics.FillRectangle(br, e.CellBounds);

            e.PaintContent(e.ClipBounds);
            e.Handled = true;
        }

        /// <sumary>
        /// Invierte un numero 
        /// </sumary>
        /// <param name="n">entero a invertir</param> 
        public static int inviertenumero(int n)
        {
            int m = 0;
            while (n > 0)
            {
                m = m * 10;
                n = n / 10;
            }
            return m;
        }
        ///<summary>
        ///Valida q textbox sea entero o decimal usando evento keyup [entero_o_decimal((TextBox)sender);]
        ///<param name="txt">caja de texto</param>
        ///<param name="tipo">I si es entero, D si es decimal</param>
        ///</summary>
        public static bool entero_o_decimal(TextBox txt, string tipo)
        {
            bool retorna = false;
            switch (tipo)
            {
                case "I":
                    try
                    {
                        int d = Convert.ToInt32(txt.Text);
                        retorna = true;
                    }
                    catch (Exception ex)
                    {
                        txt.Text = "0";
                        txt.Select(0, txt.Text.Length);
                        retorna = false;
                    }
                    break;
                case "D":
                    try
                    {
                        decimal d = Convert.ToDecimal(txt.Text);
                        retorna = true;
                    }
                    catch (Exception ex)
                    {
                        txt.Text = "0";
                        txt.Select(0, txt.Text.Length);
                        retorna = false;
                    }
                    break;
            }
            return retorna;
        }
        ///<summary>
        ///Valida q solo se ingrese numeros o letras usando evento keypress
        ///<param name="pe">evento</param>
        ///<param name="tipo">N si es numerico, L si es letra</param>
        ///</summary>
        public static void solonum_o_letra(KeyPressEventArgs pe, string tipo)
        {
            switch (tipo)
            {
                case "N":
                    if (((pe.KeyChar < 48 && pe.KeyChar != 8 || pe.KeyChar > 57)))
                    {
                        MessageBoxTemporal.Show("Solo se permiten números", "Error", 1, true);
                    }
                    break;
                case "L":
                    if ((pe.KeyChar <= 64 && pe.KeyChar != 8) || (pe.KeyChar >= 91 && pe.KeyChar <= 96) || (pe.KeyChar >= 122))
                    {
                        MessageBoxTemporal.Show("Solo se permiten letras", "Error", 1, true);
                    }
                    break;
            }
        }
        ///<summary>
        ///Valida q solo se ingrese numeros usando evento keypress
        ///</summary>
        public static void Solonumeros(KeyPressEventArgs pe)
        {
            if (char.IsDigit(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else
            {
                if (char.IsControl(pe.KeyChar))
                {
                    pe.Handled = false;
                }
                else
                {
                    pe.Handled = true;
                }
            }
        }
        ///<summary>
        ///Valida q solo se ingrese letras usando evento keypress
        ///</summary>
        public static void Sololetras(KeyPressEventArgs pe)
        {
            if (char.IsLetter(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else
            {
                if (char.IsControl(pe.KeyChar))
                {
                    pe.Handled = false;
                }
                else
                {
                    pe.Handled = true;
                }
            }
        }
        ///<summary>
        ///Toma parte izquierda del string
        ///<param name="param">string a recortar</param>
        ///<param name="length">cantidad de caracteres</param>
        ///</summary>
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        ///<summary>
        ///Toma parte derecha del string
        ///<param name="param">string</param>
        ///<param name="length">cantidad de caracteres</param>
        ///</summary>
        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
        ///<summary>
        ///Alterna el color de las filas de un datagridview
        ///</summary>
        public static void alternacolorfila(ref DataGridView grilla)
        {
            grilla.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }
        ///<summary>
        ///Muestra mensaje en pantalla que se cierra solo
        ///</summary>
        public class MessageBoxTemporal
        {
            System.Threading.Timer IntervaloTiempo;
            string TituloMessageBox;
            string TextoMessageBox;
            int TiempoMaximo;
            IntPtr hndLabel = IntPtr.Zero;
            bool MostrarContador;

            ///<summary>
            ///Genera mensaje temporal
            ///</summary>
            ///<return>
            ///
            ///</return>
            ///<param name="texto">
            ///mensaje a mostrar
            ///</param>
            ///<param name="titulo">
            ///titulo de la ventana
            ///</param>
            ///<param name="tiempo">
            ///tiempo que se muestra el mensaje
            ///</param>
            MessageBoxTemporal(string texto, string titulo, int tiempo, bool contador)
            {
                TituloMessageBox = titulo;
                TiempoMaximo = tiempo;
                TextoMessageBox = texto;
                MostrarContador = contador;

                if (TiempoMaximo > 99) return; //Máximo 99 segundos
                IntervaloTiempo = new System.Threading.Timer(EjecutaCada1Segundo,
                    null, 1000, 1000);
                if (contador)
                {
                    DialogResult ResultadoMensaje = MessageBox.Show(texto + "\r\nEste mensaje se cerrará dentro de " +
                        TiempoMaximo.ToString("00") + " segundos ...", titulo);
                    if (ResultadoMensaje == DialogResult.OK) IntervaloTiempo.Dispose();
                }
                else
                {
                    DialogResult ResultadoMensaje = MessageBox.Show(texto + "...", titulo);
                    if (ResultadoMensaje == DialogResult.OK) IntervaloTiempo.Dispose();
                }
            }
            public static void Show(string texto, string titulo, int tiempo, bool contador)
            {
                new MessageBoxTemporal(texto, titulo, tiempo, contador);
            }
            void EjecutaCada1Segundo(object state)
            {
                TiempoMaximo--;
                if (TiempoMaximo <= 0)
                {
                    IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                    if (hndMBox != IntPtr.Zero)
                    {
                        SendMessage(hndMBox, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                        IntervaloTiempo.Dispose();
                    }
                }
                else if (MostrarContador)
                {
                    // Ha pasado un intervalo de 1 seg:
                    if (hndLabel != IntPtr.Zero)
                    {
                        SetWindowText(hndLabel, TextoMessageBox +
                            "\r\nEste mensaje se cerrará dentro de " +
                            TiempoMaximo.ToString("00") + " segundos");
                    }
                    else
                    {
                        IntPtr hndMBox = FindWindow(null, TituloMessageBox);
                        if (hndMBox != IntPtr.Zero)
                        {
                            // Ha encontrado el MessageBox, busca ahora el texto
                            hndLabel = FindWindowEx(hndMBox, IntPtr.Zero, "Static", null);
                            if (hndLabel != IntPtr.Zero)
                            {
                                // Ha encontrado el texto porque el MessageBox
                                // solo tiene un control "Static".
                                SetWindowText(hndLabel, TextoMessageBox +
                                    "\r\nEste mensaje se cerrará dentro de " +
                                    TiempoMaximo.ToString("00") + " segundos");
                            }
                        }
                    }
                }
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll",
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
                string lpszClass, string lpszWindow);
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern bool SetWindowText(IntPtr hwnd, string lpString);
        }
        ///<summary>
        ///Calcula la edad al dia de hoy
        ///</summary>
        public static string CalcEdad(string fnac)
        {
            DateTime dat = Convert.ToDateTime(fnac);
            DateTime nacimiento = new DateTime(dat.Year, dat.Month, dat.Day);
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            return edad.ToString();
        }
        ///<summary>
        ///Crea archivo xml con datos de conexion en archivo conf.xml
        ///ej: @c:\directorio\
        ///conf.xml
        ///</summary>
        public static void creaxml(string uno, string dos, string tres, string cuatro, string directorio, string archivoxml)
        {
            string clave = libreria.Encriptar(cuatro.Trim());
            XmlWriter w = XmlWriter.Create(directorio + archivoxml);
            w.WriteStartElement("Config");
            w.WriteElementString("Servidor", uno.Trim());
            w.WriteElementString("Database", dos.Trim());
            w.WriteElementString("usuario", tres.Trim());
            w.WriteElementString("password", clave.Trim());
            w.WriteEndElement();
            w.Close();
        }
        ///<summary>
        ///Lee archivo xml encriptado
        ///</summary>
        public static string[] leerxml(string directorio)
        {
            string auxdir = directorio + Properties.Settings.Default.conf;
            XmlReader r = XmlReader.Create(auxdir);
            r.ReadStartElement("Config");
            string uno = r.ReadElementContentAsString();
            string dos = r.ReadElementContentAsString();
            string tres = r.ReadElementContentAsString();
            string cuatro = r.ReadElementContentAsString();
            cuatro = libreria.DesEncriptar(cuatro);
            r.Close();
            string[] vector = { uno.Trim(), dos.Trim(), tres.Trim(), cuatro.Trim() };
            return vector;
        }
        ///<summary>
        ///Devuelve el encriptado de una cadena
        ///</summary>
        public static string Encriptar(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        ///<summary>
        ///Devuelve el desencriptado de una cadena encriptada
        ///</summary>
        public static string DesEncriptar(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        ///<summary>
        ///Rellena un string con ceros a la izquierda
        ///</summary>
        public static string rellena(string dato, int x)
        {
            while (dato.Length < x)
            {
                dato = "0" + dato;
            }
            return dato;
        }
        /// <summary>
        /// Convierte una cadena con dos decimales
        /// </summary>
        /// <param name="cadena">cadena a convertir</param>
        /// <returns></returns>
        public static string cadenac2decimales(string cadena)
        {
            int largo = cadena.Length;
            string dec = Right(cadena, 2);
            string ent = Left(cadena, largo - 2);
            cadena = ent + "." + dec;
            return cadena;
        }

        /// <summary>
        /// Convierte stringdecimal a string decimal c 2 digitos
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string stringdecimalastring2dec(string a)
        {
            decimal b = 0;
            if (a == string.Empty)
                a = "0";
            b = Convert.ToDecimal(a, CultureInfo.InvariantCulture);
            a = b.ToString("0.##"); //b.ToString("C");
            return a;
        }
        ///<summary>
        ///Convierte un numero decimal a string (separador decimal punto)
        ///</summary>
        public static string decimalastringconpunto(decimal numero)
        {
            string xnumero = numero.ToString();
            xnumero = numero.ToString().Replace(',', '.');
            return xnumero;
        }
        ///<summary>
        ///Convierte un string a numero decimal (separador decimal punto)
        ///</summary>
        public static decimal stringadecimalconpunto(string numero)
        {
            if (numero == string.Empty || numero==".")
                numero = "0";
            //            numero = numero.ToString().Replace(',', '.');
            decimal xnumero = Convert.ToDecimal(numero, CultureInfo.InvariantCulture);
            return xnumero;
        }
        ///<summary>
        ///Calcula el tiempo en minutos
        ///</summary>
        public static string tiempanalisis(DateTime hrinicio, DateTime hrfin)
        {
            int hri, mni, hrf, mnf, minuto;
            string xhora;
            hri = hrinicio.Hour * 60;
            mni = hrinicio.Minute + hri;
            hrf = hrfin.Hour * 60;
            mnf = hrfin.Minute + hrf;

            minuto = mnf - mni;
            //         xhora = hora +":" + minuto;
            xhora = minuto.ToString();
            return xhora;
        }
        public static void dgvcolordetalle(DataGridView grilla, TextBox mcarrera)
        {
            libreria.alternacolorfila(ref grilla);
            foreach (DataGridViewRow dgvr in grilla.Rows)
            {
                if (Convert.ToInt16(dgvr.Cells["carrera"].Value) < Convert.ToInt16(mcarrera.Text))
                    dgvr.DefaultCellStyle.ForeColor = Color.Red;
                else
                    dgvr.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        ///<summary>
        ///Colorea de verde al ejemplar que se le finalizo la muestra
        ///</summary>
        public static void dgvcolor(DataGridView grilla)
        {
            //sralibreria.alternacolorfila(ref grilla);
            foreach (DataGridViewRow dgvr in grilla.Rows)
            {
                if (dgvr.Cells["diftiempo"].Value == null)
                    dgvr.DefaultCellStyle.ForeColor = Color.Black;
                else if (dgvr.Cells["diftiempo"].Value.ToString().Trim() == "")
                    dgvr.DefaultCellStyle.ForeColor = Color.Black;
                else if (dgvr.Cells["diftiempo"].Value.ToString().Trim() != "")
                    dgvr.DefaultCellStyle.ForeColor = Color.DarkGreen;
            }
            //cabcolor.colorcab(grilla, 4, 4);
        }
        ///<summary>
        ///Colorea el ejemplar que tiene dopping positivo
        ///</summary>
        public static void dgvcolordopping(DataGridView grilla)
        {
            foreach (DataGridViewRow dgvr in grilla.Rows)
            {
                if (dgvr.Cells["dopping"].Value == null)
                    dgvr.DefaultCellStyle.ForeColor = Color.Black;
                else if (dgvr.Cells["dopping"].Value.ToString().Trim() == "")
                    dgvr.DefaultCellStyle.ForeColor = Color.Black;
                else if (dgvr.Cells["dopping"].Value.ToString().Trim() != "")
                    dgvr.DefaultCellStyle.ForeColor = Color.Red;
            }
            //cabcolor.colorcab(grilla, 3, 3);
            //cabcolor.colorcab(grilla, 0, 1);
            //cabcolor.colorcab(grilla, 1, 1);
        }
        ///<summary>
        ///Alterna el color de la carrera basandose en en campo (string) que es el numero de carrera
        ///</summary>
        public static void alternacolorcarrera(ref DataGridView grilla, string campo)
        {
            int carrera = 0;
            int xcolor = 0;
            Color fondo = Color.LightGray;
            foreach (DataGridViewRow dgvr in grilla.Rows)
            {
                if (carrera == 0)
                {
                    xcolor = 1;
                    carrera = Convert.ToInt16(dgvr.Cells[campo].Value);
                }
                else
                {
                    if (carrera != Convert.ToInt16(dgvr.Cells[campo].Value))
                    {
                        carrera = Convert.ToInt16(dgvr.Cells[campo].Value);
                        if (xcolor == 1)
                            xcolor = 2;
                        else
                            xcolor = 1;
                    }
                }
                if (xcolor == 1)
                    fondo = Color.LightGray;
                else
                    fondo = Color.WhiteSmoke;

                dgvr.DefaultCellStyle.BackColor = fondo;
            }
        }
        public static void hringresoegreso(ref string rhora, string mensaje)
        {
            DialogResult result = MessageBox.Show("Ingresa Hora de Sistema ?", "Confirma?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                rhora = DateTime.Now.ToString("HH:mm:ss");
            else
            {
                //muestro panel c ingreso de hora
                // rhora = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Hora (hh:mm) de "+mensaje+":");
                if (rhora.Length != 5)
                {
                    MessageBox.Show("La hora no es correcta. Vuelva a ingresarla");
                    rhora = "";
                }
                else
                {
                    rhora = rhora.Substring(0, 2) + ":" + rhora.Substring(3, 2);
                    //    rhora.Substring(2,1)
                }
            }
        }
        ///<summary>
        ///Calcula el hash para website palermo
        ///</summary>
        public static string hash()
        {
            string hash;
            DateTime Hoy = DateTime.Today;
            int numfecha = Convert.ToInt32(Hoy.Year.ToString() + Hoy.Month.ToString() + Hoy.Day.ToString());// Hoy.ToString("yyyyMMd");
            numfecha = numfecha * 3;
            hash = numfecha.ToString().Trim();
            hash = libreria.CalculaMD5(hash);
            return hash;
        }
        ///<summary>
        ///Calcula el hash para website palermo
        ///</summary>
        private static string CalculaMD5(string test)
        {
            //caso 1
            MD5 md5 = MD5.Create();
            byte[] inputbyte = Encoding.ASCII.GetBytes(test);
            byte[] hashbyte = md5.ComputeHash(inputbyte);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashbyte.Length; i++)
            {
                sb.AppendFormat(hashbyte[i].ToString("X2"));
            }
            return sb.ToString();
        }
        ///<summary>
        ///Convierte string a mayuscula y elimina acentos y apostrofes y ñ
        ///</summary>
        public static string convmayacentosetc(string nomcab)
        {
            nomcab = nomcab.Replace("´", "");
            nomcab = nomcab.Replace("'", "");
            nomcab = nomcab.Replace("á", "a");
            nomcab = nomcab.Replace("é", "e");
            nomcab = nomcab.Replace("í", "i");
            nomcab = nomcab.Replace("ó", "o");
            nomcab = nomcab.Replace("ú", "u");
            nomcab = nomcab.ToUpper();
            nomcab = nomcab.Replace("Ñ", "¥");
            return nomcab;
        }
        public static void esperar()
        {
            //frmspash frm = new frmspash();
            //frm.ShowDialog();
        }
    }
}




