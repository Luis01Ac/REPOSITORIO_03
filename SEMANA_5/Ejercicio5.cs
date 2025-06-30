using System;
using System.Collections.Generic;

namespace CursoPOOEjercicios
{
    public class Ejercicio10
    {
        public void Ejecutar()
        {
            // Lista de precios
            List<int> precios = new List<int> { 60, 75, 46, 22, 90, 65, 2 };

            // Inicializamos el menor y mayor con valores extremos
            int menor = int.MaxValue;
            int mayor = int.MinValue;

            // Recorremos la lista para encontrar el menor y mayor
            foreach (int precio in precios)
            {
                if (precio < menor)
                    menor = precio;

                if (precio > mayor)
                    mayor = precio;
            }

            // Mostramos los resultados
            Console.WriteLine($"El precio menor es: {menor}");
            Console.WriteLine($"El precio mayor es: {mayor}");
        }
    }
}
