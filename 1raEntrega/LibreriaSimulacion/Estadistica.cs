﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibreriaSimulacion
{
    class Estadistica
    {
        private Fila[] listaFilas;

        public Fila[] ListaFilas
        {
            get
            {
                return listaFilas;
            }
            set
            {
                this.listaFilas = value;
            }
        }


        public Estadistica(string nombreArchivo)
        {

        }

        public Estadistica(int intervalos, double minimo, double maximo)
        {
            double limiteInferior;
            double limiteSuperior;
            double paso = (maximo - minimo) / intervalos;
          
            //calculamos los valores para definir los intervalos
            paso = (maximo - minimo) / intervalos;
            limiteInferior = minimo;
            limiteSuperior = minimo + paso;
            //Creamos la tabla
            listaFilas = new Fila[intervalos];
            //inicializacmos las filas
            for (int i = 0; i < intervalos; i++)
            { 
                listaFilas[i] = new Fila(limiteInferior, limiteSuperior);
                limiteInferior = limiteSuperior;
                limiteSuperior = limiteInferior + paso + 0.00001;
            }
        }
        
        public void agregarObservacion(double variable)
        {
            //suma  una unidad en la lista de frecuencias si se encuentra dentro del intervalo
            foreach (var fila in listaFilas)
            {
                if (fila.esDeIntervalo(variable))
                {
                    fila.sumar();
                    break;
                }
            }
        }

        public double[] getMarcasClase()
        {
            double[] marcaClases = new double[listaFilas.Count()];
            int index = 0;
            foreach (var fila in listaFilas)
            {
                marcaClases[index] = fila.conocerMedia();
                index++;
            }
            
            return marcaClases;
        }

        public double[] getFrecuencias()
        {
            double[] frecuencias = new double[listaFilas.Count()];
            int index = 0;
            foreach (var fila in listaFilas)
            {
                frecuencias[index] = fila.Frecuencia;
                index++;
            }

            return frecuencias;
        }
    }
}
