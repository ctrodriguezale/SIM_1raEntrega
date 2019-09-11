using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TablaChi;

namespace LibreriaSimulacion
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

        public void exportarTablaExponencial(Fila[] tabla, double mediaObservada, double desvObservada, int cantNum, double lambda, int intervalos)
        {
            try
            {
                double cantNumeros= Convert.ToDouble(cantNum);
                double chi = 0.0;
                double sumaChi = 0.0;
                SetNewCurrentCulture();

                //Crea el titulo
                xlWorkSheet.Range["A3:F3"].Merge();
                xlWorkSheet.Range["A3:F3"].Font.Size = 20;
                xlWorkSheet.Range["A3:F3"].Value = "Distribución Exponencial Negativa";
                xlWorkSheet.Range["A3:M4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A3:M4"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A5:A" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["B5:B" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["C5:C" + (5 + intervalos)].EntireColumn.NumberFormat = "0.000";
                xlWorkSheet.Range["D5:D" + (5 + intervalos)].EntireColumn.NumberFormat = "0";
                xlWorkSheet.Range["E5:E" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["F5:F" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                //Crea las cabeceras
                xlWorkSheet.Range["A4:M4"].Font.Size = 8;
                xlWorkSheet.Cells[4, "A"] = "Limite inferior";
                xlWorkSheet.Cells[4, "B"] = "Limite superior";
                //xlWorkSheet.Cells[4, "C"] = "Marca de clase";
                xlWorkSheet.Cells[4, "D"] = "Frecuencia";
               // xlWorkSheet.Cells[4, "E"] = "Frecuencia Relativa";
                xlWorkSheet.Cells[4, "E"] = "F. Esperada Dist. Exp. Negativa";
                xlWorkSheet.Cells[4, "F"] = "F. Chi Cua. Dist. Exp. Negativa";

                // obtencion de parametros para distribuciones falta calcular estos parametros en base a datos del archivo ingresado

                for (int i = 0; i < tabla.Length; i++)
                {
                    xlWorkSheet.Cells[i + 5, "A"] = tabla[i].LimiteInferior;
                    xlWorkSheet.Cells[i + 5, "B"] = tabla[i].LimiteSuperior;
                    xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                    xlWorkSheet.Cells[i + 5, "D"] = tabla[i].Frecuencia;
                   // xlWorkSheet.Cells[i + 5, "E"] = tabla[i].Frecuencia / cantNumeros;

                    //distribuciones esperadas
                    double observado = tabla[i].Frecuencia;

                    double esperadoExpo = ProbDistrExpo(lambda, tabla[i].LimiteSuperior, tabla[i].LimiteInferior) * cantNumeros;

                    xlWorkSheet.Cells[i + 5, "E"] = esperadoExpo;

                    // calculo de valores de chi cuadrado
                    chi = Math.Pow(observado - esperadoExpo, 2) / esperadoExpo;
                    xlWorkSheet.Cells[i + 5, "F"] = chi;
                    sumaChi = sumaChi + chi;

                }
                //muestra Sumatorias Chi cuadrado
                xlWorkSheet.Cells[5, "H"] = "Sumatoria x^2";
                xlWorkSheet.Cells[5, "I"] = sumaChi;
                TablaChi.Class1 chi2 = new Class1();
                xlWorkSheet.Cells[6, "H"] = "Valor x^2";
                xlWorkSheet.Cells[6, "I"] = chi2.ValorChi2(0.95, intervalos, 1);


                //xlWorkSheet.Cells[6, "I"].Formula="CHISQ.INV.RT(0,05;"+(intervalos-2)+")"; //"11.07";
                //xlWorkSheet.Cells[6, "H"] = "Valor de la Tabla";

                //Crea el grafico


                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(20, 120, 400, 300);
                Excel.Chart chartPage = myChart.Chart;

                int inter = 4 + intervalos;
            
                chartRange = xlWorkSheet.get_Range("C4", "E" + inter);
                chartPage.HasTitle = true;
                chartPage.ChartTitle.Caption = "Frecuencia Observada Vs. Frecuencia Esperada";

                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
               // chartPage.HasAxis = xlWorkSheet.Range["C5:C" + (5 + intervalos)];
                chartPage.HasLegend = true;
                chartPage.ShowDataLabelsOverMaximum = true;

            }
            finally
            {
                ResetCurrentCulture();
            }
        }

        public void exportarTablaUniforme(Fila[] tabla, int cantNum, double valorA, double valorB, int intervalos)
        {
            try
            {
                double cantNumeros = Convert.ToDouble(cantNum);
                double chi = 0.0;
                double sumaChi = 0.0;
                SetNewCurrentCulture();

                //Crea el titulo
                xlWorkSheet.Range["A3:F3"].Merge();
                xlWorkSheet.Range["A3:F3"].Font.Size = 20;
                xlWorkSheet.Range["A3:F3"].Value = "Distribución Uniforme";
                xlWorkSheet.Range["A3:M4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A3:M4"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A5:A" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["B5:B" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["C5:C" + (5 + intervalos)].EntireColumn.NumberFormat = "0.000";
                xlWorkSheet.Range["D5:D" + (5 + intervalos)].EntireColumn.NumberFormat = "0";
                xlWorkSheet.Range["E5:E" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["F5:F" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                //Crea las cabeceras
                xlWorkSheet.Range["A4:M4"].Font.Size = 8;
                xlWorkSheet.Cells[4, "A"] = "Limite inferior";
                xlWorkSheet.Cells[4, "B"] = "Limite superior";
                //xlWorkSheet.Cells[4, "C"] = "Marca de clase";
                xlWorkSheet.Cells[4, "D"] = "Frecuencia";
                // xlWorkSheet.Cells[4, "E"] = "Frecuencia Relativa";
                xlWorkSheet.Cells[4, "E"] = "F. Esperada Dist. Uniforme";
                xlWorkSheet.Cells[4, "F"] = "F. Chi Cua. Dist. Exp. Negativa";

                // obtencion de parametros para distribuciones falta calcular estos parametros en base a datos del archivo ingresado

                for (int i = 0; i < tabla.Length; i++)
                {
                    xlWorkSheet.Cells[i + 5, "A"] = tabla[i].LimiteInferior;
                    xlWorkSheet.Cells[i + 5, "B"] = tabla[i].LimiteSuperior;
                    xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                    xlWorkSheet.Cells[i + 5, "D"] = tabla[i].Frecuencia;
                    // xlWorkSheet.Cells[i + 5, "E"] = tabla[i].Frecuencia / cantNumeros;

                    //distribuciones esperadas
                    double observado = tabla[i].Frecuencia;

                    double esperadoExpo = ProbDistrUniforme(valorA, valorB, tabla[i].LimiteSuperior, tabla[i].LimiteInferior) * cantNumeros;

                    xlWorkSheet.Cells[i + 5, "E"] = esperadoExpo;

                    // calculo de valores de chi cuadrado
                    chi = Math.Pow(observado - esperadoExpo, 2) / esperadoExpo;
                    xlWorkSheet.Cells[i + 5, "F"] = chi;
                    sumaChi = sumaChi + chi;

                }
                //muestra Sumatorias Chi cuadrado
                xlWorkSheet.Cells[5, "H"] = "Sumatoria x^2";
                xlWorkSheet.Cells[5, "I"] = sumaChi;
                TablaChi.Class1 chi2 = new Class1();
                xlWorkSheet.Cells[6, "H"] = "Valor x^2";
                xlWorkSheet.Cells[6, "I"] = chi2.ValorChi2(0.95, intervalos, 2);


                //xlWorkSheet.Cells[6, "I"].Formula="CHISQ.INV.RT(0,05;"+(intervalos-2)+")"; //"11.07";
                //xlWorkSheet.Cells[6, "H"] = "Valor de la Tabla";

                //Crea el grafico


                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(20, 120, 400, 300);
                Excel.Chart chartPage = myChart.Chart;

                int inter = 4 + intervalos;

                chartRange = xlWorkSheet.get_Range("C4", "E" + inter);
                chartPage.HasTitle = true;
                chartPage.ChartTitle.Caption = "Frecuencia Observada Vs. Frecuencia Esperada";

                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
                // chartPage.HasAxis = xlWorkSheet.Range["C5:C" + (5 + intervalos)];
                chartPage.HasLegend = true;
                chartPage.ShowDataLabelsOverMaximum = true;

            }
            finally
            {
                ResetCurrentCulture();
            }
        }

        public void exportarTablaNormal(Fila[] tabla, int cantNum, double media, double desviacion, int intervalos)
        {
            try
            {
                double cantNumeros = Convert.ToDouble(cantNum);
                double chi = 0.0;
                double sumaChi = 0.0;
                SetNewCurrentCulture();

                //Crea el titulo
                xlWorkSheet.Range["A3:F3"].Merge();
                xlWorkSheet.Range["A3:F3"].Font.Size = 20;
                xlWorkSheet.Range["A3:F3"].Value = "Distribución Normal";
                xlWorkSheet.Range["A3:M4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A3:M4"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A5:A" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["B5:B" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["C5:C" + (5 + intervalos)].EntireColumn.NumberFormat = "0.000";
                xlWorkSheet.Range["D5:D" + (5 + intervalos)].EntireColumn.NumberFormat = "0";
                xlWorkSheet.Range["E5:E" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["F5:F" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                //Crea las cabeceras
                xlWorkSheet.Range["A4:M4"].Font.Size = 8;
                xlWorkSheet.Cells[4, "A"] = "Limite inferior";
                xlWorkSheet.Cells[4, "B"] = "Limite superior";
                //xlWorkSheet.Cells[4, "C"] = "Marca de clase";
                xlWorkSheet.Cells[4, "D"] = "Frecuencia";
                // xlWorkSheet.Cells[4, "E"] = "Frecuencia Relativa";
                xlWorkSheet.Cells[4, "E"] = "F. Esperada Dist. Normal";
                xlWorkSheet.Cells[4, "F"] = "Chi Cua. Dist. Normal";
                

                for (int i = 0; i < tabla.Length; i++)
                {
                    xlWorkSheet.Cells[i + 5, "A"] = tabla[i].LimiteInferior;
                    xlWorkSheet.Cells[i + 5, "B"] = tabla[i].LimiteSuperior;
                    xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                    xlWorkSheet.Cells[i + 5, "D"] = tabla[i].Frecuencia;
                    // xlWorkSheet.Cells[i + 5, "E"] = tabla[i].Frecuencia / cantNumeros;

                    //distribuciones esperadas
                    double observado = tabla[i].Frecuencia;

                    double normalEsperado= ProbDistrNormal(media, desviacion, tabla[i].LimiteSuperior, tabla[i].LimiteInferior) * cantNumeros;

                    xlWorkSheet.Cells[i + 5, "E"] = normalEsperado;

                    // calculo de valores de chi cuadrado
                    chi = Math.Pow(observado - normalEsperado, 2) / normalEsperado;
                    xlWorkSheet.Cells[i + 5, "F"] = chi;
                    sumaChi = sumaChi + chi;

                }
                //muestra Sumatorias Chi cuadrado
                xlWorkSheet.Cells[5, "H"] = "Sumatoria Chi-Cuadrado";
                xlWorkSheet.Cells[5, "I"] = sumaChi;
                TablaChi.Class1 chi2 = new Class1();
                xlWorkSheet.Cells[6, "H"] = "Valor x^2";
                xlWorkSheet.Cells[6, "I"] = chi2.ValorChi2(0.95, intervalos, 2);



                //Crea el grafico


                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(20, 120, 400, 300);
                Excel.Chart chartPage = myChart.Chart;

                int inter = 4 + intervalos;

                chartRange = xlWorkSheet.get_Range("C4", "E" + inter);
                chartPage.HasTitle = true;
                chartPage.ChartTitle.Caption = "Frecuencia Observada Vs. Frecuencia Esperada";

                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
                // chartPage.HasAxis = xlWorkSheet.Range["C5:C" + (5 + intervalos)];
                chartPage.HasLegend = true;
                chartPage.ShowDataLabelsOverMaximum = true;

            }
            finally
            {
                ResetCurrentCulture();
            }
        }

        public void exportarTablaPoisson(Fila[] tabla, int cantNum, double lambda, int intervalos)
        {
            try
            {
                double cantNumeros = Convert.ToDouble(cantNum);
                double chi = 0.0;
                double sumaChi = 0.0;
                SetNewCurrentCulture();

                //Crea el titulo
                xlWorkSheet.Range["A3:F3"].Merge();
                xlWorkSheet.Range["A3:F3"].Font.Size = 20;
                xlWorkSheet.Range["A3:F3"].Value = "Distribución Poisson";
                xlWorkSheet.Range["A3:M4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A3:M4"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].Font.Bold = true;
                xlWorkSheet.Range["H5:I5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A5:A" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["B5:B" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["C5:C" + (5 + intervalos)].EntireColumn.NumberFormat = "0.000";
                xlWorkSheet.Range["D5:D" + (5 + intervalos)].EntireColumn.NumberFormat = "0";
                xlWorkSheet.Range["E5:E" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                xlWorkSheet.Range["F5:F" + (5 + intervalos)].EntireColumn.NumberFormat = "00.0000";
                //Crea las cabeceras
                xlWorkSheet.Range["A4:M4"].Font.Size = 8;
                xlWorkSheet.Cells[4, "A"] = "Limite inferior";
                xlWorkSheet.Cells[4, "B"] = "Limite superior";
                //xlWorkSheet.Cells[4, "C"] = "Marca de clase";
                xlWorkSheet.Cells[4, "D"] = "Frecuencia";
                // xlWorkSheet.Cells[4, "E"] = "Frecuencia Relativa";
                xlWorkSheet.Cells[4, "E"] = "F. Esperada Dist. Poisson";
                xlWorkSheet.Cells[4, "F"] = "F. Chi Cua. Dist. Poisson";

                // obtencion de parametros para distribuciones falta calcular estos parametros en base a datos del archivo ingresado

                for (int i = 0; i < tabla.Length; i++)
                {
                    xlWorkSheet.Cells[i + 5, "A"] = tabla[i].LimiteInferior;
                    xlWorkSheet.Cells[i + 5, "B"] = tabla[i].LimiteSuperior;
                    xlWorkSheet.Cells[i + 5, "C"] = tabla[i].conocerMedia();
                    xlWorkSheet.Cells[i + 5, "D"] = tabla[i].Frecuencia;
                    // xlWorkSheet.Cells[i + 5, "E"] = tabla[i].Frecuencia / cantNumeros;

                    //distribuciones esperadas
                    double observado = tabla[i].Frecuencia;

                    double esperadoPoisson = ProbDistrPoisson(lambda, tabla[i].LimiteSuperior, tabla[i].LimiteInferior) * cantNumeros;

                    xlWorkSheet.Cells[i + 5, "E"] = esperadoPoisson;

                    // calculo de valores de chi cuadrado
                    chi = Math.Pow(observado - esperadoPoisson, 2) / esperadoPoisson;
                    xlWorkSheet.Cells[i + 5, "F"] = chi;
                    sumaChi = sumaChi + chi;

                }
                xlWorkSheet.Cells[intervalos + 2, "E"] = 0;
                xlWorkSheet.Cells[intervalos + 3, "E"] = 0;
                xlWorkSheet.Cells[intervalos + 4, "E"] = 0;
                //muestra Sumatorias Chi cuadrado
                xlWorkSheet.Cells[5, "H"] = "Sumatoria x^2";
                xlWorkSheet.Cells[5, "I"] = sumaChi;
                TablaChi.Class1 chi2 = new Class1();
                xlWorkSheet.Cells[6, "H"] = "Valor x^2";
                xlWorkSheet.Cells[6, "I"] = chi2.ValorChi2(0.95, intervalos, 1);

                //xlWorkSheet.Cells[6, "I"].Formula="CHISQ.INV.RT(0,05;"+(intervalos-2)+")"; //"11.07";
                //xlWorkSheet.Cells[6, "H"] = "Valor de la Tabla";

                //Crea el grafico


                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(20, 120, 400, 300);
                Excel.Chart chartPage = myChart.Chart;

                int inter = 4 + intervalos;

                chartRange = xlWorkSheet.get_Range("C4", "E" + inter);
                chartPage.HasTitle = true;
                chartPage.ChartTitle.Caption = "Frecuencia Observada Vs. Frecuencia Esperada";

                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
                // chartPage.HasAxis = xlWorkSheet.Range["C5:C" + (5 + intervalos)];
                chartPage.HasLegend = true;
                chartPage.ShowDataLabelsOverMaximum = true;

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

        public double ProbDistrExpo(double lambda, double limSup, double limInf)
        {
            double resultado;
            double a = 1 - Math.Pow(Math.E, (-lambda * limSup));
            double b = 1 - Math.Pow(Math.E, (-lambda * limInf));
            return resultado = a - b;
        }

        public double ProbDistrUniforme(double valorA, double valorB, double limSup, double limInf)
        {
            double resultado;
            double a = (limSup - valorA) / (valorB - valorA); ;
            double b = (limInf- valorA) / (valorB - valorA); ;
            return resultado = a - b;
        }

        public double CummulitiveDistributionFunction(int k, double lambda)
        {
            double e = Math.Pow(Math.E, (double)-lambda);
            int i = 0;
            double sum = 0.0;
            while (i <= k)
            {
                double n = Math.Pow((double)lambda, i) / Factorial(i);
                sum += n;
                i++;
            }
            double cdf = e * sum;
            return cdf;
        }

        private int Factorial(int k)
        {
            int count = k;
            int factorial = 1;
            while (count >= 1)
            {
                factorial = factorial * count;
                count--;
            }
            return factorial;
        }

        public double ProbDistrPoisson(double lambda, double limSup, double limInf)
        {
            double resultado;
            double a = 0;
            double b = 0;
            int superior = Convert.ToInt32(limSup);
            int inferior = Convert.ToInt32(limInf);
          
            b = CummulitiveDistributionFunction(superior, lambda);
            a = CummulitiveDistributionFunction(inferior, lambda);
            return resultado = b-a;
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

    }
    }