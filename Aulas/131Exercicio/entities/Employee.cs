using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131Exercicio.entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHOur { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHOur)
        {
            Name = name;
            Hours = hours;
            ValuePerHOur = valuePerHOur;
        }

        public virtual double Payment()     
        {
            return Hours * ValuePerHOur;
        }
    }
}
