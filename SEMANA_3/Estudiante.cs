using System;

namespace RegistroEstudiante
{
    // Esta clase representa la información de un estudiante
    public class Estudiante
    {
        // Propiedades públicas del estudiante
        public int Id { get; set; }                   // Identificación del estudiante
        public string Nombres { get; set; }           // Nombres del estudiante
        public string Apellidos { get; set; }         // Apellidos del estudiante
        public string Direccion { get; set; }         // Dirección del estudiante

        // Array para almacenar exactamente 3 números de teléfono
        public string[] Telefonos { get; set; } = new string[3];

        // Constructor que inicializa un nuevo objeto Estudiante
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            // Asignación de propiedades
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;

            // Validación: asegurarse de que el array tenga exactamente 3 teléfonos
            if (telefonos.Length == 3)
            {
                Telefonos = telefonos;
            }
            else
            {
                // Lanza un error si no se pasan exactamente 3 teléfonos
                throw new ArgumentException("Se deben ingresar exactamente 3 teléfonos.");
            }
        }

        // Método para mostrar la información del estudiante en consola
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");

            Console.WriteLine("Teléfonos:");
            // Recorre el array de teléfonos e imprime cada uno
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }
}
