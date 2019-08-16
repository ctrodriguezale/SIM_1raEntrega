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
            double[] tablaAleatorios;
            double valorChi = 0;

            ExcelAPI api = new ExcelAPI("Test Chi Cuadrado");

            //Generamos un listado de numeros aleatorios
            tablaAleatorios = Generador.GenerarAleatorios(x);
            //for (int i = 0; i < listado.Count; i++)
            //{
            //    lstAleatorios.Items.Add(listado[i]);
            //}
            
            tablaFrecuencias = CalcularFrecuencias(tablaAleatorios, intervalos, ref valorChi);

            api.completarTablas(tablaAleatorios,tablaFrecuencias, valorChi, intervalos);
            
        }

        public double[,] CalcularFrecuencias(double[] numerosAleatorios, int cantIntervalos, ref double chi)
        {
            double[,] frecuencias = new double[5,cantIntervalos];

            double valorMinimo = numerosAleatorios.Min();
            double valorMaximo = numerosAleatorios.Max();
            //calcula la longitud de cada intervalo
            double paso = (valorMaximo - valorMinimo) / cantIntervalos;
            double esperado = ((double)numerosAleatorios.Length )/ cantIntervalos;
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
            for (int i=0; i<numerosAleatorios.Length; i++)
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

            calcularChiCuadrado(frecuencias);
            chi = sumatoriaChiCuadrado(frecuencias);
            return frecuencias;
        }

        public void calcularChiCuadrado(double[,] datos)
        {
            for (int i = 0; i<datos.GetLength(1); i++)
            {
                datos[4, i] = calcularDesviacion((int)datos[2, i], (int)datos[3, i]);
            }
        }

        public double sumatoriaChiCuadrado(double[,] datos)
        {
            double suma = 0;

            for (int i = 0; i < datos.GetLength(1); i++)
            {
                suma += datos[4, i];
            }

            return suma;
        }

        public double calcularDesviacion(int frecuencia, int esperado)
        {
            double potencia   = Math.Pow((frecuencia - esperado), 2);
            double chiCuadrado = (potencia/esperado);
            return chiCuadrado;
        }
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TestChiCuadrado_Load(object sender, EventArgs e)
        {

        }
    }
}
