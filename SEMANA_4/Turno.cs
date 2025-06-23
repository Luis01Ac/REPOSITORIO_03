// Clase que representa un turno en la clínica
public class Turno
{
    public DateTime Fecha { get; set; }                 // Fecha y hora del turno
    public Paciente PacienteAsignado { get; set; }      // Paciente asignado al turno

    // Constructor que recibe la fecha y el paciente
    public Turno(DateTime fecha, Paciente paciente)
    {
        Fecha = fecha;
        PacienteAsignado = paciente;
    }

    // Método para mostrar los detalles del turno como texto
    public override string ToString()
    {
        return $"Turno para {PacienteAsignado.Nombre} - Fecha: {Fecha:dd/MM/yyyy HH:mm}";
    }
}
