namespace ex40pqnaorodaaqui.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            System.Console.WriteLine("==================================");
            System.Console.WriteLine("   Escolha uma opção              ");
            System.Console.WriteLine("   (1) Cadastrar Novo Usuário     ");
            System.Console.WriteLine("   (2) Efetuar Login              ");
            System.Console.WriteLine("   (3) Listar                     ");
            System.Console.WriteLine("   (0) Sair                       ");
            System.Console.WriteLine("==================================");
        }// fim menu deslogado

        public static void MenuLogado(){
            System.Console.WriteLine("==================================");
            System.Console.WriteLine("   Escolha uma opção              ");
            System.Console.WriteLine("   (1) Cadastrar Transação        ");
            System.Console.WriteLine("   (2) Extrato de Transações      ");
            System.Console.WriteLine("   (3) Gerar arquivo zip          ");
            System.Console.WriteLine("   (0) Sair                       ");
            System.Console.WriteLine("==================================");

        }// fim menu logado

        public static void TipoTransacao(){
            System.Console.WriteLine("==================================");
            System.Console.WriteLine("   Escolha o tipo de Transação    ");
            System.Console.WriteLine("   (1) Despesa                    ");
            System.Console.WriteLine("   (2) Receita                    ");
            System.Console.WriteLine("==================================");

        }// fim menu Tipo Transação
    }
}