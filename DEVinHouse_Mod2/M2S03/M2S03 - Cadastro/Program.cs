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
            while (true)
            {
                Menu(args);

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
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

         static void Menu(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao sistema de cadastro de carros. Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Carro");
                Console.WriteLine("2 - Consultar Carros");
                Console.WriteLine("3 - Sair");

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarNovoCarro();
                        break;
                    case "2":
                        ListarCarros();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}