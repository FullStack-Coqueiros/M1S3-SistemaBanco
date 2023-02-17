
namespace M1S3_SistemaBanco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo {  get {return GetSaldo(); }  private set{} }

        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} }
        
        public List<Transacao> Extrato { get; set; }

        public Cliente()
        {
            Extrato = new List<Transacao>();
        }
        public Cliente(string nome, string cpf, string email, string telefone, 
                       string end, DateTime dtNascimento,int numeroConta ) :this()
        {
            Nome = nome;
            CPF = cpf;
            Email=email;
            Telefone =telefone; 
            Endereco = end;
            DataNascimento = dtNascimento;
            NumeroConta = numeroConta;
            
        }


        public string ResumoCliente(){
           return  $"{NumeroConta} |  {Nome}  | {CPF}";
        }

        public bool EhMaior(){
            return Idade >= 18;
        }

        private double GetSaldo(){
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
    }
}