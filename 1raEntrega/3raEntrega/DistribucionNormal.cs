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
    public partial class DistribucionNormal : Form
    {
        int cantidadNum;
        int cantidadIntervalos;
        double media;
        double desviacion;

        LibreriaSimulacion.DistribucionNormal libreria = new LibreriaSimulacion.DistribucionNormal();


        public DistribucionNormal()
        {
            InitializeComponent();
        }

        private void txtMedia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este cáracter no es un número ( " + e.KeyChar + " )", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDesviacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este cáracter no es un número ( " + e.KeyChar + " )", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCantidadNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este cáracter no es un número ( " + e.KeyChar + " )", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCantidadIntervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este cáracter no es un número ( " + e.KeyChar + " )", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cantidadIntervalos = int.Parse(txtCantidadIntervalos.Text);
            cantidadNum = int.Parse(txtCantidadNumeros.Text);
            media = double.Parse(txtMedia.Text);
            desviacion = double.Parse(txtDesviacion.Text);

            List<double> listaVariables = new List<double>();

            //se generan los variables aleatorios y se guardan en el vector
            listaVariables = libreria.generarListaVariablesNormal(cantidadNum, media, desviacion);
            // se recorre el vector con las variables aleatorias y las muestras en la lista de la pantalla
            for (int i = 0; i < listaVariables.Count(); i++)
            {
                listaNormales.Items.Add(Math.Round(listaVariables[i], 4).ToString());
            }
            // se genera el excel 
            //metodos.visualizarDatos(listaVarAleatoria, cantIntervalos, lambda, cantNumeros);


        }
    }
}
