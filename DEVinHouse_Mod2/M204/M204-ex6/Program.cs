using System;

class Retangulo
{
    private double largura;
    private double altura;

    public double Largura
    {
        get { return largura; }
        set { largura = value >= 0 ? value : 0; }
    }

    public double Altura
    {
        get { return altura; }
        set { altura = value >= 0 ? value : 0; }
    }

    public double CalcularArea()
    {
        return Largura * Altura;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo1 = new Retangulo();
        retangulo1.Largura = -5;
        retangulo1.Altura = 10;
        Console.WriteLine("Largura: " + retangulo1.Largura);
        Console.WriteLine("Altura: " + retangulo1.Altura);
        Console.WriteLine("Área: " + retangulo1.CalcularArea());
        retangulo1.Largura = 5;
        Console.WriteLine("Largura: " + retangulo1.Largura);
        Console.WriteLine("Altura: " + retangulo1.Altura);
        Console.WriteLine("Área: " + retangulo1.CalcularArea());
    }
}
