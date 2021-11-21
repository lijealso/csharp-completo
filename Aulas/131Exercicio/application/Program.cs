// See https://aka.ms/new-console-template for more information

using _131Exercicio.entities;

List<Employee> list = new();

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= n ; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());

    if (ch == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine());
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("Payments: ");

foreach (Employee emp in list)
    {
    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
    }
