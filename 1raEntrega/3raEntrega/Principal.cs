﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3raEntrega
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

        private void distribuciónExponencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distr_Exponencial pantalla = new Distr_Exponencial();
            pantalla.ShowDialog();
        }

        private void distribuciónUniformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distr_Uniforme pantalla = new Distr_Uniforme();
            pantalla.ShowDialog();
        }

        private void distribuciónPoissonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Distr_Poisson pantalla = new Distr_Poisson();
            pantalla.ShowDialog();
        }

        private void distribuciónNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistribucionNormal pantalla = new DistribucionNormal();
            pantalla.ShowDialog();
        }
    }
}
