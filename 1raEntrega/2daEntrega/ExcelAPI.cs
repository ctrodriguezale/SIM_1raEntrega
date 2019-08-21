using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace _2daEntrega
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

        public void abrirArchivo(string pathFile)
        {
            xlWorkBook.OpenLinks(pathFile, false);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        }

        public int[] obtenerObservaciones(int Observacion)
        {
            int[] valores = new int[200];
            Excel.Range rangoObservaciones = xlWorkSheet.Range["B3:B203"];

            for (int i = 0; i < 200; i++)
            {
                valores[i] = xlWorkSheet.Cells.Value["B" + (i + 3)];
            }

            return valores;
        }

        public void exportarTabla(Fila[] tabla)
        {

            //Crea el titulo
            xlWorkSheet.Range["A3:F3"].Merge();
            xlWorkSheet.Range["A3:F3"].Font.Size = 20;
            xlWorkSheet.Range["A3:F3"].Value = "Distribuciones de frecuencias";
            xlWorkSheet.Range["A3:F4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            xlWorkSheet.Range["A3:F4"].Font.Bold = true;
            //Crea las cabeceras
            xlWorkSheet.Range["A4:F4"].Font.Size = 16;
            xlWorkSheet.Cells[4, "A"] = "Limite inferior";
            xlWorkSheet.Cells[4, "B"] = "Limite superior";
            xlWorkSheet.Cells[4, "C"] = "Marca de clase";
            xlWorkSheet.Cells[4, "D"] = "Frecuencia";
            for (int i = 0; i < tabla.Length; i++)
            {
                xlWorkSheet.Cells[i + 5, "A"] = tabla[i].limiteInferior;
                xlWorkSheet.Cells[i + 5, "B"] = tabla[i].limiteSuperior;
                xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                xlWorkSheet.Cells[i + 5, "D"] = tabla[i].frecuencia;
            }
        }

        public void generarHistograma(int intervalos)
        {
            Excel.Range rangoValores;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            //Rango de valores del grafico
            rangoValores = xlWorkSheet.get_Range("D5", "D" + (intervalos + 5));
        }

    }
}
