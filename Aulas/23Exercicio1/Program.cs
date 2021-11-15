using System;
using System.Globalization;

namespace _23Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa:");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre sua último nome, idade e altura (na mesma linha):");

            string[] vet = Console.ReadLine().Split(' ');
            string ultimo = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
