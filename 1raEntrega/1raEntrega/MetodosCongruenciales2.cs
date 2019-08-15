using System;
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
    public partial class MetodosCongruenciales2 : Form
    {
        int x;
        int a;
        int m;

        public MetodosCongruenciales2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            x = (int)edtSemilla.Value;
            a = (int)edtA.Value;
            m = (int)edtM.Value;

            //Reiniciamos la lista
            listNumAl.Items.Clear();
            btnAgregar.Enabled = true;

            //Se generan los 20 primeros nuemros
            CalcularAleatoriosMetodoMultiplicativo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcularAleatoriosMetodoMultiplicativo()
        {
            double aleatorio = ((double)x) / m;

            //Generamos lo primeros 20 numeros
            //Limpia la lista cada vez que se aprieta el boton generar

            listNumAl.Items.Clear();

            //Imprime el primer aleatorio
            ListViewItem elementoListView;

            string[] elementosFila = new string[2];

            elementosFila[0] = "0";
            elementosFila[1] = Math.Round(aleatorio, 4).ToString();
            elementoListView = new ListViewItem(elementosFila);
            listNumAl.Items.Add(elementoListView);

            int j = 1;
            string item = "";
            for (int i = 0; i < 19; i++)
            {
                item = j.ToString();

                // se crea vector para almacenar los datos del ID item y el numero aleatorio
                elementosFila = new string[2];

                // se asignan valores al vector
                elementosFila[0] = item;
                elementosFila[1] = aleatorio.ToString();

                //se agrega vector  a los items
                elementoListView = new ListViewItem(elementosFila);

                //se calculan nuevos valores
                aleatorio = Generador.generarAleatorioCongruencialMultiplicativo(ref x, a, m);
                listNumAl.Items.Add(elementoListView);
                j++;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double aleatorio = Generador.generarAleatorioCongruencialMultiplicativo(ref x, a, m);

            //listNumAl.Items.Add(aleatorio.ToString);

            ListViewItem elementoListView;

            string[] elementosFila = new string[2];

            int cantItem = listNumAl.Items.Count;

            elementosFila[0] = cantItem.ToString();
            elementosFila[1] = Math.Round(aleatorio, 4).ToString();
            elementoListView = new ListViewItem(elementosFila);
            listNumAl.Items.Add(elementoListView);
        }

    }
}