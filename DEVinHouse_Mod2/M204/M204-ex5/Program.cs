using System;

class Pessoa
{
    private string nome;
    private int idade;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value >= 0 ? value : 0; }
    }

    public void DefinirIdade(int idade)
    {
        if (idade >= 0)
        {
            Idade = idade;
        }
        else
        {
            Console.WriteLine("Erro: idade inválida.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "João Silva";
        pessoa1.DefinirIdade(-30);
        Console.WriteLine("Nome: " + pessoa1.Nome);
        Console.WriteLine("Idade: " + pessoa1.Idade);
        pessoa1.DefinirIdade(30);
        Console.WriteLine("Nome: " + pessoa1.Nome);
        Console.WriteLine("Idade: " + pessoa1.Idade);
    }
}
