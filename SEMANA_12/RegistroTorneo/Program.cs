using System;
using System.Collections.Generic;
using System.Diagnostics; // Para medir tiempo de ejecución

namespace RegistroTorneo
{
    class Program
    {
        // Diccionario para almacenar equipos (clave) y jugadores (valor: HashSet)
        static Dictionary<string, HashSet<string>> equipos = new Dictionary<string, HashSet<string>>();

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== Registro de Torneo de Fútbol ===");
                Console.WriteLine("1. Registrar equipo");
                Console.WriteLine("2. Registrar jugador");
                Console.WriteLine("3. Consultar jugadores de un equipo");
                Console.WriteLine("4. Listar todos los equipos y jugadores");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarEquipo();
                        break;
                    case "2":
                        RegistrarJugador();
                        break;
                    case "3":
                        ConsultarJugadores();
                        break;
                    case "4":
                        ListarEquipos();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Método para registrar un nuevo equipo
        static void RegistrarEquipo()
        {
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();

            if (!equipos.ContainsKey(nombreEquipo))
            {
                equipos[nombreEquipo] = new HashSet<string>();
                Console.WriteLine($"Equipo '{nombreEquipo}' registrado correctamente.");
            }
            else
            {
                Console.WriteLine("El equipo ya está registrado.");
            }
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        // Método para registrar un jugador en un equipo
        static void RegistrarJugador()
        {
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();

            if (equipos.ContainsKey(nombreEquipo))
            {
                Console.Write("Ingrese el nombre del jugador: ");
                string jugador = Console.ReadLine();

                // Verificar duplicado usando HashSet
                if (equipos[nombreEquipo].Add(jugador))
                {
                    Console.WriteLine($"Jugador '{jugador}' agregado al equipo '{nombreEquipo}' correctamente.");
                }
                else
                {
                    Console.WriteLine("El jugador ya existe en este equipo.");
                }
            }
            else
            {
                Console.WriteLine("El equipo no existe. Primero debe registrarlo.");
            }
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        // Método para consultar jugadores de un equipo específico
        static void ConsultarJugadores()
        {
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreEquipo = Console.ReadLine();

            if (equipos.ContainsKey(nombreEquipo))
            {
                Console.WriteLine($"Jugadores del equipo '{nombreEquipo}':");
                foreach (string jugador in equipos[nombreEquipo])
                {
                    Console.WriteLine($"- {jugador}");
                }
            }
            else
            {
                Console.WriteLine("El equipo no existe.");
            }
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        // Método para listar todos los equipos y sus jugadores
        static void ListarEquipos()
        {
            Console.WriteLine("=== Listado de Equipos y Jugadores ===");

            Stopwatch stopwatch = Stopwatch.StartNew(); // Medir tiempo de ejecución

            foreach (var equipo in equipos)
            {
                Console.WriteLine($"\nEquipo: {equipo.Key}");
                foreach (string jugador in equipo.Value)
                {
                    Console.WriteLine($"- {jugador}");
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"\nTiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }
}

