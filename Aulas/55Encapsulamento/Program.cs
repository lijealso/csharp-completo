using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55Encapsulamento
{
    public class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            // p.Quantidade = -10;

            Console.WriteLine(p.GetNome());

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());

            p.SetNome("R"); // tem que ter pelo menos 2 caracteres

            Console.WriteLine(p.GetNome());

            Console.ReadKey();
        }
    }
}
