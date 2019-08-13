using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace _1raEntrega
{
    class ExcelAPI
    {
        private Application AppExcel;
        private Workbook libro;
        private Worksheet hoja;

        public ExcelAPI(string titulo)
        {
            // Creamos un objeto Excel.
            AppExcel = default(Application);
            // Creamos un objeto WorkBook. Para crear el documento Excel.           
            libro = default(Workbook);
            // Creamos un objeto WorkSheet. Para crear la hoja del documento.
            hoja = default(Worksheet);
            //Instanciamos la aplicacion
            AppExcel = new Application();
            AppExcel.Visible = true;
            /* Ahora creamos un nuevo documento y seleccionamos la primera hoja del 
            * documento en la cual crearemos nuestro informe. 
            */
            // Creamos una instancia del Workbooks de excel.            
            libro = AppExcel.Workbooks.Add();
            // Creamos una instancia de la primera hoja de trabajo de excel            
            hoja = libro.Worksheets[1];

            crearCabecera(titulo);
        }


        public void crearCabecera(string titulo)
        {
            //Creamos el titulo
            hoja.Range["A1:E1"].Merge();
            hoja.Range["A1:E1"].Value = titulo;
            hoja.Range["A1:E1"].Font.Bold = true;
            // La cuarta línea signa un Size a titulo de 15.
            hoja.Range["A1:E1"].Font.Size = 15;

            Range celda = hoja.Range["A3",Type.Missing];
            celda.Value = "Orden";

            celda = hoja.Range["B3", Type.Missing];
            celda.Value = "Min";

            celda = hoja.Range["C3", Type.Missing];
            celda.Value = "Max";

            celda = hoja.Range["D3", Type.Missing];
            celda.Value = "O(i)";

            celda = hoja.Range["E3", Type.Missing];
            celda.Value = "E(i)";
        }

        public void completarTabla(double[,] datos)
        {
            for(int i = 0; i < datos.Length; i++)
            {
                hoja.Cells[i+4, "A"] = i + 1;
                hoja.Cells[i+4, "B"] = datos[0,i];
                hoja.Cells[i+4, "C"] = datos[1,i];
                hoja.Cells[i+4, "D"] = datos[2,i];
                hoja.Cells[i+4, "E"] = datos[3,i];
                
            }
            libro.PrintPreview();
        }
    }
}