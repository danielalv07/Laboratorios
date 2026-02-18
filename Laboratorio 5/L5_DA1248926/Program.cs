using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_DA1248926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int idUsuario, pin, tokenSeguridad, modoSeguro;
            string modo;
            Console.WriteLine("Coloque ID de usuario");
            idUsuario = Convert.ToInt32(Console.ReadLine());

            if (idUsuario == 2026)
            {
                Console.WriteLine("Usuario Reconocido");
            }
            else
            {
                Console.WriteLine("Usuario no Reconocido");
            }

            Console.WriteLine("Coloque el PIN");
            pin = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToInt32(pin) == 1234)
            {
                Console.WriteLine("PIN correcto");
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            Console.WriteLine("Coloque el Token de Seguridad");
            tokenSeguridad = Convert.ToInt32(Console.ReadLine());

            if (Convert.ToInt32(tokenSeguridad) == 777)
            {
                Console.WriteLine("Token válido");
            }
            else
            {
                Console.WriteLine("Token inválido");
            }

            Console.WriteLine("¿Modo seguro activado?");
            modo = Console.ReadLine();

            if (modo.ToLower() == "si")
            {
                modoSeguro = 1;
            }
            else
            {
                modoSeguro = 0;
            }

            if (modoSeguro == 1)
            {
                Console.WriteLine("Modo seguro activado: se aplican reglas extra");
            }
            else
            {
                Console.WriteLine("Modo seguro desactivado");
            }

            if (idUsuario == 2026 && pin == 1234 && tokenSeguridad == 777)
            {
                Console.WriteLine("Acceso total concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            if (modoSeguro == 1)
            {
                if (tokenSeguridad >= 700)
                { 
                    Console.WriteLine("Regla extra aprobada");
                }
                else
                {
                    Console.WriteLine("Regla extra fallida");
                }
            }

            //Ejercicio 2


        }
    }
}
