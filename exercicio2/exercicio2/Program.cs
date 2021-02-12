using System;
using System.Globalization;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;
            double media;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            funcionario1.Nome = Console.ReadLine();
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario2.Nome = Console.ReadLine();
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine($"Nome: {funcionario1.Nome}");
            Console.WriteLine($"Salario: {funcionario1.Salario}");

            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine($"Nome: {funcionario2.Nome}");
            Console.WriteLine($"Salario: {funcionario2.Salario}");

            Console.WriteLine("Salario médio: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
