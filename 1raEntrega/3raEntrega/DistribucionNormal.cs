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

        private void btn_generar_Click(object sender, EventArgs e)
        {
            cantidadIntervalos = (int)tbx_cant_variables.Value;
            cantidadNum = (int)txb_cant_intervalos.Value;
            media = (double)txb_media.Value;
            desviacion = (double)txb_desviacion.Value;

            List<double> listaVariables = new List<double>();

            if (!validarValoresCorrectos(media, desviacion))
            {

                MessageBox.Show("Ingrese parametros Válidos", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                //se generan los variables aleatorios y se guardan en el vector
                listaVariables = libreria.generarListaVariablesNormal(cantidadNum, media, desviacion);
                // se recorre el vector con las variables aleatorias y las muestras en la lista de la pantalla
                for (int i = 0; i < listaVariables.Count(); i++)
                {
                    listVarAlea.Items.Add(Math.Round(listaVariables[i], 4).ToString());
                }
                // se genera el excel 
                libreria.visualizarDatos(listaVariables, cantidadIntervalos, media, desviacion, cantidadNum);
            }

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarValoresCorrectos(double media, double desviacion)
        {
            if (desviacion>media) { MessageBox.Show("El valor de la Media no puede ser Menor al valor de la Desviación", "Advertencia", MessageBoxButtons.OK); return false; }

            if (desviacion < 1) { MessageBox.Show("La Desviación no puede ser Negativa o igual a 0", "Advertencia", MessageBoxButtons.OK); return false; }

            return true;
        }
    }
}
