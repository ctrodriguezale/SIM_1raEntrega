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
            DialogResult resultado = MessageBox.Show("¿Desea salir de la apliación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void métodoCongruencialMixtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodosCongruenciales dialogo = new MetodosCongruenciales();
            dialogo.ShowDialog();
        }

        private void métodoMultiplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodosCongruenciales2 dialogo = new MetodosCongruenciales2();
            dialogo.ShowDialog();
        }

        private void puntoBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestChiCuadrado frm = new TestChiCuadrado();
            frm.ShowDialog();
        }

        private void puntoCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestChiCuadrado2 frm = new TestChiCuadrado2();
            frm.ShowDialog();
        }

    }
}
