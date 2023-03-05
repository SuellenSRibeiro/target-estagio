using System;

class Program
{
    static void Main(string[] args)
    {
        int indice = 13, soma = 0, k = 0;
        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }
        Console.WriteLine("A soma dos primeiros {0} números inteiros positivos é: {1}", indice, soma);
    }
}
