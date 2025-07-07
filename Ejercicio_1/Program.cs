// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Lista lista = new Lista();
        Random random = new Random();

        // Agregar 50 números aleatorios del 1 al 999
        for (int i = 0; i < 50; i++)
            lista.Agregar(random.Next(1, 1000));

        Console.WriteLine("Lista generada:");
        lista.Mostrar();

        // Leer rango desde teclado
        Console.Write("Ingrese el valor mínimo del rango: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor máximo del rango: ");
        int max = int.Parse(Console.ReadLine());

        // Eliminar nodos fuera del rango
        lista.EliminarFueraDeRango(min, max);

        Console.WriteLine("Lista filtrada:");
        lista.Mostrar();
    }
}
