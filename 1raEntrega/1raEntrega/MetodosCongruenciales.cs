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
    public partial class MetodosCongruenciales : Form
    {
        int x;
        int a;
        int c;
        int m;
        int metodo; 

        public MetodosCongruenciales()
        {
            InitializeComponent();
            cmbMetodos.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Reiniciamos la lista
            lstNumeros.Items.Clear();
            //Configuramos los valores iniciales
            x = (int)edtSemilla.Value;
            a = (int)edtA.Value;
            c = (int)edtC.Value;
            m = (int)edtM.Value;
            metodo = cmbMetodos.SelectedIndex;

            if (metodo == 0)
                CalcularAleatoriosMetodoMixto();
            else
                CalcularAleatoriosMetodoMultiplicativo();
        }

        private void CalcularAleatoriosMetodoMixto()
        {
            double aleatorio = x;

            //Generamos lo primeros 20 numeros
            for (int i = 0; i < 20; i++)
            {
                lstNumeros.Items.Add(aleatorio.ToString());
                aleatorio = Generador.calcularMetodoCongruencialMixto(x, a, m, c);
            }
        }

        private void CalcularAleatoriosMetodoMultiplicativo()
        {
            double aleatorio = x;

            //Generamos lo primeros 20 numeros
            for (int i = 0; i < 20; i++)
            {
                lstNumeros.Items.Add(aleatorio.ToString());
                aleatorio = Generador.generarAleatorioCongruenteMultiplicativo(x, a, m);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Deshabilita o habilita las entradas necesarias
            if (cmbMetodos.SelectedIndex == 0)
            {
                edtA.Enabled = true;
                edtM.Enabled = true;
            }
            else
            {
                edtA.Enabled = false;
                edtM.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (metodo == 0)
                Generador.generarAleatorioCongruenteMixto(x, a, m, c);
            else
                Generador.generarAleatorioCongruenteMultiplicativo(x,a,m);
        }
    }
}
