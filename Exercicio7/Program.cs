using Exercicio7;
using System;

namespace ControleEmpregados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do empregado:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Tipo de empregado:");
            Console.WriteLine("1 - Assalariado");
            Console.WriteLine("2 - Comissionado");
            Console.WriteLine("3 - Horista");
            Console.Write("Digite o número correspondente ao tipo de empregado: ");
            int tipoEmpregado = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Empregado empregado = null;

            switch (tipoEmpregado)
            {
                case 1:
                    empregado = new Assalariado(nome, sobrenome, cpf, salario);
                    break;
                case 2:
                    Console.Write("Total de vendas: ");
                    double totalVendas = double.Parse(Console.ReadLine());

                    Console.Write("Porcentagem de comissão: ");
                    double porcentagemComissao = double.Parse(Console.ReadLine());

                    empregado = new Comissionado(nome, sobrenome, cpf, salario, totalVendas, porcentagemComissao);
                    break;
                case 3:
                    Console.Write("Preço da hora: ");
                    double precoHora = double.Parse(Console.ReadLine());

                    Console.Write("Total de horas trabalhadas: ");
                    int totalHoras = int.Parse(Console.ReadLine());

                    empregado = new Horista(nome, sobrenome, cpf, salario, precoHora, totalHoras);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (empregado != null)
            {
                Console.WriteLine($"O salário do empregado {empregado.Nome} {empregado.Sobrenome} é: {empregado.CalcularVencimento()}");
            }

            Console.ReadKey();
        }
    }

    

    

    

    
}
