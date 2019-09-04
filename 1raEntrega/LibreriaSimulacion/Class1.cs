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
   
        List<double> listaVariables;
        Estadistica tabla;


        public DistribucionUniforme()
        {
            listaVariables = new List<double>();
            tabla = null;
        }

        public static double GenerarAleatorio()
        {
            Random aleatorio = new Random();
            return aleatorio.NextDouble();
        }

        public double generarVariablesAleatorias(double valorA, double valorB)
        {
            double varAleatoria;
            // A + aleatorio * (B-A)
            
            varAleatoria = valorA + (GenerarAleatorio() * (valorB - valorA) );
            return varAleatoria;
        }

        public List<double> generarListaVariablesAleatorias(int cantNumeros, double valorA, double valorB)
        {

            List<double> listaVarAleatoria = new List<double>();

            
            for (int i = 0; i < cantNumeros; i++)
            {
                listaVarAleatoria.Add(generarVariablesAleatorias(valorA, valorB));
                Thread.Sleep(15);
            }
            return listaVarAleatoria;
        }

        public void visualizarDatos(List<double> lista, int intervalos, double valorA, double valorB, int cantNum)
        {
            try
            {
                double minimo, maximo;
                ExcelAPI excel = new ExcelAPI("");
                //abrimos el archivo y extraemos los datos
                listaVariables = lista;
                minimo = listaVariables.Min();
                maximo = listaVariables.Max();
                //contabilizamos las frecuencias
                tabla = new Estadistica(intervalos, minimo, maximo);
                tabularDatos();
                //generamos el histograma
                excel.exportarTablaUniforme(tabla.ListaFilas, cantNum, valorA, valorB, intervalos);
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
            //=(-1/VarLambda)*LN(1-nuAaleatorio)
            varAleatoria = (-1.0 / lambda) * Math.Log(1 - GenerarAleatorio());
            return varAleatoria;
        }

        public List<double> generarListaVariablesAleatorias(int cantNumeros, double lambda)
        {

            List<double> listaVarAleatoria = new List<double>();

            for (int i = 0; i < cantNumeros; i++)
            {
                listaVarAleatoria.Add(generarVariablesAleatorias(lambda));
                Thread.Sleep(15);
            }
            return listaVarAleatoria;
        }

        public void visualizarDatos(List<double> lista, int intervalos, double lambda, int cantNum)
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

        public double calcularDesviacion(double lambda)
        {
            return 1 / Math.Pow(lambda, 2);
        }

        public double calcularMedia(double lamda)
        {
            return 1 / lamda;
        }
    }

    public class DistribucionPoisson
    {
        List<double> listaVariables;
        Estadistica tabla;
        public List<double> generarListaVariablesAleatorias(int vueltas, int landa)
        {
            List<double> vector = new List<double>(); ;
            double x = 0;
            double h = 0;
            double y = 0;
            int i = 0;
            while (vueltas > i)
            {
                y = (-1.0 / landa) * Math.Log(1 - GenerarAleatorio());
                h = h + y;
                if (h > 1)
                {
                    vector.Add(x);
                    Thread.Sleep(15);
                    i++;
                    h = 0;
                    x = 0;
                }
                else
                {
                    x++;
                }
            }
            return vector;
        }
        public static double GenerarAleatorio()
        {
            Random aleatorio = new Random();
            return aleatorio.NextDouble();
        }
        public void visualizarDatos(List<double> lista, int intervalos, int lambda, int cantNum)
        {
            try
            {
                double minimo, maximo;
                ExcelAPI excel = new ExcelAPI("");
                //abrimos el archivo y extraemos los datos
                listaVariables = lista;
                minimo = listaVariables.Min();
                maximo = listaVariables.Max();
                //contabilizamos las frecuencias
                tabla = new Estadistica(intervalos, minimo, maximo);
                tabularDatos();
                //generamos el histograma
                excel.exportarTablaPoisson(tabla.ListaFilas, calcularMedia(lambda), calcularDesviacion(lambda), cantNum, lambda, intervalos);
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
            return Math.Sqrt(lambda); ;
        }

        public double calcularMedia(int lamda)
        {
            return lamda;
        }
    }
}
