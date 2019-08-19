using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2daEntrega
{
    class Fila
    {
        private double limiteInferior;
        private double limiteSuperior;
        private int frecuencia;

        public Fila(double limiteInferior, double limiteSuperior)
        {
            this.limiteInferior = limiteInferior;
            this.limiteSuperior = limiteSuperior;
            this.frecuencia = 0;
        }

        public double conocerMedia()
        {
            double media;
            media = (limiteSuperior + limiteInferior) / 2;
            return media;
        }

        public void sumar()
        {
            frecuencia++;
        }

        public Boolean esDeIntervalo(double aleatorio)
        {
            if ((aleatorio >= limiteInferior) && (aleatorio < limiteSuperior))
                return true;
            else
                return false;
        }
    }
}
