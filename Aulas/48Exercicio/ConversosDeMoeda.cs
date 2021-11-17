using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48Exercicio
{
    public class ConversosDeMoeda
    {
        public static double IOF = 0.06;

        public static double Converte(double cotacao, double quantidade)
            {
            double resultado;

            resultado = quantidade * cotacao;

            return resultado + resultado * IOF;
            }
    }
}
