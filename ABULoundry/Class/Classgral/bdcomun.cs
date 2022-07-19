using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using Loundry.Reportes;
using System.Drawing.Printing;

namespace Loundry
{
    public class bdcomun
    {

        public static string path = @Properties.Settings.Default.DirectorioConf; //es el path donde se encuentra el conf.xml
        /// <summary>
        /// Setea la pagina de impresion con margenes 
        /// </summary>
        /// <returns></returns>
        public static PageSettings reportepagina()
        {
            PaperSize size = new PaperSize();
            size.RawKind = (int)PaperKind.A4;

            PageSettings pg = new PageSettings();
            pg.PaperSize = size;
            pg.Margins.Top = 0;
            pg.Margins.Bottom = 0;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            return pg;
        }

        /// <summary>
        /// Imprime una consulta a traves de un reportviewer
        /// </summary>
        /// <param name="rpt">ReportViewer</param>
        /// <param name="archivordlc">nombre del archvivo rdlc</param>
        /// <param name="consulta">query</param>
        /// <param name="ntabla">nro de tabla del dataset</param>
        /// <param name="rptdatasource">nombre del datasource del reporte</param>
        /// <param name="parameters">parametros de report para imprimir</param>
        public static ReportViewer reporte(ReportViewer rpt, string archivordlc, string consulta, int ntabla, string rptdatasource, ReportParameter[] parameters)
        {
            //leer http://joseluisgarciab.blogspot.com.ar/2013/10/reportviewer-y-rdlc-ejemplo-facturacion.html
            // http://infotacticassoluciones.blogspot.com.ar/2015/03/hacer-que-los-reportes-rdlc-reportes.html
            //string ruta = "c://sracsharp//Loundry//Loundry//Reportes//Report1.rdlc";

            string ruta = @Properties.Settings.Default.PathReport + archivordlc;

            MySqlConnection condet = bdcomun.Conexion();

            DataSetLoundry ds = new DataSetLoundry();
            DataTable informacion = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = new MySqlCommand(consulta, condet);
            da.Fill(ds.Tables[ntabla]);
            informacion = ds.Tables[ntabla];

            rpt.ProcessingMode = ProcessingMode.Local;
            rpt.Reset();
            rpt.LocalReport.ReportPath = ruta; // rpt.LocalReport.ReportEmbeddedResource = "Loundry."+archivordlc;
            rpt.LocalReport.DataSources.Clear();
            rpt.LocalReport.EnableExternalImages = true;
            rpt.LocalReport.SetParameters(parameters);
            //            ReportDataSource datasource = new ReportDataSource("dsReport1", informacion);
            ReportDataSource datasource = new ReportDataSource(rptdatasource, informacion);
            rpt.LocalReport.DataSources.Add(datasource);
            //rpt.DocumentMapCollapsed = true;
            rpt.RefreshReport();
            return rpt;

            ///
            // LAS TRES LINEAS SIGUIENTES SON OBLIGATORIAS PARA QUE SE RECONOZCA COMO RECURSO EMBEBIDO
            /*
            rpt.ProcessingMode = ProcessingMode.Local;
            rpt.Reset();
            rpt.LocalReport.ReportEmbeddedResource = "Loundry";
            rpt.LocalReport.DataSources.Clear();
            rpt.LocalReport.SetParameters(repParamHeader);
            rpt.LocalReport.DataSources.Add(new ReportDataSource("dsInformes", miDataTablePagos));
            rpt.LocalReport.Refresh();
            */
        }

        ///<summary>
        ///Lee un registro de la base de datos y 
        ///retorna el valor de un campo
        ///</summary>
        public static string contenidocampo(string consulta, string campo)
        {
            string resultado = string.Empty;
            MySqlConnection condet = bdcomun.Conexion();
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            MySqlDataReader reg = comandodet.ExecuteReader();
            if (reg.HasRows)
            {
                reg.Read();
                resultado = reg[campo].ToString();
            }
            reg.Close();
            condet.Close();
            return resultado;
        }

        public static bool changeip(Form x)
        {
            bool resul;
            if (Properties.Settings.Default.Status == "Public")
            {
                string[] datos = libreria.leerxml(@Properties.Settings.Default.DirectorioConf);
                Properties.Settings.Default.Host = "localhost";
                Properties.Settings.Default.Pass = datos[3];
                Properties.Settings.Default.Port = "3307";
                Properties.Settings.Default.Status = "Private";
                resul = false;
            }
            else
            {
                string[] datos = libreria.leerxml(@Properties.Settings.Default.DirectorioConf);
                Properties.Settings.Default.Host = datos[0].Trim();
                Properties.Settings.Default.Pass = datos[3];
                Properties.Settings.Default.Port = "3306";
                Properties.Settings.Default.Status = "Public";
                resul = true;
            }
            if (x != null)
            {
                for (int i = x.MdiChildren.Count() - 1; i >= 0; i--)
                {
                    string nom = x.MdiChildren[i].Name;
                    x.MdiChildren[i].Close();
                }
            }
            return resul;
        }
        ///<summary>
        ///Conexion a base mysql
        ///Retorna Conexion
        ///Parámetro "path"> Carpeta dde se encuentra conf.xml con datos de conexion (@"c:\");.
        ///</summary>
        public static MySqlConnection Conexion()
        {
            //string[] datos = libreria.leerxml(@"c:\sracsharp\re\");
            string[] datos = libreria.leerxml(path);
            datos[0] = Properties.Settings.Default.Host;
            datos[3] = Properties.Settings.Default.Pass;
            string consulta = "server=" + datos[0].Trim() + "; database=" + datos[1] +
                              ";Uid=" + datos[2] + ";Pwd=" + datos[3].Trim() + "; " +
                              " Allow Zero Datetime=True; Convert Zero Datetime=True; " +
                              " Port = " + Properties.Settings.Default.Port + ";  Connect Timeout=700 ; ";

            //consulta = "server=localhost;database=Loundry;Uid=root;Pwd=apache";
            MySqlConnection conectar = null;
            conectar = new MySqlConnection(consulta);
            try
            {
                if (!conectar.Ping())
                    conectar.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return conectar;
        }
        ///<summary>
        ///Conexion a base mysql a un database especifico para backup
        ///Retorna Conexion
        ///</summary>
        public static MySqlConnection Conexion(string database)
        {
            //string[] datos = libreria.leerxml(@"c:\sracsharp\re\");
            string[] datos = libreria.leerxml(path);
            datos[1] = database;
            string consulta = "server=" + datos[0].Trim() + "; database=" + datos[1].Trim() +
                              ";Uid=" + datos[2] + ";Pwd=" + datos[3].Trim() + "; " +
                              " Allow Zero Datetime=True; Convert Zero Datetime=True; " +
                              " Port = " + Properties.Settings.Default.Port + ";  Connect Timeout=700;";

            //consulta = "server=localhost;database=Cocheria;Uid=root;Pwd=apache";
            MySqlConnection conectar = null;
            conectar = new MySqlConnection(consulta);

            try
            {
                if (!conectar.Ping())
                    conectar.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return conectar;
        }
        public static MySqlConnection Conexion(int serv)
        {
            //string[] datos = libreria.leerxml(@"c:\sracsharp\re\");
            string[] datos = libreria.leerxml(path);
            datos[0] = Properties.Settings.Default.Host;
            datos[3] = Properties.Settings.Default.Pass;
            string consulta = "server=" + datos[0].Trim() + "; database=" + datos[1] +
                              ";Uid=" + datos[2] + ";Pwd=" + datos[3].Trim() + "; " +
                              " Allow Zero Datetime=True; Convert Zero Datetime=True; " +
                              " Port = " + 3306 + "; Connect Timeout=36000; ";

            //consulta = "server=localhost;database=Loundry;Uid=root;Pwd=apache";
            MySqlConnection conectar = new MySqlConnection(consulta);
            try
            {
                conectar.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return conectar;
        }

        ///<summary>
        ///Ejecuta una consulta mysql abriendo y cerrando conexion
        ///Retorna cantidad de registros afectados.-
        ///Parámetro "consulta"> Query a la tabla.
        ///Parámetro "path"> Carpeta dde se encuentra conf.xml con datos de conexion (@"c:\").
        ///Nota: (El método se encarga de abrir y cerrar la conexion)
        ///</summary>
        public static int ejecuta(string consulta, int serv)
        {
            int creg = 0;
            //            MySqlConnection condet = bdcomun.Conexion(@"c:\sracsharp\wscpalermo\stud\");
            MySqlConnection condet = bdcomun.Conexion(serv);
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            creg = comandodet.ExecuteNonQuery();
            condet.Close();
            return creg;
        }
        public static int ejecuta(string consulta)
        {
            int creg = 0;
            //            MySqlConnection condet = bdcomun.Conexion(@"c:\sracsharp\wscpalermo\stud\");
            MySqlConnection condet = bdcomun.Conexion();
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            creg = comandodet.ExecuteNonQuery();
            condet.Close();
            return creg;
        }
        ///<summary>
        ///Lee un registro de la base de datos 
        ///Retorna el valor de un campo
        ///Parámetro "consulta"> Query a la tabla.
        ///          "campo">Campo de la tabla a retornar
        ///          "path"> Carpeta dde se encuentra conf.xml con datos de conexion (@"c:\");.
        ///</summary>
        public static string ejecuta(string consulta, string campo)
        {
            string resultado = string.Empty;
            MySqlConnection condet = bdcomun.Conexion();
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            MySqlDataReader reg = comandodet.ExecuteReader();
            if (reg.HasRows)
            {
                reg.Read();
                resultado = reg[campo].ToString();
            }
            reg.Close();
            condet.Close();
            return resultado;
        }
        public static string ejecuta(string consulta, string campo, int serv)
        {
            string resultado = string.Empty;
            MySqlConnection condet = bdcomun.Conexion(serv);
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            MySqlDataReader reg = comandodet.ExecuteReader();
            if (reg.HasRows)
            {
                reg.Read();
                resultado = reg[campo].ToString();
            }
            reg.Close();
            condet.Close();
            return resultado;
        }
        ///<summary>
        ///Verifica si hay registros 
        ///Retorna true false
        ///Parámetro "consulta"> Query a la tabla.
        ///          "aux" bool false para entrar.
        ///</summary>
        public static bool ejecuta(string consulta, bool aux)
        {
            MySqlConnection condet = bdcomun.Conexion();
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            MySqlDataReader reg = comandodet.ExecuteReader();
            return reg.HasRows;
        }

        ///<summary>
        ///Carga una matriz con los datos de la consulta
        ///Retorna un datareader con datos de la consulta.-
        ///Parámetro "consulta"> Query a la tabla.
        ///Parámetro "condet"> Conexión a Database (MySqlConnection).
        ///Nota: (Se debe abrir la conexión antes de ejecutar el método y cerrarla dps de su ejecución)
        ///</summary>
        public static MySqlDataReader leereg(string consulta, MySqlConnection condet)
        {
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            MySqlDataReader reg = comandodet.ExecuteReader();
            return reg;
        }

        ///<summary>
        ///Carga un datatable con los datos de la consulta
        ///Retorna un datatable con datos de la consulta.-
        ///Parámetro "consulta"> Query a la tabla.
        ///Parámetro "condet"> Conexión a Database (MySqlConnection).
        ///Nota: (Se debe abrir la conexión antes de ejecutar el método y cerrarla dps de su ejecución)
        ///</summary>
        public static DataTable leereg(string consulta, MySqlConnection condet, string vacio)
        {
            MySqlCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            comandodet.ExecuteNonQuery();
            DataTable tdatos = new DataTable();
            //DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, condet);
            adapter.Fill(tdatos);
            return tdatos;
        }
        ///<summary>
        ///Carga los datos de una consulta al Datagridview
        ///Retorna un DataGridView
        ///Parámetro "grilla"> DataGridView a cargar
        ///          "consulta"> Query a la tabla.
        ///          "columna">Nombre de la columna a colorear.
        ///          "path"> Carpeta dde se encuentra conf.xml con datos de conexion (@"c:\");.
        ///
        ///</summary>
        public static DataGridView dgv(DataGridView grilla, string consulta, string columna) //corregido
        {
            if (consulta != null)
            {
                #region planilla
                int colum;
                MySqlConnection condet = bdcomun.Conexion();
                MySqlCommand comandodet = condet.CreateCommand();
                comandodet.CommandText = consulta;
                //comandodet.ExecuteNonQuery();
                DataTable tdatos = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, condet);
                adapter.Fill(tdatos);
                grilla.DataSource = tdatos;
                grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                grilla.AutoResizeColumns();
                grilla.AllowUserToResizeColumns = true;
                grilla.AllowUserToOrderColumns = true;
                if (columna != string.Empty)
                {
                    colum = Convert.ToInt16(columna);
                    grilla.Columns[colum].DefaultCellStyle.BackColor = Color.LightGray;
                    grilla.Columns[colum].DefaultCellStyle.ForeColor = Color.OrangeRed;
                    grilla.Columns[colum].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                libreria.alternacolorfila(ref grilla);
                condet.Close();
                #endregion
            }
            return grilla;
        }
        ///<summary>
        ///Carga los datos de una consulta al Datagridview
        ///Retorna un DataGridView
        ///Parámetro "grilla"> DataGridView a cargar
        ///          "consulta"> Query a la tabla.
        ///          "path"> Carpeta dde se encuentra conf.xml con datos de conexion (@"c:\");.
        ///</summary>
        public static DataGridView dgv(DataGridView grilla, string consulta)
        {
            //if (consulta != null)
            //{
            //    #region 
            //    MySqlConnection condet = bdcomun.Conexion();
            //    MySqlCommand comandodet = condet.CreateCommand();
            //    comandodet.CommandText = consulta;
            //    //comandodet.ExecuteNonQuery();
            //    DataTable tdatos = new DataTable();
            //    MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, condet);
            //    adapter.Fill(tdatos);
            //    grilla.DataSource = tdatos;
            //    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //    grilla.AutoResizeColumns();
            //    grilla.AllowUserToResizeColumns = true;
            //    grilla.AllowUserToOrderColumns = true;
            //    grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //    libreria.alternacolorfila(ref grilla);
            //    #endregion
            //}
            return grilla;
        }

        ///<summary>
        ///Genera un archivo dbf en funcion a una consulta en mysql
        ///Parametros: "consulta"> consulta mysql
        ///            "path"> path de conf.xml
        ///</summary>
        public static void mysqladbf(string consulta)
        {
            SaveFileDialog grabaarch = new SaveFileDialog();
            grabaarch.Title = "Graba un DBF";
            grabaarch.ShowDialog();
            if (grabaarch.FileName != "")
            {
                string pathdbf = grabaarch.FileName;
                string nombre = pathdbf;
                string[] words = pathdbf.Split('\\');
                nombre = "anotac";
                foreach (string word in words)
                {
                    nombre = word;
                }
                pathdbf = pathdbf.Remove(pathdbf.IndexOf(nombre), nombre.Length);
                MySqlConnection con = bdcomun.Conexion();
                DataTable dt = bdcomun.leereg(consulta, con, "");
                OleDbConnection cnn = dbfcomun.Conexion(pathdbf);
                int creg = dbfcomun.creadbfdesdetabla(dt, nombre, cnn);
                //int creg = dbfcomun.cargadbfdesdetabla(dt, "carrer", cnn);
                con.Dispose();
                cnn.Close();
                libreria.MessageBoxTemporal.Show("Cantidad reg " + creg.ToString(), "Informa wscpalermo", 2, true);
            }
        }

    }
}
