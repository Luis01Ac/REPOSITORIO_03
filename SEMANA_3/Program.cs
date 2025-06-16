using System;

namespace RegistroEstudiante
{
    class Program
    {
        // Punto de entrada del programa
        static void Main(string[] args)
        {
            // Creamos un arreglo de 3 teléfonos para el estudiante
            string[] telefonos = { "0985672558", "0985678452", "0958746924" };

            // Creamos una instancia del estudiante utilizando el constructor
            Estudiante estudiante1 = new Estudiante(
                1,                                      // ID
                "Luis Alfredo",                          // Nombres
                "Achachi Culqui",                         // Apellidos
                "Av. Cevallos 03-25",                 // Dirección
                telefonos                               // Teléfonos
            );

            // Llamamos al método para mostrar la información del estudiante
            estudiante1.MostrarInformacion();
        }
    }
}
