using _115Enum.entities;
using _115Enum.entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _115Enum.application
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // from enum to string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // from string to enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivere");
            Console.WriteLine(os);          
        }
        
    }
}
