using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


///<summary>
///Conexion a dbf.
///</summary>
namespace Loundry
{
    public class dbfcomun
    {
        ///<summary> Genera conexion a dbf. </summary>
        ///<return>Devuelve la conexion</return>
        ///<param name="path">Ruta del dbf a leer.</param>
        public static OleDbConnection Conexion(string path)
        {
            string sBase = path;
            string sConn;
            //sConn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + sBase + ";Extended Properties=dBASE IV; User ID=;Password=";
            //sConn = "Provider=VFPOLEDB.1; Data Source=" + sBase ; 
            sConn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + sBase + "; Extended Properties = dBASE III; User ID = ;";

            //sConn = "Provider=VFPOLEDB.1;Data Source=" + sBase + ";";
            OleDbConnection conectar = new OleDbConnection();
            conectar.ConnectionString = sConn;
            try
            {
                conectar.Open();
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.ToString());
            }
            return conectar;
        }

        ///<summary>Ejecuta una consulta sobre un archivo dbf.</summary>
        ///<return>Retorna cantidad de registros afectados</return>
        ///<param name="consulta">Query a la base de datos.</param>
        ///<param name="path">Ruta del dbf a leer.</param>
        ///<remarks>El método solo abre y cierra la conexión</remarks>
        public static int ejecuta(string consulta, string path)
        {
            int creg = 0;
            OleDbConnection conn = dbfcomun.Conexion(path);
            OleDbCommand comandodet = conn.CreateCommand();
            comandodet.CommandText = consulta;
            creg = comandodet.ExecuteNonQuery();
            conn.Close();
            return creg;
        }

        ///<summary>Carga datos al Datagridview</summary>
        ///<return>Retorna el Datagridview</return>
        ///<param name="grilla">Datagridview.</param>
        ///<param name="consulta">Consulta a la base de datos</param>
        ///<param name="columna">columna a la que se le cambia el color</param>
        ///<param name="condet">conector de base de datos</param>
        public static DataGridView dgv(DataGridView grilla, string consulta, string columna, OleDbConnection condet)
        {
            if (consulta != null)
            {
                #region planilla
                OleDbCommand comandodet = condet.CreateCommand();
                comandodet.CommandText = consulta;
                comandodet.ExecuteNonQuery();
                DataTable tdatos = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, condet);
                adapter.Fill(tdatos);
                grilla.DataSource = tdatos;
                #endregion
            }
            return grilla;
        }

        ///<summary>Lee registros de una dbf</summary>
        ///<return>Retorna el/los registros leidos (oledbdatareader)</return>
        ///<param name="consulta">Query a realizar a la base de datos dbf</param>
        ///<param name="condet">conexion a la base de datos</param>
        ///<remarks>Se debe realizar la conexión antes del método y cerrarla posteriormente  </remarks>
        public static OleDbDataReader leereg(string consulta, OleDbConnection condet)
        {
            #region sesscard
            OleDbCommand comandodet = condet.CreateCommand();
            comandodet.CommandText = consulta;
            OleDbDataReader reg = comandodet.ExecuteReader();
            //tomo la fecha para filtrar el xmldetalle
            #endregion
            return reg;
        }

        /// <summary>Crea y carga datos a un dbf en funcion del contenido de un datatable</summary>
        /// <param name="dt">DataTable.</param>
        /// <param name="tabladbf">El nombre del archivo DBF que se desea crear.</param>
        /// <param name="cnn">Connection oledb.</param>
        /// <returns>Retorna cantidad de registros insertados</returns>
        /// <remarks></remarks>
        public static int creadbfdesdetabla(DataTable dt, string tabladbf, OleDbConnection cnn)
        {
            StringBuilder consulta = new StringBuilder(256);
            string[] tdato = new string[dt.Columns.Count];
            try
            {
                #region crea dbf
                consulta.Append("CREATE TABLE " + tabladbf + "(");
                int elto = 0;
                foreach (DataColumn dc in dt.Columns)
                {
                    string xx = dt.Rows[0].ItemArray[elto].ToString();
                    consulta.Append(tipodedatodbf(dc, xx));
                    tdato[elto] = tipodedatodbf(dc, xx);
                    elto++;
                }
                // Reemplazo la última coma por el cierre de paréntesis
                consulta.Replace(",", ")", consulta.Length - 1, 1);

                //OleDbConnection conn = dbfcomun.Conexion(path);
                OleDbCommand comandodet = cnn.CreateCommand();
                comandodet.CommandText = consulta.ToString();
                comandodet.ExecuteNonQuery();
                #endregion
                //
                #region insertar registros
                StringBuilder consinsertar = new StringBuilder(256);
                StringBuilder consvalue = new StringBuilder(256);
                consinsertar.Append("insert into " + tabladbf + " (");
                consvalue.Append(" Values (");
                foreach (DataColumn dc in dt.Columns)  //nombres de campo
                {
                    consinsertar.Append(dc.ColumnName + ",");
                    consvalue.Append("?,");
                }
                consinsertar.Replace(",", ")", consinsertar.Length - 1, 1);
                consvalue.Replace(",", ")", consvalue.Length - 1, 1);
                consinsertar.Append(consvalue.ToString());

                //
                string aux = string.Empty;
                string fecha = string.Empty;
                int r = 0;
                for (r = 0; r < dt.Rows.Count; r++)
                {
                    comandodet.Parameters.Clear();
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        aux = dt.Rows[r].ItemArray[c].ToString();

                        if (aux == string.Empty)
                        {
                            if (tdato[c].IndexOf("Numeric") >= 0)
                            {
                                aux = "0";
                            }
                            else
                            {
                                if (tdato[c].IndexOf("Date") >= 0)
                                {
                                    aux = DateTime.Now.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                        comandodet.Parameters.AddWithValue("p" + r.ToString(), aux);
                    }
                    comandodet.CommandText = consinsertar.ToString();
                    comandodet.ExecuteNonQuery();
                }
                #endregion
                return r;

                /*//
                comandodet.CommandText = String.Format("SELECT * FROM [{0}]", tableName);

                OleDbDataAdapter da = new OleDbDataAdapter(comandodet);
                da.Fill(dt);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                cb.QuotePrefix = "[";
                cb.QuoteSuffix = "]";
                da.InsertCommand = cb.GetInsertCommand();
                cnn.Close();
                return da.Update(dt);
                */ //
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.ToString());
                return 0;
            }
            finally
            {
                consulta = null;
            }
        }

        /// <summary>Metodo complemento de creadbfdesdetabla</summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private static string tipodedatodbf(DataColumn dc, string xx)
        {
            //Dim columnName As String = dc.ColumnName
            string columnName = dc.ColumnName;
            string tipodato = string.Empty;
            string aux = xx.ToString();
            Int32 maxLength = aux.Length * 2;
            if (aux.Length > 30)
                maxLength = 254;
            else
                maxLength = aux.Length * 2;

            aux = Convert.ToString(maxLength);
            switch (dc.DataType.Name)
            {
                case "varchar":
                case "String":
                    tipodato = "Char(" + aux + ")";
                    maxLength = dc.MaxLength;
                    break;
                case "DateTime":
                case "MySqlDateTime":
                case "Date":
                    tipodato = "Date"; // "datetime";
                    maxLength = dc.MaxLength;
                    break;
                case "Decimal":
                case "Double":
                    tipodato = "Numeric(10,2)";
                    maxLength = dc.MaxLength;
                    break;
                case "Int16":
                case "UInt16":
                case "Int32":
                case "UInt32":
                case "Int64":
                case "UInt64":
                    tipodato = "Numeric(10)";//"bigint";
                    maxLength = dc.MaxLength;
                    break;
                default:
                    if (dc.MaxLength == 536870910)
                    {
                        tipodato = "Memo";
                    }
                    else
                    {
                        tipodato = "Char(" + aux + ")";  // "nvarchar";
                        maxLength = dc.MaxLength;
                    }
                    break;
            }
            if (maxLength > 0)
                return String.Format("[{0}] {1} ({2}),", columnName, tipodato, maxLength);
            else
                return String.Format("[{0}] {1},", columnName, tipodato);
        }

        private static string GetDataTypeSql(DataColumn dc)
        {
            //Dim columnName As String = dc.ColumnName
            string columnName = dc.ColumnName;
            string tipodato = string.Empty;
            Int32 maxLength = 0;
            switch (dc.DataType.Name)
            {
                case "Boolean":
                    tipodato = "bit";
                    break;
                case "Byte":
                    tipodato = "tinyint";
                    break;
                case "SByte":
                    tipodato = "tinyint";
                    break;
                case "Char":
                    tipodato = "nchar";
                    maxLength = dc.MaxLength;
                    break;
                case "DateTime":
                    tipodato = "datetime";
                    break;
                case "Decimal":
                    tipodato = "decimal (18, 2)";
                    break;
                case "Double":
                    tipodato = "real";
                    break;
                case "Int16":
                    tipodato = "smallint";
                    break;
                case "UInt16":
                    tipodato = "smallint";
                    break;
                case "Int32":
                    tipodato = "int";
                    break;
                case "UInt32":
                    tipodato = "int";
                    break;
                case "Int64":
                    tipodato = "bigint";
                    break;
                case "UInt64":
                    tipodato = "bigint";
                    break;
                case "Object":
                    tipodato = "image";
                    break;
                case "Byte[]":
                    tipodato = "image";
                    break;
                case "Single":
                    tipodato = "float";
                    break;
                default:
                    if (dc.MaxLength == 536870910)
                    {
                        tipodato = "memo";
                    }
                    else
                    {
                        tipodato = "nvarchar";
                        maxLength = dc.MaxLength;
                    }
                    break;
            }
            if (maxLength > 0)
                return String.Format("[{0}] {1} ({2}),", columnName, tipodato, maxLength);
            else
                return String.Format("[{0}] {1},", columnName, tipodato);
        }

        public static int cargadbfdesdetabla(DataTable dt, string tabladbf, OleDbConnection cnn)
        {
            StringBuilder consulta = new StringBuilder(256);
            string[] tdato = new string[dt.Columns.Count];
            int elto = 0;
            try
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    string xx = dt.Rows[0].ItemArray[elto].ToString();
                    consulta.Append(tipodedatodbf(dc, xx));
                    tdato[elto] = tipodedatodbf(dc, xx);
                    elto++;
                }

                OleDbCommand comandodet = cnn.CreateCommand();
                //
                #region insertar registros
                StringBuilder consinsertar = new StringBuilder(256);
                StringBuilder consvalue = new StringBuilder(256);
                consinsertar.Append("insert into " + tabladbf + " (");
                consvalue.Append(" Values (");
                foreach (DataColumn dc in dt.Columns)  //nombres de campo
                {
                    consinsertar.Append(dc.ColumnName + ",");
                    consvalue.Append("?,");
                }
                consinsertar.Replace(",", ")", consinsertar.Length - 1, 1);
                consvalue.Replace(",", ")", consvalue.Length - 1, 1);
                consinsertar.Append(consvalue.ToString());

                //
                string aux = string.Empty;
                string fecha = string.Empty;
                int r = 0;

                #region insertar sin parametros
                /*
                for (r = 0; r < dt.Rows.Count; r++)
                {
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        if (dt.Rows[r].ItemArray[c] == null)
                            aux = "";
                        else
                            aux = dt.Rows[r].ItemArray[c].ToString();

                        if (tdato[c].IndexOf("Numeric") >= 0)
                        {
                            aux=aux.Replace(',' , '.' );
                        }
                        if (tdato[c].IndexOf("Date") >= 0)
                        {
                            fecha = dt.Rows[r].ItemArray[0].ToString().Substring(0, 10);
                            aux = fecha;
                        }
                        if (aux == string.Empty)
                        {
                            if (tdato[c].IndexOf("Numeric") >= 0)
                            {
                                aux = "0";
                            }
                            else
                            {
                                if (tdato[c].IndexOf("Date") >= 0)
                                {
                                    aux = fecha;
                                }
                            }
                        }
                        if (tdato[c].IndexOf("Numeric") >= 0)
                           consinsertar.Append(aux+",");
                        else
                           consinsertar.Append("'" + aux + "',");
                    }
                    consinsertar.Replace(",", ")", consinsertar.Length - 1, 1);
                    comandodet.CommandText = consinsertar.ToString();
                    comandodet.ExecuteNonQuery();
                }
                */
                #endregion

                #region insertar con parametros
                for (r = 0; r < dt.Rows.Count; r++)
                {
                    comandodet.Parameters.Clear();
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        if (dt.Rows[r].ItemArray[c] == null)
                            aux = "";
                        else
                            aux = dt.Rows[r].ItemArray[c].ToString();
                        if (tdato[c].IndexOf("Date") >= 0)
                        {
                            fecha = dt.Rows[r].ItemArray[0].ToString().Substring(0, 10);
                            aux = fecha;
                        }
                        if (aux == string.Empty)
                        {
                            if (tdato[c].IndexOf("Numeric") >= 0)
                            {
                                aux = "0";
                            }
                            else
                            {
                                if (tdato[c].IndexOf("Date") >= 0)
                                {
                                    aux = fecha;
                                }
                            }
                        }
                        comandodet.Parameters.AddWithValue("p" + r.ToString(), aux);
                    }
                    comandodet.CommandText = consinsertar.ToString();
                    comandodet.ExecuteNonQuery();
                }
                #endregion

                #endregion
                return r;
            }
            catch (OleDbException e)
            {
                MessageBox.Show(e.ToString());
                return 0;
            }
            finally
            {
                consulta = null;
            }
        }

    }
}
