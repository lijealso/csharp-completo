using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + funcionario);

            Console.Write("Digite a percentagem para aumenta o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + funcionario);

            Console.ReadLine();

        }
    }
}
