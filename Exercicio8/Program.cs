using Exercicio8;

     Controle controle = new Controle();

  controle.adicionarFuncionario("Leo", 30);
  controle.adicionarDependente(0, "Lucas", 5);
  controle.adicionarDependente(0, "Bruna", 3);

  controle.adicionarFuncionario("Julia", 25);
  controle.adicionarDependente(1, "Juliana", 2);


  controle.listarDependentes(0);
  controle.listarDependentes(1);
    


