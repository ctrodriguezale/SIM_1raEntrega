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
            c = (int) edtC.Value;
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
            double aleatorio = x;

            //Generamos lo primeros 20 numeros
            for (int i = 0; i < 20; i++)
            {
                lstNumeros.Items.Add(aleatorio.ToString());
                aleatorio = Generador.generarAleatorioCongruencialMultiplicativo(ref x, a, m);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double aleatorio = Generador.generarAleatorioCongruencialMultiplicativo(ref x, a, m);
            lstNumeros.Items.Add(aleatorio.ToString());
        }
    }
}
