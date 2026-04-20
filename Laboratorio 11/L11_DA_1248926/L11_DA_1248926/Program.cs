using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_DA_1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int largo;
            string contraseña;
            int mayus = 0;
            Console.WriteLine("Ingrese una contraseña con: ");
            Console.WriteLine("Al menos 8 caracteres");
            Console.WriteLine("Al menos 1 número");
            Console.WriteLine("Al menos un carácter especial");
            contraseña = Console.ReadLine();
            largo = contraseña.Length;

            for (int i = 0; i < largo; i++)
            {
                if (largo < 8)
                {
                    Console.WriteLine("Contraseña inválida, no es lo suficientemente larga");
                    
                }
                if (contraseña[i] == Char.ToUpper(contraseña[i]))
                {
                    mayus = 1;
                    i = largo - 1;
                }
                if (mayus != 1) { Console.WriteLine("Contraseña inválida, no tiene mayúsculas"); }
            }

        }
    }
}
