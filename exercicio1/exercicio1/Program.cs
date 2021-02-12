using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;
            string maisVelho;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            pessoa1.Nome = Console.ReadLine();
            pessoa1.Idade = int.Parse(Console.ReadLine());

            pessoa2.Nome = Console.ReadLine();
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                maisVelho = pessoa1.Nome;
            } else
            {
                maisVelho = pessoa2.Nome;
            }

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {pessoa1.Nome}");
            Console.WriteLine($"Idade: {pessoa1.Idade}");

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine($"Nome: {pessoa2.Nome}");
            Console.WriteLine($"Idade: {pessoa2.Idade}");

            Console.WriteLine($"Pessoa mais velha: {maisVelho}");
        }
    }
}
