using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41TrianguloMetodo
{
    internal class Triangulo
    {
        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;

            double area = Math.Sqrt( p * (p - A) * (p - B) * (p- C) );

            return area;
        }
    }
}
