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

        public MetodosCongruenciales()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Reiniciamos la lista
            lstNumeros.Items.Clear();
            btnAgregar.Enabled = true;

            //Configuramos los valores iniciales
            x = (int)edtSemilla.Value;
            a = (int)edtA.Value;
            c = (int)edtC.Value;
            m = (int)edtM.Value;

            CalcularAleatoriosMetodoMixto();
        }

        private void CalcularAleatoriosMetodoMixto()
        {
            double aleatorio = ((double)x)/m;

            //Generamos lo primeros 20 numeros
            //Limpia la lista cada vez que se aprieta el boton generar
            lstNumeros.Items.Clear();
            listNumAl.Items.Clear();
            int j = 0;
            string item = "";
            for (int i = 0; i < 20; i++)
            {
                item =j.ToString();
                lstNumeros.Items.Add(aleatorio.ToString());
                //listNumAl.Items.Add(item, aleatorio.ToString());
                //listNumAl. Add(aleatorio.ToString());
                aleatorio = Generador.generarAleatorioCongruencialMixto(ref x, a, m, c);
                j++;

               
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double aleatorio = Generador.generarAleatorioCongruencialMixto(ref x, a, m, c);
            lstNumeros.Items.Add(aleatorio);
        }
    }
}
