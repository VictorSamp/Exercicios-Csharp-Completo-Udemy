using exercicio9.Entities;
using exercicio9.Entities.Enums;
using System;
using System.Globalization;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email;
            DateTime birthDate;
            int itemsQuantity;

            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            itemsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemsQuantity; i++)
            {
                string productName;
                double productPrice;
                int quantity;

                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                productName = Console.ReadLine();
                Console.Write("Product Price: ");
                productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
