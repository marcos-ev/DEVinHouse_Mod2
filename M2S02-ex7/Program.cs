using System;

class Program {
    static void Main(string[] args) {
        int numero;

        do {
            Console.Write("Digite um número inteiro positivo: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0) {
                Console.WriteLine("Erro: o número deve ser maior que zero.");
            }
        } while (numero <= 0);

        Console.WriteLine("\nNúmeros pares de 0 até {0}:", numero);
        for (int i = 0; i < numero; i += 2) {
            Console.WriteLine(i);
        }
    }
}
