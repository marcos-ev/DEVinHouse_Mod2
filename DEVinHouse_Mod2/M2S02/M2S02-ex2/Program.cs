using System;

namespace NumeroParImpar
{
class Program
{
static void Main(string[] args)
{
double num;

        Console.Write("Digite um número: ");
        num = double.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("O número " + num + " é par.");
        }
        else
        {
            Console.WriteLine("O número " + num + " é ímpar.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
}