namespace Exercicio8
{ 
class Funcionario
{
    public string nome { get; set; }
    public int idade { get; set; }
    public List<Dependente> dependentes { get; set; }

    public Funcionario(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
        this.dependentes = new List<Dependente>();
    }

    public void adicionarDependente(string nome, int idade)
    {
        Dependente dependente = new Dependente(nome, idade);
        this.dependentes.Add(dependente);
    }

    public void listarDependentes()
    {
        foreach (Dependente dependente in this.dependentes)
        {
            Console.WriteLine(dependente.nome + " - " + dependente.idade + " anos");
        }
    }
}
}
