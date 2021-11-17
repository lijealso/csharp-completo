using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57AutoProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);

            p.Preco = 555.0;
            Console.WriteLine(p.Preco);

            Console.ReadKey();  
        }
    }
}
