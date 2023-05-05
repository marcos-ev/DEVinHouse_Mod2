using System;
using System.Collections.Generic;

namespace FullStackBank
{
    // Classe abstrata Cliente, que serve de base para as classes PessoaFisica e PessoaJuridica
    public abstract class Cliente
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public string Endereco { get; set; }

        public virtual void ResumoCliente()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}\nSaldo: {Saldo:C}\nEndereço: {Endereco}");
        }
    }

    // Classe PessoaFisica, que herda da classe Cliente
    public class PessoaFisica : Cliente
    {
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

        public override void ResumoCliente()
        {
            base.ResumoCliente();
            Console.WriteLine($"CPF: {CPF}\nData de Nascimento: {DataNascimento:d}");
        }

        public bool EhMaior()
        {
            DateTime dataAtual = DateTime.Today;
            int idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-idade))
                idade--;

            return idade >= 18;
        }
    

    // Classe ClienteService, que gerencia os clientes do banco
    public class ClienteService
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static void CriarConta()
        {
            Console.WriteLine("Qual tipo de conta você gostaria de criar?");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");
            int tipoConta = int.Parse(Console.ReadLine());

            switch (tipoConta)
            {
                case 1:
                    CriarContaPessoaFisica();
                    break;
                case 2:
                    CriarContaPessoaJuridica();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private static void CriarContaPessoaFisica()
        {
            Console.WriteLine("Criando conta para pessoa física...");
            PessoaFisica cliente = new PessoaFisica();

            Console.Write("Informe o número da conta: ");
            cliente.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o saldo inicial: ");
            cliente.Saldo = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o endereço: ");
            cliente.Endereco = Console.ReadLine();

            Console.Write("Informe o CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.Write("Informe a data de nascimento (dd/mm/aaaa): ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            if (cliente.EhMaior())
            {
                clientes.Add(cliente);
                Console.WriteLine("Conta criada com sucesso!");
            }
            else
            {
                Console.WriteLine("O cliente precisa ser maior de idade para abrir uma conta.");
            }
        }

        private static void CriarContaPessoaJuridica()
        {
            // Implementação para criar conta de pessoa jurídica
        }

        public static Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    return cliente;
                }
            }

            Console.WriteLine($"Não foi encontrado nenhum cliente com o número da conta {numeroConta}.");
            return null;
        }

    public static void ExibirClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Não há clientes cadastrados no momento.");
            }
            else
            {
                Console.WriteLine("Lista de clientes:");
                foreach (Cliente cliente in clientes)
                {
                    cliente.ResumoCliente();
                    Console.WriteLine();
                }
            }
        }
  

    // Classe Program, que contém o método Main
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bem-vindo ao Full Stack Bank!");
                Console.WriteLine("O que você gostaria de fazer?");
                Console.WriteLine("1 - Criar uma conta");
                Console.WriteLine("2 - Buscar um cliente pelo número da conta");
                Console.WriteLine("3 - Exibir lista de clientes");
                Console.WriteLine("0 - Sair");
                double opcao = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ClienteService.CriarConta();
                        break;
                    case 2:
                        Console.Write("Informe o número da conta: ");
                        int numeroConta = int.Parse(Console.ReadLine());
                        Cliente cliente = ClienteService.BuscarClientePorNumeroDeConta(numeroConta);
                        if (cliente != null)
                        {
                            cliente.ResumoCliente();
                        }
                        break;
                    case 3:
                        ClienteService.ExibirClientes();
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por usar o Full Stack Bank!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();
            }
            }
            }
            
public class PessoaJuridica : Cliente
{
    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }

    public override void ResumoCliente()
    {
        base.ResumoCliente();
        Console.WriteLine($"Razão Social: {RazaoSocial}\nCNPJ: {CNPJ}");
    }

    private static void CriarContaPessoaJuridica()
{
    Console.WriteLine("Criando conta para pessoa jurídica...");
    PessoaJuridica cliente = new PessoaJuridica();

    Console.Write("Informe o número da conta: ");
    cliente.NumeroConta = int.Parse(Console.ReadLine());

    Console.Write("Informe o saldo inicial: ");
    cliente.Saldo = decimal.Parse(Console.ReadLine());

    Console.Write("Informe o endereço: ");
    cliente.Endereco = Console.ReadLine();

    Console.Write("Informe o CNPJ: ");
    cliente.CNPJ = Console.ReadLine();

    Console.Write("Informe a razão social: ");
    cliente.RazaoSocial = Console.ReadLine();

    clientes.Add(cliente);
    Console.WriteLine("Conta criada com sucesso!");
}


public interface IClienteService
{
    void CriarConta();
    Cliente BuscarClientePorNumeroDeConta(int numeroConta);
    void ExibirClientes();

    static void Menu(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao Full Stack Bank!");
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("1 - Abrir Conta");
            Console.WriteLine("2 - Consultar Conta");
            Console.WriteLine("3 - Listar Todas as Contas");
            Console.WriteLine("4 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ClienteService.CriarConta();
                    break;
                case "2":
                    Console.Write("Informe o número da conta: ");
                    int numeroConta = int.Parse(Console.ReadLine());
                    Cliente cliente = ClienteService.BuscarClientePorNumeroDeConta(numeroConta);
                    if (cliente != null)
                    {
                        cliente.ResumoCliente();
                    }
                    break;
                case "3":
                    ClienteService.ExibirClientes();
                    break;
                case "4":
                    Console.WriteLine("Obrigado por usar o Full Stack Bank!");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine();
        }
    }
}
}
}
}
}




