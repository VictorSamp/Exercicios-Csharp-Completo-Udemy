namespace exercicio7
{
    class Quarto
    {
        public int NumeroDoQuarto { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Quarto(string nome, string email, int numeroDoQuarto)
        {
            Nome = nome;
            Email = email;
            NumeroDoQuarto = numeroDoQuarto;
        }

        public override string ToString()
        {
            return $"{NumeroDoQuarto}: {Nome}, {Email}";
        }
    }
}
