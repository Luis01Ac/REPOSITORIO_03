using System;
using System.Collections.Generic;

namespace CursoPOOEjercicios
{
    public class Ejercicio2
    {
        public void Ejecutar()
        {
            // Lista de asignaturas
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            // Mostrar mensaje personalizado para cada asignatura
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}
