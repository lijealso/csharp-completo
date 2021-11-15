using System;

namespace 15TiposBasicos
{
    class Program
    {
        static int Main(string[] args)
        {
            sbyte x = 100;
            Console.WriteLine(x);

            byte n1 = 255;
            // volta a zero
            n1++;
            Console.WriteLine(n1);
            
            // o numero está no limite de int
            int n2 = 2147483647;
            Console.WriteLine(n2);

            long n3 = 2147483648;
            Console.WriteLine(n3);

            return 0;
        }
    }
}
