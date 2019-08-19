using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2daEntrega
{
    class Estadistica
    {
        private Fila[] listaFilas;

        public Estadistica(int intervalos, double maximo, double minimo)
        {
            double limiteInferior;
            double limiteSuperior;
            double paso = (maximo - minimo) / intervalos;

            limiteInferior = minimo - (Math.Ceiling(paso) - paso)/2;
            limiteSuperior = minimo + paso;

            //Creamos la tabla
            listaFilas = new Fila[intervalos];
            //inicializacmos las filas
            for (int i = 0; i < intervalos; i++)
            {
                listaFilas[i] = new Fila(limiteInferior, limiteSuperior);
                limiteInferior = limiteSuperior;
                limiteSuperior = limiteInferior + paso;
            }


        }
        
        public void agregarObservacion(double observacion)
        {
            foreach (var fila in listaFilas)
            {
                if (fila.esDeIntervalo(observacion))
                {
                    fila.sumar();
                    break;
                }
            }
        }


    }
}
