using System;

namespace _29Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());

            if (x >= 0.0 && x <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (x > 25.0 && x <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (x > 50.0 && x <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (x > 75.0 && x <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else if (x < 0 || x > 100)
            {
                Console.WriteLine("Fora do intervalo");
            }       
        }
    }
}
