using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == id2);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This Id does not exist!");
            }


            Console.WriteLine("Updated list of employees: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
