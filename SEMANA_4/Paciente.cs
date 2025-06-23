// Clase que representa a un paciente
public class Paciente
{
    public string Nombre { get; set; }          // Nombre del paciente
    public string Cedula { get; set; }          // Cédula del paciente

    // Constructor que inicializa los datos del paciente
    public Paciente(string nombre, string cedula)
    {
        Nombre = nombre;
        Cedula = cedula;
    }

    // Método para mostrar los datos del paciente como texto
    public override string ToString()
    {
        return $"Paciente: {Nombre}, Cédula: {Cedula}";
    }
}
