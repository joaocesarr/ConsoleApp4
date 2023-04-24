using System;
using Exercicio6;

namespace ControleImpressao
{
    class Program
    {
        static void Main(string[] args)
        {

            Documento doc = new Documento();


            Console.WriteLine("Digite o texto a ser impresso:");
            string texto = Console.ReadLine();


            doc.Conteudo = texto;


            Impressora imp = new Impressora(doc);


            Console.WriteLine("Digite a quantidade de cópias:");
            int qtdCopias = int.Parse(Console.ReadLine());


            imp.Imprimir(qtdCopias);

            Console.ReadKey();
        }
    }

    

    
}
