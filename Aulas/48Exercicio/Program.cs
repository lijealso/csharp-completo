using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Exercicio
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConversosDeMoeda conversor = new ConversosDeMoeda();

            Console.Write("Qual a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares vai comprar: ");
            double quantidade = double.Parse(Console.ReadLine());

            double resultado = ConversosDeMoeda.Converte(cotacao, quantidade);

            Console.WriteLine("Valor a ser pago: " + resultado.ToString("F2"));

            Console.ReadLine();
        }
    }
}
