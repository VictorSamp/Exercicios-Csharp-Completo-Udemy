using System.Globalization;

namespace exercicio6
{
    class Conta
    {
        // Propriedades Auto Implementadas
        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double Saldo { get; private set; }

        // Construtores
        public Conta(int numeroDaConta, string nomeDoTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
        }

        public Conta(int numeroDaConta, string nomeDoTitular, double saldo) : this(numeroDaConta, nomeDoTitular)
        {
            FazDeposito(saldo);
        }

        // Outros Métodos da Classe
        public override string ToString()
        {
            return "Conta: " + NumeroDaConta
                + ", Titular: " + NomeDoTitular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void FazDeposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void FazSaque(double valorSaque)
        {
            Saldo -= (valorSaque + 5.00);
        }
    }
}
