using System;

namespace _21OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // * / % tem precedência maior que + e -
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            int n4 = 10 / 8;
            Console.WriteLine(n4);

            double n5 = 10 / 8;
            Console.WriteLine(n5);

            double n6 = (double)10 / 8;
            Console.WriteLine(n6);

            double a = 1.0, b = -3.0, c = -4.0;
            // double delta = b * b - 4.0 * a * c;
            // ou:
            double delta2 = Math.Pow(b, 2) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta2)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta2)) / (2.0 * a);

            Console.WriteLine($"X1 = {x1} e X2 = {x2}");
        }
    }
}
