using System;

namespace _24Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o primeiro valor:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o segundo valor:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o terceiro valor:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o quarto valor:");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Diferença = " + (a * b - c * d));
        }
    }
}
