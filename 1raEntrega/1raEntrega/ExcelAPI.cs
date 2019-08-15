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
     //   private Application AppExcel;
       // private Workbook libro;
      //  private Worksheet hoja;

        public ExcelAPI(string titulo)
        {
            // Creamos un objeto Excel.
           /* AppExcel = default(Application);
            // Creamos un objeto WorkBook. Para crear el documento Excel.           
            libro = default(Workbook);
            // Creamos un objeto WorkSheet. Para crear la hoja del documento.
            hoja = default(Worksheet);
            //Instanciamos la aplicacion
            AppExcel = new Application();
            AppExcel.Visible = true;
            /* Ahora creamos un nuevo documento y seleccionamos la primera hoja del 
            * documento en la cual crearemos nuestro informe. 
            */
            // Creamos una instancia del Workbooks de excel.            
       /*     libro = AppExcel.Workbooks.Add();
            // Creamos una instancia de la primera hoja de trabajo de excel            
            hoja = libro.Worksheets[1];

            crearCabecera(titulo);*/
        }


    /*    public void crearCabecera(string titulo)
        {
            //Creamos el titulo
            hoja.Range["A1:E1"].Merge();
            hoja.Range["A1:E1"].Value = titulo;
            hoja.Range["A1:E1"].Font.Bold = true;
            // La cuarta línea signa un Size a titulo de 15.
            hoja.Range["A1:E1"].Font.Size = 15;

            Range celda = hoja.Range["A3",Type.Missing];
            celda.Value = "Orden";

            celda = hoja.Range["B3", Type.Missing];
            celda.Value = "Min";

            celda = hoja.Range["C3", Type.Missing];
            celda.Value = "Max";

            celda = hoja.Range["D3", Type.Missing];
            celda.Value = "O(i)";

            celda = hoja.Range["E3", Type.Missing];
            celda.Value = "E(i)";
        }
        */
        public void completarTabla(double[,] datos)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Range["A1:E1"].Merge();
            xlWorkSheet.Range["A1:E1"].Value = "Chi Cuadrado";
            xlWorkSheet.Range["A1:E1"].Font.Size = 15;
            xlWorkSheet.Range["A1:E1"].HorizontalAlignment = HorizontalAlignment.Center;

            xlWorkSheet.Cells[3, 2] = "Minimo";
            xlWorkSheet.Cells[3, 3] = "Maximo";
            xlWorkSheet.Cells[3, 4] = "Frecuencia";
            xlWorkSheet.Cells[3, 5] = "Esperado";
            xlWorkSheet.Cells[3, 6] = "Esperado";
            //xlWorkSheet.Cells[3, 6] = "Student3";

            for (int i = 0; i < datos.GetLength(1); i++)
            {
                xlWorkSheet.Cells[i+4, "A"] = i + 1;
                xlWorkSheet.Cells[i+4, "B"] = datos[0,i];
                xlWorkSheet.Cells[i+4, "C"] = datos[1,i];
                xlWorkSheet.Cells[i+4, "D"] = datos[2,i];
                xlWorkSheet.Cells[i+4, "E"] = datos[3,i];
                xlWorkSheet.Cells[i+4, "F"] = datos[4,i];
            }
            /*
            //add data 
            xlWorkSheet.Cells[1, 1] = "";
            xlWorkSheet.Cells[1, 2] = "Student1";
            xlWorkSheet.Cells[1, 3] = "Student2";
            xlWorkSheet.Cells[1, 4] = "Student3";

            xlWorkSheet.Cells[2, 1] = "Term1";
            xlWorkSheet.Cells[2, 2] = "80";
            xlWorkSheet.Cells[2, 3] = "65";
            xlWorkSheet.Cells[2, 4] = "45";

            xlWorkSheet.Cells[3, 1] = "Term2";
            xlWorkSheet.Cells[3, 2] = "78";
            xlWorkSheet.Cells[3, 3] = "72";
            xlWorkSheet.Cells[3, 4] = "60";

            xlWorkSheet.Cells[4, 1] = "Term3";
            xlWorkSheet.Cells[4, 2] = "82";
            xlWorkSheet.Cells[4, 3] = "80";
            xlWorkSheet.Cells[4, 4] = "65";

            xlWorkSheet.Cells[5, 1] = "Term4";
            xlWorkSheet.Cells[5, 2] = "75";
            xlWorkSheet.Cells[5, 3] = "82";
            xlWorkSheet.Cells[5, 4] = "68";
            */

            Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A3", "E13");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

       //     xlWorkBook.SaveAs("csharp.net-informations.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlApp.Visible = true;
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
    
        }
        //
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