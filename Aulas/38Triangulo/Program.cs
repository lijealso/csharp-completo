using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC;
            double yA, yB, yC;

            Console.WriteLine("Medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2.0;

            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) + (p - xC));

            p = (yA + yB + yC) / 2.0;

            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) + (p - yC));

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
