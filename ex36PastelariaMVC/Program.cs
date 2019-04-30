using System;
using ex36PastelariaMVC.Utils;
using ex36PastelariaMVC.ViewController;
using ex36PastelariaMVC.ViewModel;

namespace ex36PastelariaMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
           do{
               //Menu Deslogado
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado){
                    case 1:
                        //Cadastrar Usuário
                        UsuarioViewController.CadastrarUsuario();
                    break;

                    case 2:
                        // Efetuar Login
                        UsuarioViewModel usuarioRetornado = UsuarioViewController.EfetuarLogin();
                        if(usuarioRetornado != null){
                            System.Console.WriteLine($"Bem vindo {usuarioRetornado.Nome}");

                            do{   
                                MenuUtil.MenuLogado();

                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch(opcaoLogado){
                                    case 1:
                                        ProdutoViewControler.CadastrarProduto();
                                    break;

                                    case 2:
                                        ProdutoViewControler.ListarProdutos();
                                    break;

                                    case 3:
                                        ProdutoViewControler.BuscarProdutoPorId();
                                    break;

                                    case 0:
                                        //sair
                                        System.Console.WriteLine("Você pediu para deslogar");
                                    break;

                                    default:
                                        System.Console.WriteLine("Opção Inválida");
                                    break;
                                }

                            }while(opcaoLogado != 0);
                         
                            


                        }
                    break;

                    case 3:
                        //Listar usuários Cadastrados
                        UsuarioViewController.ListarUsuario();
                        
                    break;

                    case 0:
                        //Sair
                        System.Console.WriteLine("Você pediu para sair!");
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break;
                }
           }while(opcaoDeslogado != 0);
        }
    }
}
