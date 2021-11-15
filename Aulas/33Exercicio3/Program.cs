using System;

namespace _33Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int entrada = int.Parse(Console.ReadLine());

            while (entrada > 0)
            {
                if (entrada > 4)
                {
                    entrada = int.Parse(Console.ReadLine());
                }
                else if (entrada == 1)
                {
                    alcool++;
                    entrada = int.Parse(Console.ReadLine());
                }
                else if (entrada == 2)
                {
                    gasolina++;
                    entrada = int.Parse(Console.ReadLine());
                }
                else if (entrada == 3)
                {
                    diesel++;
                    entrada = int.Parse(Console.ReadLine());
                }
                else if (entrada == 4)
                {
                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                    break;
                }
            }
        }    
    }
}
