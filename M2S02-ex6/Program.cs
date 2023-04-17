using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        string frase = "A linguagem de programação C# é muito poderosa";
        List<string> palavras = new List<string>(frase.Split(' '));
        string palavraBuscada = "poderosa";

        for (int i = 0; i < palavras.Count; i++) {
            if (palavras[i] == palavraBuscada) {
                Console.WriteLine($"A palavra buscada é: {palavraBuscada}");
                return;
            }
        }

        Console.WriteLine("A palavra buscada não foi encontrada na frase.");
    }
}
