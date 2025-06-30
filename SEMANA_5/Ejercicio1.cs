using System;
using System.Collections.Generic;

namespace CursoPOOEjercicios
{
    public class Ejercicio1
    {
        // Método que ejecuta el ejercicio 1
        public void Ejecutar()
        {
            // Creamos una lista de asignaturas
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            Console.WriteLine("Asignaturas del curso:");

            // Recorremos la lista y mostramos cada asignatura
            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine(asignatura);
            }
        }
    }
}
