using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1raEntrega
{
    class Generador
    {
        //Generador de numeros aleatorios provisto por el Lenguaje
        public static List<double> GenerarAleatorios(int cantidad)
        {
            List<double> listaAleatorios = new List<double>();

            Random aleatorio = new Random(); ;

            for (int i = 0; i<cantidad; i++)
            {  
                listaAleatorios.Add(aleatorio.NextDouble());
            }

            return listaAleatorios;
        }

        //Metodo Congruencial Mixto para generar numeros aleatorios
        public static int calcularMetodoCongruencialMixto(int x, int a, int m, int c)
        {
            int resultado;

            //Calculo del numero aleatorio
            resultado = ((a * x + c) % m);

            return resultado;
        }

        //Metodo Multiplicativo para generar numeros aleatorios
        public static int calcularMetodoMutiplicativo(int x, int a, int m)
        {
            int resultado;

            //Calculo del numero aleatorio
            resultado = ((a * x) % m);

            return resultado;
        }

        public static double generarAleatorioCongruenteMixto(int x, int a, int m, int c)
        {
            double aleatorio;
            //Calcula el aleatorio y actualiza x al nuevo valor
            x = (a * x + c) % m;
            aleatorio = (double) x / m;


            return aleatorio;
        }

        public static double generarAleatorioCongruenteMultiplicativo(int x, int a, int m)
        {
            double aleatorio;
            //Calcula el aleatorio y actualiza x al nuevo valor
            x = (a * x) % m;
            aleatorio = (double)x / m;


            return aleatorio;
        }
    }
}
