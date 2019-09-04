using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TablaChi
{
    internal class Class1
    {

            public double ValorChi2(double probabilidad, int filas, int varibles)
            {
                probabilidad = 1 - probabilidad;
                StreamReader Archivo;
                switch (probabilidad)
                {
                    case 0.001:
                        Archivo = new StreamReader("0.001.txt");
                        break;
                    case 0.0025:
                        Archivo = new StreamReader("0.0025.txt");
                        break;
                    case 0.005:
                        Archivo = new StreamReader("0.005.txt");
                        break;
                    case 0.01:
                        Archivo = new StreamReader("0.01.txt");
                        break;
                    case 0.025:
                        Archivo = new StreamReader("0.025.txt");
                        break;
                    case 0.05:
                        Archivo = new StreamReader("0.05.txt");
                        break;
                    case 0.1:
                        Archivo = new StreamReader("0.1.txt");
                        break;
                    case 0.15:
                        Archivo = new StreamReader("0.15.txt");
                        break;
                    case 0.2:
                        Archivo = new StreamReader("0.2.txt");
                        break;
                    case 0.25:
                        Archivo = new StreamReader("0.25.txt");
                        break;
                    case 0.3:
                        Archivo = new StreamReader("0.3.txt");
                        break;
                    case 0.35:
                        Archivo = new StreamReader("0.35.txt");
                        break;
                    case 0.4:
                        Archivo = new StreamReader("0.4.txt");
                        break;
                    case 0.45:
                        Archivo = new StreamReader("0.45.txt");
                        break;
                    case 0.5:
                        Archivo = new StreamReader("0.5.txt");
                        break;
                    default:
                        Archivo = new StreamReader("0.5.txt");
                        break;
                }
                //TextReader Archivo;
                int GL = filas - varibles - 1;
                double valor;
                int i = 0;

                while (!Archivo.EndOfStream)
                {
                    valor = Convert.ToDouble(Archivo.ReadLine());
                    if (i == GL)
                    {

                        return valor;
                    }
                    i++;
                }
                return 0;
            }

        }
    }