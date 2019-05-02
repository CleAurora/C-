using System;
using ex37Kanban.Utils;
using ex37Kanban.ViewController;
using ex37Kanban.ViewModel;

namespace ex37Kanban {
    class Program {
        static void Main (string[] args) {
            //Programa com menu para cadastro, login e listar usuários. Uma vez logado, a pessoa pode cadastrar tarefas, lembrando o método Kanban

            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            //int opcaoDesejada = 0;
            UsuarioViewModel usuarioRetornado;
            UsuarioViewModel teste;
            do {
                //Menu Deslogado
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastrar
                        UsuarioViewController.CadastrarUsuario ();
                        break;

                    case 2:
                        //login
                        usuarioRetornado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRetornado != null) {
                            teste = usuarioRetornado;
                            System.Console.WriteLine ($"Bem vindo {usuarioRetornado.Nome}");

                            do {
                                MenuUtil.MenuLogado ();
                                opcaoLogado = int.Parse (Console.ReadLine ());

                                switch (opcaoLogado) {
                                    case 1:
                                        //Cadastrar Tarefa
                                        TarefaViewController.CadastrarTarefa (usuarioRetornado);
                                    break;

                                    case 2:
                                        //Listar Tarefas
                                        TarefaViewController.ListarTiposTarefas (usuarioRetornado);
                                    break;
                                    
                                    case 3:
                                        //Listar Usuários
                                        UsuarioViewController.ListarUsuario (usuarioRetornado);
                                    break;

                                    case 0:
                                        //sair
                                        System.Console.WriteLine ("Você pediu para sair");
                                        break;

                                    default:
                                        System.Console.WriteLine ("Opção Inválida");
                                        break;
                                }
                            } while (opcaoLogado != 0);

                        }
                        break;

                    case 0:
                        //Sair
                        System.Console.WriteLine ("Você pediu para sair");
                        break;

                    default:
                        System.Console.WriteLine ("Opção Inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);

        }
    }
}