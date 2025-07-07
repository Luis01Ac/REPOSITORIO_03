// Program.cs
using System;

class Program
{
    static bool EsPrimo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    static bool EsArmstrong(int num)
    {
        int sum = 0, temp = num;
        int digits = num.ToString().Length;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }

        return sum == num;
    }

    static void Main(string[] args)
    {
        Lista listaPrimos = new Lista();
        Lista listaArmstrong = new Lista();
        Random rand = new Random();

        // Insertar 50 números aleatorios
        for (int i = 0; i < 50; i++)
        {
            int n = rand.Next(1, 1000);

            if (EsPrimo(n))
                listaPrimos.AgregarAlFinal(n);

            if (EsArmstrong(n))
                listaArmstrong.AgregarAlInicio(n);
        }

        Console.WriteLine("Lista de primos:");
        listaPrimos.Mostrar();

        Console.WriteLine("Lista de Armstrong:");
        listaArmstrong.Mostrar();

        Console.WriteLine("\nCantidad en lista de primos: " + listaPrimos.Conteo);
        Console.WriteLine("Cantidad en lista de Armstrong: " + listaArmstrong.Conteo);

        if (listaPrimos.Conteo > listaArmstrong.Conteo)
            Console.WriteLine("La lista de primos tiene más elementos.");
        else if (listaPrimos.Conteo < listaArmstrong.Conteo)
            Console.WriteLine("La lista de Armstrong tiene más elementos.");
        else
            Console.WriteLine("Ambas listas tienen la misma cantidad de elementos.");
    }
}
