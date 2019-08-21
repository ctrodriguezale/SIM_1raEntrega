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
                int[] datos;
                //Abrimos el archivo que tiene las observaciones
                ExcelAPI excel = new ExcelAPI("");
                
                excel.abrirArchivo("E:\\Documentos\\Facultad\\IV-SIM\\Repo\\1raEntrega\\1raEntrega\\2daEntrega\\Tp2_Muestras.xlsx");

                datos = excel.obtenerObservaciones(1);

            }
            catch
            {
                MessageBox.Show("Error ");
            }
        }
    }
}
