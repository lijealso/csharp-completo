using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66TiposRefValor
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "X = "
                + X.ToString()
                + " Y = "
                + Y.ToString();
        }
    }
}
