using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_DA1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int num;
            Console.WriteLine("Ingrese un número positivo: ");
            num = int.Parse(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("Número inválido");
                num = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
