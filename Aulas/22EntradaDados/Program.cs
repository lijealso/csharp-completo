using System;

namespace _22EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            Console.WriteLine("Texto digitado: " + frase);

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Digitado: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // ler com espaços para variáveis diferentes
            // string s = Console.ReadLine();
            // string[] vet = s.Split(' ');
            // ou:
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1 + " " + p2 + " " + p3);
            
        }
    }
}
