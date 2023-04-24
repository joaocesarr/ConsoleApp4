using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Horista : Empregado
    {
        public double PrecoHora { get; set; }
        public int TotalHoras { get; set; }

        public Horista(string nome, string sobrenome, string cpf, double salario, double precoHora, int totalHoras) : base(nome, sobrenome, cpf, salario)
        {
            PrecoHora = precoHora;
            TotalHoras = totalHoras;
        }

        public override double CalcularVencimento()
        {
            return PrecoHora * TotalHoras;
        }
    }
}
