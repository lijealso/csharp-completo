using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _92TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts1 = TimeSpan.MaxValue;
            TimeSpan ts2 = TimeSpan.MinValue;
            TimeSpan ts3 = TimeSpan.Zero;

            Console.WriteLine(ts1);
            Console.WriteLine(ts2);
            Console.WriteLine(ts3);

            Console.WriteLine("--------------");

            TimeSpan ts4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(ts4);

            Console.WriteLine("Days: " + ts4.Days);
            Console.WriteLine("Minutes: " + ts4.Minutes);

            Console.WriteLine("Total days: " + ts4.TotalDays);
            Console.WriteLine("Total minutes: " + ts4.TotalMinutes);

            Console.WriteLine("--------------");
            Console.WriteLine("Operações: ");

            TimeSpan ts5 = new TimeSpan(1, 30, 10);
            TimeSpan ts6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = ts5.Add(ts6);
            Console.WriteLine(ts5);
            Console.WriteLine(ts6);
            Console.WriteLine("Sum: " + sum);

            TimeSpan dif = ts5.Subtract(ts6);
            Console.WriteLine("Dif: " + dif);

            TimeSpan mult = 


        }
    }
}
