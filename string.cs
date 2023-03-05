using System;

class Program
{
    static void Main(string[] args)
    {
        string original, invertida = "";
        Console.Write("Digite uma palavra ou frase: ");
        original = Console.ReadLine();
        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }
        Console.WriteLine("Palavra/frase original: {0}", original);
        Console.WriteLine("Palavra/frase invertida: {0}", invertida);
    }
}
