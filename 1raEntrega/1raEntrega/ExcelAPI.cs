using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace _1raEntrega
{
    class ExcelAPI
    {

        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        object misValue;

        public ExcelAPI(string titulo)
        {
            misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        }



        public void completarTablas(double[,] tabla1, double[,] tabla2)
        {
            //Completa tabla de numeros aleatorios
            xlWorkSheet.Range["D1:H1"].Merge();
            xlWorkSheet.Range["D1:H1"].Value = "Chi Cuadrado";
            xlWorkSheet.Range["D1:H1"].Font.Size = 15;
            xlWorkSheet.Range["D1:H1"].HorizontalAlignment = HorizontalAlignment.Center;

            xlWorkSheet.Cells[3, 1] = "N";
            xlWorkSheet.Cells[3, 2] = "Aleatorio";

            for (int i = 0; i < tabla1.GetLength(1); i++)
            {
                xlWorkSheet.Cells[i + 4, "A"] = i + 1;
                xlWorkSheet.Cells[i + 4, "B"] = tabla1[0, i];
            }

            //Formatea los campos numericos a 4 decimales
            xlWorkSheet.Range["B:B"].NumberFormat = "0.0000";
            xlWorkSheet.Range["E:E"].NumberFormat = "0.0000";
            xlWorkSheet.Range["F:F"].NumberFormat = "0.0000";

            //cabecera de la tabla
            xlWorkSheet.Cells[3, 5] = "Mínimo";
            xlWorkSheet.Cells[3, 6] = "Máximo";
            xlWorkSheet.Cells[3, 7] = "O(i)";
            xlWorkSheet.Cells[3, 8] = "E(i)";
            xlWorkSheet.Cells[3, 9] = "(O-E)^2/E";

            //Cargamos los datos
            for (int i = 0; i < tabla2.GetLength(1); i++)
            {
                xlWorkSheet.Cells[i + 4, "D"] = i + 1;
                xlWorkSheet.Cells[i + 4, "E"] = tabla2[0, i];
                xlWorkSheet.Cells[i + 4, "F"] = tabla2[1, i];
                xlWorkSheet.Cells[i + 4, "G"] = tabla2[2, i];
                xlWorkSheet.Cells[i + 4, "H"] = tabla2[3, i];
                xlWorkSheet.Cells[i + 4, "I"] = tabla2[4, i];
            }

            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("H3", "I13");
            chartPage.HasTitle = true;
            chartPage.ChartTitle.Caption = "Chi Cuadrado de los Números Aleatorios Generados";

            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            chartPage.HasLegend = true;
            chartPage.ShowDataLabelsOverMaximum = true;


            //Crea Excel 



            //xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlApp.Visible = true;
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

        }
        
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        } 
        
    }
}