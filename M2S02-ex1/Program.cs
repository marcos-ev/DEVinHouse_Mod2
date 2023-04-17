using System;

namespace SomaNumerosReais
{
class Program
{
static void Main(string[] args)
{
double num1, num2, soma;

        Console.Write("Digite o primeiro número real: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número real: ");
        num2 = double.Parse(Console.ReadLine());

        soma = num1 + num2;

        Console.WriteLine("A soma dos números " + num1 + " e " + num2 + " é: " + soma);

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
}