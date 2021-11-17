using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Exercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numeroConta;
            string nome;
            double depositoInicial;
            char resposta;

            Conta contaBancaria;

            Console.Write("Número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            nome = Console.ReadLine();

            Console.Write("Deposito inicial (s/n)? ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new Conta(numeroConta, nome, depositoInicial);
                
            }
            else
            {
                contaBancaria = new Conta(numeroConta, nome);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);

            Console.Write("Valor a depositar: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.Write("Valor a levantar: ");
            contaBancaria.Levantamento(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);


            Console.ReadLine();
        }
    }
}
