// See https://aka.ms/new-console-template for more information

using _136ExMetodosAbstratos;
using _136ExMetodosAbstratos.entities;
using _136ExMetodosAbstratos.entities.enums;

List<Shape> list = new();

Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.Write("Rectangle or Circle (r/c)");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (ch == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());
        list.Add(new Circle(radius, color));
    }
}

    Console.WriteLine();
    Console.WriteLine("Shape areas: ");
    foreach (Shape item in list)
    {
        Console.WriteLine(item.Area().ToString("F2"));
    }