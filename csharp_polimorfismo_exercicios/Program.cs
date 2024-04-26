using csharp_polimorfismo_exercicios.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported? (c/u/i): ");
    char r = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    switch (r)
    {
        case 'u':
            Console.Write("Manufacture date (DD/MM/YYYY): ");
            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
            products.Add(new UsedProduct(name, price, manufactureDate));
            break;
        case 'i':
            Console.Write("Custom fee: ");
            double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            products.Add(new ImportedProduct(name, price, customsFee));
            break;
        default:
            products.Add(new Product(name, price));
            break;
    }
}

foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}