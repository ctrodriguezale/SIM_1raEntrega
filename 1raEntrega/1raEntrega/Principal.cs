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
            pageSetupDialog1 = new Integrantes();

        }
    }
}
