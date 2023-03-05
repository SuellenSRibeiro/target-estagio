using System;

public class Program {
    public static void Main() {
        int numero;
        bool pertence;

        Console.Write("Informe um número: ");
        numero = int.Parse(Console.ReadLine());

        pertence = VerificaFibonacci(numero);

        if (pertence) {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
        } else {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
        }
    }

    public static bool VerificaFibonacci(int numero) {
        int a = 0;
        int b = 1;
        int c = 1;

        while (c < numero) {
            a = b;
            b = c;
            c = a + b;
        }
        if (c == numero) {
            return true;
        } else {
            return false;
        }
    }
}
