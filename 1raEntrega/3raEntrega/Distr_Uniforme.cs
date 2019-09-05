using LibreriaSimulacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3raEntrega
{
    public partial class Distr_Uniforme : Form
    {

        int cantNumeros;
        int cantIntervalos;
        double valorA;
        double valorB;
        LibreriaSimulacion.DistribucionUniforme metodos = new DistribucionUniforme();

        public Distr_Uniforme()
        {
            InitializeComponent();
        }
        


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
            valorA = (double)txb_valor_a.Value;
            valorB = (double)txb_valor_b.Value;
            List<double> listaVarAleatoria = new List<double>();

            if (!validarValoresCorrectos(valorA, valorB))
            {

               MessageBox.Show("Ingrese parametros Válidos", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                //se generan los variables aleatorios y se guardan en el vector
                listaVarAleatoria = metodos.generarListaVariablesAleatorias(cantNumeros, valorA, valorB);
                // se recorre el vector con las variables aleatorias y las muestras en la lista de la pantalla
                for (int i = 0; i < listaVarAleatoria.Count(); i++)
                {
                    listVarAlea.Items.Add(Math.Round(listaVarAleatoria[i], 4).ToString());
                }
                // se genera el excel 
                metodos.visualizarDatos(listaVarAleatoria, cantIntervalos, valorA, valorB, cantNumeros);
            }
           

        }

        private bool validarValoresCorrectos(double valorA, double valorB)
        {
            if (valorA == valorB) { MessageBox.Show("Los valores A y B no puede ser iguales.", "Advertencia", MessageBoxButtons.OK); return false; }

            if (valorA < 0 && valorA > valorB) { MessageBox.Show("Si el Valor A es Negativo, el Valor B no puede ser menor al Valor A.", "Advertencia", MessageBoxButtons.OK); return false; }

            if (valorA == 0 && valorB < 0) { MessageBox.Show("Si el valor A es igual a cero, el valor B no puede ser Negativo.", "Advertencia", MessageBoxButtons.OK); return false; }

            if (valorA > 0 && valorA < 1 && valorB < 0) { MessageBox.Show("Si el Valor A se encuentra entre 0 y 1.¡, el valor B no puede ser Negativo.", "Advertencia", MessageBoxButtons.OK); return false; }

            if (valorB == 0 && valorA > 0) { MessageBox.Show("Si el valor A es Positivo, el valor B no puede ser cero.", "Advertencia", MessageBoxButtons.OK); return false; }

            if (valorB > 0 && valorB < 1 && valorA > 0) { MessageBox.Show("Si el valor A es Positivo, el valor B no puede estar entre los valores 0 y 1.", "Advertencia", MessageBoxButtons.OK); return false; }

            if (valorA > valorB) { MessageBox.Show("El valor A debe ser Menor que el valor B.", "Advertencia", MessageBoxButtons.OK); return false; }

            return true;
        }

    }
}

