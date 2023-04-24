using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Impressora
    {
        private Documento doc;

        public Impressora(Documento documento)
        {
            doc = documento;
        }

        public void Imprimir(int qtdCopias = 1)
        {
            for (int i = 0; i < qtdCopias; i++)
            {
                Console.WriteLine(doc.Conteudo);
            }
        }
    }
}
