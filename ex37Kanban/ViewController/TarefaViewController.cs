using System;
using ex37Kanban.Repositorio;
using ex37Kanban.Utils;
using ex37Kanban.ViewModel;

namespace ex37Kanban.ViewController
{
    public class TarefaViewController
    {
        //Instanciar um repositorio:
        static TarefaRepositorio tarefaRepositorio = new TarefaRepositorio();

        public static void CadstrarTarefa(){
            string nome, /*tipo,*/ descricao /*idUsuario*/;

            MenuUtil.MenuTipoTarefa();
            int opcaoTarefa = int.Parse(Console.ReadLine());
            

            do{
                System.Console.WriteLine("Digite o nome da tarefa");
                nome = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }
            }while(string.IsNullOrEmpty(nome));

            System.Console.WriteLine("Descreva a sua tarefa");
            descricao = Console.ReadLine();

            TarefaViewModel tarefaViewModel = new TarefaViewModel();
            tarefaViewModel.Nome = nome;
            tarefaViewModel.Descricao = descricao;

            System.Console.WriteLine("Tarefa Cadastrada com Sucesso");

        }// Fim Cadastrar Tarefas


    }
}