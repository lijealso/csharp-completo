using System;

namespace _24Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o primeiro número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo número:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma = " + (a+b));
        }
    }
}
