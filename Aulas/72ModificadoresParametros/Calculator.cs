﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72ModificadoresParametros
{
    class Calculator
    {
        /*
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        public static int Sum(params int[] numbers) // <-- adiciona-se "params"
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length ; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;
        }
    }
}
