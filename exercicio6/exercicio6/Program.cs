using System;
using System.Globalization;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDaConta;
            string titularDaConta;
            double saldo;
            char escolhaUsuario;
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            titularDaConta = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            escolhaUsuario = char.Parse(Console.ReadLine());

            if (escolhaUsuario == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroDaConta, titularDaConta, saldo);
            }
            else
            {
                conta = new Conta(numeroDaConta, titularDaConta);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            conta.FazDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            conta.FazSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
