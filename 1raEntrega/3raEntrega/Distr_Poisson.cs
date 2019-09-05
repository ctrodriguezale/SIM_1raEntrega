using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaSimulacion;

namespace _3raEntrega
{
    public partial class Distr_Poisson : Form
    {
        public Distr_Poisson()
        {
            InitializeComponent();
        }

        int cantNumeros;
        int cantIntervalos;
        double lambda;

        LibreriaSimulacion.DistribucionPoisson metodos = new DistribucionPoisson();

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            //Reiniciamos la lista
            listVarAlea.Items.Clear();

            //Configuramos los valores iniciales
            cantNumeros = (int)tbx_cant_variables.Value;
            cantIntervalos = (int)txb_cant_intervalos.Value;
            lambda = (double)txb_lambda.Value;
            List<double> listaVarAleatoria = new List<double>();

            if (!validarValoresCorrectos(lambda))
            {

                MessageBox.Show("Ingrese parametros Válidos", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                //se generan los variables aleatorios y se guardan en el vector
                listaVarAleatoria = metodos.generarListaVariablesAleatorias(cantNumeros, lambda);
                // se recorre el vector con las variables aleatorias y las muestras en la lista de la pantalla
                for (int i = 0; i < listaVarAleatoria.Count(); i++)
                {
                    listVarAlea.Items.Add(Math.Round(listaVarAleatoria[i], 4).ToString());
                }
                // se genera el excel 
                metodos.visualizarDatos(listaVarAleatoria, cantIntervalos, lambda, cantNumeros);
            }
        }
        private bool validarValoresCorrectos(double lambda)
        {
            if (lambda < 1) { MessageBox.Show("El valor de Lambda deber ser mayor o igual a 1", "Advertencia", MessageBoxButtons.OK); return false; }

            return true;
        }
    }
}
