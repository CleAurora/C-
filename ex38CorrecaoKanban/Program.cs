using System;
using ex38CorrecaoKanban.Utils;
using ex38CorrecaoKanban.ViewController;

namespace ex38CorrecaoKanban
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
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