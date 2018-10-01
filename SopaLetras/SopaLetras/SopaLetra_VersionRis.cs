using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class PuttingWords
    {
        static void NuestroNombres()
        {
            Console.WriteLine("screewed");
            Console.WriteLine("");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine("╔══════════════════════════════════════════════════╗");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine("║ Bienvenidos a la sopa de letras elaborada por:   ║");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.SetCursorPosition(30, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║ Rene Francisco Santamaría Calderon               ║");
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.SetCursorPosition(30, 11);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║ Ronald Ernesto Tejada Ríos                       ║");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.SetCursorPosition(30, 13);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("║ Hector Ernesto Amaya                             ║");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("║ Diego José Cortés Moreno                         ║");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("╠══════════════════════════════════════════════════╣");
            Console.SetCursorPosition(30, 17);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ Presione cualquier tecla para continuar<>        ║");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("╚══════════════════════════════════════════════════╝");
            Console.SetCursorPosition(30, 19);
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        static void GameBoy(string[,] SOPA)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(132, Console.LargestWindowHeight);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" ║      ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗      ║");
            for (int i = 0; i < SOPA.GetLength(0)*2+2; i++)
            {
            Console.WriteLine(" ║      ║                                                                                                                  ║      ║");
            }
            Console.WriteLine(" ║      ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝      ║");
            Console.WriteLine(" ║      ╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗      ║");
            Console.WriteLine(" ║      ║                                                                                                                  ║      ║");
            Console.WriteLine(" ║      ║                                                                                                                  ║      ║");
            Console.WriteLine(" ║      ║                                                                                                                  ║      ║");
            Console.WriteLine(" ║      ╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝      ║");
            Console.WriteLine(" ║                ╔═╗                                                                                                    ╔═╗      ║");
            Console.WriteLine(" ║              ╔═╝ ╚═╗                                                                                                  ╚═╝      ║");
            Console.WriteLine(" ║              ╚═╗ ╔═╝                                 ╔═╗            ╔═╗                                         ╔═╗            ║");
            Console.WriteLine(" ║                ╚═╝                                   ╚═╝            ╚═╝                                         ╚═╝            ║");
            Console.WriteLine(" ║                                                                                                                                ║");
            Console.WriteLine(" ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {

            string[,] words = new string[,] {
                {  "ITALIA" , "LONDRES" , "VENECIA", "JAPON","GALWAY","BRASIL","PORTUGAL","RUSIA","HAWAII","ARGENTINA","INGLATERRA","FRANCIA","SUIZA","DINAMARCA","TOKYO"}
                
            };
            NuestroNombres();

            int tamano=0,x,y,cantP,Categ,disp,Tipo=2, aux,pos,cantUsados, posX,posY ;
            bool inverso=false;
            /**
            Console.WriteLine("Ingrse el tema");
            tema = Convert.ToInt32(Console.ReadLine());
            **/
            int nivel=-1, cantMin=0, CantMax=0;
           
            do
            {
                Console.WriteLine("Bienvenido Al Juego Sopa de Letras");
                Console.WriteLine("    Seleccione la");
                Console.WriteLine("        Dificultad:");
                Console.WriteLine("»1-Dificultad Facil");
                Console.WriteLine("»2-Dificultad Media");
                Console.WriteLine("»3-Dificultad Dificil");
                Console.WriteLine("»4-Salir del juego");
                nivel = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (nivel < 1 || nivel > 3)
                {
                    Console.WriteLine("Debe ingresar un 1, un 2 o un 3");
                    Console.ReadKey();
                    Console.Clear();
                }

                switch (nivel)
                {
                    case 1:
                        cantMin = 5;
                        CantMax = 8;
                        tamano = 12;
                        Tipo = 2;
                        break;
                    case 2:
                        cantMin = 7;
                        CantMax = 12;
                        tamano = 15;
                        Tipo = 3;
                        break;
                    case 3:
                        cantMin = 10;
                        CantMax = 15;
                        tamano = 20;
                        Tipo = 3;
                        inverso = true;
                        break;
                    default:
                        break;
                }
            } while (nivel < 1 || nivel > 3);

            
            bool palabraAsignada;
            string[,] SOPA = new string[tamano, tamano];
            for (int i = 0; i < tamano; i++)
            {
                for (int j = 0; j < tamano; j++)
                {
                    SOPA[i, j] = "0";
                }
            }
            Random r = new Random();
            //cant de palabras a ubicar
            Categ = 0;
            cantP = r.Next(cantMin, CantMax+1);
             string[] catUsada = new string[cantP];
            int[] indices = new int[cantP];
            indices[0] = r.Next(0, CantMax);
            cantUsados = 0;
            do{
                aux = r.Next(0, CantMax);
                pos = cantUsados; 
                while(pos>=0 && aux != indices[pos])
                {

                    if (pos == 0) {
                        indices[++cantUsados] = aux;
                    }
                    pos--;
                }
            } while (cantUsados<cantP-1);

            for (int i = 0; i < cantP; i++)
            {
                pos = indices[i];
                catUsada[i] = words[Categ,pos];
            }
            Console.WriteLine(cantP + " Palabras");
            for (int i = 0; i < cantP; i++)
            {
                Console.WriteLine(catUsada[i]);
            }
            int HVD;
            for (int i = 0; i < cantP; i++)
            {
                palabraAsignada = false;
                do
                {
                  
                    pos = catUsada[i].Length - 1;
                    disp = tamano - catUsada[i].Length - 1;
                    HVD = r.Next(0, Tipo);
                    switch (HVD)
                    {
                        case 0:
                            //1 HORIZONTAL
                            x = r.Next(0, disp);
                            y = r.Next(0, tamano - 1);
                            posX = x;
                            posY = y;
                            while (pos >= 0 && SOPA[y, x++] == "0")
                            {
                                if (pos == 0)
                                {
                                    //Almaceno la palabra
                                    if (inverso == false)
                                    {   //Guardo la palabra normal
                                        for (int n = 0; n < catUsada[i].Length; n++)
                                        {
                                             SOPA[posY, posX++] = catUsada[i].Substring(n, 1);
                                        }
                                    }
                                    else
                                    {   //Guardo la palabra pero invertida
                                        for (int n = catUsada[i].Length-1; n >= 0; n--)
                                        {
                                            SOPA[posY, posX++] = catUsada[i].Substring(n, 1);
                                        }
                                    }
                                    palabraAsignada = true;
                                }
                                pos--;
                            }
                            break;
                        case 1:
                            //2 VERTICAL
                            x = r.Next(0, tamano-1);
                            y = r.Next(0, disp);
                            posX = x;
                            posY = y;
                            while (pos >= 0 && SOPA[y++, x] == "0")
                            {
                                if (pos == 0)
                                {
                                    //Almaceno la palabra
                                    if (inverso==false)
                                    {   //Guardo la palabra normal
                                        for (int n = 0; n < catUsada[i].Length; n++)
                                        {
                                            SOPA[posY++, posX] = catUsada[i].Substring(n, 1);

                                        }
                                    }
                                    else
                                    {   //Guardo la palabra pero invertida
                                        for (int n = catUsada[i].Length - 1; n >=0; n--)
                                        {
                                            SOPA[posY++, posX] = catUsada[i].Substring(n, 1);

                                        }
                                    }
                                    
                                    palabraAsignada = true;
                                }
                                pos--;
                            }

                            break;

                        case 2:
                            //3 DIAGONAL ...
                            x = r.Next(0, disp);
                            y = r.Next(0, disp);
                            posX = x;
                            posY = y;

                            while (pos >= 0 && SOPA[y++, x++] == "0")
                            {
                                if (pos == 0)
                                {
                                    //Almaceno la palabra
                                    if (inverso == false)
                                    {   //Guardo la palabra normal
                                        for (int n = 0; n < catUsada[i].Length; n++)
                                        {
                                            SOPA[posY++, posX++] = catUsada[i].Substring(n, 1);
                                        }
                                    }
                                    else
                                    {   //Guardo la palabra pero invertida
                                        for (int n = catUsada[i].Length-1; n >= 0; n--)
                                        {
                                            SOPA[posY++, posX++] = catUsada[i].Substring(n, 1);
                                        }
                                    }
                                    palabraAsignada = true;
                                }
                                pos--;
                            }
                            break;

                    }
                    
                } while (palabraAsignada == false);
            }
            Console.WriteLine();
            Console.WriteLine("SOPA.GetLenght(0) = {0}", SOPA.GetLength(0));
            Console.ReadKey();
            GameBoy(SOPA);

            //CUADRICULA
            //Cabeza
            Console.ForegroundColor = ConsoleColor.Blue;

            
            //Coordenadas horizontales
            Console.SetCursorPosition(15, 2);
            for (int i = 0; i < SOPA.GetLength(0); i++)
            {
                Console.Write(" {0}",i + 1);
                if (i < 9) {
                    Console.Write(" ");
                }
            }
            //Coordenadas verticales
            for (int i = 0; i < SOPA.GetLength(0); i++)
            {
                Console.SetCursorPosition(13, 4+i*2);
                Console.WriteLine(i + 1);
            }
            int posCursor = 3;
            Console.SetCursorPosition(15, posCursor++);
            Console.Write("┌─");
            for (int z = 0; z < SOPA.GetLength(0)-1; z++)
            {
                Console.Write("─┬─");
            }
            Console.WriteLine("─┐");
            //Cuerpo
            for (int f = 0; f < SOPA.GetLength(0); f++)
            {
                Console.SetCursorPosition(15, posCursor++);
                for (int c = 0; c < SOPA.GetLength(0); c++)
                {
                    Console.Write("│");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (SOPA[f,c]!="0")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write(SOPA[f, c]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" ");
                }
                Console.Write("│");

                
                
                if (f!= SOPA.GetLength(0)-1)
                {
                    Console.SetCursorPosition(15, posCursor++);
                    Console.Write("├─");
                    for (int z = 0; z < SOPA.GetLength(0) - 1; z++)
                    {
                        Console.Write("─┼─");
                    }
                    Console.WriteLine("─┤");
                }
                
            }//Fondo
            Console.SetCursorPosition(15, posCursor++);
            Console.Write("└─");
            for (int z = 0; z < SOPA.GetLength(0)-1; z++)
            {
                Console.Write("─┴─");
            }
            Console.WriteLine("─┘");
            

            

            Console.ReadKey();
        }
    }
}
