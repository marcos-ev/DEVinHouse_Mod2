using System;

class ContaBancaria
{
    public int NumeroDaConta { get; set; }
    public const double SaldoMaximo = 10000.00;
    private double saldo;

    public double Saldo
    {
        get { return saldo; }
    }

    public void Depositar(double valor)
    {
        if (valor > 0 && Saldo + valor <= SaldoMaximo)
        {
            saldo += valor;
            Console.WriteLine("Depósito realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Erro: valor de depósito inválido.");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && Saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Erro: valor de saque inválido.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.NumeroDaConta = 1234;
        conta1.Depositar(5000.00);
        Console.WriteLine("Saldo atual: " + conta1.Saldo);
        conta1.Sacar(2000.00);
        Console.WriteLine("Saldo atual: " + conta1.Saldo);
        conta1.Depositar(10000.00);
        Console.WriteLine("Saldo atual: " + conta1.Saldo);
        conta1.Depositar(2000.00);
        Console.WriteLine("Saldo atual: " + conta1.Saldo);
        conta1.Sacar(15000.00);
        Console.WriteLine("Saldo atual: " + conta1.Saldo);
    }
}
