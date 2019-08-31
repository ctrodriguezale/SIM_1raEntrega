using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _3raEntrega
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

        System.Globalization.CultureInfo oldCI;
        //get the old CurrenCulture and set the new, en-US
        void SetNewCurrentCulture()
        {
            oldCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        //reset Current Culture back to the originale
        void ResetCurrentCulture()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI;
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

        public void exportarTabla(Fila[] tabla, double mediaObservada, double desvObservada)
        {
            try
            {
                SetNewCurrentCulture();

                //Crea el titulo
                xlWorkSheet.Range["A3:F3"].Merge();
                xlWorkSheet.Range["A3:F3"].Font.Size = 20;
                xlWorkSheet.Range["A3:F3"].Value = "Distribuciones de Frecuencias";
                xlWorkSheet.Range["A3:M4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A3:M4"].Font.Bold = true;
                xlWorkSheet.Range["A5:M12"].NumberFormat = "00.0000";
                //Crea las cabeceras
                xlWorkSheet.Range["A4:M4"].Font.Size = 8;
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

                for (int i = 0; i < tabla.Length; i++)
                {
                    xlWorkSheet.Cells[i + 5, "A"] = tabla[i].LimiteInferior;
                    xlWorkSheet.Cells[i + 5, "B"] = tabla[i].LimiteSuperior;
                    xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                    xlWorkSheet.Cells[i + 5, "D"] = tabla[i].Frecuencia;
                    xlWorkSheet.Cells[i + 5, "E"] = tabla[i].Frecuencia / 200.0;

                    //distribuciones esperadas
                    double observado = tabla[i].Frecuencia;
                    double esperadoUniforme = 200.0 / 7.0;
                    double esperadoNormal = ProbDistrNormal(mediaObservada, desvObservada, tabla[i].LimiteSuperior, tabla[i].LimiteInferior) * 200.0;
                    double esperadoExpo = ProbDistrExpo(mediaObservada, tabla[i].LimiteSuperior, tabla[i].LimiteInferior) * 200.0;
                    xlWorkSheet.Cells[i + 5, "G"] = esperadoUniforme;
                    xlWorkSheet.Cells[i + 5, "H"] = esperadoNormal;
                    xlWorkSheet.Cells[i + 5, "I"] = esperadoExpo;

                    // calculo de valores de chi cuadrado
                    xlWorkSheet.Cells[i + 5, "K"] = Math.Pow(observado - esperadoUniforme, 2) / esperadoUniforme;
                    xlWorkSheet.Cells[i + 5, "L"] = Math.Pow(observado - esperadoNormal, 2) / esperadoNormal;
                    xlWorkSheet.Cells[i + 5, "M"] = Math.Pow(observado - esperadoExpo, 2) / esperadoExpo;

                }
                //muestra Sumatorias Chi cuadrado
                xlWorkSheet.Cells[12, "K"].Formula = "=SUM(K5:K11)";
                xlWorkSheet.Cells[12, "L"].Formula = "=SUM(L5:L11)";
                xlWorkSheet.Cells[12, "M"].Formula = "=SUM(M5:M11)";
                xlWorkSheet.Cells[12, "N"] = "Sumatoria Chi Cuadrado";

                //muestra resultado funcion INV.CHICUAD.CD de excel con intervalos igual a 7 y grados de libertas igual a 0,005
                // ya que estos valos res no se modifican los resultados obtenidos a travez la funcion son los mismos	 9,49 	 11,07 
                xlWorkSheet.Cells[13, "K"] = "9.49";
                xlWorkSheet.Cells[13, "L"] = "9.49";
                xlWorkSheet.Cells[13, "M"] = "11.07";
                xlWorkSheet.Cells[13, "N"] = "Valor de la Tabla";
            }
            finally
            {
                ResetCurrentCulture();
            }
        }

        public void mostrar()
        {
            xlApp.Visible = true;
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

        public double ProbDistrNormal(double media, double desviacion, double limSup, double limInf)
        {
            Chart chart = new Chart();
            double zetaSup = (limSup - media) / desviacion;
            double zetaInf = (limInf - media) / desviacion;
            double probabilidad = chart.DataManipulator.Statistics.NormalDistribution(zetaSup);
            probabilidad -= chart.DataManipulator.Statistics.NormalDistribution(zetaInf);
            return probabilidad;
        }


        public double ProbDistrExpo(double media, double limSup, double limInf)
        {
            double resultado;
            double lambda = 1 / media;
            double a = 1 - Math.Pow(Math.E, (-lambda * limSup));
            double b = 1 - Math.Pow(Math.E, (-lambda * limInf));
            return resultado = a - b;
        }


    }
}