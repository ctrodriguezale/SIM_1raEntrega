using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4taEntrega
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void batallaNavalModoAutomaticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatallaNavalModoAutomaticocs pantalla = new BatallaNavalModoAutomaticocs();
            pantalla.Show();
        }

        private void BatallaNavalModoSemiautomáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatallaNavalModoSemiautomatico pantalla = new BatallaNavalModoSemiautomatico();
            pantalla.Show();
        }
    }
}
