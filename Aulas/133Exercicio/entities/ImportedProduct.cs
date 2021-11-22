using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133Exercicio.entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return TotalPrice().ToString("F2") + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
