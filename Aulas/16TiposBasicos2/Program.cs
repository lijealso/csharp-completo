using System;

namespace 16TiposBasicos2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);

            // código unicode
            char letra = '\u0041';
            Console.WriteLine(letra);

            float n5 = 4.5f;
            double n6 = 4.6;
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            // é uma cadeia de códigos unicode e é imutável
            string nome = "Maria Green";
            Console.WriteLine(nome);

            // obj é um tipo genérico, aceita quqlquer coisa
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // funções para valores máximos e mínimos
            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);


        }
    }
}
