using System;
using ex40pqnaorodaaqui.Repositorio;
using ex40pqnaorodaaqui.Utils;
using ex40pqnaorodaaqui.ViewController;
using ex40pqnaorodaaqui.ViewModel;
using Ionic.Zip;

namespace ex39apptransacao {
    class Program {
        static void Main (string[] args) {
            //Criação de um app para controle de finanças com cadastro de Usuarios (nome, email, senha, data de nascimento), Login de Usuários (e-mail e senha), Cadastro de Transações (Tipo de transação, descrição, data da transação, valor), extrato de transação Total e banco de dados - pelo menos. Se der, relatório em World e exportação de banco de dados.

            int opcaoDeslogado = 0;
            int opcaoLogado = 0;

            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastrar Novo Usuário
                        UsuarioViewController.CadastrarUsuario ();

                        break;

                    case 2:
                        //Efetuar Login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            System.Console.WriteLine ($"Bem vindo {usuarioRecuperado.Nome}");

                            do {
                                MenuUtil.MenuLogado ();
                                opcaoLogado = int.Parse (Console.ReadLine ());

                                switch (opcaoLogado) {
                                    case 1:
                                        //Cadastro de Transações
                                        TransacaoViewController.CadastrarTransacao(usuarioRecuperado);
                                    break;

                                    case 2:
                                        //Extrato das Transações
                                        TransacaoViewController.Listar(usuarioRecuperado);
                                    break;

                                    case 3:
                                        //Criar os arquivos  csv tipo zip
                                        var transacaoRepositorio = new TransacaoRepositorio();
                                        transacaoRepositorio.CriarZip();
                                    break;

                                    case 0:
                                        //Sair
                                        System.Console.WriteLine ("Você pediu para sair");
                                    break;

                                    default:
                                        System.Console.WriteLine ("Opção Inválida");
                                    break;
                                }

                            } while (opcaoLogado != 0);
                        }

                    break;

                    case 3:
                        //Listar Usuarios
                        UsuarioViewController.ListarUsuario();
                    break;

                    case 0:
                        //sair
                        System.Console.WriteLine ("Você pediu para sair");
                    break;

                    default:
                        System.Console.WriteLine ("Opção inválida");
                    break;

                }

            } while (opcaoDeslogado != 0);

        } //fim static void Main
    } // fim class program
} // fim name space