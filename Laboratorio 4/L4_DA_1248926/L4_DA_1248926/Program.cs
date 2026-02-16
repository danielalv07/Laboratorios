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

            //Ejercicio 5
            string señalOxigeno = "true";
            Convert.ToBoolean(señalOxigeno);

            string temperaturaCabina = "22.8";
            Convert.ToDouble(temperaturaCabina);

            Console.WriteLine("La señal de oxígeno es: " + señalOxigeno);
            Console.WriteLine("La temperatura de la cabina es: " + temperaturaCabina);

            //Ejercicio 6
            double velocidadLuz = 299792.458;

            string stringVelocidad = velocidadLuz.ToString("N3");
            Console.WriteLine("La velocidad de la luz es: " + stringVelocidad);

            //Ejercicio 7
            string precioGalón;
            Console.WriteLine("Coloque el Precio por Galón de Litio");
            precioGalón = Console.ReadLine();

            double impuestoGaláctico = Convert.ToDouble(precioGalón) * 0.12;

            double costoTotal = Convert.ToDouble(precioGalón) + impuestoGaláctico;
            Console.WriteLine("El costo final del suministro es: " + (int)costoTotal);



            






        }
    }
}
