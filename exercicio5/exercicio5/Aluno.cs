using System;
using System.Collections.Generic;

namespace exercicio5
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }

            return false;
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }

            return 60.0 - NotaFinal();
        }
    }
}
