using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace _4taEntrega
{
    class BatallaNavalFunciones
    {
        // 

        //int[,] tablero1 = new int[100, 100];
        //int[,] tablero2 = new int[100, 100];
        List<List<Tuple<int,int>>> tablero1 = new  List < List<Tuple<int, int>> >();
        List<List<Tuple<int, int>>> tablero2 = new List<List<Tuple<int, int>>>();
        List<Tuple<int, int>> aciertosJugador1 = new List<Tuple<int, int>>();
        List<Tuple<int, int>> aciertosJugador2 = new List<Tuple<int, int>>();
        List<Tuple<int, int>> fallosJugador1 = new List<Tuple<int, int>>();
        List<Tuple<int, int>> fallosJugador2 = new List<Tuple<int, int>>();
        int x1 = 0;
        int x2 = 0;
        int primerValor = 0;
        int posicionCazaX = 0;
        int posicionCazaXInicial = 0;
        int posicionCazaY = 0;
        int posicionCazaYInicial = 0;
        int undirBarcoJugador1 = 1;
        int undirBarcoJugador2 = 1;
        int jugador1PartidasGanadas = 0;
        int jugador2PartidasGanadas = 0;
        bool acierto1 = false;
        bool acierto2 = false;
        public List< List<Tuple<int,int>>> SimularSemiAleatoreo()
        {

            List<List<Tuple<int, int>>> resultadoDisparos = new List<List<Tuple<int, int>>>();


           PosicionarBarcos(tablero1, tablero2);


            int resultado = Partida();
            resultadoDisparos.Add(aciertosJugador1);
            foreach(List<Tuple<int, int>> i in tablero2)
            {
                resultadoDisparos.Add(i);
            }
            resultadoDisparos.Add(aciertosJugador2);
            foreach (List<Tuple<int, int>> i in tablero1)
            {
                resultadoDisparos.Add(i);
            }
            return resultadoDisparos;

        }
        public Tuple<string,string> SimularMilJuegos(ProgressBar progreso)
        {
            //int jugador1CantDisparos = 0;
            //int jugador1CantAciertos = 0;
            //int jugador2CantDisparos = 0;
            //int jugador2CantAciertos = 0;
            int promedioAciertos1 = 0;
            int promedioFallos1 = 0;
            int promedioAciertos2 = 0;
            int promedioFallos2 = 0;


            //posicionar barcos
            PosicionarBarcos(tablero1, tablero2);
            //hacer juego de mil
            for (int i = 0; i < 40; i++)
            {
                int resultado = Partida();
                if (i == 0)
                {
                    promedioAciertos1 = aciertosJugador1.Count();
                    promedioAciertos2 = aciertosJugador2.Count();
                    promedioFallos1 = fallosJugador1.Count();
                    promedioFallos2 = fallosJugador2.Count();
                }
                else
                {
                    promedioAciertos1 = ((promedioAciertos1 * (i - 1)) + aciertosJugador1.Count()) / i;
                    promedioAciertos2 = ((promedioAciertos2 * (i - 1)) + aciertosJugador2.Count()) / i;
                    promedioFallos1 = ((promedioFallos1 * (i - 1)) + fallosJugador1.Count()) / i;
                    promedioFallos2 = ((promedioFallos2 * (i - 1)) + fallosJugador2.Count()) / i;
                }
                if (resultado == 1)
                {
                    jugador1PartidasGanadas++;
                }
                else
                {
                    jugador2PartidasGanadas++;
                }
                tablero1 = new List<List<Tuple<int, int>>>();
                tablero2 = new List<List<Tuple<int, int>>>();
                aciertosJugador1 = new List<Tuple<int, int>>();
                aciertosJugador2 = new List<Tuple<int, int>>();
                fallosJugador1 = new List<Tuple<int, int>>();
                fallosJugador2 = new List<Tuple<int, int>>();
                x1 = 0;
                x2 = 0;
                primerValor = 0;
                posicionCazaX = 0;
                posicionCazaXInicial = 0;
                posicionCazaY = 0;
                posicionCazaYInicial = 0;
                undirBarcoJugador1 = 1;
                undirBarcoJugador2 = 1;
                acierto1 = false;
                acierto2 = false;
                progreso.Increment(1);
              //  progresoPor.Text = Convert.ToString( i ) ;
                //var stopwatch = Stopwatch.StartNew();
               // Thread.Sleep(500); //tiempo de pausa
                //stopwatch.Stop();
                PosicionarBarcos(tablero1, tablero2);
            }
            //calcular estadisticas
            string jug1 = string.Format("El jugador 1 gano {0} partidas de 1000 con un promedio de aciertos {1} y fallos {2}. ", jugador1PartidasGanadas*2, promedioAciertos1, promedioFallos1);
            string jug2 = string.Format("El jugador 2 gano {0} partidas de 1000 con un promedio de aciertos {1} y fallos {2}. ", jugador2PartidasGanadas*2, promedioAciertos2, promedioFallos2);

            return Tuple.Create(jug1,jug2);
        }

        public void PosicionarBarco( int tamaño,Boolean orientacion, List<List<Tuple<int, int>>> tablero)
        {
            int posicionX =  1 + ( 100 * GenerarAleatorio()/10000);
            int posicionY = 1 + (100 * GenerarAleatorio() / 10000);
            List<Tuple<int,int>> barco = new List<Tuple<int,int>>();

            while (validarPosicion(posicionX,posicionY,orientacion, tamaño, tablero) == false)
            {
                posicionX = 1 + (100 * GenerarAleatorio() / 10000);
                posicionY = 1 + (100 * GenerarAleatorio() / 10000);

            }
            for (int i = 0; i < tamaño; i++)
            {
                barco.Add(Tuple.Create(posicionX,posicionY));
                if (orientacion == true)
                {
                    posicionX++;
                }
                else
                {
                    posicionY++;
                }
            }
            tablero.Add(barco);

            //tablero[x, y] = 1;

            //if (orientacion == "v")
            //{

            //    for (int i = 1; i == tamaño; i++)
            //    {
            //        tablero[x + i, y] = 1;
            //    }
            //}
            //else
            //{

            //    for (int i = 1; i == tamaño; i++)
            //    {
            //        tablero[x, y + 1] = 1;
            //    }
            //}
        }

        public bool validarPosicion(int posicionX, int posicionY, Boolean orientacion, int tamaño, List<List<Tuple<int, int>>> tableroSel)
        {
            int X = posicionX;
            int Y = posicionY;
            if (tableroSel.Count() == 0)
            {
                for (int t = 0; t < tamaño; t++)
                {
                    if (orientacion == true)
                    {
                        X++;
                        if (X > 100)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        Y++;
                        if (Y > 100)
                        {
                            return false;
                        }
                    }
                }
            }
            X = posicionX;
            Y = posicionY;

            foreach (List < Tuple<int, int> > i in tableroSel)
            {
                foreach (Tuple<int, int> j in i)
                    {
                    X = posicionX;
                    Y = posicionY;
                    for (int t = 0; t < tamaño; t++)
                        {
                           if( j.Item1 == X )
                           {
                                return false;
                           }
                            if (j.Item2 == Y)
                            {
                                return false;
                            }

                            if (orientacion == true )
                            {
                                X++;
                                if (X > 100)
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                Y++;
                                if (Y > 100)
                                {
                                    return false;
                                }
                            }
                        }
                     }
            }
            return true;

        }

        public void PosicionarBarcos(List<List<Tuple<int, int>>> tablero1, List<List<Tuple<int, int>>> tablero2)
        {
            // porta aviones jugador 1
            PosicionarBarco(6,true,tablero1);
            PosicionarBarco(6, true, tablero1);

            // fragatas jugador 1
            PosicionarBarco(5, true, tablero1);
            PosicionarBarco(5, true, tablero1);

            // submarinos jugador 1
            PosicionarBarco(4, true, tablero1);
            PosicionarBarco(4, false, tablero1);

            // corbetas jugador 1
            PosicionarBarco(3, true, tablero1);
            PosicionarBarco(3, false, tablero1);

            // destructores jugador 1
            PosicionarBarco(2, true, tablero1);
            PosicionarBarco(2, false, tablero1);



            // porta aviones jugador 2
            PosicionarBarco(6, true, tablero2);
            PosicionarBarco(6, true, tablero2);

            // fragatas jugador 2
            PosicionarBarco(5, true, tablero2);
            PosicionarBarco(5, false, tablero2);

            // submarinos jugador 2
            PosicionarBarco(4, true, tablero2);
            PosicionarBarco(4, true, tablero2);

            // corbetas jugador 2
            PosicionarBarco(3, true, tablero2);
            PosicionarBarco(3, false, tablero2);

            // destructores jugador 2
            PosicionarBarco(2, true, tablero2);
            PosicionarBarco(2, false, tablero2);


            //PosicionarBarco(4, true, tablero1);
            //PosicionarBarco(8,false, tablero1);
            //PosicionarBarco(8, true, tablero2);
            //PosicionarBarco(4,false, tablero2);
            //PosicionarBarco(8, true, tablero2);

            ////Tablero1
            ////barcos de 6
            //PosicionarBarco(6, "h", tablero1);
            //PosicionarBarco(6, "v", tablero1);
            ////barcos de 5
            //PosicionarBarco(5, "v", tablero1);
            //PosicionarBarco(5, "h", tablero1);
            ////barcos de 4
            //PosicionarBarco(4, "v", tablero1);
            //PosicionarBarco(4, "h", tablero1);
            ////barcos de 3
            //PosicionarBarco(3, "v", tablero1);
            //PosicionarBarco(3, "h", tablero1);
            ////barcos de 2
            //PosicionarBarco(2, "h", tablero1);
            //PosicionarBarco(2, "v", tablero1);

            ////Tablero2
            ////barcos de 6
            //PosicionarBarco(6, "h", tablero2);
            //PosicionarBarco(6, "v", tablero2);
            ////barcos de 5
            //PosicionarBarco(5, "h", tablero2);
            //PosicionarBarco(5, "v", tablero2);
            ////barcos de 4
            //PosicionarBarco(4, "v", tablero2);
            //PosicionarBarco(4, "h", tablero2);
            ////barcos de 3
            //PosicionarBarco(3, "v", tablero2);
            //PosicionarBarco(3, "h", tablero2);
            ////barcos de 2
            //PosicionarBarco(2, "v", tablero2);
            //PosicionarBarco(2, "h", tablero2);
        }

        public int GenerarAleatorio()
        {
            if (primerValor == x2)
            {
                Random aleatorio = new Random();
                primerValor = aleatorio.Next(0, 9998);
                x1 = primerValor;
            }
            x2 = (67 * x1 + 71) % 9999;
            x1 = x2;
            return x2 ;
        }
        // resuelto 
        public Boolean EstrategiaAzar(List<List<Tuple<int, int>>> tablero,List<Tuple<int,int>> aciertos, List<Tuple<int, int>> fallos)
        {
            int posicionX = 1 + (100 * GenerarAleatorio() / 10000);
            int posicionY = 1 + (100 * GenerarAleatorio() / 10000);
            Tuple<int, int> tiro;
            tiro = Tuple.Create(posicionX,posicionY);

            while (fallos.Contains(tiro) == true || aciertos.Contains(tiro) == true )
            {
                posicionX = 1 + (100 * GenerarAleatorio() / 10000);
                posicionY = 1 + (100 * GenerarAleatorio() / 10000);
                tiro = Tuple.Create(posicionX, posicionY);
            }
            //for (int i = 0; i < fallos.Count(); i++)
            //{
            //    tiro = fallos[i];

            //    //if (posicionX == tiro.Item1 && posicionY == tiro.Item2)
            //    //{
            //    //    posicionX = 1 + (100 * GenerarAleatorio() / 10000);
            //    //    posicionY = 1 + (100 * GenerarAleatorio() / 10000);
            //    //}

            //}
            //for (int i = 0; i < aciertos.Count(); i++)
            //    {
            //        tiro = aciertos[i];

            //        if (posicionX == tiro.Item1 && posicionY == tiro.Item2)
            //        {
            //            posicionX = 1 + (100 * GenerarAleatorio() / 10000);
            //            posicionY = 1 + (100 * GenerarAleatorio() / 10000);
            //            i = 0;

            //            for (int j = 0; j < fallos.Count(); j++)
            //            {
            //                tiro = fallos[i];

            //                if (posicionX == tiro.Item1 && posicionY == tiro.Item2)
            //                {
            //                    posicionX = 1 + (100 * GenerarAleatorio() / 10000);
            //                    posicionY = 1 + (100 * GenerarAleatorio() / 10000);
            //                j = 0;
            //                }

            //            }
            //        }
                
            //     }

            foreach (List<Tuple<int, int>> i in tablero)
            {
                if (i.Contains(tiro) == true)
                {
                    aciertos.Add(tiro);
                    return true;
                }
                //foreach(Tuple<int, int> j in i)
                //{
                //    if (posicionX == j.Item1 && posicionY == j.Item2)
                //    {
                //        aciertos.Add(Tuple.Create( posicionX, posicionY ) );
                //        return true;
                //    }
                //}
            }
            fallos.Add(tiro);
            return false;
        }

        public Boolean EstrategiaCaza(List<List<Tuple<int, int>>> tablero, List<Tuple<int, int>> aciertos, List<Tuple<int, int>> fallos)
        {
            if (posicionCazaX == 100)
            {
                if (posicionCazaXInicial == 100)
                {
                    posicionCazaY = posicionCazaYInicial + 1;
                    posicionCazaYInicial++;
                    posicionCazaX = 0;
                }
                else
                {
                    posicionCazaX = posicionCazaXInicial + 1;
                    posicionCazaXInicial++;
                    posicionCazaY = 0;
                }
            }
            posicionCazaX++;
            posicionCazaY++;
            Tuple<int, int> tiro = Tuple.Create(posicionCazaX,posicionCazaY);
            while (fallos.Contains(tiro) == true || aciertos.Contains(tiro) == true)
            {
                posicionCazaX++;
                posicionCazaY++;
                tiro = Tuple.Create(posicionCazaX , posicionCazaY);
            }

            foreach (List<Tuple<int, int>> i in tablero)
            {
                if (i.Contains(tiro) == true)
                {
                    aciertos.Add(tiro);
                    return true;
                }

            }
            fallos.Add(tiro);
            return false;
            //foreach (List<Tuple<int, int>> i in tablero)
            //{
            //    foreach (Tuple<int, int> j in i)
            //    {
            //        if (posicionCazaX == j.Item1 && posicionCazaY == j.Item2)
            //        {
            //            aciertos.Add(Tuple.Create(posicionCazaX, posicionCazaY));
            //            acierto2Numero = 0;
            //            return true;
            //        }
            //    }
            //}


        }

        public Boolean UndirBarco(List<List<Tuple<int, int>>> tablero, List<Tuple<int, int>> aciertos, List<Tuple<int, int>> fallos, int direccion , int jugador)
        {
            int x = 0;
            int y = 0;
            int xF = 0;
            int yF= 0;
            Boolean posible = false;
            Tuple<int, int> tiro;
            //foreach( Tuple<int,int> i in aciertos )
            //{
            //    x = i.Item1;
            //    y = i.Item2;
            //}
            tiro = aciertos[(aciertos.Count() - 1)];
            x = tiro.Item1;
            y = tiro.Item2;
            xF = x;
            yF = y;
            do
            {
                if(direccion == 1)
                {
                    x = x + 1;
                }
                if (direccion == 2)
                {
                    x = x - 1;
                }
                if (direccion == 3)
                {
                    y = y + 1;
                }
                if (direccion == 4)
                {
                    y = y - 1;
                }
                if (direccion > 4)
                {
                    if (jugador == 1)
                    {
                        undirBarcoJugador1 = 1;
                    }
                    else
                    {
                        undirBarcoJugador2 = 1;
                    }
                    return false;

                }
                //switch (direccion)
                //{
                //    case 1:
                //        x = x + 1;
                //        break;
                //    case 2:
                //        x = x - 1;
                //        break;
                //    case 3:
                //        y = y + 1;
                //        break;
                //    case 4:
                //        y = y - 1;
                //        break;
                //    default:
                //        Thread.Sleep(500);
                //        direccion = 1;
                //        return false;
                //        //if(jugador == 1)
                //        //{
                //        //    undirBarcoJugador1 = 1;
                //        //    acierto1Numero = 100;
                //        //}
                //        //else
                //        //{
                //        //    undirBarcoJugador2 = 1;
                //        //    acierto2Numero = 100;
                //        //}
                //        //return false;
                //}
                tiro = Tuple.Create(x, y);
                if (x < 1 || x > 100 || y < 1 || y > 100)
                {
                    direccion++;
                    if (jugador == 1)
                    {
                        undirBarcoJugador1++;
                    }
                    else
                    {
                        undirBarcoJugador2++;
                    }
                    x = xF;
                    y = yF;

                }
                else
                {

                    if (fallos.Contains(tiro) == true) /*|| aciertos.Contains(tiro) == true)*/
                    {
                        posible = false;
                        direccion++;
                        if (jugador == 1)
                        {
                            undirBarcoJugador1++;
                        }
                        else
                        {
                            undirBarcoJugador2++;
                        }
                        x = xF;
                        y = yF;
                    }
                    else if (aciertos.Contains(tiro) == false)
                    {
                        posible = true;
                    }

                    //posible = true;

                    //for (int i = 0; i < aciertos.Count(); i++)
                    //{
                    //    tiro = aciertos[i];

                    //    if (x == tiro.Item1 && y == tiro.Item2)
                    //    {
                    //        posible = false;
                    //        xF = x;
                    //        yF = y;
                    //    }

                    //}
                    //for (int j = 0; j < fallos.Count(); j++)
                    //{
                    //    tiro = fallos[j];

                    //    if (x == tiro.Item1 && y == tiro.Item2)
                    //    {
                    //        posible = false;
                    //        direccion++;
                    //        xF = x;
                    //        yF = y;
                    //    }

                    //}

                }
            } while (posible == false);

            foreach (List<Tuple<int, int>> i in tablero)
            {
                if(i.Contains(tiro)==true)
                {
                    aciertos.Add(tiro);
                    return true;
                }
                //foreach (Tuple<int, int> j in i)
                //{
                //    if (x == j.Item1 && y == j.Item2)
                //    {
                //        aciertos.Add(Tuple.Create(x, y));
                //        return true;
                //    }
                //}
            }
            fallos.Add(tiro);
            if (jugador == 1)
            {
                undirBarcoJugador1++;
                if (undirBarcoJugador1 == 5)
                {
                    undirBarcoJugador1 = 1;
                    return false;
                }
            }
            else
            {
                undirBarcoJugador2++;
                if (undirBarcoJugador2 == 5)
                {
                    undirBarcoJugador2 = 1;
                    return false;
                }
            }
            return true;

        }
        public int Partida()
        {

            while (aciertosJugador1.Count() != 40 || aciertosJugador2.Count() != 40)
            {
                //Jugador 1 dispara tablero 2
                if (acierto1 == false)
                {
                    acierto1 = EstrategiaAzar(tablero2, aciertosJugador1, fallosJugador1);
                }
                else
                {
                    // modificar la direccion, no se esta cambiando
                    acierto1 = UndirBarco(tablero2, aciertosJugador1, fallosJugador1,undirBarcoJugador1, 1);
                    if (aciertosJugador1.Count() == 40)

                        return 1;
                }
                
                // Jugador 2 dispara tablero 1
                if (acierto2 == false)
                {
                    acierto2 = EstrategiaCaza(tablero1, aciertosJugador2, fallosJugador2);
                }
                else
                {
                    acierto2 = UndirBarco(tablero1, aciertosJugador2, fallosJugador2, undirBarcoJugador2,2);
                    if (aciertosJugador2.Count() == 40)
                    {
                        return 2;
                    }
                }
            }

            return 1;
        }
    }
}
