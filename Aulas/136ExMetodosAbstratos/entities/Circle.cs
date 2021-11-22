using System;
using _136ExMetodosAbstratos.entities.enums;

namespace _136ExMetodosAbstratos.entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2.0) * Math.PI;
        }
    }
}
