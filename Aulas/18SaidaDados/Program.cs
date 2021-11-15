using System;
using System.Globalization; // ponto em vez de vírgula

namespace 18SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // não faz quebra de linha
            Console.Write("Hello World!");

            // coloca quebra de linha
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            char genero = 'F';
            int idade = 32;
            double saldo = 10.47734;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            // notar que faz arredondamento para 10.48
            // apresentadouble com 2 casas decimais
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));

            // colocar ponto em vez de vírgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // placeholders
            Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2} euros", nome, idade, saldo);

            // interpolação
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo:F2} euros");

            // concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo de " + saldo.ToString("F2") + " euros");
        }
    }
}
