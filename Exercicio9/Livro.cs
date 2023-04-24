using Exercicio9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    public class Livro
    {
        public string ISBN { get; set; }
        public string NomeLivro { get; set; }
        public Autor Autor { get; set; }
        public string Idioma { get; set; }
        public int Edicao { get; set; }
        public DateTime DataLancamento { get; set; }

        public Livro(string isbn, string nomelivro, Autor autor, string idioma, int edicao, DateTime datalancamento)
        {
            ISBN = isbn;
            NomeLivro = nomelivro;
            Autor = autor;
            Idioma = idioma;
            Edicao = edicao;
            DataLancamento = datalancamento;
        }


    }
}