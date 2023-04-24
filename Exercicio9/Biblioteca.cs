using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    public class Biblioteca
    {
        public List<Livro> ListaDeLivros { get; set; } = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            ListaDeLivros.Add(livro);
        }

        public void RemoverLivro(string ISBN)
        {
            Livro livro = ListaDeLivros.Find(l => l.ISBN == ISBN);
            if (livro != null)
            {
                ListaDeLivros.Remove(livro);
                Console.WriteLine("Livro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Não foi possível remover o livro, ISBN inválido.");
            }
        }

        public void ListarLivros()
        {
            if (ListaDeLivros.Count > 0)
            {
                Console.WriteLine("Lista de Livros:");
                foreach (Livro livro in ListaDeLivros)
                {
                    Console.WriteLine($"{livro.NomeLivro} - {livro.Autor.Nome}");
                }
            }
            else
            {
                Console.WriteLine("Não há livros na biblioteca.");
            }
        }

        public void ListarLivrosOrdemAlfabetica()
        {
            List<Livro> livrosOrdenados = ListaDeLivros;
            livrosOrdenados.Sort((l1, l2) => l1.NomeLivro.CompareTo(l2.NomeLivro));
            if (livrosOrdenados.Count > 0)
            {
                Console.WriteLine("Lista de Livros em Ordem Alfabética:");
                foreach (Livro livro in livrosOrdenados)
                {
                    Console.WriteLine($"{livro.NomeLivro} - {livro.Autor.Nome}");
                }
            }
            else
            {
                Console.WriteLine("Não há livros na biblioteca.");
            }
        }

        public void ListarLivroPorIdioma(string idioma)
        {
            List<Livro> livrosFiltrados = ListaDeLivros.FindAll(l => l.Idioma == idioma);
            if (livrosFiltrados.Count > 0)
            {
                Console.WriteLine($"Lista de Livros em {idioma}:");
                foreach (Livro livro in livrosFiltrados)
                {
                    Console.WriteLine($"{livro.NomeLivro} - {livro.Autor.Nome} ({livro.Autor.IdiomaNativo})");
                }
            }
            else
            {
                Console.WriteLine($"Não há livros em {idioma} na biblioteca.");
            }
        }
        public void ListarAutorLivroOutroIdioma()
        {
            Dictionary<string, int> autoresLivrosOutrosIdiomas = new Dictionary<string, int>();
            foreach (Livro livro in ListaDeLivros)
            {
                if (livro.Autor.IdiomaNativo != livro.Idioma)
                {
                    if (autoresLivrosOutrosIdiomas.ContainsKey(livro.Autor.Nome))
                    {
                        autoresLivrosOutrosIdiomas[livro.Autor.Nome]++;
                    }
                    else
                    {
                        autoresLivrosOutrosIdiomas.Add(livro.Autor.Nome, 1);
                    }
                }
            }
            if (autoresLivrosOutrosIdiomas.Count > 0)
            {
                Console.WriteLine("Autores com livros em idiomas diferentes do idioma nativo:");
                foreach (KeyValuePair<string, int> autor in autoresLivrosOutrosIdiomas)
                {
                    Console.WriteLine($"Autor: {autor.Key}, Quantidade de livros em outros idiomas: {autor.Value}");
                }
            }
            else
            {
                Console.WriteLine("Não há autores com livros em idiomas diferentes do idioma nativo.");
            }
        }
    }

}