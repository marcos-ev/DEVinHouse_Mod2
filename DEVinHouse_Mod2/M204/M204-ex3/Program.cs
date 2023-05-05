using System;

class Banco
{
    private double saldo;

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Erro: saldo insuficiente.");
        }
    }

    public override string ToString()
    {
        return "Saldo: " + saldo;
    }
}

class Cliente
{
    private string nome;
    private string cpf;

    public Cliente(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }

    public override string ToString()
    {
        return "Nome: " + nome + ", CPF: " + cpf;
    }
}

class ContaBancaria
{
    private int numero;
    private Cliente cliente;
    private Banco banco;

    public ContaBancaria(int numero, Cliente cliente)
    {
        this.numero = numero;
        this.cliente = cliente;
        this.banco = new Banco();
    }

    public void Depositar(double valor)
    {
        banco.Depositar(valor);
    }

    public void Sacar(double valor)
    {
        banco.Sacar(valor);
    }

    public override string ToString()
    {
        return "Conta: " + numero + ", " + cliente.ToString() + ", " + banco.ToString();
    }

    public void ExibirDados()
    {
        Console.WriteLine("Dados da conta:\n" + ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente("João Silva", "123.456.789-00");
        ContaBancaria conta1 = new ContaBancaria(1234, cliente1);
        conta1.ExibirDados();
        conta1.Depositar(1000);
        Console.WriteLine("Depósito de R$1000.00");
        Console.WriteLine(conta1.ToString());
        conta1.Sacar(500);
        Console.WriteLine("Saque de R$500.00");
        Console.WriteLine(conta1.ToString());
    }
}
