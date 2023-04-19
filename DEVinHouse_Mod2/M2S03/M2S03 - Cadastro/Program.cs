using System;
using System.Collections.Generic;

namespace CadastroCar
{
    class Proprietario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Proprietario(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }
    }

    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public Proprietario Proprietario { get; set; }

        public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Proprietario = proprietario;
        }
    }

    class Program
    {
        static List<Carro> carros = new List<Carro>();

        static void Main(string[] args)
        {
            // criando as instâncias da classe Proprietario com diferentes parâmetros
            var Proprietario1 = new Proprietario("Ana Luiza Oliveira", "987.654.321-00", "(48) 99999-8888");
            var Proprietario2 = new Proprietario("Fernando Silva Santos", "123.456.789-00", "(48) 77777-6666");
            var Proprietario3 = new Proprietario("Lucas Pereira Souza", "111.222.333-44", "(48) 33333-2222");

            // criando as instâncias da classe Carro com diferentes parâmetros e Proprietarios
            var carro1 = new Carro("Volkswagen", "Polo", "ABC-1234", "Azul", Proprietario1);
            var carro2 = new Carro("Chevrolet", "Onix", "DEF-5678", "Prata", Proprietario2);
            var carro3 = new Carro("Toyota", "Corolla", "GHI-9012", "Preto", Proprietario3);

            // adicionando as instâncias de Carro na lista
            carros.Add(carro1);
            carros.Add(carro2);
            carros.Add(carro3);

            CadastrarNovoCarro();

            // restante do código aqui
        }

       static void CadastrarNovoCarro()
{
    // Obtém os atributos do proprietário via Console.ReadLine()
    Console.WriteLine("Cadastro de proprietário:");
    Console.Write("Nome: ");
    string nomeProprietario = Console.ReadLine();
    Console.Write("CPF: ");
    string cpfProprietario = Console.ReadLine();
    Console.Write("Telefone: ");
    string telefoneProprietario = Console.ReadLine();
    
    // Cria a instância de Proprietario com os valores obtidos
    Proprietario novoProprietario = new Proprietario(nomeProprietario, cpfProprietario, telefoneProprietario);
    
    // Obtém os atributos do carro via Console.ReadLine()
    Console.WriteLine("\nCadastro de carro:");
    Console.Write("Marca: ");
    string marcaCarro = Console.ReadLine();
    Console.Write("Modelo: ");
    string modeloCarro = Console.ReadLine();
    Console.Write("Placa: ");
    string placaCarro = Console.ReadLine();
    Console.Write("Cor: ");
    string corCarro = Console.ReadLine();
    
    // Cria a instância de Carro com os valores obtidos
    Carro novoCarro = new Carro(marcaCarro, modeloCarro, placaCarro, corCarro, novoProprietario);
    
    // Adiciona a instância de Carro na lista de carros
    carros.Add(novoCarro);
    
    Console.WriteLine("\nNovo carro cadastrado com sucesso!");
} 

static void ListarCarros()
{
    Console.WriteLine("Lista de carros cadastrados:\n");
    
    foreach (var carro in carros)
    {
        Console.WriteLine($"Marca: {carro.Marca}");
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Placa: {carro.Placa}");
        Console.WriteLine($"Cor: {carro.Cor}");
        Console.WriteLine($"Proprietário:");
        Console.WriteLine($"Nome: {carro.Proprietario.Nome}");
        Console.WriteLine($"CPF: {carro.Proprietario.CPF}");
        Console.WriteLine($"Telefone: {carro.Proprietario.Telefone}");
        Console.WriteLine("-----------------------------");
    }
}

 }

 
  }

  
