using System;

// Esta clase representa un rectángulo con largo y ancho
public class Rectangulo
{
    // Propiedades que almacenan el largo y el ancho del rectángulo
    public double Largo { get; set; }
    public double Ancho { get; set; }

    // Constructor que inicializa el rectángulo con largo y ancho
    public Rectangulo(double largo, double ancho)
    {
        Largo = largo;
        Ancho = ancho;
    }

    // Método que calcula el área del rectángulo
    // Fórmula: Área = largo * ancho

    public double CalcularArea()
    {
        return Largo * Ancho;
    }

    // Método que calcula el perímetro del rectángulo
    // Fórmula: Perímetro = 2 * (largo + ancho)
    public double CalcularPerimetro()
    {
        return 2 * (Largo + Ancho);
    }
}
