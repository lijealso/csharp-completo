using System;

namespace _29Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número");
            int a = int.Parse(Console.ReadLine());

            if(a < 0)
                Console.WriteLine("É negativo");
            else
                Console.WriteLine("É positivo");
        }
    }
}
