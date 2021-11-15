using System;

namespace _24Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dados1 = Console.ReadLine();
            string[] vet1 = dados1.Split(' ');

            int num1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2]); 

            string dados2 = Console.ReadLine();
            string[] vet2 = dados2.Split(' ');

            int num2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2]);

            Console.WriteLine("Valor a pagar: R$ " + ( num1*valor1 + num2*valor2 ).ToString("F2"));
        }
    }
}
