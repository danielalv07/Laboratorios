using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            int num = 0;
            int numCorrecto = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese una contraseña con: ");
            Console.WriteLine("Al menos 8 caracteres");
            Console.WriteLine("Al menos 1 número");
            Console.WriteLine("Al menos un carácter especial");
            contraseña = Console.ReadLine();
            largo = contraseña.Length;
            if (largo < 8)
            {
                Console.WriteLine("Contraseña inválida, no es lo suficientemente larga");
            }
            else
            {
                for (int i = 0; i < largo; i++)
                {
                    if (contraseña[i] == Char.ToUpper(contraseña[i]))
                    {
                        mayus = 1;
                    }
                }
                if (mayus != 1)
                {
                    Console.WriteLine("Contraseña inválida, no tiene mayúsculas");
                }
                else
                {
                    for (int j = 0; j < largo; j++)
                    {
                        for (int g = 0; g < 10; g++)
                        {
                            if (contraseña[j] == num)
                            {
                                numCorrecto = 1;
                            }
                            num = num + 1;
                        }

                    }
                    if (numCorrecto != 1)
                    {
                        Console.WriteLine("Contraseña inválida, no tiene mnúmeros");
                    }
                    if (largo > 8 && mayus == 1 && numCorrecto == 1)
                    {
                        Console.WriteLine("Contraseña válida.");
                    }
                }
            }   
        }


    }
}
