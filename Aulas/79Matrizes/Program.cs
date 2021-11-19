using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[2, 3];

            Console.WriteLine(mat.Length); // número de elementos da matriz

            Console.WriteLine(mat.Rank); // quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // tamanho da primeira dimensão (linhas)

            Console.WriteLine(mat.GetLength(1)); // tamanho da segunda dimensão (colunas)

        }
    }
}
