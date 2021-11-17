using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercicio1
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (2.0 * Largura) + (2.0 * Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura,2) + Math.Pow(Altura,2));
        }

        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2")
                + "\nPERÍMETRO: "
                + Perimetro().ToString("F2")
                + "\nDIAGONAL: "
                + Diagonal().ToString("F2");
        }
    }
}
