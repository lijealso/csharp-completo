using System;

namespace _27IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("Bom dia");

            if (x > 5)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");

            // par ou ímpar

            Console.WriteLine("Insira um número:");
            int y = int.Parse(Console.ReadLine());

            if(y % 2 == 0)
                Console.WriteLine("O número é par");
            else
                Console.WriteLine("O número é ímpar");

            // encadeamento

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12)
                Console.WriteLine("Bom dia");
            else if(hora < 18)
                Console.WriteLine("Boa tarde");
            else
                Console.WriteLine("Boa noite");
        }
    }
}
