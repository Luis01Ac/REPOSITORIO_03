using System;

// Esta clase representa un círculo y contiene métodos para calcular su área y perímetro
public class Circulo
{
    // Propiedad que almacena el radio del círculo
    public double Radio { get; set; }

    // Constructor que inicializa el círculo con un radio
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Método que calcula el área del círculo
    // Fórmula: Área = π * radio^2
    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    // Método que calcula el perímetro del círculo
    // Fórmula: Perímetro = 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
