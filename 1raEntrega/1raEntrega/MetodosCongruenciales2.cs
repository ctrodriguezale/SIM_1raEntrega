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
        int c;
        int m;

        public MetodosCongruenciales2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            x = (int) edtSemilla.Value;
            a = (int) edtA.Value;
            m = (int) edtM.Value;

            //Limpia la lista cada vez que se aprieta el boton generar
            lstNumeros.Items.Clear();

            //Se generan los 20 primeros nuemros
            CalcularAleatoriosMetodoMultiplicativo();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcularAleatoriosMetodoMultiplicativo()
        {
            double aleatorio = ((double)x)/m;
            //Imprime el primer aleatorio
            lstNumeros.Items.Add(Math.Round(aleatorio, 4).ToString());

            //Generamos lo 19 restantes
            for (int i = 0; i < 19; i++)
            {
                aleatorio = Generador.generarAleatorioCongruencialMultiplicativo(ref x, a, m);
                lstNumeros.Items.Add(aleatorio.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double aleatorio = Generador.generarAleatorioCongruencialMultiplicativo(ref x, a, m);
            lstNumeros.Items.Add(aleatorio.ToString());
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
