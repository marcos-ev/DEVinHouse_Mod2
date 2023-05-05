using System;
using System.Collections.Generic;

class ContaBancaria
{
    private double saldo;
    private List<string> transacoes;

    public ContaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
        transacoes = new List<string>();
    }

    public void Depositar(double valor)
    {
        saldo += valor;
        transacoes.Add($"Depósito de {valor:C}. Saldo atual: {saldo:C}");
    }

    public bool Retirar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            transacoes.Add($"Retirada de {valor:C}. Saldo atual: {saldo:C}");
            return true;
        }
        else
        {
            transacoes.Add($"Tentativa de retirada de {valor:C}, mas saldo insuficiente ({saldo:C})");
            return false;
        }
    }

    public double VerificarSaldo()
    {
        return saldo;
    }

    public List<string> VerificarTransacoes()
    {
        return transacoes;
    }
}
