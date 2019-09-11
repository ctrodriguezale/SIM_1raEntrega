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

        public string SimularMilJuegos(ProgressBar progreso)
        {
            //int jugador1CantDisparos = 0;
            //int jugador1CantAciertos = 0;
            //int jugador2CantDisparos = 0;
            //int jugador2CantAciertos = 0;


            //posicionar barcos
            PosicionarBarcos(tablero1, tablero2);
            //hacer juego de mil
            for (int i = 0; i < 100; i++)
            {
                int resultado = Partida();
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
                progreso.Increment(1);
                var stopwatch = Stopwatch.StartNew();
                Thread.Sleep(500); //tiempo de pausa
                stopwatch.Stop();
                PosicionarBarcos(tablero1, tablero2);
            }
            //calcular estadisticas 
            return string.Format("El jugador 1 gano {0} partidas de 1000. El jugado 2 gano {1} de 1000", jugador1PartidasGanadas, jugador2PartidasGanadas);

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
            PosicionarBarco(8,true,tablero1);
            PosicionarBarco(4, true, tablero1);
            PosicionarBarco(8,false, tablero1);
            PosicionarBarco(8, true, tablero2);
            PosicionarBarco(4,false, tablero2);
            PosicionarBarco(8, true, tablero2);

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

            for (int i = 0; i < fallos.Count(); i++)
            {
                tiro = fallos[i];

                if (posicionX == tiro.Item1 && posicionY == tiro.Item2)
                {
                    posicionX = 1 + (100 * GenerarAleatorio() / 10000);
                    posicionY = 1 + (100 * GenerarAleatorio() / 10000);
                }

            }
            for (int i = 0; i < aciertos.Count(); i++)
                {
                    tiro = aciertos[i];

                    if (posicionX == tiro.Item1 && posicionY == tiro.Item2)
                    {
                        posicionX = 1 + (100 * GenerarAleatorio() / 10000);
                        posicionY = 1 + (100 * GenerarAleatorio() / 10000);
                        i = 0;

                        for (int j = 0; j < fallos.Count(); j++)
                        {
                            tiro = fallos[i];

                            if (posicionX == tiro.Item1 && posicionY == tiro.Item2)
                            {
                                posicionX = 1 + (100 * GenerarAleatorio() / 10000);
                                posicionY = 1 + (100 * GenerarAleatorio() / 10000);
                            j = 0;
                            }

                        }
                    }
                
                 }

            foreach (List<Tuple<int, int>> i in tablero)
            {
                foreach(Tuple<int, int> j in i)
                {
                    if (posicionX == j.Item1 && posicionY == j.Item2)
                    {
                        aciertos.Add(Tuple.Create( posicionX, posicionY ) );
                        return true;
                    }
                }
            }
            fallos.Add(Tuple.Create(posicionX, posicionY));
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
            foreach (List<Tuple<int, int>> i in tablero)
            {
                foreach (Tuple<int, int> j in i)
                {
                    if (posicionCazaX == j.Item1 && posicionCazaY == j.Item2)
                    {
                        aciertos.Add(Tuple.Create(posicionCazaX, posicionCazaY));
                        return true;
                    }
                }
            }
            fallos.Add(Tuple.Create(posicionCazaX, posicionCazaY));
            return false;

        }

        public Boolean UndirBarco(List<List<Tuple<int, int>>> tablero, List<Tuple<int, int>> aciertos, List<Tuple<int, int>> fallos, int direccion)
        {
            int x = 0;
            int y = 0;
            int xF = 0;
            int yF= 0;
            Boolean posible = false;
            Tuple<int, int> tiro;
            foreach( Tuple<int,int> i in aciertos )
            {
                x = i.Item1;
                y = i.Item2;
            }
            xF = x;
            yF = y;
            while (posible == false)
            {
                switch (direccion)
                {
                    case 1:
                        x = x + 1;
                        break;
                    case 2:
                        x = x - 1;
                        break;
                    case 3:
                        y = y + 1;
                        break;
                    case 4:
                        y = y - 1;
                        break;
                    default:
                        direccion = 1;
                        return false;
                }
                if( x < 1 || x > 100 || y < 1 || y > 100)
                {
                    direccion++;
                    xF = x;
                    yF = y;

                }
                else
                {
                    posible = true;

                    for (int i = 0; i < aciertos.Count(); i++)
                    {
                        tiro = aciertos[i];

                        if (x == tiro.Item1 && y == tiro.Item2)
                        {
                            posible = false;
                            xF = x;
                            yF = y;
                        }

                    }
                    for (int j = 0; j < fallos.Count(); j++)
                    {
                        tiro = fallos[j];

                        if (x == tiro.Item1 && y == tiro.Item2)
                        {
                            posible = false;
                            direccion++;
                            xF = x;
                            yF = y;
                        }

                    }

                }
            }

            foreach (List<Tuple<int, int>> i in tablero)
            {
                foreach (Tuple<int, int> j in i)
                {
                    if (x == j.Item1 && y == j.Item2)
                    {
                        aciertos.Add(Tuple.Create(x, y));
                        return true;
                    }
                }
            }
            fallos.Add(Tuple.Create(x, y));
            return true;

        }
        public int Partida()
        {
            bool acierto1 = false;
            bool acierto2 = false;

            while (aciertosJugador1.Count() != 20 || aciertosJugador2.Count() != 20)
            {
                //Jugador 1 dispara tablero 2
                if (acierto1 == false)
                {
                    acierto1 = EstrategiaAzar(tablero2, aciertosJugador1, fallosJugador1);
                }
                else
                {
                    acierto1 = UndirBarco(tablero2, aciertosJugador1, fallosJugador1,undirBarcoJugador1);
                    if (aciertosJugador1.Count() == 20)

                        return 1;
                }
                
                // Jugador 2 dispara tablero 1
                if (acierto2 == false)
                {
                    acierto2 = EstrategiaCaza(tablero1, aciertosJugador2, fallosJugador2);
                }
                else
                {
                    acierto2 = UndirBarco(tablero1, aciertosJugador2, fallosJugador2, undirBarcoJugador2);
                    if (aciertosJugador2.Count() == 20)
                    {
                        return 2;
                    }
                }
            }

            return 1;
        }
    }
}
