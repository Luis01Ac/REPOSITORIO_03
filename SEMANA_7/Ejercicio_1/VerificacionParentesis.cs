using System;
using System.Collections.Generic;

class VerificacionParentesis
{
    static void Main()
    {
        // Solicitar al usuario que ingrese una expresión
        Console.WriteLine("Ingrese la expresión matemática:");
        string expression = Console.ReadLine();
        
        // Llamar a la función para verificar si la expresión está balanceada
        if (IsBalanced(expression))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula no balanceada.");
        }
    }

    // Función para verificar si los paréntesis están balanceados
    static bool IsBalanced(string expression)
    {
        // Usamos una pila para almacenar los paréntesis abiertos
        Stack<char> stack = new Stack<char>();
        
        // Recorrer cada carácter de la expresión
        foreach (char c in expression)
        {
            // Si encontramos un paréntesis de apertura, lo apilamos
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            // Si encontramos un paréntesis de cierre, verificamos que coincida con el de apertura
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía o no hay coincidencia, la expresión no es balanceada
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
                {
                    return false;
                }
            }
        }

        // Al final, si la pila está vacía, entonces está balanceada
        return stack.Count == 0;
    }

    // Función para verificar si un par de paréntesis coincide
    static bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}
