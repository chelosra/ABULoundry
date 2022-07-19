using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Loundry
{
    public class libreriabase
    {
        /// <summary>
        /// Devuelve nuevo codigo de registro incrementandolo en 1
        /// </summary>
        /// <param name="consulta">select de la base orden desc con campo a incrementar</param>
        /// <param name="campocodigo">campo a incrementar</param>
        /// <param name="largorelleno">ceros a completar a la izquierda</param>
        /// <returns></returns>
        public static string newreg(string consulta, string campocodigo, int largorelleno)
        {
            string aux = string.Empty;
            MySqlConnection conectar = bdcomun.Conexion();
            //string consulta = "Select * from rubros order by crubro desc limit 1";
            MySqlDataReader reg = bdcomun.leereg(consulta, conectar);
            if (reg.HasRows)
            {
                reg.Read();
                aux = Convert.ToString(Convert.ToInt64(reg[campocodigo].ToString()) + 1);
                aux = libreria.rellena(aux, largorelleno);
            }
            else
            {
                aux = "0";
                aux = Convert.ToString(Convert.ToInt64(aux) + 1);
                aux = libreria.rellena(aux, largorelleno);
            }
            reg.Close();
            return aux;
        }

        /// <summary>
        /// Carga un combobox desde una tabla 
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="campo">si se quiere dos campos separarlos por semicolon</param>
        /// <param name="tablamysql"></param>
        /// <param name="primeroenblanco">verdadero para primer item en blanco</param>
        public static void cargabox(ref ComboBox combo, string campo, string tablamysql, bool primeroenblanco)
        {
            string[] kampos = campo.Split(';');
            int cant = kampos.Count();
            combo.Items.Clear();
            if (primeroenblanco)
                combo.Items.Add("");
            MySqlConnection condet = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from " + tablamysql, condet);
            while (reg.Read())
            {
                switch (cant)
                {
                    case 1:
                        combo.Items.Add(reg[kampos[0]].ToString());
                        break;
                    case 2:
                        combo.Items.Add(reg[kampos[0]].ToString() + "-" + reg[kampos[1]].ToString());
                        break;
                }

            }
            combo.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            reg.Close();
            condet.Close();
        }

        public static void cargabox2(ref ComboBox combo, string campo, ref ComboBox comboc, string campoc, string tablamysql, bool primeroenblanco, string orden)
        {
            if (orden == string.Empty)
                orden = campo;
            combo.Items.Clear();
            comboc.Items.Clear();
            if (primeroenblanco)
            {
                combo.Items.Add("");
                comboc.Items.Add("");
            }
            MySqlConnection condet = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from " + tablamysql + " order by " + orden, condet);
            while (reg.Read())
            {
                combo.Items.Add(reg[campo].ToString());
                comboc.Items.Add(reg[campoc].ToString());
            }
            combo.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            reg.Close();
            condet.Close();
        }

        public static void cargabox2filtrada(ref ComboBox combo, string campo, ref ComboBox comboc, string campoc, string tablamysql, string campofiltro, string filtro)
        {
            combo.Items.Clear();
            comboc.Items.Clear();
            combo.Items.Add("");
            comboc.Items.Add("");
            MySqlConnection condet = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from " + tablamysql + " where " + campofiltro + "='" + filtro + "' order by " + campo, condet);
            while (reg.Read())
            {
                combo.Items.Add(reg[campo].ToString());
                comboc.Items.Add(reg[campoc].ToString());
            }
            combo.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            reg.Close();
            condet.Close();
        }

        public static bool existexcampo(string campobase, string dato, string tablamysql)
        {
            bool retorna = false;
            MySqlConnection condet = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg("select * from " + tablamysql + " where " + campobase + "='" + dato + "'", condet);
            if (reg.HasRows)
                retorna = true;
            else
                retorna = false;
            reg.Close();
            condet.Close();
            return retorna;
        }

        ///<summary>
        ///verifica si existe una consulta
        ///</summary>
        public static bool existe(string consulta)
        {
            bool retorna = false;
            MySqlConnection condet = bdcomun.Conexion();
            MySqlDataReader reg = bdcomun.leereg(consulta, condet);
            if (reg.HasRows)
                retorna = true;
            else
                retorna = false;
            reg.Close();
            condet.Close();
            return retorna;
        }

        #region backup
        public static void BackupDeTablas(string tabla, ToolStripProgressBar pgb)
        {
            string[] veccampos = camposbase(tabla).Split('/');
            string[] tipocampos = camposbasetipo(tabla).Split('/');
            string campos = nombrecamposainsertar(veccampos);
            string consulta1 = "SELECT * FROM " + tabla;
            MySqlConnection cn1 = bdcomun.Conexion(0);
            MySqlDataReader reg = bdcomun.leereg(consulta1, cn1);
            if (reg.HasRows)
            {
                string consulta2 = "insert into " + tabla + " " + campos + " value ";
                bool bandera = true;
                while (reg.Read())
                {
                    if (bandera)
                    {
                        consulta2 += "(";
                        bandera = false;
                    }
                    else
                        consulta2 += "),(";
                    consulta2 += libreriabase.datosainsertar(veccampos, tipocampos, reg);
                }
                consulta2 += ")";
                bdcomun.ejecuta("truncate " + tabla);
                bdcomun.ejecuta(consulta2);
            }
            pgb.Value++;
        }

        /// <summary>
        /// obtiene nombre de campos de una tabla
        /// </summary>
        /// <param name="xbase"></param>
        /// <returns></returns>
        private static string camposbase(string xbase)
        {
            string nombrecampo = string.Empty;
            string tipo = string.Empty;
            string consulta = "DESCRIBE " + xbase;
            MySqlConnection cn = bdcomun.Conexion(0);
            MySqlDataReader reg = bdcomun.leereg(consulta, cn);
            while (reg.Read())
            {
                nombrecampo += reg["Field"].ToString() + "/";
                tipo += reg["Type"].ToString() + "/";
            }
            return nombrecampo;
        }
        private static string camposbasetipo(string xbase)
        {
            string nombrecampo = string.Empty;
            string tipo = string.Empty;
            string consulta = "DESCRIBE " + xbase;
            MySqlConnection cn = bdcomun.Conexion(0);
            MySqlDataReader reg = bdcomun.leereg(consulta, cn);
            while (reg.Read())
                tipo += reg["Type"].ToString() + "/";
            return tipo;
        }

        private static string nombrecamposainsertar(string[] veccampos)
        {
            string campos = string.Empty;
            for (int i = 0; i < veccampos.Length - 1; i++)
            {
                if (i == 0)
                    campos += "(" + veccampos[i].ToString();
                else
                    campos += ", " + veccampos[i].ToString();
            }
            campos += ")";
            return campos;
        }

        private static string datosainsertar(string[] veccampos, string[] tipocampos, MySqlDataReader reg)
        {
            string datos = string.Empty;
            for (int i = 0; i < veccampos.Length - 1; i++)
            {
                string xdat = string.Empty;
                bool sincomillas = false;
                switch (tipocampos[i].ToString())
                {
                    case "date":
                        if (reg[veccampos[i].ToString()].ToString() == "")
                        {
                            xdat = "NULL";
                            sincomillas = true;
                        }
                        else
                            xdat = libreria.fechaamysql(reg[veccampos[i].ToString()].ToString());
                        break;
                    default:
                        if (reg[veccampos[i].ToString()].ToString() == "")
                        {
                            xdat = "NULL";
                            sincomillas = true;
                        }
                        else
                            xdat = reg[veccampos[i].ToString()].ToString();
                        break;
                }

                if (i == 0)
                    if (sincomillas)
                        datos += xdat;
                    else
                        datos += "'" + xdat + "'";
                else
                    if (sincomillas)
                    datos += "," + xdat;
                else
                    datos += ", '" + xdat + "'";
            }
            return datos;
        }

        public static void backupUsb(ToolStripProgressBar pgb)
        {
            bool rta = false;
            DialogResult dialogo = MessageBox.Show("Coloque el Pendrive y active MySql",
                                                   "Continúa?", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
                rta = true;
            if (rta)
            {
                pgb.Visible = true;
                pgb.Maximum = 18;
                pgb.Value = 0;
                //pgb.Style = ProgressBarStyle.Blocks;
                //pgb.MarqueeAnimationSpeed = 50;

                libreriabase.BackupDeTablas("afipconceptofactura", pgb);
                libreriabase.BackupDeTablas("afipcondiva", pgb);
                libreriabase.BackupDeTablas("afiptipodocclie", pgb);
                libreriabase.BackupDeTablas("afiptipoform", pgb);
                libreriabase.BackupDeTablas("afiptiporesponsable", pgb);
                //libreriabase.BackupDeTablas("auxcheques",pgb);
                //libreriabase.BackupDeTablas("auxmovimiento",pgb);
                //libreriabase.BackupDeTablas("auxmovimiento3",pgb);
                libreriabase.BackupDeTablas("productos", pgb);
                libreriabase.BackupDeTablas("caja", pgb);
                //libreriabase.BackupDeTablas("cheques",pgb);
                libreriabase.BackupDeTablas("cliente", pgb);
                //libreriabase.BackupDeTablas("configuracion",pgb);
                //libreriabase.BackupDeTablas("ctactecliente",pgb);
                libreriabase.BackupDeTablas("detcaja", pgb);
                //libreriabase.BackupDeTablas("documento",pgb);
                //libreriabase.BackupDeTablas("documentoenc",pgb);
                libreriabase.BackupDeTablas("empleados", pgb);
                //libreriabase.BackupDeTablas("factfinal",pgb);
                //libreriabase.BackupDeTablas("factproveedor",pgb);
                libreriabase.BackupDeTablas("formadepago", pgb);
                libreriabase.BackupDeTablas("formularios", pgb);
                libreriabase.BackupDeTablas("impfiscal", pgb);
                //libreriabase.BackupDeTablas("movimiento",pgb);
                libreriabase.BackupDeTablas("negocio", pgb);
                //libreriabase.BackupDeTablas("npedido",pgb);
                libreriabase.BackupDeTablas("proveedores", pgb);
                libreriabase.BackupDeTablas("ptoventa", pgb);
                libreriabase.BackupDeTablas("rubros", pgb);
                libreriabase.BackupDeTablas("usuario", pgb);
                pgb.Value = 0;
                pgb.Visible = false;
            }
        }
        #endregion
    }
}
