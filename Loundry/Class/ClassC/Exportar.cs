using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Loundry
{
    class Exportar
    {

        //Exporta Datagridview a Archivo de Excel
        public void ExportarDataGridViewExcel(DataGridView grd,string archivo)
        {
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = archivo;
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =(Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

    
                    int indicecolumna = 0;
                    foreach (DataGridViewColumn col in grd.Columns)
                    {
                        indicecolumna++;
                        hoja_trabajo.Cells[1, indicecolumna] = col.Name;
                    }
                    int indicefila = 0;
                    foreach (DataGridViewRow row in grd.Rows)
                    {
                        indicefila++;
                        indicecolumna = 0;
                        foreach (DataGridViewColumn col in grd.Columns)
                        {
                            indicecolumna++;
                            hoja_trabajo.Cells[indicefila + 1, indicecolumna] = row.Cells[col.Name].Value;
                        }
                    }

                    /*
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < grd.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i+1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    */
                    libros_trabajo.SaveAs(fichero.FileName,Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}


