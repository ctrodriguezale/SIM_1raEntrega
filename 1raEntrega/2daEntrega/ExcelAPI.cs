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
            xlWorkSheet.Range["A4:M4"].Font.Size = 16;
            xlWorkSheet.Cells[4, "A"] = "Limite inferior";
            xlWorkSheet.Cells[4, "B"] = "Limite superior";
            xlWorkSheet.Cells[4, "C"] = "Marca de clase";
            xlWorkSheet.Cells[4, "D"] = "Frecuencia";
            xlWorkSheet.Cells[4, "E"] = "Frecuencia Relativa";
            xlWorkSheet.Cells[4, "G"] = "F. Esperada Distr. Uniforme";
            xlWorkSheet.Cells[4, "H"] = "F. Esperada Distr. Normal";
            xlWorkSheet.Cells[4, "I"] = "F. Esperada Dist. Exp. Negativa";
            xlWorkSheet.Cells[4, "K"] = "F. Chi Cua. Distr. Uniforme";
            xlWorkSheet.Cells[4, "L"] = "F. Chi Cua. Distr. Normal";
            xlWorkSheet.Cells[4, "M"] = "F. Chi Cua. Dist. Exp. Negativa";

            // obtencion de parametros para distribuciones falta calcular estos parametros en base a datos del archivo ingresado

            //Media = (max + min) / 2

            //Varianza = (max + min) ^2 / 12

            //Lamda = 1/media

            double sumUniforme = 0, sumNormal = 0, sumExpoNegativa = 0;

            for (int i = 0; i < tabla.Length; i++)
            {
                xlWorkSheet.Cells[i + 5, "A"] = tabla[i].LimiteInferior;
                xlWorkSheet.Cells[i + 5, "B"] = tabla[i].LimiteSuperior;
                xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                xlWorkSheet.Cells[i + 5, "D"] = tabla[i].Frecuencia;
                xlWorkSheet.Cells[i + 5, "E"] = tabla[i].obtenerFrecRelativa();

                //distribuciones esperadas
                xlWorkSheet.Cells[i + 5, "G"] = 200/7;
                // falta realizar el calculo de las distribuciones esparedas para la normal y exponencial negativa
                xlWorkSheet.Cells[i + 5, "H"] = "= (DISTR.NORM.N(E14; Media; desviacion; 1)-DISTR.NORM.N(D14; Media; desviacion; 1))*200";
                xlWorkSheet.Cells[i + 5, "I"] = "= (DISTR.EXP.N(E14; Lambda;1)-DISTR.EXP.N(D14; Lamda;1)) * 200";

                // calculo de valores de chi cuadrado
                xlWorkSheet.Cells[i + 5, "K"] = Math.Pow(xlWorkSheet.Cells[i + 5, "D"] - xlWorkSheet.Cells[i + 5, "G"], 2) / xlWorkSheet.Cells[i + 5, "G"];
                xlWorkSheet.Cells[i + 5, "L"] = Math.Pow(xlWorkSheet.Cells[i + 5, "D"] - xlWorkSheet.Cells[i + 5, "H"], 2) / xlWorkSheet.Cells[i + 5, "H"];
                xlWorkSheet.Cells[i + 5, "M"] = Math.Pow(xlWorkSheet.Cells[i + 5, "D"] - xlWorkSheet.Cells[i + 5, "I"], 2) / xlWorkSheet.Cells[i + 5, "I"];

                // Sumatoria Chi Cuadrado
                sumUniforme = sumUniforme + xlWorkSheet.Cells[i + 5, "K"];
                sumNormal = sumNormal + xlWorkSheet.Cells[i + 5, "L"];
                sumExpoNegativa = sumExpoNegativa + xlWorkSheet.Cells[i + 5, "M"];
            }

            int ultimaFila = tabla.Length;
            //muestra Sumatorias Chi cuadrado
            xlWorkSheet.Cells[ultimaFila + 5, "K"] = sumUniforme;
            xlWorkSheet.Cells[ultimaFila + 5, "L"] = sumNormal;
            xlWorkSheet.Cells[ultimaFila + 5, "M"] = sumExpoNegativa;
            // muestra Sumatoria funcion INV.CHICUAD.CD de excel con intervalos igual a 7
            xlWorkSheet.Cells[ultimaFila + 6, "K"] = "=INV.CHICUAD.CD(0,05;(7 - 2 - 1))";
            xlWorkSheet.Cells[ultimaFila + 6, "L"] = "=INV.CHICUAD.CD(0,05;(7 - 2 - 1))";
            xlWorkSheet.Cells[ultimaFila + 6, "M"] = "=INV.CHICUAD.CD(0,05;(7 - 1 - 1))";
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
