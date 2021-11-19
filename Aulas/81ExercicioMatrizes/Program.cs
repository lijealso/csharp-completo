using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81ExercicioMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size (rows and columns): ");
            string[] answer = new string[2];
            answer = Console.ReadLine().Split(' ');
            int rows = int.Parse(answer[0]);
            int columns = int.Parse(answer[1]);

            int[,] mat = new int[rows,columns];

            for (int i = 0 ; i < rows ; i++)
            {
                Console.Write("Enter row values: ");
                string[] row = Console.ReadLine().Split(' ');

                for (int j = 0 ; j < columns ; j++)
                {
                    mat[i,j] = int.Parse(row[j]);
                }
            }

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mat[i,j] == number)
                    {
                        Console.WriteLine("Number found, position: [" + i + "," + j + "]");

                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        if (j < columns - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[(i - 1), j]);
                        if (i < rows - 1)
                            Console.WriteLine("Down: " + mat[(i + 1), j]);
                    }
                }
            }
        }
    }
}
