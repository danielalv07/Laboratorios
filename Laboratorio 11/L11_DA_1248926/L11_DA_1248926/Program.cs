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
            /*int largo;
            string contraseña;
            int mayus = 0;
            int num = 0;
            int numCorrecto = 0;
            int num2 = 0;
            Console.WriteLine("Ingrese una contraseña con: ");
            Console.WriteLine("Al menos una mayúscula");
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
                    if ((contraseña[i] == Char.ToUpper(contraseña[i])) && (Convert.ToInt32(contraseña[i]) < 49 || Convert.ToInt32(contraseña[i]) > 57))
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
                        for (int g = 49; g < 58; g++)
                        {
                            if (Convert.ToInt32(contraseña[j]) == g)
                            {
                                numCorrecto = 1;
                            }
                            num = num + 1;
                        }
                        num = 0;

                    }

                    if (numCorrecto != 1)
                    {
                        Console.WriteLine("Contraseña inválida, no tiene números");
                    }
                }
                if (largo > 8 && mayus == 1 && numCorrecto == 1)
                {
                    Console.WriteLine("Contraseña válida.");
                }
            }*/

            //Ejercicio 2
            string palabra, palabrai ="";
            int largopalabra;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Ingrese una palabra:");
            palabra = Console.ReadLine();
            largopalabra = palabra.Length;
            palabrai = palabra;
            for (int i = 0; i < largopalabra; i++)
            {
                palabrai[i] = palabra[largopalabra - i - 1];
            }
            Console.WriteLine(palabrai);
        }


    }
}
