using System;
using ex37extra.Enums;
using ex37extra.ViewModel;

namespace ex37extra
{
    class Program
    {
        static void Main(string[] args)
        {
            //sistema para cadastro de tarefas com permissão de acesso:
            //Model Usuario - Id, Nome, Email, Senha, Tipo (usuário/admin), dataCriacao
            //Model Tarefas - Id, NOme, Descrição tipo (para fazer, Fazendo, Feito), IdUsuário, Data Criação 

            int limiteUsuarios = 3;
            int limiteTarefas = 10;
            bool sair = false;

            UsuarioViewModel [] usuarios = new UsuarioViewModel [limiteUsuarios];
            TarefaViewModel [] tarefas = new TarefaViewModel[limiteTarefas];

            int usuariosCadastrados = 0;
            int tarefasCadastradas = 0;

            do{
                #region MENU
                Console.Clear ();
                //HEADER

                string[] itensMenu = Enum.GetNames (typeof(MenuUsuario));
                string barraMenu = "===================";
                System.Console.WriteLine("");


            }while(!sair);
        }
    }
}
