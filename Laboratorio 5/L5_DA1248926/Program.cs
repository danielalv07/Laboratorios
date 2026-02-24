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
            int PIN;
            Console.WriteLine("Coloque el PIN:");
            PIN = Convert.ToInt32(Console.ReadLine());

            if (PIN >= 1000 && PIN <= 9999)
            {
                Console.WriteLine("PIN de 4 dígitos: OK");
            }
            else
            {
                Console.WriteLine("PIN inválido: debe tener 4 dígitos");
            }

            if (PIN % 2 == 0)
            {
                Console.WriteLine("PIN par");
            }
            else
            {
                Console.WriteLine("PIN impar");
            }

            if (PIN % 5 == 0)
            {
                Console.WriteLine("Múltiplo de 5.");
            }
            else
            {
                Console.WriteLine("No es múltiplo de 5.");
            }
            if (PIN >= 1000 && PIN <= 9999 && PIN % 2 == 0 && PIN % 5 == 0)
            {
                Console.WriteLine("PIN aceptado por política");
            }
            else
            {
                Console.WriteLine("PIN rechazado por política");
            }


            //Ejercicio 3
            int CodigoDeActivación, edad, puntaje;
            string TerminosYCondiciones, Veri2Pasos;
            bool TerminoBool, VeriBool;


            Console.WriteLine("Coloque el código de activación:");
            CodigoDeActivación = Convert.ToInt32(Console.ReadLine());
            if (CodigoDeActivación == 2026)
            {
                Console.WriteLine("Código correcto.");
            }
            else
            {
                Console.WriteLine("Código incorrecto");
            }

            Console.WriteLine("Coloque su edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Edad válida");
            }
            else
            {
                Console.WriteLine("Edad inválida");
            }

            Console.WriteLine("¿Aceptó términos y condiciones?");
            TerminosYCondiciones = Console.ReadLine();
            if (TerminosYCondiciones.ToLower() == "si")
            {
                TerminoBool = true;
            }
            else
            {
                TerminoBool = false;
            }
            if (TerminoBool == true)
            {
                Console.WriteLine("Términos aceptados");
            }
            else
            {
                Console.WriteLine("Debe aceptar términos");
            }

            Console.WriteLine("¿Activó verificación en dos pasos?");
            Veri2Pasos = Console.ReadLine();
            if (Veri2Pasos.ToLower() == "si")
            {
                VeriBool = true;
            }
            else
            {
                VeriBool = false;
            }
            if (VeriBool == true)
            {
                Console.WriteLine("2FA activado");
            }
            else
            {
                Console.WriteLine("2FA no activado");
            }

            Console.WriteLine("Coloque su puntaje:");
            puntaje = Convert.ToInt32(Console.ReadLine());
            if (puntaje >= 70)
            {
                Console.WriteLine("Puntaje suficiente");
            }
            else
            {
                Console.WriteLine("Puntaje insuficiente");
            }

            if (CodigoDeActivación == 2026 && edad >= 18 && TerminoBool == true && VeriBool == true && puntaje >= 70)
            {
                Console.WriteLine("Cuenta activada exitosamente");
            }
            else
            {
                Console.WriteLine("Cuenta NO activada");
            }

            //Ejercicio 4
            Console.Write("Ingrese la nota previa (0-100): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota <= 100 && nota >= 0)
            {
                Console.WriteLine("Puntaje valido");
            }
            else
            {
                Console.WriteLine("Puntaje debe ser entre 0-100");
            }
            Console.Write("Minutos de llegada tarde: ");
            int tarde = int.Parse(Console.ReadLine());

            Console.Write("Tiene solvencia de pagos (1. Si 0. No):");
            int solvencia = int.Parse(Console.ReadLine());
            bool pagos = solvencia == 1;

            Console.Write("Trae identificación física (1. Si, 0. No):");
            int fisica = int.Parse(Console.ReadLine());
            bool identificacion = fisica == 1;

            Console.Write("Trae calculadora permitida (1. Si, 0. No):");
            int permitida = int.Parse(Console.ReadLine());
            bool calcu = permitida == 1;

            if (nota >= 61)
            {
                Console.WriteLine("Requisito académico aprobado.");
            }
            else
            {
                Console.WriteLine("Requisito académico NO aprobado.");
            }
            if (tarde <= 10)
            {
                Console.WriteLine("Hora valida");
            }
            else
            {
                Console.WriteLine("Hora no valida");
            }
            if (pagos == true)
            {
                Console.WriteLine("Solvencia validada");
            }
            else
            {
                Console.WriteLine("Sin solvencia");
            }
            if (identificacion == true)
            {
                Console.WriteLine("Identificación validada");
            }
            else
            {
                Console.WriteLine("Identificacion no valida");
            }
            if (calcu == true)
            {
                Console.WriteLine("Calculadora permitida");
            }
            else
            {
                Console.WriteLine("Calculadora no permitida");
            }
            if (nota >= 61 && tarde <= 10 && pagos == true && identificacion == true)
            {
                Console.WriteLine("Acceso a sala de examen concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            if (tarde > 0 && tarde <= 10)
            {
                Console.WriteLine("Advertencia: llegó tarde, pero aún puede ingresar.");
            }

        }
    }
}
