using ex39apptransacao.Repositorio;
using ex39apptransacao.Utils;
using ex39apptransacao.ViewModel;

namespace ex39apptransacao.ViewController
{
    public class transacaoViewController
    {

        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();
        // Cadastrar transação

        public static void CadastrarTransacao(UsuarioViewModel usuario){
            string tipo, descricao;
            float valor;
            int opcaoTipo;


            MenuUtil.TipoTransacao();
            opcaoTipo = int.Parse(Console.ReadLine());

            switch (opcaoTipo)
            {
                case 1:
                    //Despesa
                    tipo = "Despesa";

                    System.Console.WriteLine("Descreva sua transação");
                    descricao = Console.ReadLine();

                    System.Console.WriteLine("Digite o valor da despesa:");
                    valor = float.Parse(Console.ReadLine();
                    ) * (-1);

                break;

                case 2:
                    //Receita
                    tipo = "Receita";

                    System.Console.WriteLine("Descreva sua transação");
                    descricao = Console.ReadLine();

                    System.Console.WriteLine("Digite o valor da receita:");
                    valor = float.Parse(Console.ReadLine();
                    );
                break;
                
                default:
                    System.Console.WriteLine("Opção Inválida");
                break;
            }

            TransacaoViewModel transacao = new TransacaoViewModel();

            transacao.Tipo = tipo;
            transacao.Descicao = descricao;
            transacao.Valor = valor;

            
            

            System.Console.WriteLine("Transação efetuada com sucesso");


        }
    }
}