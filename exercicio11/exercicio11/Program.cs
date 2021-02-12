using exercicio11.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payersList = new List<TaxPayer>();

            Console.Write("Enter the number os tax payers: ");
            int payersQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= payersQuantity; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Induvidual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("");

                if (payerType == 'i')
                {
                    Console.Write("Heath expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payersList.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payersList.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double totalTaxes = 0.0;

            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in payersList)
            {
                Console.WriteLine(payer);
                totalTaxes += payer.Tax();
            }

            Console.WriteLine();

            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
