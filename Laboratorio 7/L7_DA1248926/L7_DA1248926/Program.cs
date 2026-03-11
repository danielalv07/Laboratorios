using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_DA1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            //entrada
            int numero;
            int contador = 1;
            int suma = 0;
            Console.WriteLine("Ingrese el primer número");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("Ingrese otro número mayor 0");
                numero = int.Parse(Console.ReadLine());
            }
            //proceso
            while (contador <= numero)
            {
                suma = suma + contador;
                contador++;
            }
            float promedio = suma / numero;
            //salida
            Console.WriteLine("El promedio es " + promedio);
            Console.WriteLine("La suma es " + suma);

            //Ejercicio 2

            Console.WriteLine("");
            //entrada
            double farenheit;
            double Celsius;
            double Km;
            double Millas;
            int decision;
            do
            {
                Console.WriteLine("Para convertir Celsius a Fahrenheit coloque: 1");
                Console.WriteLine("Para convertir Fahrenheit a Celsius coloque 2");
                Console.WriteLine("Para convertir Kilómetros a Millas coloque 3");
                Console.WriteLine("Para salir coloque 4");
                decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 1:
                        Console.WriteLine("Ingrese los grados en Celsius");
                        Celsius = double.Parse(Console.ReadLine());
                        farenheit = (Celsius * 1.8) + 32;
                        Console.WriteLine("Los grados en Farenheit son" + farenheit);
                    break;
                    case 2:
                        Console.WriteLine("Ingrese los grados en Fahrenheit"
                }
            }while (decision > 0 && decision < 4);
        }

    }
}
