﻿using System;

namespace _32While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine());

            while (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3"));
                Console.WriteLine("Digite outro número");
                x = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo, impossível calcular");
        }
    }
}
