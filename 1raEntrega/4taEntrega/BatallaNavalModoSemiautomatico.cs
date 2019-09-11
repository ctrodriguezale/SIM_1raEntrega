using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _4taEntrega
{
    public partial class BatallaNavalModoSemiautomatico : Form
    {
        List<List<PictureBox>> barcosJugador1 = new List<List<PictureBox>>();
        List<List<PictureBox>> barcosJugador2 = new List<List<PictureBox>>();
        public BatallaNavalModoSemiautomatico()
        {
            InitializeComponent();
            List<PictureBox> barco = new List<PictureBox>();
            barco.Add(p110);
            barco.Add(p111);
            barco.Add(p112);
            barco.Add(p113);
            barco.Add(p114);
            barco.Add(p115);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(p120);
            barco.Add(p121);
            barco.Add(p122);
            barco.Add(p123);
            barco.Add(p124);
            barco.Add(p125);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(f110);
            barco.Add(f111);
            barco.Add(f112);
            barco.Add(f113);
            barco.Add(f114);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(f120);
            barco.Add(f121);
            barco.Add(f122);
            barco.Add(f123);
            barco.Add(f124);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(s110);
            barco.Add(s111);
            barco.Add(s112);
            barco.Add(s113);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(s120);
            barco.Add(s121);
            barco.Add(s122);
            barco.Add(s123);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(c110);
            barco.Add(c111);
            barco.Add(c112);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(c120);
            barco.Add(c121);
            barco.Add(c122);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(d110);
            barco.Add(d111);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(d120);
            barco.Add(d121);
            barcosJugador1.Add(barco);
            barco = new List<PictureBox>();

            // jugador 2

            barco = new List<PictureBox>();
            barco.Add(p210);
            barco.Add(p211);
            barco.Add(p212);
            barco.Add(p213);
            barco.Add(p214);
            barco.Add(p215);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(p220);
            barco.Add(p221);
            barco.Add(p222);
            barco.Add(p223);
            barco.Add(p224);
            barco.Add(p225);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(f210);
            barco.Add(f211);
            barco.Add(f212);
            barco.Add(f213);
            barco.Add(f214);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(f220);
            barco.Add(f221);
            barco.Add(f222);
            barco.Add(f223);
            barco.Add(f224);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(s210);
            barco.Add(s211);
            barco.Add(s212);
            barco.Add(s213);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(s220);
            barco.Add(s221);
            barco.Add(s222);
            barco.Add(s223);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(c210);
            barco.Add(c211);
            barco.Add(c212);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(c220);
            barco.Add(c221);
            barco.Add(c222);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();

            barco.Add(d210);
            barco.Add(d211);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();
            barco.Add(d220);
            barco.Add(d221);
            barcosJugador2.Add(barco);
            barco = new List<PictureBox>();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BatallaNavalFunciones BSA = new BatallaNavalFunciones();          
            List<List<Tuple<int, int>>> resultadoSimulacion = BSA.SimularSemiAleatoreo();          
            List<Tuple<int, int>> resultado = resultadoSimulacion[0];

            foreach(List<PictureBox> barcosVerdes in barcosJugador1 )
            {
                foreach(PictureBox caja in barcosVerdes)
                {
                    caja.BackColor = Color.Lime;
                }
            }
            foreach (List<PictureBox> barcosVerdes in barcosJugador2)
            {
                foreach (PictureBox caja in barcosVerdes)
                {
                    caja.BackColor = Color.Lime;
                }
            }

            listaJugador1.Items.Clear();
            listaJugador2.Items.Clear();


            for (int i = 0; i < resultado.Count(); i++)
            {
                Tuple<int, int> r = resultado[i];
                listaJugador1.Items.Add("Fuego en: "+r.Item1+"-"+r.Item2);
                //Thread.Sleep(50); //tiempo de pausa
            }

            for (int i = 1; i < resultadoSimulacion.Count(); i++)
            {
                List<Tuple<int, int>> r = resultadoSimulacion[i];
                for (int j = 0; j < r.Count(); j++)
                {
                    //foreach (Tuple<int, int> p in resultado)
                    //{
                    for (int p = 0; p < resultado.Count(); p++)
                    {
                        if (r.Contains(resultado[p]) == true)
                        {
                            barcosJugador2[i - 1][j].BackColor = Color.Red;
                        }
                    }
                }
                if(i==10)
                {
                    break;
                }
            }



                    resultado = resultadoSimulacion[11];
            for (int i = 0; i < resultado.Count(); i++)
            {
                Tuple<int, int> r = resultado[i];
                listaJugador2.Items.Add("Fuego en: " + r.Item1 + "-" + r.Item2);
                //Thread.Sleep(50); //tiempo de pausa
            }

            for (int i = 12; i < resultadoSimulacion.Count(); i++)
            {
                List<Tuple<int, int>> r = resultadoSimulacion[i];
                for(int j = 0; j < r.Count(); j++ )
                {

                    for (int p = 0; p < resultado.Count(); p++)
                    {
                        if (r.Contains(resultado[p]) == true)
                        {
                            barcosJugador1[i - 12][j].BackColor = Color.Red;
                        }
                    }

                 }

            }
        }
    }
}
