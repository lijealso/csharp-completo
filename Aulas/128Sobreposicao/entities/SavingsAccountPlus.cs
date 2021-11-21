using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _128Sobreposicao.entities
{
    class SavingsAccountPlus : SavingsAccount
    {
        // 'class1' : cannot derive from sealed type 'class2'

        public override void Withdraw(double amount)
        {
            // 'member' : cannot override inherited member 'inherited member' because it is sealed
        }
    }
}
