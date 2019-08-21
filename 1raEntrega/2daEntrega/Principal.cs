using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2daEntrega
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

        private void analizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double observacion = 250;
            Estadistica tabla = new Estadistica(5, 500, 203);
            for (int i = 0; i < 200; i++)
            {
                tabla.agregarObservacion(observacion);
            }

            ExcelAPI excel = new ExcelAPI;
            
        }
    }
}
