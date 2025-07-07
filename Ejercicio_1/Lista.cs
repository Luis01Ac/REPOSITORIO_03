// Lista.cs
using System;

public class Lista
{
    public Nodo Cabeza;

    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
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

    public void EliminarFueraDeRango(int min, int max)
    {
        while (Cabeza != null && (Cabeza.Valor < min || Cabeza.Valor > max))
            Cabeza = Cabeza.Siguiente;

        Nodo actual = Cabeza;
        while (actual != null && actual.Siguiente != null)
        {
            if (actual.Siguiente.Valor < min || actual.Siguiente.Valor > max)
                actual.Siguiente = actual.Siguiente.Siguiente;
            else
                actual = actual.Siguiente;
        }
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
