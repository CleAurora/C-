using System;
using ex37Kanban.Repositorio;
using ex37Kanban.Utils;
using ex37Kanban.ViewModel;

namespace ex37Kanban.ViewController {
    public class TarefaViewController {
        //Instanciar um repositorio:
        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio ();
        static int opcaoDesejada = 0;

        public static int CadastrarTarefa (UsuarioViewModel us) {

            string nome, descricao, tipoSelecionado = "" /*idUsuario*/ ; //chamar listas a fazer, fazendo ou feito

            do {
                System.Console.WriteLine ("Digite o nome da tarefa");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            System.Console.WriteLine ("Descreva a sua tarefa");
            descricao = Console.ReadLine ();

            MenuUtil.MenuTipoTarefa ();
            opcaoDesejada = int.Parse (Console.ReadLine ());

            do{
                switch (opcaoDesejada) {
                    case 1:
                        tipoSelecionado = "A Fazer";
                        break;
                    case 2:
                        tipoSelecionado = "Fazendo";
                        break;
                    case 3:
                        tipoSelecionado = "Feito";
                        break;
                    default:
                        System.Console.WriteLine ("Opção Inválida");
                        break;
                }
            }while(opcaoDesejada>3 || opcaoDesejada<0);
                


           
            TarefaViewModel tarefaViewModel = new TarefaViewModel ();
            tarefaViewModel.Nome = nome;
            tarefaViewModel.Descricao = descricao;
            tarefaViewModel.Tipo = tipoSelecionado;
            tarefaViewModel.IdUsuario = us.Nome;

            tarefaRepositorio.InserirTarefa (tarefaViewModel);
            System.Console.WriteLine ("Tarefa Cadastrada com Sucesso");

            return opcaoDesejada;

        } // Fim Cadastrar Tarefas

        //Início Listar:
        public static void ListarTiposTarefas(UsuarioViewModel us){


            foreach (var item in TarefaRepositorio.ListarPorTipo()){
                if (us.Nome.Equals(item.IdUsuario)){
                      if( item.Tipo.Equals("A Fazer")){
                        System.Console.WriteLine($"A Fazer:{item.Nome}, Descrição:{item.Descricao}, DataDeCriação: {item.DataCriacao}");
                    }else if(item.Tipo.Equals("Fazendo")){
                        System.Console.WriteLine($"Fazendo: {item.Nome}, Descrição:{item.Descricao}, DataDeCriação: {item.DataCriacao}");
                    }else{
                        System.Console.WriteLine($"Feito: {item.Nome}, Descrição:{item.Descricao}, DataDeCriação: {item.DataCriacao}");
                }
                }
              
            }    
        }// Fim do Listar
    }
}