namespace ex37Kanban.Utils
{
    public class MenuUtil
    {
        public static void/* int*/ MenuDeslogado(){

            System.Console.WriteLine("===================================");
            System.Console.WriteLine("===========Kanban Senai============");
            System.Console.WriteLine("          Escolha uma opção        ");
            System.Console.WriteLine("       1. Cadastrar Usuário        ");
            System.Console.WriteLine("       2. Efetuar Login            ");
            System.Console.WriteLine("       0. Sair                     ");
            System.Console.WriteLine("===================================");

            //int opcaoDesejada = Console.ReadLine();
            
        }

        public static void MenuLogado(){

            System.Console.WriteLine("===================================");
            System.Console.WriteLine("==========Kanban Usuário===========");
            System.Console.WriteLine("          Escolha uma opção        ");
            System.Console.WriteLine("       1. Cadastrar Tarefa         ");
            System.Console.WriteLine("       2. Listar Tarefas           ");
            System.Console.WriteLine("       3. Listar Usuários          ");
            System.Console.WriteLine("       0. Sair                     ");
            System.Console.WriteLine("===================================");
        }

        public static void MenuTipoUsuario(){
            System.Console.WriteLine("===================================");
            System.Console.WriteLine("===========Kanban Senai============");
            System.Console.WriteLine("          Escolha uma opção        ");
            System.Console.WriteLine("       1. Usuário                  ");
            System.Console.WriteLine("       2. Administrador            ");
            System.Console.WriteLine("                                   ");
            System.Console.WriteLine("===================================");
        }

           public static void MenuTipoTarefa(){
            System.Console.WriteLine("===================================");
            System.Console.WriteLine("==========Kanban Tarefa============");
            System.Console.WriteLine("          Escolha uma opção        ");
            System.Console.WriteLine("       1. A Fazer                  ");
            System.Console.WriteLine("       2. Fazendo                  ");
            System.Console.WriteLine("       3. Feito                    ");
            System.Console.WriteLine("                                   ");
            System.Console.WriteLine("===================================");
        }
    }
}