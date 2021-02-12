using System;
using System.Globalization;

namespace exercicio3
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculaArea()
        {
            return Largura * Altura;
        }

        public double CalculaPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalculaDiagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
