using System;

namespace _24Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.
            Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B. */

            double pi = 3.14159;
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);

            Console.WriteLine("Triângulo: " + ( (a*c)/2 ).ToString("F3"));
            Console.WriteLine("Círculo: " + ( pi*c*c ).ToString("F3") );
            Console.WriteLine("Trapézio: " + ( (a+b)/2 * c ).ToString("F3"));
            Console.WriteLine("Quadrado: " + (Math.Pow(b,2).ToString("F3")));
            Console.WriteLine("Rectângulo: " + ( ( a*b ).ToString("F3")));

        }
    }
}
