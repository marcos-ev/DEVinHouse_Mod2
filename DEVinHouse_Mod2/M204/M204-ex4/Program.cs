using System;

class ContaBancaria
{
    private double saldo;

    public double Saldo
    {
        get { return saldo; }
        set { saldo = value >= 0 ? value : 0; }
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Erro: saldo insuficiente.");
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Depositar(1000);
        Console.WriteLine("Saldo disponível: " + conta1.Saldo);
        if (conta1.Sacar(500))
        {
            Console.WriteLine("Saque de R$500.00 efetuado.");
            Console.WriteLine("Saldo disponível: " + conta1.Saldo);
        }
        else
        {
            Console.WriteLine("Saque de R$500.00 não pôde ser efetuado.");
        }
    }
}
