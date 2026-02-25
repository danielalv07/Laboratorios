using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_DA1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int opcion;
            Console.WriteLine("Coloque su tipo de vehículo: 1: Bicicleta, 2: Motocicleta, 3: Auto, 4: Camión, 5: Autobús");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Vehículo No motorizado");
                    break;
                case 2:
                    Console.WriteLine("Vehículo Ligero");
                    break;
                case 3:
                    Console.WriteLine("Vehículo Mediano");
                    break;
                case 4:
                    Console.WriteLine("Vehículo Pesado");
                    break;
                case 5:
                    Console.WriteLine("Transporte Público");
                    break;
                default: Console.WriteLine("Número no disponible en la lista");
                    break;
            }

            //Ejercicio 2
            int tipoTarjeta;
            double limite;
            Console.WriteLine("Coloque su tipo de tarjeta:");
            tipoTarjeta = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto es su límite de crédito");
            limite = double.Parse(Console.ReadLine());
            switch (tipoTarjeta)
            {
                case 1:
                    Console.WriteLine("Su nuevo limite es de " + Convert.ToInt32(limite * 1.25));
                    break;
                case 2:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
