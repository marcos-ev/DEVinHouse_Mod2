using System;

namespace SomaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, soma;

            Console.Write("Digite o primeiro número real: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número real: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número real: ");
            num3 = double.Parse(Console.ReadLine());

            soma = num1 + num2 + num3;

            Console.WriteLine("A soma dos números " + num1 + ", " + num2 + " e " + num3 + " é: " + soma);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
