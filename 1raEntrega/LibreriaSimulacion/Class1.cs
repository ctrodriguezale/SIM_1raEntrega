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
        double x1;
        double x2 = 0;
        int primerValor = 0;

        public DistribucionUniforme()
        {
            listaVariables = new List<double>();
            tabla = null;
        }

        public double GenerarAleatorio()
        {
            if (primerValor == x2)
            {
                Random aleatorio = new Random();
                primerValor = aleatorio.Next(0, 9998);
                x1 = primerValor;
            }
            x2 = (67 * x1 + 71) % 9999;
            x1 = x2;
            return x2 / 10000;
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
        List<Double> variables;
        Estadistica tabla;
        Boolean ban = true;
        double x1;
        double x2 = 0;
        int primerValor = 0;

        public DistribucionNormal()
        {
            variables = new List<double>();
            tabla = null;
        }

        //public static double GenerarAleatorio()
        //{
        //    Random aleatorio = new Random();
        //    return aleatorio.NextDouble();
        //}
        //public static double GenerarAleatorioNuevo()
        //{
        //    Random aleatorio2 = new Random();
        //    return aleatorio2.NextDouble();
        //}

        public double GenerarAleatorio()
        {
            //if (primerValor == x2)
            //{
            //    Random aleatorio = new Random();
            //    primerValor = aleatorio.Next(0, 9998);
            while (primerValor == x2)
            {
                Random aleatorio = new Random();
                primerValor = aleatorio.Next(0, 9998);
                x1 = primerValor;
                Thread.Sleep(5);
            }
            //    x1 = primerValor;
            //}
            x2 = (67 * x1 + 71) % 9999;
            x1 = x2;
            return x2 / 10000;


        }


        public double generarVariableAleatoriaNormal(double media, double desviacion)
        {
            double varAleatoria;
            double aux;
            //double auxiliarParaAleatorio;
            //double auxiliarParaAleatorio2;


            //if (ban == true)
            //{

            //auxiliarParaAleatorio = GenerarAleatorio();
            //auxiliarParaAleatorio2 = GenerarAleatorioNuevo();
            //=RAIZ(-2*LN((random1)))*SENO((2*PI()*random2))

            aux = Math.Sqrt(-2 * Math.Log(GenerarAleatorio())) * Math.Sin(2 * Math.PI * (GenerarAleatorio()));
            //aleatoria = =normalmed+D7*normalvar

            varAleatoria = media + aux * Math.Sqrt(desviacion);
            ban = false;
            return varAleatoria;
            //}
            //else
            //{

            //    //auxiliarParaAleatorio = GenerarAleatorio();
            //    //auxiliarParaAleatorio2 = GenerarAleatorioNuevo();
            //    //=RAIZ(-2*LN((random1)))*SENO((2*PI()*random2))

            //    aux = Math.Sqrt(-2 * Math.Log(GenerarAleatorio())) * Math.Cos(2 * Math.PI * (GenerarAleatorio()));
            //    //aleatoria = =normalmed+D7*normalvar

            //    varAleatoria = media + aux * Math.Sqrt(desviacion);
            //    ban = true;

            //    return varAleatoria;

            //}




            //auxiliarParaAleatorio = GenerarAleatorio();
            //auxiliarParaAleatorio2 = GenerarAleatorioNuevo();
            ////=RAIZ(-2*LN((random1)))*SENO((2*PI()*random2))

            //aux = Math.Sqrt(-2 * Math.Log(auxiliarParaAleatorio)) * Math.Sin(2 * Math.PI * (auxiliarParaAleatorio2 + 1));
            ////aleatoria = =normalmed+D7*normalvar

            //varAleatoria = media + aux * Math.Sqrt(desviacion);

            //return varAleatoria;
        }


        public List<double> generarListaVariablesNormal(int cantNumeros, double media, double desviacion)
        {

            List<double> listaVarAleatoria = new List<double>();

            for (int i = 0; i < cantNumeros; i++)
            {
                listaVarAleatoria.Add(generarVariableAleatoriaNormal(media, desviacion));
                Thread.Sleep(15);
            }
            return listaVarAleatoria;
        }

        public void visualizarDatos(List<double> lista, int intervalos, double media, double desviacion, int cantNum)
        {
            try
            {
                double minimo, maximo;
                ExcelAPI excel = new ExcelAPI("");
                //abrimos el archivo y extraemos los datos
                variables = lista;
                minimo = variables.Min();
                maximo = variables.Max();
                //contabilizamos las frecuencias
                tabla = new Estadistica(intervalos, minimo, maximo);
                tabularDatos();
                //generamos el histograma
                excel.exportarTablaNormal(tabla.ListaFilas, cantNum, media, desviacion, intervalos);
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
            foreach (var variable in variables)
            {
                tabla.agregarObservacion(variable);
            }
        }
    }

    public class DistribucionExponencial
    {
        List<double> listaVariables;
        Estadistica tabla;
        double x1;
        double x2 = 0;
        int primerValor = 0;


        public DistribucionExponencial()
        {
            listaVariables = new List<double>();
            tabla = null;
        }

        public double GenerarAleatorio()
        {
            //Random aleatorio = new Random(); 
            //return aleatorio.NextDouble();
            if (primerValor == x2)
            {
                Random aleatorio = new Random();
                primerValor = aleatorio.Next(0, 9998);
                x1 = primerValor;
            }
            x2 = (67 * x1 + 71) % 9999;
            x1 = x2;
            return x2 / 10000;
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
        double x1;
        double x2 = 0;
        int primerValor = 0;

        public List<double> generarListaVariablesAleatorias(int vueltas, double landa)
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
        public double GenerarAleatorio()
        {
            //Random aleatorio = new Random();
            //return aleatorio.NextDouble();
            if (primerValor == x2)
            {
                Random aleatorio = new Random();
                primerValor = aleatorio.Next(0, 9998);
                x1 = primerValor;
            }
            x2 = (67 * x1 + 71) % 9999;
            x1 = x2;
            return x2 / 10000;

        }
        public void visualizarDatos(List<double> lista, int intervalos, double lambda, int cantNum)
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
                excel.exportarTablaPoisson(tabla.ListaFilas, cantNum, lambda, intervalos);
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
            return Math.Sqrt(lambda); ;
        }

        public double calcularMedia(double lamda)
        {
            return lamda;
        }
    }
}
