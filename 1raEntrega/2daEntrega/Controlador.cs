using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2daEntrega
{
    class Controlador
    {
        private AnalisisDatos pantalla;
        List<int> listaObservaciones;
        Estadistica tabla;
        

        public Controlador(AnalisisDatos aPantalla)
        {
            listaObservaciones = new List<int>();
            pantalla = aPantalla;
            tabla = null;
        }

        public void visualizarDatos (string aNombreArchivo, int intervalos)
        {
            int minimo, maximo;
            //abrimos el archivo y extraemos los datos
            listaObservaciones = leerDatosDesdeArchivo(aNombreArchivo);
            minimo = listaObservaciones.Min();
            maximo = listaObservaciones.Max();
            //contabilizamos las frecuencias
            tabla = new Estadistica(intervalos, minimo, maximo);
            tabularDatos();
            //generamos el histograma
            pantalla.mostrarHistograma(tabla.getMarcasClase(), tabla.getFrecuencias());
            
        }

        private void tabularDatos()
        {
            //distribuye los valores en los intervalos
            foreach (var observacion in listaObservaciones)
            {
                tabla.agregarObservacion(observacion);
            }
        }


        private List<int> leerDatosDesdeArchivo(string nombreArchivo)
        {
            List<int> lista = new List<int>();
            string linea = "";
            int observacion;
            try
            {
                //Leemos desde el archivo
                StreamReader archivo = new StreamReader(nombreArchivo);
                while ((linea = archivo.ReadLine()) != null)
                {
                    //para cada linea se intenta convertir a entero
                    if (int.TryParse(linea, out observacion))
                        lista.Add(observacion);
                    else
                        pantalla.MostrarError("Valor inválido: " + linea);
                }
            }
            catch
            {
                pantalla.MostrarError("No se puede leer el archivo");
            }

            return lista;
        }


    }
}
