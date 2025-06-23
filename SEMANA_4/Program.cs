using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- AGENDA DE TURNOS CLÍNICA ---");
            Console.WriteLine("1. Agendar Turno");
            Console.WriteLine("2. Ver Turnos");
            Console.WriteLine("3. Consultar por Fecha");
            Console.WriteLine("4. Consultar por Cédula del Paciente");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre del paciente: ");
                    string? nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        Console.WriteLine("Nombre inválido.");
                        break;
                    }

                    Console.Write("Cédula del paciente: ");
                    string? cedula = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(cedula))
                    {
                        Console.WriteLine("Cédula inválida.");
                        break;
                    }

                    Console.Write("Ingrese fecha y hora del turno (dd/MM/yyyy HH:mm): ");
                    string? fechaTexto = Console.ReadLine();
                    if (!DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy HH:mm", null, DateTimeStyles.None, out DateTime fecha))
                    {
                        Console.WriteLine("Formato de fecha inválido.");
                        break;
                    }

                    Paciente paciente = new Paciente(nombre, cedula);
                    Turno turno = new Turno(fecha, paciente);
                    agenda.AgendarTurno(turno);
                    break;

                case "2":
                    agenda.VerTurnos();
                    break;

                case "3":
                    Console.Write("Ingrese la fecha a consultar (dd/MM/yyyy): ");
                    string? fechaConsulta = Console.ReadLine();
                    if (!DateTime.TryParseExact(fechaConsulta, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime fechaC))
                    {
                        Console.WriteLine("Formato de fecha inválido.");
                        break;
                    }

                    agenda.ConsultarPorFecha(fechaC);
                    break;

                case "4":
                    Console.Write("Ingrese la cédula del paciente: ");
                    string? cedulaConsulta = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(cedulaConsulta))
                    {
                        Console.WriteLine("Cédula inválida.");
                        break;
                    }

                    agenda.ConsultarPorCedula(cedulaConsulta);
                    break;

                case "5":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
