using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131Exercicio.entities
{
    class OutsourcedEmployee : Employee
    {
        public double AddicionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHOur, double additionalCharge)
           : base (name, hours, valuePerHOur)
        {
            AddicionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + AddicionalCharge * 1.1;

        }
    }
}