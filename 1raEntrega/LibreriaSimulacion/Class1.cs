using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace LibreriaSimulacion
{
    public class DistribucionUniforme
    {
    }

    public class DistribucionNormal
    {
    }

    public class DistribucionExponencial
    {
        List<double> listaVariables;
        Estadistica tabla;


        public DistribucionExponencial()
        {
            listaVariables = new List<double>();
            tabla = null;
        }

        public static double GenerarAleatorio()
        {
            Random aleatorio = new Random(); 
            return aleatorio.NextDouble();
        }

        public double generarVariablesAleatorias(double lambda)
        {
            double varAleatoria;
                //numAleatorio = GenerarAleatorio();
                varAleatoria = (-1.0 / lambda) * Math.Log(1 - GenerarAleatorio());
            return varAleatoria;
        }

        public List<double> generarListaVariablesAleatorias(int cantNumeros, double lambda)
        {

            List<double> listaVarAleatoria = new List<double>();

            //=(-1/VarLambda)*LN(1-nuAaleatorio)
            for (int i = 0; i < cantNumeros; i++)
            {
                listaVarAleatoria.Add(generarVariablesAleatorias(lambda));
                Thread.Sleep(15);
            }
            return listaVarAleatoria;
        }

        public void visualizarDatos(List<double> lista, int intervalos, int lambda, int cantNum)
        {
            try
            {
                double minimo, maximo;
                ExcelAPI excel = new ExcelAPI("");
                //abrimos el archivo y extraemos los datos
                listaVariables = lista ;
                minimo = listaVariables.Min();
                maximo = listaVariables.Max();
                //contabilizamos las frecuencias
                tabla = new Estadistica(intervalos, minimo, maximo);
                tabularDatos();
                //generamos el histograma
                excel.exportarTablaExponencial(tabla.ListaFilas, calcularMedia(lambda), calcularDesviacion(lambda), cantNum, lambda, intervalos);
                excel.mostrar();
            }
            catch (Exception e)
            {
                //pantalla.MostrarError("Error: " + e.Message);
            }
        }

        private void tabularDatos()
        {
            //distribuye los valores en los intervalos
            foreach (var variable in listaVariables)
            {
                tabla.agregarObservacion(variable);
            }
        }

        public double calcularDesviacion(int lambda)
        {
            return 1 / Math.Pow(lambda, 2);
        }

        public double calcularMedia(int lamda)
        {
            return 1 / lamda;
        }
    }

    public class DistribucionPoisson
    {
    }
}
