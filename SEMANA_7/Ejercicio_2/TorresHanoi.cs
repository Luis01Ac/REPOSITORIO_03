using System;

class TorresDeHanoi
{
    static void Main()
    {
        int n = 3;  // Número de discos
        char source = 'A';  // Torre fuente
        char auxiliary = 'B'; // Torre auxiliar
        char target = 'C';  // Torre de destino

        // Llamar a la función recursiva para resolver el problema
        SolveHanoi(n, source, auxiliary, target);
    }

    // Función recursiva para mover los discos
    static void SolveHanoi(int n, char source, char auxiliary, char target)
    {
        // Caso base: Si solo hay un disco, moverlo directamente
        if (n == 1)
        {
            Console.WriteLine($"Mover disco 1 de {source} a {target}");
            return;
        }

        // Paso 1: Mover n-1 discos de la torre fuente a la torre auxiliar
        SolveHanoi(n - 1, source, target, auxiliary);
        
        // Paso 2: Mover el disco n de la torre fuente a la torre destino
        Console.WriteLine($"Mover disco {n} de {source} a {target}");
        
        // Paso 3: Mover los n-1 discos de la torre auxiliar a la torre destino
        SolveHanoi(n - 1, auxiliary, source, target);
    }
}