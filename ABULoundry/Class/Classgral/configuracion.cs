using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Loundry
{
    class configuracion
    {
        public static void BotonFlat(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is Button)
                {
                    Button btn = item as Button;

                    btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
                }
            }
        }
        public static string titulomensaje()
        {
            return "Informa Loundry";
        }

        public static void mensaje(string mens)
        {
            libreria.MessageBoxTemporal.Show(mens, configuracion.titulomensaje(), 1, false);
        }
        public static string archxml(string archivo)
        {
            string pre = "c:\\sracsharp\\re\\sdl3\\";
            archivo = pre + archivo;
            return archivo;
        }

        public static void tabcontrol(TabControl tc)
        {
            int t = tc.TabPages.Count;
            for (int i = 0; i < t; i++)
            {
                if ((i % 2) == 0)
                    tc.TabPages[i].BackColor = Color.WhiteSmoke;
                else
                    tc.TabPages[i].BackColor = Color.Lavender; // Color.MintCream;
                tc.TabPages[i].BorderStyle = BorderStyle.Fixed3D;

            }
        }
        public static void grupobox(GroupBox gpb)
        {
            gpb.BackColor = Color.MediumSeaGreen;
        }

        /// <summary>
        /// cambia nombre de columnas
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="campos"></param>
        /// <param name="nombres"></param>
        public static void dgvocultacolumna(ref DataGridView dgv, string[] campos, string[] nombres)
        {
            for (int i = 0; i < campos.Length; i++)
            {
                string campo = campos[i].ToString();
                dgv.Columns[campo].HeaderText = nombres[i].ToString();
            }
        }
        /// <summary>
        /// Oculta columnas del datagridview
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="campos"></param>
        public static void dgvocultacolumna(ref DataGridView dgv, string[] campos)
        {
            for (int i = 0; i < campos.Length; i++)
                dgv.Columns[campos[i].ToString()].Visible = false;
        }

        /// <summary>
        /// Cofigura datagridview permitiendo mostrar o no los nombres de columnas, tamanio de letra y ocultar titulo de una columna 
        /// </summary>
        /// <param name="dgv">dgv</param>
        /// <param name="columna">vacio o nombre columna</param>
        /// <param name="fontsize">entero</param>
        /// <param name="cabecera">bool</param>
        /// <returns></returns>
        /// 
        public static DataGridView confdgv(DataGridView dgv, string columna, int fontsize, bool cabecera)
        {
            try
            {
                //dgv.RowTemplate.Height = alto;

                dgv.GridColor = Color.Black;
                dgv.RowHeadersVisible = false;

                if (cabecera)
                    dgv.ColumnHeadersVisible = true;
                else
                    dgv.ColumnHeadersVisible = false;
                if (columna != string.Empty)
                    dgv.Columns[columna].HeaderText = " ";
                dgv.ScrollBars = ScrollBars.Both;
                dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                dgv.DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Regular);  //todas las celdas
                dgv.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.DefaultCellStyle.Font = new Font("Arial", fontsize, FontStyle.Bold);
                dgv.ClearSelection();
                dgv.AllowUserToAddRows = false;

                //dgv.AutoResizeColumns();
                //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch
            {
                libreria.MessageBoxTemporal.Show("confdgv2", "configuracion", 1, true);
            }
            return dgv;
        }
        /// <summary>
        /// Define alto de fila datagridview sin cabecera
        /// </summary>
        /// <param name="dgv"></param>
        public static void AdjustGridViewHeight(ref DataGridView dgv)
        {
            try
            {
                int rowNumbers = dgv.RowCount - 2;
                dgv.Height = (dgv.ColumnHeadersHeight + (dgv.RowTemplate.Height * (rowNumbers + 1)));
            }
            catch
            {
                libreria.MessageBoxTemporal.Show("ajust", "configuracion", 1, true);
            }
        }
        /// <summary>
        /// define el alto de cada fila del datagridview sin la cabecera
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="alto">alto de fila</param>
        public static void Altocelda(ref DataGridView dgv, int alto, int menos)
        {
            try
            {
                int rowNumbers = dgv.RowCount - menos;
                dgv.Height = (dgv.ColumnHeadersHeight + (rowNumbers * alto));
            }
            catch
            {
                libreria.MessageBoxTemporal.Show("ajust", "configuracion", 1, true);
            }
        }
        public static void Altocelda(ref DataGridView dgv, int alto, int menos, string asegura)
        {
            try
            {
                int rowNumbers = dgv.RowCount - menos;
                dgv.Height = (dgv.ColumnHeadersHeight + (rowNumbers * alto));
            }
            catch
            {
                libreria.MessageBoxTemporal.Show("ajust", "configuracion", 1, true);
            }
        }

        /// <summary>
        /// configura listview
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static ListView conflstv(ListView lst)
        {
            string tj;
            lst.OwnerDraw = false;
            lst.View = View.Details;
            //lst.GridLines = true;
            lst.ForeColor = Color.White;
            lst.BackColor = Color.Black;
            lst.HeaderStyle = ColumnHeaderStyle.None; //oculta header
            lst.Font = new Font("Arial", 11, FontStyle.Bold);

            int i = lst.Items.Count;
            lst.Height = i * 23;

            //cambia color filas
            for (int k = 0; k < lst.Items.Count; k++)
            {
                if ((k % 2) == 0)
                    lst.Items[k].BackColor = Color.Blue;
                else
                    lst.Items[k].BackColor = Color.Black;
            }

            for (int f = 0; f < lst.Items.Count; f++)
            {
                tj = lst.Items[f].SubItems[3].Text;
                Color fondo = lst.Items[f].BackColor;

                switch (tj)
                {
                    case "2":
                        lst.Items[f].UseItemStyleForSubItems = false;
                        lst.Items[f].SubItems[1].ForeColor = Color.Yellow;
                        break;
                    case "3":
                        lst.Items[f].UseItemStyleForSubItems = false;
                        lst.Items[f].SubItems[1].ForeColor = Color.DarkGreen;
                        break;
                    case "4":
                        lst.Items[f].UseItemStyleForSubItems = false;
                        lst.Items[f].SubItems[1].ForeColor = Color.DarkRed;
                        break;
                    default:
                        //lst.Items[f].SubItems[1].ForeColor = Color.LightGray;
                        break;
                }
                lst.Items[f].SubItems[1].BackColor = fondo;
                lst.Items[f].SubItems[2].BackColor = fondo;
                lst.Items[f].SubItems[3].BackColor = fondo;
            }

            return lst;
        }
    }

}
