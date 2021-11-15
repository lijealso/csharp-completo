using System;

namespace _28ScopeInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y;

            // Console.WriteLine(y);

            double preco = double.Console.ReadLine();

            if(preco > 100.0)
            {
                double desconto = preco * 0.1;
            }

            // não funciona fora do IF
            // Console.WriteLine(desconto);
        }
    }
}
