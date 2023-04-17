using System;

namespace Carro
{
class Program
{
static void Main(string[] args)
{
string marca, modelo;
double km;

        Console.Write("Digite a marca do carro: ");
        marca = Console.ReadLine();

        Console.Write("Digite o modelo do carro: ");
        modelo = Console.ReadLine();

        Console.Write("Digite a km rodados do carro: ");
        km = double.Parse(Console.ReadLine());

        Console.WriteLine("Carro: " + marca + " " + modelo);
        Console.WriteLine("KM rodados: " + km);

        if (km > 10000)
        {
            Console.WriteLine("O carro precisa de uma revisão.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
}