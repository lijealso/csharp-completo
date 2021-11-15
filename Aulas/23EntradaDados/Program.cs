using System;
using System.Globalization;

namespace _23EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digitado: ");
            Console.WriteLine(n1);

            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Digitado: ");
            Console.WriteLine(ch);

            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digitado: ");
            Console.WriteLine(n2);
            */

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Digitado:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
