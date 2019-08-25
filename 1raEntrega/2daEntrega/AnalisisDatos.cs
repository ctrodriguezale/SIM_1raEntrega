using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace _2daEntrega
{
    public partial class AnalisisDatos : Form
    {

        public AnalisisDatos()
        {
            InitializeComponent();
        }

        private void cargarHistograma()
        {
            //limpiamos el grafico
            chrHistograma.Series.Clear();
            chrHistograma.Titles.Clear();
            chrHistograma.ChartAreas.Clear();
            //Agrago el area de grafico
            ChartArea area = new ChartArea();
            chrHistograma.ChartAreas.Add(area);
            //Agrego el titulo
            chrHistograma.Titles.Add("Duración de capítulos, para series originales de NETFLIX en género Drama");
            //Configuramos la serie de datos
            Series serie = new Series();
            serie.XValueMember = "Duración";
            serie.YValueMembers = "Frecuencia";
            serie.IsValueShownAsLabel = false;
            chrHistograma.Series.Add(serie);
            //chrHistograma.DataSource =


        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Controlador controller = new Controlador(this);
                controller.visualizarDatos(lblArchivo.Text, (int) edtIntervalos.Value);

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.ShowDialog();
            asignarArchivo(opnFile.FileName);
        }

        private void asignarArchivo(string NombreArchivo)
        {
            if (NombreArchivo != "")
            {
                lblArchivo.Text = NombreArchivo;
            }
            else
            {
                lblArchivo.Text = "Seleccionar Archivo de datos";
            }
        }

        public void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void MostrarHistograma(Estadistica tabla)
        {
            ChartArea area = new ChartArea("Duración de capítulos, para series originales de NETFLIX en género Drama");
            chrHistograma.ChartAreas.Add(area);
            foreach (var fila in tabla.)
            {

            }
                chrHistograma.Series.Add();
        }


    }
}
