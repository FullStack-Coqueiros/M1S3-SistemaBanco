
using M1S3_SistemaBanco;

Cliente CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereco do cliente:");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Data de Nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero Da Conta");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    return cliente;
}


string opcao;
do{
  Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opação");
  Console.WriteLine("1 - Criar Conta ");
  Console.WriteLine("2 - Adicionar Transacao");
  Console.WriteLine("3 - Consultar Extrato");
  Console.WriteLine("4 - Sair");
  opcao = Console.ReadLine();

  if(opcao == "1"){
    Cliente novoCliente =  CriarConta();
  }
} while(opcao != "3");

