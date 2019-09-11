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
    public partial class BatallaNavalModoAutomaticocs : Form
    {
        public BatallaNavalModoAutomaticocs()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            BarraProgreso.Value = 0;
            BatallaNavalFunciones juego = new BatallaNavalFunciones();
            string resultado = juego.SimularMilJuegos(this.BarraProgreso);
            listBox1.Items.Add(resultado);
        }
    }
}
