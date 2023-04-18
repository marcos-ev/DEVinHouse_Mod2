using System;

namespace Paciente
{
class Program
{
static void Main(string[] args)
{
string nome;
double idade;

        Console.Write("Digite o nome do paciente: ");
        nome = Console.ReadLine();

        Console.Write("Digite a idade do paciente: ");
        idade = double.Parse(Console.ReadLine());

        Console.WriteLine("\n\nNome do paciente: " + nome);

        if (idade < 18)
        {
            Console.WriteLine("O paciente é menor de idade.");
        }
        else if (idade < 60)
        {
            Console.WriteLine("O paciente é maior de idade.");
        }
        else
        {
            Console.WriteLine("O paciente é idoso.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
}