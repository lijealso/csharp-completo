using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42Exercicio
{
        public class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            // Console.WriteLine("Dados do produto: " + p1.Nome + ", $ " + p1.Preco.ToString("F2") + ", " + p1.Quantidade + " unidades, Total: $ " + p1.ValorTotalEmEstoque());
            Console.WriteLine("Dados do produto: " + p1);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p1.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            p1.RemoverProdutos(int.Parse(Console.ReadLine()));

            // Console.WriteLine("Dados atualizados: " + p1.Nome + ", $ " + p1.Preco.ToString("F2") + ", " + p1.Quantidade + " unidades, Total: $ " + p1.ValorTotalEmEstoque());
            Console.WriteLine("Dados atualizados: " + p1);

            Console.ReadLine();
        }
    }
}
