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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Sale de la aplicacion previa confirmacion
            DialogResult resultado = MessageBox.Show("¿Seguro desea salir de la apliación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integrantes acercaDe = new Integrantes();
            acercaDe.ShowDialog();
        }

        private void métodoCongruencialMixtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int x = (int) edtSemilla.Value;
            int a = (int) edtA.Value;
            int c = (int) edtC.Value;
            int m = (int) edtM.Value;
            
            for (int i = 0; i < 20; i++)
            {
                float aleatorio = ((float)x/ m);

                lstNumeros.Items.Add("" + aleatorio.ToString());
                int rtdo = calcularMetodoCongruencialMixto(x, a, m, c);
                
                x = rtdo;
            }
        }

        private int calcularMetodoCongruencialMixto(int x, int a, int m, int c)
        {
            int resultado;

            //Calculo del numero aleatorio
            resultado = ((a * x + c) % m);
            
            return resultado;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
