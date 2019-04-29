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
                            MenuUtil.MenuLogado();
                        }
                    break;

                    case 3:
                        //Listar usuários Cadastrados
                        UsuarioViewController.ListarUsuario();
                        
                    break;

                    case 0:
                        //Sair
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break;
                }
           }while(opcaoDeslogado != 0);
        }
    }
}
