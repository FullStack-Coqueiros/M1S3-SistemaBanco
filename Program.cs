
using M1S3_SistemaBanco;

List<Cliente> clientes = new List<Cliente>();

clientes.Add(new Cliente("Vitor", "123456", "vitor@email","123", "rua",
            new DateTime(2002, 5, 15), 1));
            
clientes.Add(new Cliente("Fernando", "123456", "Fernando@email","123", "rua",
            new DateTime(2002, 5, 15), 2));
            
clientes.Add(new Cliente("Vanessa", "123456", "Vanessa@email","123", "rua",
            new DateTime(2002, 5, 15), 3));

clientes.Add(new Cliente("Lucas", "123456", "Lucas@email","123", "rua",
            new DateTime(2002, 5, 15), 4));



string opcao;
do{
  Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
  Console.WriteLine("1 - Criar Conta ");
  Console.WriteLine("2 - Adicionar Transacao");
  Console.WriteLine("3 - Consultar Extrato");
  Console.WriteLine("4 - Sair");
  Console.WriteLine("5 - Exibir Clientes");
  opcao = Console.ReadLine();

  if(opcao == "1"){
    CriarConta();
  }
  else if (opcao == "5"){
    ExibirClientes();
  }
  else if (opcao == "2"){
    AdicionarTransacao();
  }

  Console.WriteLine("Tecle Enter para continuar");
  Console.ReadLine();
} while(opcao != "4");




void AdicionarTransacao(){
  Console.WriteLine("Qual a conta?");
  int numeroConta = int.Parse(Console.ReadLine());

  Cliente contaCliente = null;
  foreach(var cliente in clientes){
    if(cliente.NumeroConta == numeroConta){
      contaCliente = cliente;
      break ;
    }
  }
  // mesma coisa que o foreach
  // for(int i =0; i < clientes.Count; i++){
  //    if(clientes[i].NumeroConta == numeroConta);
  //     contaCliente = clientes[i];
  // }
  if (contaCliente == null){
    Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
    return;
  }

  Console.WriteLine("Qual o valor da transação?" );
  double valor = double.Parse(Console.ReadLine());
  Transacao transacao = new Transacao();
  transacao.Data = DateTime.Now;
  transacao.Valor = valor;

  contaCliente.Extrato.Add(transacao);

}

void ExibirClientes(){
   Console.WriteLine("Número da conta        | Nome         | CPF    ");
  for(int i =0; i < clientes.Count; i++){
    Console.WriteLine(clientes[i].ResumoCliente());
  }
}

void CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Data de Nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    if(!cliente.EhMaior()){
      Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
      return ;
    }
    Console.WriteLine("A idade do cliente é " + cliente.Idade);
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereco do cliente:");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero Da Conta");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);
}