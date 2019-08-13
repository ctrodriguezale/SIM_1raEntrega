﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1raEntrega
{
    public partial class TestChiCuadrado : Form
    {
        
        public TestChiCuadrado()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int x = (int)edtCantidad.Value;
            int intervalos = (int)edtIntervalos.Value;
            double[,] tablaFrecuencias;

            //Limpia la lista cada vez que se aprieta el boton generar
            lstAleatorios.Items.Clear();
            //Generamos un listado de numeros aleatorios
            List<double> listado = Generador.GenerarAleatorios(x);
            for (int i=0; i<listado.Count; i++)
            {
                lstAleatorios.Items.Add(listado[i]);
            }

            tablaFrecuencias = CalcularFrecuencias(listado, intervalos);
            ExcelAPI api = new ExcelAPI("Test Chi Cuadrado");
            api.completarTabla(tablaFrecuencias);
        }

        public double[,] CalcularFrecuencias(List<double> numerosAleatorios, int cantIntervalos)
        {
            double[,] frecuencias = new double[4,cantIntervalos];

            double valorMinimo = numerosAleatorios.Min();
            double valorMaximo = numerosAleatorios.Max();
            //calcula la longitud de cada intervalo
            double paso = (valorMaximo - valorMinimo) / cantIntervalos;
            double esperado = numerosAleatorios.Count/cantIntervalos;
            double minActual = valorMinimo;
            double maxActual = valorMinimo;
            
            // armamos los intervalos de la tabla
            for (int i=0; i<cantIntervalos; i++)
            {
                frecuencias[0, i] = minActual;
                maxActual = minActual + paso;
                frecuencias[1, i] = maxActual;
                frecuencias[2, i] = 0;
                frecuencias[3, i] = esperado;
                
                minActual = maxActual;
            }

            //contamos las frecuencias. Por cada numero aleatorio
            for (int i=0; i<numerosAleatorios.Count; i++)
            {
                //validamos se encuentre dentro de un intervalo
                for(int j=0; j<cantIntervalos; j++)
                {
                    //si esta dentro del intervalo actual, incrementamos el contador y salimos del bucle
                    if (numerosAleatorios[i] < frecuencias[1, j])
                    {
                        frecuencias[2, j]++;
                        break;
                    }
                }
            }
            return frecuencias;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}