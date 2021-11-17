using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72ModificadoresParametros
{
    class Program
    {
        static void Main(string[] args)
        {         
            // int s1 = Calculator.Sum(2, 3);

            // int s1 = Calculator.Sum(new int[] {2, 3});

            // int s2 = Calculator.Sum(3, 4, 5);

            // int s2 = Calculator.Sum(new int[] {4, 5, 6});

            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(3, 4, 6);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
            Console.ReadKey();
        }
    }
}
