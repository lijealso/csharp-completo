using System;
using System.Globalization;

namespace _24Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("introduza o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
