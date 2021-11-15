using System;

namespace _29Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número:");
            int a = int.Parse(Console.ReadLine());

            if(a%2 == 0)
                Console.WriteLine("É par");
            else
                Console.WriteLine("É ímpar");
        }
    }
}
