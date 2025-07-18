using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AsignacionAsientos
{
    // Clase que representa a una persona con Id y Nombre
    class Persona
    {
        public int Id { get; set; }           // Identificador único de la persona
        public string Nombre { get; set; }    // Nombre de la persona

        // Constructor para inicializar una persona con Id y Nombre
        public Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }

    // Clase que simula la atracción con una cola de espera y asignación de asientos
    class Atraccion
    {
        private Queue<Persona> colaEspera = new Queue<Persona>();  // Cola para controlar orden de llegada
        private int capacidad = 30;                                 // Capacidad máxima de asientos disponibles
        private int asignados = 0;                                  // Contador de asientos ya asignados

        // Método para agregar una persona a la cola si hay capacidad disponible
        public void AgregarPersona(Persona persona)
        {
            // Verifica si aún hay asientos disponibles sumando asignados y en cola
            if (asignados + colaEspera.Count < capacidad)
            {
                colaEspera.Enqueue(persona); // Agrega la persona al final de la cola
                Console.WriteLine($"[INFO] {persona.Nombre} fue agregado a la cola.");
            }
            else
            {
                // Si no hay asientos, muestra advertencia y no agrega a la cola
                Console.WriteLine($"[ADVERTENCIA] No hay más asientos disponibles para {persona.Nombre}.");
            }
        }

        // Método para asignar asientos en orden FIFO hasta agotar la capacidad
        public void AsignarAsientos()
        {
            Console.WriteLine("\n--- Iniciando asignación de asientos ---");

            Stopwatch cronometro = new Stopwatch(); // Medidor de tiempo de ejecución
            cronometro.Start();

            // Mientras haya personas en la cola y capacidad disponible
            while (colaEspera.Count > 0 && asignados < capacidad)
            {
                Persona persona = colaEspera.Dequeue(); // Saca a la persona que está al frente de la cola
                asignados++;                             // Incrementa contador de asientos asignados
                // Muestra la asignación realizada en consola
                Console.WriteLine($"Asiento #{asignados} asignado a: {persona.Nombre} (ID: {persona.Id})");
            }

            cronometro.Stop();
            // Muestra el tiempo total que tomó asignar los asientos
            Console.WriteLine($"\nAsignación completada en {cronometro.ElapsedMilliseconds} ms.");
        }

        // Método para visualizar quiénes aún están esperando en la cola
        public void VerEstadoCola()
        {
            Console.WriteLine($"\nPersonas aún en la cola: {colaEspera.Count}");
            // Recorre la cola mostrando nombre e Id de cada persona
            foreach (var persona in colaEspera)
            {
                Console.WriteLine($"En cola: {persona.Nombre} (ID: {persona.Id})");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion(); // Crear instancia de la atracción

            // Simular ingreso de 35 personas (más que la capacidad para probar límite)
            for (int i = 1; i <= 35; i++) 
            {
                atraccion.AgregarPersona(new Persona(i, $"Persona_{i}"));
            }

            atraccion.VerEstadoCola();    // Mostrar estado de la cola antes de asignar asientos
            atraccion.AsignarAsientos();  // Realizar asignación de asientos
            atraccion.VerEstadoCola();    // Mostrar estado de la cola después de asignar

            Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
            Console.ReadKey();            // Esperar tecla para cerrar la consola
        }
    }
}
