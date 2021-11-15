using System;

namespace _29Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a hora inicial e a hora final");
            string[] vet = Console.ReadLine().Split(' ');
            int i = int.Parse(vet[0]);
            int f = int.Parse(vet[1]);

            if(i == f)
                Console.WriteLine("O jogo durou 24 horas");
            else if(i < f)
                Console.WriteLine("O jogo durou " + (f - i).ToString() );
            else if(i > f)
                Console.WriteLine("O jogo durou " + (24 - i + f));
        }
    }
}
