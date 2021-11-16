using System;

namespace _34For
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            Console.WriteLine("Quantos números inteiros? ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 1 ; i <= N ; i++)
            {
                Console.WriteLine("Insira o número # " + i);
                soma = soma + int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma = " + soma);

        }
    }
}
