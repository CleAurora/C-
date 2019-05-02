using System;
using System.Collections.Generic;
using ex37Kanban.ViewModel;

namespace ex37Kanban.Repositorio
{
    public class TarefaRepositorio
    {
        public static List<TarefaViewModel> listaDeTarefas = new List<ViewModel.TarefaViewModel>();
        public TarefaViewModel InserirTarefa(TarefaViewModel tarefa){
            tarefa.Id = listaDeTarefas.Count + 1;
            tarefa.DataCriacao = DateTime.Now;

            listaDeTarefas.Add(tarefa);
            return tarefa;
        }


        public static List<TarefaViewModel> ListarPorTipo(){
            return listaDeTarefas;
        }

        

    }
}