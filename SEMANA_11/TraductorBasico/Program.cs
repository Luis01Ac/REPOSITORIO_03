using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario inicial: clave = palabra en inglés, valor = traducción al español
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"part", "parte"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"},
            {"week", "semana"},
            {"case", "caso"},
            {"point", "punto"},
            {"government", "gobierno"},
            {"company", "empresa"}
        };

        // Bucle principal del programa: se repetirá hasta que el usuario seleccione salir
        while (true)
        {
            // Mostrar el menú al usuario
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine(); // Leer opción del usuario

            // Salir del programa si el usuario ingresa "0"
            if (opcion == "0")
                break;

            // Evaluar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    TraducirFrase(diccionario); // Llamar a función de traducción
                    break;
                case "2":
                    AgregarPalabra(diccionario); // Llamar a función para agregar palabra
                    break;
                default:
                    Console.WriteLine("Opción no válida."); // Mensaje de error si la opción no existe
                    break;
            }
        }
    }

    // Función para traducir una frase palabra por palabra
    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la frase a traducir: ");
        string frase = Console.ReadLine(); // Leer frase ingresada por el usuario

        // Separar la frase en palabras utilizando espacio como delimitador
        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Recorrer cada palabra de la frase
        for (int i = 0; i < palabras.Length; i++)
        {
            // Limpiar la palabra de signos de puntuación y convertirla a minúsculas
            string palabraLimpia = palabras[i].Trim(new char[] { '.', ',', ';', ':', '!', '?' }).ToLower();

            // Verificar si la palabra existe en el diccionario
            if (diccionario.ContainsKey(palabraLimpia))
            {
                // Reemplazar la palabra por su traducción
                palabras[i] = diccionario[palabraLimpia];
            }
            // Si no existe en el diccionario, se mantiene la palabra original
        }

        // Mostrar la traducción parcial (solo palabras encontradas en el diccionario)
        Console.WriteLine("Traducción parcial: " + string.Join(' ', palabras));
    }

    // Función para agregar nuevas palabras al diccionario
    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string ingles = Console.ReadLine().ToLower(); // Convertir a minúscula para consistencia

        Console.Write("Ingrese la traducción al español: ");
        string espanol = Console.ReadLine();

        // Verificar si la palabra ya existe
        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol); // Agregar palabra al diccionario
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
