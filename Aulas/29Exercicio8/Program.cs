using System;

namespace _29Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario = float.Parse(Console.ReadLine());

            if (salario <= 2000)
                Console.WriteLine("Isento");
            else if(salario <= 3000)
                Console.WriteLine("R$ " + ((salario-2000)*0.08).ToString("F2"));
            else if(salario <= 4500)
            
                Console.WriteLine("R$ " + (80+((salario-3000)*0.18)).ToString("F2"));
            else
                Console.WriteLine("R$ " + (350+((salario-4500)*0.28)).ToString("F2"));
        }
    }
}
