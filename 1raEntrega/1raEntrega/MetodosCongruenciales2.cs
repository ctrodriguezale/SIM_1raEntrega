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
        public MetodosCongruenciales2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
                int x = (int)edtSemilla.Value;
                int a = (int)edtA.Value;
                int c = (int)edtC.Value;
                int m = (int)edtM.Value;

                //Limpia la lista cada vez que se aprieta el boton generar
                lstNumeros.Items.Clear();

                for (int i = 0; i < 20; i++)
                {
                    float aleatorio = ((float)x / m);

                    lstNumeros.Items.Add("" + aleatorio.ToString());
                    int rtdo = Generador.calcularMetodoMutiplicativo(x, a, m);

                    x = rtdo;
                }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
