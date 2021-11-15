using System;

namespace _29Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;

            Console.WriteLine("Insira o código e a quantidadade:");
            string[] vet = Console.ReadLine().Split(' ');

            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            if (X == 1)
            {
                preco = 4.00;
                Console.WriteLine("Total: R$ " + (preco * Y).ToString("F2"));
            }
            else if (X == 2)
            {
                preco = 4.50;
                Console.WriteLine("Total: R$ " + (preco * Y).ToString("F2"));
            }
            else if (X == 3)
            {
                preco = 5.00;
                Console.WriteLine("Total: R$ " + (preco * Y).ToString("F2"));
            }
            else if (X == 4)
            {
                preco = 5.00;
                Console.WriteLine("Total: R$ " + (preco * Y).ToString("F2"));
            }
            else if (X == 5)
            {
                preco = 5.00;
                Console.WriteLine("Total: R$ " + (preco * Y).ToString("F2"));
            }
        }
    }
}
