using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Practica7
{
    class ArregloAleatorio
    {
        public static Random r;
        public static int[,] numeros;

        public static void CargarDatos()
        {
            r = new Random();
            for (int f = 0; f < numeros.GetLength(0); f++)
            {
                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                    numeros[f, c] = r.Next(10, 99);
                }
            }
            Console.WriteLine();
            Console.WriteLine("La matriz se generó correctamente !!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione <enter> para regresar al menú...");
            Console.ReadLine();
        }

        public static void MostrarDatos()
        {
            Console.WriteLine("┌──┬──┬──┬──┬──┬──┬──┬──┬──┬──┐");
            for (int f = 0; f < numeros.GetLength(0); f++)
            {
                Console.Write("│");
                for (int c = 0; c < numeros.GetLength(0); c++)
                {
                    if (numeros[f, c] == 0)
                    {
                        Console.Write("00");
                    }
                    else
                    {
                        if ((numeros[f, c] != 0) && (numeros[f, c] % 2 == 0))
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.Write(numeros[f, c]);
                    }
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("│");
                }

                Console.WriteLine();
                if (f < 9)
                {
                    Console.WriteLine("├──┼──┼──┼──┼──┼──┼──┼──┼──┼──┤");
                }
            }
            Console.WriteLine("└──┴──┴──┴──┴──┴──┴──┴──┴──┴──┘");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione <enter> para regresar al menú...");
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            int op = 0;
            numeros = new int[10, 10];
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("[1] Llenar matriz");
                Console.WriteLine("[2] Ver matriz");
                Console.WriteLine("[3] Salir");
                Console.WriteLine();
                Console.Write("Su opción es: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CargarDatos();
                        break;
                    case 2:
                        MostrarDatos();
                        break;
                }
            } while (op != 3);
        }
    }
}
