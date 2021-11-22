// See https://aka.ms/new-console-template for more information

using _133Exercicio.entities;

List<Product> products = new();

Console.Write("Enter the number of products: ");
int n1 = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= n1 ; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.WriteLine("Common, used or imported (c/u/i)? ");
    char c1 = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (c1 == 'i')
    {
        Console.Write("Customsfee:");
        double customsFee = double.Parse(Console.ReadLine());
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else if (c1 == 'u')
    {
        Console.Write("Manufactured date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, date));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}

Console.WriteLine("Price tags: ");
foreach (Product prod in products)
{
    Console.WriteLine(prod.PriceTag());
}


