using exercicio10.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int productsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= productsQuantity; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported? (c/u/i): ");
                char productType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productType == 'c')
                {
                    productsList.Add(new Product(name, price));
                }
                else if (productType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    productsList.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productsList.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");

            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
