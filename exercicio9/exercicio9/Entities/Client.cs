using System;
using System.Text;

namespace exercicio9.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Client: {Name} {BirthDate.ToString("dd/MM/yyyy")} - {Email}");

            return stringBuilder.ToString();
        }
    }
}
