using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Quantos números deseja calcular a média? ");
        int quantidadeNumeros = int.Parse(Console.ReadLine());

        int[] numeros = new int[quantidadeNumeros];
        double soma = 0;

        for (int i = 0; i < quantidadeNumeros; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        double media = soma / quantidadeNumeros;
        Console.WriteLine($"\nA média dos {quantidadeNumeros} números é: {media}");
    }
}
