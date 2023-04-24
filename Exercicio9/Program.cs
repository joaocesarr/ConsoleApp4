using Exercicio9;
using System.ComponentModel.Design;

class Program
{
    static Biblioteca biblioteca = new Biblioteca();

    public static IEnumerable<Livro> ListaDeLivros { get; private set; }

    static void Main(string[] args)
    {
        MostrarMenu();
    }
    static void MostrarMenu()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Remover Livro");
            Console.WriteLine("3 - Listar Livros");
            Console.WriteLine("4 - Listar Livros em Ordem Alfabética");
            Console.WriteLine("5 - Listar Livros por Idioma");
            Console.WriteLine("6 - Listar Autores com Livros em Outro Idioma");
            Console.WriteLine("7 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarLivro();
                    Console.Clear();
                    break;

                case 2:
                    RemoverLivro();
                    break;

                case 3:
                    ListarLivros();
                    break;

                case 4:
                    ListarLivrosOrdemAlfabetica();
                    break;

                case 5:
                    ListarLivroPorIdioma();
                    break;

                case 6:
                    ListarAutorLivroOutroIdioma();
                    break;
                case 7:
                    Console.WriteLine("Saindo do programa...");
                    break;


                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

    }

    private static void ListarAutorLivroOutroIdioma()
    {
        throw new NotImplementedException();
    }

    static void AdicionarLivro()
    {
        Console.WriteLine("Digite o ISBN do livro:");
        string isbn = Console.ReadLine();

        Console.WriteLine("Digite o nome do livro:");
        string nomelivro = Console.ReadLine();

        Console.WriteLine("Digite o idioma do livro:");
        string idioma = Console.ReadLine();

        Console.WriteLine("Digite o número da edição do livro:");
        int edicao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a data de lançamento do livro (no formato DD/MM/AAAA):");
        DateTime datalancamento = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do autor do livro:");
        string nomeautor = Console.ReadLine();

        Console.WriteLine("Digite o país de origem do autor do livro:");
        string paisorigemautor = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento do autor do livro (no formato DD/MM/AAAA):");
        DateTime datanascimentoautor = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o idioma nativo do autor do livro:");
        string idiomaautor = Console.ReadLine();

        Autor autor = new Autor(nomeautor, paisorigemautor, datanascimentoautor, idiomaautor);
        Livro livro = new Livro(isbn, nomelivro, autor, idioma, edicao, datalancamento);

        biblioteca.AdicionarLivro(livro);

        Console.WriteLine("Livro adicionado com sucesso!");
    }

    static void RemoverLivro()
    {
        Console.WriteLine("Digite o ISBN do livro que deseja remover:");
        string isbn = Console.ReadLine();

        biblioteca.RemoverLivro(isbn);

        Console.WriteLine("Livro removido com sucesso!");
    }

    static void ListarLivros()
    {
        biblioteca.ListarLivros();
    }

    static void ListarLivrosOrdemAlfabetica()
    {
        biblioteca.ListarLivrosOrdemAlfabetica();
    }

    static void ListarLivroPorIdioma()
    {
        Console.WriteLine("Digite o idioma para filtrar os livros:");
        string idioma = Console.ReadLine();

        List<Livro> livrosFiltrados = biblioteca.ListaDeLivros.FindAll(l => l.Idioma == idioma);
        if (livrosFiltrados.Count > 0)
        {
            Console.WriteLine($"Lista de Livros em {idioma}:");
            foreach (Livro livro in livrosFiltrados)
            {
                Console.WriteLine($"ISBN: {livro.ISBN}, Título: {livro.NomeLivro}, Autor: {livro.Autor.Nome}, Edição: {livro.Edicao}, Data de Lançamento: {livro.DataLancamento}");
            }
        }
        else
        {
            Console.WriteLine($"Não foram encontrados livros em {idioma}.");
        }

        void ListarAutorLivroOutroIdioma()
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
                    Console.WriteLine($"Autor: {autor.Key}, Livros em idiomas diferentes: {autor.Value}");
                }
            }
            else
            {
                Console.WriteLine("Não há autores com livros em idiomas diferentes do idioma nativo.");
            }
        }

        Console.WriteLine();
        MostrarMenu();
    }
}