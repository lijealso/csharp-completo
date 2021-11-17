using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Insira a largura e altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine(retangulo);


            Console.ReadLine();
        }
    }
}
