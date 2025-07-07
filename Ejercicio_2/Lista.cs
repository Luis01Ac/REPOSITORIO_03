// Lista.cs
using System;

public class Lista
{
    public Nodo Cabeza;
    public int Conteo = 0;

    public void AgregarAlFinal(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        Conteo++;

        if (Cabeza == null)
            Cabeza = nuevo;
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
    }

    public void AgregarAlInicio(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        nuevo.Siguiente = Cabeza;
        Cabeza = nuevo;
        Conteo++;
    }

    public void Mostrar()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}
