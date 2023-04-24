using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    abstract class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Empregado(string nome, string sobrenome, string cpf, double salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
            Salario = salario;
        }

        public abstract double CalcularVencimento();
    }
}
