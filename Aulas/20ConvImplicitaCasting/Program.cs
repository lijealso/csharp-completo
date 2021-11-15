using System;

namespace _20ConvImplicitaCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a;
            float b;

            // está a colocar conteúdo de 8 bytes em 4 bytes
            // tem que se fazer casting com (float)a
            a = 5.5;
            b = (float)a;
            Console.WriteLine(b);

            // valor de a fica truncado
            int c;
            c = (int)a;
            Console.WriteLine(c);

            int d = 5;
            int e = 2;
            double resultado = (double)d / e;
            Console.WriteLine(resultado);
        }
    }
}
