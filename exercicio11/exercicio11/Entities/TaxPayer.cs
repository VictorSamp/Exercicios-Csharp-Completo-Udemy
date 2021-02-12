using System.Globalization;
using System.Text;

namespace exercicio11.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            return stringBuilder.ToString();
        }
    }
}
