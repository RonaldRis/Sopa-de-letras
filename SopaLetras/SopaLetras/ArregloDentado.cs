using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class ArregloDentado
    {
        public static String[][] datos;

        public static void CargarDatos()
        {
            int grupos, integrantes;
            Console.Write("Cuantos grupos desea crear: ");
            grupos =  Convert.ToInt32(Console.ReadLine());
            datos = new String[grupos][];
            for (int g = 0; g < datos.Length; g++)
            {
                Console.WriteLine();
                Console.Write("Cuantos integrantes tiene el grupo "+(g+1)+":");
                integrantes = Convert.ToInt32(Console.ReadLine());
                datos[g] = new String[integrantes];
                for (int i = 0; i < datos[g].Length; i++)
                {
                    Console.Write("Ingrese el nombre del integrante "+(i+1)+":");
                    datos[g][i] = Console.ReadLine();
                }
            }
        }

        public static void MostrarDatos()
        {
            Console.WriteLine();
            Console.WriteLine("Información de los grupos:");
            for (int g = 0; g < datos.Length; g++)
            {
                Console.Write("Grupo "+(g+1)+": ");
                for (int i = 0; i < datos[g].Length; i++)
                {
                    Console.Write(datos[g][i]+" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            CargarDatos();
            MostrarDatos();
            Console.ReadKey();
        }
    }
}
