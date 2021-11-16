﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A39TrianguloComClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;

            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) + (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) + (p - y.B));

            Console.WriteLine("Área de X = " + areaX.ToString("F4"));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área = X");
            }
            else
            {
                Console.WriteLine("Maior área = Y");
            }

            Console.ReadKey();
        }
    }
}
