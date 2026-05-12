using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_DA1248926
{
    //  EJERCICIO 1 – Clase Libro
    class Libro
    {
        // ----- Atributos -----
        private string titulo;
        private string autor;
        private int anioPublicacion;
        private bool disponible;

        // ----- Constructor -----
        public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            this.disponible = disponible;
        }

        // ----- Get y Set -----
        public string GetTitulo() => titulo;
        public string GetAutor() => autor;
        public int GetAnioPublicacion() => anioPublicacion;
        public bool GetDisponible() => disponible;
        public void SetTitulo(string t) => titulo = t;
        public void SetAutor(string a) => autor = a;
        public void SetAnioPublicacion(int a) => anioPublicacion = a;
        public void SetDisponible(bool d) => disponible = d;

        // ----- Métodos -----
        public void MostrarInformacion()
        {
            Console.WriteLine("  Titulo            : " + titulo);
            Console.WriteLine("  Autor             : " + autor);
            Console.WriteLine("  Año publicacion  : " + anioPublicacion);
            Console.WriteLine("  Disponible        : " + (disponible ? "Si" : "No"));
        }

        public void PrestarLibro()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine("  El libro \"" + titulo + "\" fue prestado exitosamente.");
            }
            else
            {
                Console.WriteLine("  El libro \"" + titulo + "\" NO esta disponible para prestamo.");
            }
        }

        public void DevolverLibro()
        {
            disponible = true;
            Console.WriteLine("  El libro " + titulo + " fue devuelto y ya esta disponible.");
        }
    }

    //  EJERCICIO 2 – Clase Mascota
    class Mascota
    {
        // ----- Atributos -----
        private string nombre;
        private string especie;
        private int edad;
        private bool vacunado;

        // ----- Constructor -----
        public Mascota(string nombre, string especie, int edad, bool vacunado)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
            this.vacunado = vacunado;
        }

        // ----- Get y Set -----
        public string GetNombre() => nombre;
        public string GetEspecie() => especie;
        public int GetEdad() => edad;
        public bool GetVacunado() => vacunado;
        public void SetNombre(string n) => nombre = n;
        public void SetEspecie(string e) => especie = e;
        public void SetEdad(int e) => edad = e;
        public void SetVacunado(bool v) => vacunado = v;

        // ----- Métodos -----
        public void MostrarInformacion()
        {
            Console.WriteLine("  Nombre   : " + nombre);
            Console.WriteLine("  Especie  : " + especie);
            Console.WriteLine("  Edad     : " + edad + " año(s)");
            Console.WriteLine("  Vacunado : " + (vacunado ? "Si" : "No"));
        }

        public void Vacunar()
        {
            if (!vacunado)
            {
                vacunado = true;
                Console.WriteLine("  >> " + nombre + " ha sido vacunado/a correctamente.");
            }
            else
            {
                Console.WriteLine("  >> " + nombre + " ya estaba vacunado/a.");
            }
        }

        public void CumplirAnios()
        {
            edad++;
            Console.WriteLine("  >> " + nombre + " cumplio años! Ahora tiene " + edad + " año(s).");
        }
    }

    //  EJERCICIO 3 – Clase Estudiante
    class Estudiante
    {
        // ----- Atributos -----
        private string nombre;
        private int edad;
        private string grado;
        private List<decimal> notas;
        private decimal promedio;

        // ----- Constructor -----
        public Estudiante(string nombre, int edad, string grado, decimal[] notasIniciales)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = new List<decimal>(notasIniciales);
            CalcularPromedio();
        }

        // ----- Get y Set -----
        public string GetNombre() => nombre;
        public int GetEdad() => edad;
        public string GetGrado() => grado;
        public decimal GetPromedio() => promedio;
        public List<decimal> GetNotas() => notas;
        public void SetNombre(string n) => nombre = n;
        public void SetEdad(int e) => edad = e;
        public void SetGrado(string g) => grado = g;

        // ----- Métodos -----
        public void CalcularPromedio()
        {
            if (notas.Count == 0) { promedio = 0; return; }
            decimal suma = 0;
            foreach (decimal n in notas) suma += n;
            promedio = suma / notas.Count;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("  Nombre  : " + nombre);
            Console.WriteLine("  Edad    : " + edad + " años");
            Console.WriteLine("  Grado   : " + grado);
            Console.Write("  Notas   : ");
            for (int i = 0; i < notas.Count; i++)
                Console.Write(notas[i].ToString("F1") + (i < notas.Count - 1 ? ", " : ""));
            Console.WriteLine();
            Console.WriteLine("  Promedio: " + promedio.ToString("F2"));
        }

        public void Aprobar()
        {
            if (promedio >= 61)
                Console.WriteLine("  >> " + nombre + " APROBO con promedio " + promedio.ToString("F2") + ".");
            else
                Console.WriteLine("  >> " + nombre + " REPROBO con promedio " + promedio.ToString("F2") + ".");
        }

        public void AgregarNota(decimal nuevaNota)
        {
            notas.Add(nuevaNota);
            CalcularPromedio();
            Console.WriteLine("  >> Nota " + nuevaNota.ToString("F1") + " agregada. Nuevo promedio de " + nombre + ": " + promedio.ToString("F2"));
        }
    }

    //  PROGRAMA PRINCIPAL
    class Program
    {
        // ---- Helpers visuales ----
        static void Separador(string titulo)
        {
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("  " + titulo);
            Console.WriteLine("==================================================");
        }

        static void SubTitulo(string texto)
        {
            Console.WriteLine("\n  -- " + texto + " --");
        }

        // ---- Leer entero con validación ----
        static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor)) return valor;
                Console.WriteLine("  [!] Ingrese un numero entero valido.");
            }
        }

        // ---- Leer decimal con validación ----
        static decimal LeerDecimal(string mensaje)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensaje);
                if (decimal.TryParse(Console.ReadLine(), out valor)) return valor;
                Console.WriteLine("  [!] Ingrese un numero decimal valido (use punto o coma).");
            }
        }

        // ---- Leer booleano (s/n) ----
        static bool LeerBooleano(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje + " (s/n): ");
                string resp = Console.ReadLine().Trim().ToLower();
                if (resp == "s") return true;
                if (resp == "n") return false;
                Console.WriteLine(" Ingrese 's' para Si o 'n' para No.");
            }
        }

        // ---- Crear un Libro desde consola ----
        static Libro CrearLibro(int numero)
        {
            Console.WriteLine("\n  [ Datos del Libro " + numero + " ]");
            Console.Write("  Titulo           : "); string titulo = Console.ReadLine();
            Console.Write("  Autor            : "); string autor = Console.ReadLine();
            int anio = LeerEntero("  Año publicacion : ");
            bool disponible = LeerBooleano("  Esta disponible?");
            return new Libro(titulo, autor, anio, disponible);
        }

        // ---- Crear una Mascota desde consola ----
        static Mascota CrearMascota(int numero)
        {
            Console.WriteLine("\n  [ Datos de la Mascota " + numero + " ]");
            Console.Write("  Nombre  : "); string nombre = Console.ReadLine();
            Console.Write("  Especie : "); string especie = Console.ReadLine();
            int edad = LeerEntero("  Edad    : ");
            bool vacunado = LeerBooleano("  Esta vacunado?");
            return new Mascota(nombre, especie, edad, vacunado);
        }

        // ---- Crear un Estudiante desde consola ----
        static Estudiante CrearEstudiante(int numero)
        {
            Console.WriteLine("\n  [ Datos del Estudiante " + numero + " ]");
            Console.Write("  Nombre : "); string nombre = Console.ReadLine();
            int edad = LeerEntero("  Edad   : ");
            Console.Write("  Grado  : "); string grado = Console.ReadLine();

            int cantNotas = LeerEntero("  Cuantas notas desea ingresar? ");
            decimal[] notas = new decimal[cantNotas];
            for (int i = 0; i < cantNotas; i++)
                notas[i] = LeerDecimal("  Nota " + (i + 1) + " : ");

            return new Estudiante(nombre, edad, grado, notas);
        }

        // ==================================================
        static void Main(string[] args)
        {
            //  EJERCICIO 1 – Biblioteca
            Separador("EJERCICIO 1 - Sistema de Biblioteca");

            Console.WriteLine("\n  Ingrese los datos para crear 2 libros:");

            Libro libro1 = CrearLibro(1);
            Libro libro2 = CrearLibro(2);

            SubTitulo("Informacion de los libros registrados");
            Console.WriteLine("\n  [Libro 1]"); libro1.MostrarInformacion();
            Console.WriteLine("\n  [Libro 2]"); libro2.MostrarInformacion();

            SubTitulo("Prueba de prestamo - Libro 1");
            Console.WriteLine("  Estado ANTES del prestamo:");
            libro1.MostrarInformacion();
            libro1.PrestarLibro();
            Console.WriteLine("  Estado DESPUES del prestamo:");
            libro1.MostrarInformacion();

            SubTitulo("Intentar prestar Libro 1 nuevamente (ya prestado)");
            libro1.PrestarLibro();

            SubTitulo("Prueba de devolucion - Libro 1");
            Console.WriteLine("  Estado ANTES de la devolucion:");
            libro1.MostrarInformacion();
            libro1.DevolverLibro();
            Console.WriteLine("  Estado DESPUES de la devolucion:");
            libro1.MostrarInformacion();

            SubTitulo("Prestamo y devolucion - Libro 2");
            libro2.PrestarLibro();
            libro2.MostrarInformacion();
            libro2.DevolverLibro();
            libro2.MostrarInformacion();

            //  EJERCICIO 2 – Veterinaria
            Separador("EJERCICIO 2 - Sistema de Veterinaria");

            Console.WriteLine("\n  Ingrese los datos para registrar 2 mascotas:");

            Mascota mascota1 = CrearMascota(1);
            Mascota mascota2 = CrearMascota(2);

            SubTitulo("Informacion de las mascotas registradas");
            Console.WriteLine("\n  [Mascota 1]"); mascota1.MostrarInformacion();
            Console.WriteLine("\n  [Mascota 2]"); mascota2.MostrarInformacion();

            SubTitulo("Vacunacion de la Mascota 1");
            Console.WriteLine("  Estado ANTES:");
            mascota1.MostrarInformacion();
            mascota1.Vacunar();
            Console.WriteLine("  Estado DESPUES:");
            mascota1.MostrarInformacion();

            SubTitulo("Vacunacion de la Mascota 2");
            mascota2.Vacunar();
            mascota2.MostrarInformacion();

            SubTitulo("Cumpleaños de ambas mascotas");
            mascota1.CumplirAnios();
            mascota1.MostrarInformacion();
            mascota2.CumplirAnios();
            mascota2.MostrarInformacion();

            // ============================================
            //  EJERCICIO 3 – Escuela
            // ============================================
            Separador("EJERCICIO 3 - Sistema de Escuela");

            Console.WriteLine("\n  Ingrese los datos para registrar 2 estudiantes:");

            Estudiante est1 = CrearEstudiante(1);
            Estudiante est2 = CrearEstudiante(2);

            SubTitulo("Informacion de los estudiantes");
            Console.WriteLine("\n  [Estudiante 1]"); est1.MostrarInformacion();
            Console.WriteLine("\n  [Estudiante 2]"); est2.MostrarInformacion();

            SubTitulo("Calculo de promedios");
            est1.CalcularPromedio();
            Console.WriteLine("  Promedio de " + est1.GetNombre() + ": " + est1.GetPromedio().ToString("F2"));
            est2.CalcularPromedio();
            Console.WriteLine("  Promedio de " + est2.GetNombre() + ": " + est2.GetPromedio().ToString("F2"));

            SubTitulo("Verificacion de aprobacion");
            est1.Aprobar();
            est2.Aprobar();

            SubTitulo("Agregar nueva nota al Estudiante 1");
            decimal nuevaNota = LeerDecimal("  Ingrese la nueva nota para " + est1.GetNombre() + ": ");
            est1.AgregarNota(nuevaNota);
            Console.WriteLine("  Informacion actualizada:");
            est1.MostrarInformacion();
            est1.Aprobar();

        }
    }
}
