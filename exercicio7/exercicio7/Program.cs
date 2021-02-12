using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeQuartosAlugados;
            Quarto[] vetorQuartos;
            Quarto quarto;


            Console.Write("How many rooms will be rented? ");
            quantidadeDeQuartosAlugados = int.Parse(Console.ReadLine());

            vetorQuartos = new Quarto[10];

            for (int i = 1; i <= quantidadeDeQuartosAlugados; i++)
            {
                string nome, email;
                int numeroDoQuarto;

                Console.WriteLine($"Rent #{i}: ");
                Console.Write("Name: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Room: ");
                numeroDoQuarto = int.Parse(Console.ReadLine());

                quarto = new Quarto(nome, email, numeroDoQuarto);

                vetorQuartos[quarto.NumeroDoQuarto] = quarto;
            }

            Console.WriteLine("Busy rooms:");

            for (int j = 0; j < vetorQuartos.Length; j++)
            {
                if (vetorQuartos[j] != null)
                {
                    Console.WriteLine(vetorQuartos[j]);
                }
            }
        }
    }
}
