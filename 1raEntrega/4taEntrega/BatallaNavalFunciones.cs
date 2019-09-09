using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4taEntrega
{
    class BatallaNavalFunciones
    {
        // 

        int[,] tablero1 = new int[100, 100];
        int[,] tablero2 = new int[100, 100];

        public string SimularMilJuegos()
        {
            //int jugador1CantDisparos = 0;
            //int jugador1CantAciertos = 0;
            //int jugador2CantDisparos = 0;
            //int jugador2CantAciertos = 0;
            int jugador1PartidasGanadas = 0;
            int jugador2PartidasGanadas = 0;

            //posicionar barcos
            PosicionarBarcos(tablero1, tablero2);
            //hacer juego de mil
            for (int i = 1; i<=2; i++)
            {
                var resultado = Partida();
                if (resultado.Item1 == 1)
                {
                    jugador1PartidasGanadas++;
                }
                else
                {
                    jugador2PartidasGanadas++;
                }
            }
            //calcular estadisticas 
            return string.Format("El jugador 1 gano {0} partidas de 1000. El jugado 2 gano {1} de 1000", jugador1PartidasGanadas, jugador2PartidasGanadas);

        }

        public void PosicionarBarco( int tamaño, string orientacion, int[,] tablero)
        {

           int x = GenerarAleatorio();
           int y = GenerarAleatorio();

            while (validarPosicion(x, y, tamaño, orientacion, tablero) == false)
            {
                x = GenerarAleatorio();
                y = GenerarAleatorio();
            }

            tablero[x, y] = 1;

            if (orientacion == "v")
            {

                for (int i = 1; i == tamaño; i++)
                {
                    tablero[x + i, y] = 1;
                }
            }
            else
            {

                for (int i = 1; i == tamaño; i++)
                {
                    tablero[x, y + 1] = 1;
                }
            }
        }

        public bool validarPosicion(int x, int y, int tamaño, string orientacion, int[,] tablero)
        {
            if (tablero[x, y] == 1)
            { return false; }
            else
            {
                if (orientacion == "v")
                {

                    for (int i = 1; i == tamaño; i++)
                    {
                        if (tablero[x + i, y] == 1)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i == tamaño; i++)
                    {
                        if (tablero[x, y + i] == 1)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

        }

        public void PosicionarBarcos(int[,] tablero1, int[,] tablero2)
        {
            //Tablero1
            //barcos de 6
            PosicionarBarco(6, "h", tablero1);
            PosicionarBarco(6, "v", tablero1);
            //barcos de 5
            PosicionarBarco(5, "v", tablero1);
            PosicionarBarco(5, "h", tablero1);
            //barcos de 4
            PosicionarBarco(4, "v", tablero1);
            PosicionarBarco(4, "h", tablero1);
            //barcos de 3
            PosicionarBarco(3, "v", tablero1);
            PosicionarBarco(3, "h", tablero1);
            //barcos de 2
            PosicionarBarco(2, "h", tablero1);
            PosicionarBarco(2, "v", tablero1);

            //Tablero2
            //barcos de 6
            PosicionarBarco(6, "h", tablero2);
            PosicionarBarco(6, "v", tablero2);
            //barcos de 5
            PosicionarBarco(5, "h", tablero2);
            PosicionarBarco(5, "v", tablero2);
            //barcos de 4
            PosicionarBarco(4, "v", tablero2);
            PosicionarBarco(4, "h", tablero2);
            //barcos de 3
            PosicionarBarco(3, "v", tablero2);
            PosicionarBarco(3, "h", tablero2);
            //barcos de 2
            PosicionarBarco(2, "v", tablero2);
            PosicionarBarco(2, "h", tablero2);
        }

        public int GenerarAleatorio()
        {
            //int x1 =0;
            //int x2 = 0;
            //int primerValor = 0;
            Random aleatorio = new Random();
            return aleatorio.Next(0, 100);
            //if (primerValor == x2)
            //{
            //    Random aleatorio = new Random();
            //    primerValor = aleatorio.Next(0, 9998);
            //    x1 = primerValor;
            //}
            //x2 = (67 * x1 + 71) % 9999;
            //x1 = x2;
            //return x2 / 10000;
        }

        public int EstrategiaAzar(int[,] tablero)
        {
            int x = GenerarAleatorio();
            int y = GenerarAleatorio();

            while (tablero[x, y] == 3 || tablero[x, y] == 2)
            {
                 x = GenerarAleatorio();
                 y = GenerarAleatorio();
            }
            if (tablero[x, y] == 1)
            {
                tablero[x, y] = 2; // disparo barco tocado
                return 2;
            }
            if (tablero[x, y] == 0)
            {
                tablero[x, y] = 3; // Dispro agua
                return 3;
            }
            return 3;
        }

        public int EstrategiaCaza(int[,] tablero)
        {
            return 3;
        }

        public Tuple<int, int, int> Partida()
        {
            int jugador1CantDisparos = 0;
            int jugador1CantAciertos = 0;
            int jugador2CantDisparos = 0;
            int jugador2CantAciertos = 0;
            do
            {
                //Jugador 1 dispara tablero 2
                int jugador1Disparo = EstrategiaAzar(tablero2);
                    jugador1CantDisparos++;

                if ( jugador1Disparo == 2)
                {
                    jugador1CantAciertos++;
                }

                // Jugador 2 dispara tablero 1
                int jugador2Disparo = EstrategiaCaza(tablero1);
                jugador2CantDisparos++;

                if (jugador2Disparo == 2)
                {
                    jugador2CantAciertos++;
                }

            } while (jugador1CantAciertos != 40 || jugador2CantAciertos != 40);
            if (jugador1CantAciertos == 40)
            {
                return Tuple.Create(1, jugador1CantAciertos, jugador1CantDisparos);
            }
            else
            {
                return Tuple.Create(2, jugador2CantAciertos, jugador2CantDisparos);
            }
            
        }
    }
}
