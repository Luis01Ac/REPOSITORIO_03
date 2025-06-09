using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de la clase Circulo con radio 5
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("Figura: Círculo");
        Console.WriteLine($"Radio: {miCirculo.Radio}");
        Console.WriteLine($"Área: {miCirculo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro()}");

        Console.WriteLine(); // Línea en blanco

        // Crear una instancia de la clase Rectangulo con largo 4 y ancho 3
        Rectangulo miRectangulo = new Rectangulo(4, 3);
        Console.WriteLine("Figura: Rectángulo");
        Console.WriteLine($"Largo: {miRectangulo.Largo}, Ancho: {miRectangulo.Ancho}");
        Console.WriteLine($"Área: {miRectangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro()}");
    }
}

