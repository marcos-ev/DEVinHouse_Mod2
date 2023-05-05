using System;

class ContaBancaria
{
    private int numeroConta;
    private double saldo;

    public ContaBancaria(int numeroConta)
    {
        this.numeroConta = numeroConta;
        saldo = 0;
    }

    public void deposita(double valor)
    {
        saldo += valor;
    }

    public void saca(double valor)
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

    public double getSaldo()
    {
        return saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria(123);
        conta1.deposita(1000);
        conta1.saca(500);
        Console.WriteLine("Saldo disponível: " + conta1.getSaldo());
    }
}
