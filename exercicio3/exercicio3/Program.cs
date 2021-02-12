using System;
using System.Globalization;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = {0}", retangulo.CalculaArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = {0}", retangulo.CalculaPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = {0}", retangulo.CalculaDiagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
