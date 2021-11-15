using System;

namespace _26OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 4 != 5;
            Console.WriteLine(c1);

            bool c2 = 2 > 3 && 4 != 5;
            Console.WriteLine(c2);

            bool c3 = 2 > 3 || 4 != 5; // verdadeiro
            Console.WriteLine(c3);

            bool c4 = !(2 > 3) && 4 != 5; // verdadeiro
            Console.WriteLine(c4);

            Console.WriteLine("-----------------");

            bool c5 = 10 < 5; // falso
            bool c6 = c3 || c4 && c5; // verdadeiro

            Console.WriteLine(c6);
        }
    }
}
