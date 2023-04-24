namespace Exercicio8
{ 


class Controle
{
    private List<Funcionario> funcionarios;

    public Controle()
    {
        this.funcionarios = new List<Funcionario>();
    }

    public void adicionarFuncionario(string nome, int idade)
    {
        Funcionario funcionario = new Funcionario(nome, idade);
        this.funcionarios.Add(funcionario);
    }

    public void adicionarDependente(int indiceFuncionario, string nome, int idade)
    {
        this.funcionarios[indiceFuncionario].adicionarDependente(nome, idade);
    }

    public void listarDependentes(int indiceFuncionario)
    {
        Console.WriteLine("Dependentes do funcionário " + this.funcionarios[indiceFuncionario].nome + ":");
        this.funcionarios[indiceFuncionario].listarDependentes();
    }
}
}