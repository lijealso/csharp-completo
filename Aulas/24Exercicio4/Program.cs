using System;
using System.Globalization;

namespace _24Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o número do funcionário:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas trabalhadas:");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor pago por hora:");
            float porhora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario = horas * porhora;

            Console.WriteLine("Number = " + numero);
            Console.WriteLine("Salary = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
