// ===============================================
// Catálogo de Revistas - SEMANA_13
// Programa en C# que permite:
//   - Buscar títulos en un catálogo (usando búsqueda recursiva)
//   - Mostrar el catálogo completo
//   - Agregar nuevos títulos
// ===============================================

using System;
using System.Collections.Generic;

namespace SEMANA_13
{
    class Program
    {
        // Lista inicial con revistas de música/rock
        // List<string> es dinámico, permite añadir o quitar elementos fácilmente
        static readonly List<string> catalogo = new List<string>
        {
            "Rolling Stone",
            "NME",
            "Guitar World",
            "Rock Sound",
            "Dogma",              // Título cambiado
            "Spin",
            "Mojo",
            "Classic Rock",
            "Metal Hammer",
            "La Hoguera del Rock",
            "Ritmo y Riffs"
        };

        static void Main(string[] args)
        {
            Console.Title = "Catálogo de Revistas - SEMANA_13"; 
            bool salir = false; // Controla la ejecución del menú

            // Bucle principal que muestra el menú hasta que el usuario decida salir
            while (!salir)
            {
                MostrarMenu();
                string opcion = Console.ReadLine()?.Trim();

                // Ejecutamos la acción según lo que elija el usuario
                switch (opcion)
                {
                    case "1": BuscarTitulo(); break;
                    case "2": MostrarCatalogo(); break;
                    case "3": AgregarTitulo(); break;
                    case "4": salir = true; break; // finaliza el programa
                    default:
                        Console.WriteLine("Opción inválida. Presiona Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Muestra las opciones del menú en pantalla
        static void MostrarMenu()
        {
            Console.Clear(); // Limpia la consola para que el menú se vea ordenado
            Console.WriteLine("=== Catálogo de Revistas (SEMANA_13) ===");
            Console.WriteLine("1) Buscar un título (recursivo)");
            Console.WriteLine("2) Mostrar catálogo");
            Console.WriteLine("3) Agregar título");
            Console.WriteLine("4) Salir");
            Console.Write("Elige una opción: ");
        }

        // Permite al usuario buscar un título dentro del catálogo usando recursividad
        static void BuscarTitulo()
        {
            Console.Write("\nIntroduce el título a buscar: ");
            string busqueda = Console.ReadLine()?.Trim() ?? string.Empty;

            // Verificamos que el usuario no deje vacío el campo de búsqueda
            if (string.IsNullOrEmpty(busqueda))
            {
                Console.WriteLine("Entrada vacía. Presiona Enter para volver al menú.");
                Console.ReadLine();
                return;
            }

            // La búsqueda siempre se realiza con el algoritmo recursivo
            int indice = BusquedaRecursiva(catalogo, busqueda, 0);

            // Si el índice es válido, se encontró el título
            if (indice >= 0)
                Console.WriteLine("Encontrado en posición: " + indice);
            else
                Console.WriteLine("No encontrado");

            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine(); // Pausa antes de regresar al menú
        }

        // Algoritmo de búsqueda recursiva
        // Parámetros:
        //   - lista: catálogo de revistas
        //   - objetivo: título a buscar
        //   - indice: posición actual en la lista
        static int BusquedaRecursiva(List<string> lista, string objetivo, int indice)
        {
            // Caso base: si llegamos al final de la lista, devolvemos -1 (no encontrado)
            if (indice >= lista.Count) return -1;

            // Comparamos el elemento actual con el objetivo (ignorando mayúsculas/minúsculas)
            if (string.Equals(lista[indice], objetivo, StringComparison.OrdinalIgnoreCase))
                return indice; // Se encontró, devolvemos la posición

            // Paso recursivo: avanzamos al siguiente índice
            return BusquedaRecursiva(lista, objetivo, indice + 1);
        }

        // Muestra todos los títulos en pantalla junto con su índice
        static void MostrarCatalogo()
        {
            Console.WriteLine("\n--- Catálogo ---");
            for (int i = 0; i < catalogo.Count; i++)
                Console.WriteLine($"{i}: {catalogo[i]}");

            Console.WriteLine("\nPresiona Enter para volver al menú...");
            Console.ReadLine();
        }

        // Permite al usuario agregar un nuevo título al catálogo
        static void AgregarTitulo()
        {
            Console.Write("\nIntroduce el nuevo título: ");
            string nuevo = Console.ReadLine()?.Trim() ?? string.Empty;

            if (!string.IsNullOrEmpty(nuevo))
            {
                catalogo.Add(nuevo); // Se añade al final de la lista
                Console.WriteLine($"Título '{nuevo}' añadido correctamente.");
            }
            else
            {
                Console.WriteLine("Título vacío. No se añadió al catálogo.");
            }

            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
