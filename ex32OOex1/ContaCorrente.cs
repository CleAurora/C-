namespace ex32OOex1
{
    public class ContaCorrente
    {
        public string titular;

        public int agencia;

        public int numeroConta;

        private double saldo {get; set;} //get = pegar, set = inserir, configurar, private pra gravar - não tenho mais acesso a esse atributo saldo. Só posso acessar a través de um atributo que tenha a mesma classe - no caso depositar e sacar. - vc não acessa diretamente um atributo, precisa de metodos para isso - saque e deposito

        //métodos - caminhos lógicos para que eu possa acessar meus atributos. Sempre em maiúsculo, com parenteses abrindo e fechando
        public void Depositar(double valor){
            saldo += valor;
        }

        public bool Sacar(double valor){ //mesmo tipo do saldo: double e chamei de valor
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                return true;
            }

        }//fim sacar

        public double ExibirSaldo(){
            return saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino){
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }

        }
    }
}