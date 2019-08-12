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
        public static double generarAleatorioCongruencialMixto(ref int x, int a, int m, int c)
        {
            double aleatorio;

            //Calculo del numero aleatorio
            x = (a * x + c) % m;
            aleatorio = Math.Round((double)x/m, 4);
            
            return aleatorio;
        }

        //Metodo Multiplicativo para generar numeros aleatorios
        public static double generarAleatorioCongruencialMultiplicativo(ref int x, int a, int m)
        {
            double aleatorio;

            //Calculo del numero aleatorio
            x = (a * x) % m;
            aleatorio = Math.Round((double)x / m, 4);

            return aleatorio;
        }
    }
}
