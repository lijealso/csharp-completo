using System;

namespace _33Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] pontos = Console.ReadLine().Split(' ');

            int X = int.Parse(pontos[0]);
            int Y = int.Parse(pontos[1]);

            while (X != 0 && Y != 0)
            {

                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                pontos = Console.ReadLine().Split(' ');
                X = int.Parse(pontos[0]);
                Y = int.Parse(pontos[1]);
            }
        }
    }
}
