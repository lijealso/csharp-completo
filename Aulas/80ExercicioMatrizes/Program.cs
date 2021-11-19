using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.Write("Main diagonal: ");
            for (int j = 0; j < N; j++)
            {
                Console.Write(mat[j, j] + " ");
            }

            Console.WriteLine("\nNegative numbers: " + count);
        }
    }
}
