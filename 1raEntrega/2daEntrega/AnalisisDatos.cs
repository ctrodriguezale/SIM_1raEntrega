﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace _2daEntrega
{
    public partial class AnalisisDatos : Form
    {

        public AnalisisDatos()
        {
            InitializeComponent();
        }
        
        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            try
            {
                Controlador controller = new Controlador(this);
                controller.visualizarDatos(lblArchivo.Text, (int) edtIntervalos.Value);
                if (lblArchivo.Text.Contains("PrimeraMuestra"))
                {
                    txtConclusion.Text = "Hipótesis: \nDado el gráfico que observamos de la muestra analizada, proponemos la hipótesis de que la variable sigue una distribución Exponencial Negativa. \n \n \nTras realizar la Prueba de Chi Cuadrado en el excel determinamos que los valores de la muestra no siguen ningun Tipo de las Distribuciones Candidatas Planteadas";
                }
                else
                {
                    txtConclusion.Text = "Hipótesis: \nDado el gráfico que observamos de la muestra analizada, proponemos la hipótesis de que la variable sigue una distribución Normal. \n \n \nTras realizar la Prueba de Chi Cuadrado en el excel determinamos que los valores de la muestra no siguen ningun Tipo de las Distribuciones Candidatas Planteadas";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.ShowDialog();
            asignarArchivo(opnFile.FileName);
        }

        private void asignarArchivo(string NombreArchivo)
        {
            if (NombreArchivo != "")
            {
                lblArchivo.Text = NombreArchivo;
            }
            else
            {
                lblArchivo.Text = "Seleccionar Archivo de datos";
            }
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void mostrarHistograma(double[] marcasClase, double[] frecuencias)
        {
            // se limpia histograma
            chrHistograma.Series.Clear();
            chrHistograma.Titles.Clear();

            //Agrego el titulo
            chrHistograma.Titles.Add("Duración de Capítulos de Series Originales de NETFLIX de Género Drama");
            //agrego la serie
            chrHistograma.Series.Add (new Series());
          
            for (int i = 0; i < marcasClase.Length; i++)
            {
                chrHistograma.Series[0].Points.AddXY(Math.Round(marcasClase[i],2), frecuencias[i]);
            }

            chrHistograma.ChartAreas[0].AxisX.Interval = 1;
            chrHistograma.Series[0].IsXValueIndexed = true;

            chrHistograma.Series[0].IsVisibleInLegend = true;
            chrHistograma.Series[0].IsValueShownAsLabel = true;
            chrHistograma.ChartAreas[0].AxisX.Title = "Duración en Minutos" ;
            chrHistograma.ChartAreas[0].AxisY.Title = "Frecuencia";

        }
    }
}
