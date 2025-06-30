using System;

namespace CursoPOOEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menú para seleccionar el ejercicio a ejecutar
            Console.WriteLine("Seleccione el ejercicio a ejecutar (1, 2, 4, 6, 10):");
            string opcion = Console.ReadLine();

            // Dependiendo de la opción, se ejecuta el ejercicio correspondiente
            switch (opcion)
            {
                case "1":
                    new Ejercicio1().Ejecutar();
                    break;
                case "2":
                    new Ejercicio2().Ejecutar();
                    break;
                case "4":
                    new Ejercicio4().Ejecutar();
                    break;
                case "6":
                    new Ejercicio6().Ejecutar();
                    break;
                case "10":
                    new Ejercicio10().Ejecutar();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
