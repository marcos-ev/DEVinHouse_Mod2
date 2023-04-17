using System;

class Program {
    static void Main(string[] args) {
        int[] numeros = new int[4];

        for (int i = 0; i < 4; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numeros);

        Console.WriteLine("\nNúmeros ordenados:");
        for (int i = 0; i < 4; i++) {
            Console.WriteLine(numeros[i]);
        }
    }
}