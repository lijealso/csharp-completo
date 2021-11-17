using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;
            Console.WriteLine("Quantos números: ");
            int n = int.Parse(Console.ReadLine());
            
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Número " + (i + 1) + ": " );
                vect[i] = double.Parse(Console.ReadLine());
                soma = soma + vect[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Posição" + i + " = " + vect[i]);
            }

            Console.WriteLine("MÉDIA = " + (soma / vect.Length).ToString("F2"));

            Console.ReadKey();
        }
    }
}
