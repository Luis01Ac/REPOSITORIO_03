using System;
using System.Collections.Generic;

namespace CursoPOOEjercicios
{
    public class Ejercicio6
    {
        public void Ejecutar()
        {
            // Lista de asignaturas del curso
            List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            // Diccionario para guardar la nota de cada asignatura
            Dictionary<string, float> notas = new Dictionary<string, float>();

            // Pedimos al usuario que ingrese su nota para cada asignatura
            foreach (string asignatura in asignaturas)
            {
                Console.Write($"Nota de {asignatura}: ");
                float nota = float.Parse(Console.ReadLine()); // Convertimos a número decimal
                notas[asignatura] = nota;
            }

            // Lista para guardar asignaturas no aprobadas (nota < 5)
            List<string> reprobadas = new List<string>();

            foreach (var asignatura in notas)
            {
                if (asignatura.Value < 5.0f) // Si la nota es menor que 5
                {
                    reprobadas.Add(asignatura.Key); // Se agrega a la lista de reprobadas
                }
            }

            // Mostramos las asignaturas que deben repetirse
            Console.WriteLine("Asignaturas que debes repetir:");
            foreach (string a in reprobadas)
            {
                Console.WriteLine(a);
            }
        }
    }
}
