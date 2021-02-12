using System;
using System.Globalization;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            double salarioLiquido;

            funcionario.Nome = Console.ReadLine();
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioLiquido = funcionario.SalarioLiquido();

            Console.WriteLine();

            Console.WriteLine("Funcionário: {0}, $ {1}", funcionario.Nome, salarioLiquido.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário:");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            funcionario.SalarioLiquido();

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: {0}, $ {1}", funcionario.Nome, funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
