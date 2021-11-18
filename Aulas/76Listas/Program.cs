using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);

            // string s1 = list.Find(Test);

            string s1 = list.Find(x => x[0] == 'A');

            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');

            Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');

            Console.WriteLine("Index of first A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine("Index of last A: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Alex");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            list.RemoveAll(x => x[0] == 'M');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            list.RemoveAt(0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            list.RemoveAll(x => x[0] == 'M');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.Add("Maria");
            list.Add("Alex");


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------");

            list.RemoveRange(0, 1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
