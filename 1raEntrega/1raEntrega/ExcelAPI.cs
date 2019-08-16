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



        public void completarTablas(double[] aleatorios, double[,] frecuencias, double chi,int intervalos)
        {
            //Completa tabla de numeros aleatorios
            xlWorkSheet.Range["D1:H1"].Merge();
            xlWorkSheet.Range["D1:H1"].Value = "Chi Cuadrado";
            xlWorkSheet.Range["D1:H1"].Font.Size = 15;
            xlWorkSheet.Range["D1:H1"].HorizontalAlignment = HorizontalAlignment.Center;

            xlWorkSheet.Cells[3, 1] = "N";
            xlWorkSheet.Cells[3, 2] = "Aleatorio";

            //Formatea los campos numericos a 4 decimales
            xlWorkSheet.Range["B:B"].NumberFormat = "0.0000";
            xlWorkSheet.Range["E:E"].NumberFormat = "0.0000";
            xlWorkSheet.Range["F:F"].NumberFormat = "0.0000";

            for (int i = 0; i < aleatorios.Length; i++)
            {
                xlWorkSheet.Cells[i + 4, "A"] = i + 1;
                xlWorkSheet.Cells[i + 4, "B"] = aleatorios[i];
            }

            //cabecera de la tabla
            xlWorkSheet.Cells[3, 5] = "Mínimo";
            xlWorkSheet.Cells[3, 6] = "Máximo";
            xlWorkSheet.Cells[3, 7] = "O(i)";
            xlWorkSheet.Cells[3, 8] = "E(i)";
            xlWorkSheet.Cells[3, 9] = "(O-E)^2/E";

            //Cargamos los datos
            for (int i = 0; i < frecuencias.GetLength(1); i++)
            {
                xlWorkSheet.Cells[i + 4, "D"] = i + 1;
                xlWorkSheet.Cells[i + 4, "E"] = frecuencias[0, i];
                xlWorkSheet.Cells[i + 4, "F"] = frecuencias[1, i];
                xlWorkSheet.Cells[i + 4, "G"] = frecuencias[2, i];
                xlWorkSheet.Cells[i + 4, "H"] = frecuencias[3, i];
                xlWorkSheet.Cells[i + 4, "I"] = frecuencias[4, i];
            }
            //Coloca el resultado final
            xlWorkSheet.Cells[frecuencias.GetLength(1) + 4, "H"].value = "X^2";
            xlWorkSheet.Cells[frecuencias.GetLength(1) + 4, "I"].value = chi;



            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            int inter = 3 + intervalos;

            chartRange = xlWorkSheet.get_Range("G3", "H"+inter);
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