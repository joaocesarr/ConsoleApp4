using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Comissionado : Empregado
    {
        public double TotalVendas { get; set; }
        public double PorcentagemComissao { get; set; }

        public Comissionado(string nome, string sobrenome, string cpf, double salario, double totalVendas, double porcentagemComissao) :

    base(nome, sobrenome, cpf, salario)
        {
            TotalVendas = totalVendas;
            PorcentagemComissao = porcentagemComissao;
        }

        public override double CalcularVencimento()
        {
            return Salario + (TotalVendas * (PorcentagemComissao / 100));
        }
    }
}
