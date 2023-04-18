using System;

class Program {
    static void Main(string[] args) {
        int[] numeros = new int[5];
        int maiorNumero = int.MinValue;

        for (int i = 0; i < 5; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > maiorNumero) {
                maiorNumero = numeros[i];
            }
        }

        Console.WriteLine($"\nO maior número digitado foi: {maiorNumero}");
    }
}
