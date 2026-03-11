using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L8_DA_1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int nota, contador, contAprobados, contReprobados;
            int suma = 0;
            contReprobados = 0;
            contAprobados = 0;
            contador = 1;
            while (contador <= 10)
            {
                contador++;
                Console.WriteLine("Ingrese una nota");
                nota = int.Parse(Console.ReadLine());
                suma = suma + nota;
                if (nota < 61)
                {
                    contReprobados++;
                }
                else
                {
                    contAprobados++;
                }
            }
            Console.WriteLine("La cantidad de aprobados son: " + contAprobados);
            Console.WriteLine("La cantidad de reprobados son: " + contReprobados);
            Console.WriteLine("El promedio de la clase fue: " + suma / 10);

            //Ejercicio 2
            int numero, contadorPar, contadorImpar, cont, suma2;
            Console.WriteLine("Ingrese el número");
            numero = int.Parse(Console.ReadLine());
            cont = 1;
            suma2 = 0;
            contadorPar = 0;
            contadorImpar = 0;
            while (numero >= cont)
            {
                suma2 = suma2 + cont;
                cont++;
                if (suma2 % 2 == 0)
                {
                    contadorPar++;
                }
                else
                {
                    contadorImpar++;
                }
            }
            Console.WriteLine("La suma de todos los números es: " + suma2);
            Console.WriteLine("Hay " + contadorPar + " números pares");
            Console.WriteLine("Hay" + contadorImpar + " números impares");

            //Ejercicio 3
            

        }
    }
}
