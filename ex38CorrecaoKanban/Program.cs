using System;
using ex38CorrecaoKanban.Utils;
using ex38CorrecaoKanban.ViewController;
using ex38CorrecaoKanban.ViewModel;

namespace ex38CorrecaoKanban
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            do{
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado){
                    case 1:
                        //Cadastrar novo Usuário
                        UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                        //Listar todos os Usuários
                        UsuarioViewController.ListarUsuario();
                    break;

                    case 3:
                        //Efetuar Login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                        if(usuarioRecuperado != null){
                            System.Console.WriteLine($"Bem vindo {usuarioRecuperado.Nome}");

                            do{
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado){
                                    case 1:
                                        //Cadastrar Produto
                                        ProdutoViewController.CadastrarProduto(usuarioRecuperado);
                                    break;

                                    case 2:
                                        //Listar Produtos
                                        ProdutoViewController.Listar();

                                    break;

                                    case 3:
                                        //Buscar por Id
                                    break;

                                    case 0:
                                        //sair
                                        System.Console.WriteLine("Você pediu para sair");
                                    break;
                                    
                                    default:
                                        System.Console.WriteLine("Opção Inválida");
                                    break;
                                }
                            }while(opcaoLogado !=0);
                        }


                    break;

                    case 0:
                        //Sair
                        System.Console.WriteLine("Volte sempre");
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break;
                }

            }while(opcaoDeslogado != 0);
        }//fim static void main

        
    }//fim class program
}//fim namespace