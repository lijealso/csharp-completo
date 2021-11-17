using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercicio3
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double CalculaNotaFinal()
        {
            double resultado = Nota1 + Nota2 + Nota3;
            return resultado;
        }

        public string AferirPassagem()
        {
            double resultado = Nota1 + Nota2 + Nota3;

            if (resultado > 60.0)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO\n"
                    + "FALTARAM "
                    + (60.0 - resultado).ToString("F2")
                    + " PONTOS";
            }
        }
    }
}
