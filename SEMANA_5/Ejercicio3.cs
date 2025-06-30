using System;
using System.Collections.Generic;

namespace CursoPOOEjercicios
{
    public class Ejercicio4
    {
        public void Ejecutar()
        {
            // Creamos una lista vacía para guardar los números
            List<int> numerosLoteria = new List<int>();

            Console.WriteLine("Ingrese los 6 números ganadores de la lotería:");

            // Pedimos 6 números al usuario
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine()); // Convertimos la entrada a entero
                numerosLoteria.Add(numero); // Agregamos a la lista
            }

            // Ordenamos la lista de menor a mayor
            numerosLoteria.Sort();

            Console.WriteLine("Números ordenados:");
            foreach (int num in numerosLoteria)
            {
                Console.WriteLine(num); // Mostramos los números ordenados
            }
        }
    }
}
