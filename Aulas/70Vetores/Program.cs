using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for(int i = 0 ; i < n ; i++)
            {
                sum += vect[i].Price;
            }

            Console.WriteLine("AVERAGE PRICE = " + (sum/vect.Length).ToString("F2"));

            Console.ReadLine();
        }

    }
}
