using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_DA_1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            string modelo = "FNasa12";
            int carga = 3000;
            float NivelCombustible = 25.5f;
            Boolean SaltoActivo = true;
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Carga: " + carga);
            Console.WriteLine("Nivel del combustible " + NivelCombustible);
            Console.WriteLine("¿Es de salto activo? " + SaltoActivo);

            //Ejercicio 2
            short sensoresActivos = 128;
            int registroProcesador = Convert.ToInt32(sensoresActivos);
            double precisionTotal = Convert.ToDouble(registroProcesador);
            Console.WriteLine("Precisión total: " + precisionTotal);

            //Ejercicio 3
            double energiaGenerada = 987.65;

            int energiaLimitada = (int)energiaGenerada;

            Console.WriteLine("Energía Generada: " + energiaGenerada);
            Console.WriteLine("Energía Limitada: " + energiaLimitada);

            //Ejercicio 4
            string entradaRadar;

            Console.WriteLine("Ingrese la distancia en números del planeta más cercano");
            entradaRadar = Console.ReadLine();

            int distancia = int.Parse(entradaRadar);
            distancia = distancia + 100;
            Console.WriteLine("La distancia segura es: " + distancia);
            






        }
    }
}
