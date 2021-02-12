using System.Text;
using System.Globalization;

namespace exercicio9.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"{Product.Name}, " +
                                $"${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                                $"Quantity: {Quantity}, " +
                                $"SubTotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");

            return stringBuilder.ToString();
        }
    }
}
