using System;

namespace _19OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a %= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            // concatenação de strings
            s += " DEF";
            Console.WriteLine(s);

            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);

            a = 10;
            // primeiro atribui a a b, depois incrementa a
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 10;
            // primeiro incrementa a e depois atribui a a b
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);





        }
    }
}
