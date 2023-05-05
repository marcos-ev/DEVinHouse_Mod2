using System;

abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public abstract void EmitirSom();
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal cachorro1 = new Cachorro();
        cachorro1.Nome = "Rex";
        cachorro1.Idade = 2;
        cachorro1.EmitirSom();

        Animal gato1 = new Gato();
        gato1.Nome = "Garfield";
        gato1.Idade = 4;
        gato1.EmitirSom();
    }
}
