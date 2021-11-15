using System;

namespace _29Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira 2 números:");
            string[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);

            if(a > b && a%b == 0 || b > a && b%a == 0)
                Console.WriteLine("São múltiplos");
            else if(a > b && a%b != 0 || b > a && b%a != 0)
                Console.WriteLine("Não são múltiplos");
        }
    }
}
