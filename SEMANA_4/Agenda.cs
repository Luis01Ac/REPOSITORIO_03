using System;
using System.Collections.Generic; // Necesario para usar List<T>

// Clase que administra la agenda de turnos
public class Agenda
{
    private List<Turno> turnos; // Lista que almacena los turnos

    // Constructor: inicializa la lista de turnos
    public Agenda()
    {
        turnos = new List<Turno>();
    }

    // Agrega un nuevo turno a la lista
    public void AgendarTurno(Turno turno)
    {
        turnos.Add(turno);
        Console.WriteLine("Turno agendado exitosamente.\n");
    }

    // Muestra todos los turnos agendados
    public void VerTurnos()
    {
        if (turnos.Count == 0)
        {
            Console.WriteLine("No hay turnos agendados.\n");
            return;
        }

        foreach (var t in turnos)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine();
    }

    // Busca y muestra turnos por una fecha específica
    public void ConsultarPorFecha(DateTime fecha)
    {
        bool encontrado = false;

        foreach (var t in turnos)
        {
            if (t.Fecha.Date == fecha.Date)
            {
                Console.WriteLine(t);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No hay turnos en esa fecha.\n");
        }
    }

    // Busca y muestra turnos por cédula del paciente
    public void ConsultarPorCedula(string cedula)
    {
        bool encontrado = false;

        foreach (var t in turnos)
        {
            if (t.PacienteAsignado.Cedula == cedula)
            {
                Console.WriteLine(t);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontraron turnos para ese paciente.\n");
        }
    }
}
