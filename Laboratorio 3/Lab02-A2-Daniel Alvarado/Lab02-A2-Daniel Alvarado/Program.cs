using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_A2_Daniel_Alvarado
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Coloque su nombre");
            string nombre;
           nombre = Console.ReadLine();
           Console.WriteLine("Coloque el nombre del curso");
            string nombreCurso;
           nombreCurso = Console.ReadLine();
           Console.WriteLine("Lab de pensamiento Computacional");
            Console.Write(nombre);
            Console.Write(" vas muy bien en el curso de ");
            Console.WriteLine(nombreCurso);
            Console.WriteLine("Nunca te rindas.");
           Console.WriteLine("Presione cualquier tecla para salir.");
           Console.ReadKey();

        }
    }
}
