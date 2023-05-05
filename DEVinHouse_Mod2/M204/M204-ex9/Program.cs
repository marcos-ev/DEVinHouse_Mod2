using System;

static class Calculadora
{
    public const double Pi = 3.14159265359;

    public static double Soma(double a, double b)
    {
        return a + b;
    }

    public static double Subtracao(double a, double b)
    {
        return a - b;
    }

    public static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    public static double Divisao(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Erro: divisão por zero!");
            return 0;
        }
        else
        {
            return a / b;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        double resultado = Calculadora.Soma(10, 5);
        Console.WriteLine("Resultado da soma: " + resultado);

        resultado = Calculadora.Subtracao(10, 5);
        Console.WriteLine("Resultado da subtração: " + resultado);

        resultado = Calculadora.Multiplicacao(10, 5);
        Console.WriteLine("Resultado da multiplicação: " + resultado);

        resultado = Calculadora.Divisao(10, 5);
        Console.WriteLine("Resultado da divisão: " + resultado);

        resultado = Calculadora.Divisao(10, 0);
        Console.WriteLine("Resultado da divisão: " + resultado);

        Console.WriteLine("Valor de Pi: " + Calculadora.Pi);
    }
}
