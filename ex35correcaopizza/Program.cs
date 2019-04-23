using System;

namespace ex35correcaopizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa de Criação de menu para cadastro de Usuários em uma pizzaria; listar usuários e efetuar login. Caso a pessoa consiga efetuar o login, haverá um novo menu com a opção de cadastrar produtos, listar produtos cadastrados e procurar o produto pelo ID.
            //Objetivo: uso de POO

            System.Console.WriteLine("Pizza");
            int resposta = 0;
            int respostaProduto = 0;
            do{
                Console.Clear();
                System.Console.WriteLine("Selecione");
                System.Console.WriteLine("1. Cadastrar Usuário:");
                System.Console.WriteLine("2. Efetuar login de Usuário");
                System.Console.WriteLine("3. Listar Usuários");
                Console.WriteLine("9. Sair");
                resposta = int.Parse(Console.ReadLine());
                

                switch (resposta){
                    case 1:
                        Usuario.Inserir();
                    break;

                    case 2:
                        Usuario.EfetuarLogin();

                        do{
                            Console.Clear();
                            System.Console.WriteLine("Selecione");
                            System.Console.WriteLine("1. Cadastrar produto");
                            System.Console.WriteLine("2. Listar Produtos Cadastrados");
                            System.Console.WriteLine("3. Buscar produto pelo ID");
                            System.Console.WriteLine("4. Sair");
                            respostaProduto = int.Parse(Console.ReadLine());
                            

                            switch(respostaProduto){
                                case 1:
                                    Produto.InserirProduto();
                                break;

                                case 2:
                                    Produto.ListarProduto();
                                break;

                                case 3:
                                    Produto.BuscaPorId();
                                break;

                                case 4:
                                    System.Console.WriteLine("Você pediu pra sair");
                                break;

                                default:
                                    System.Console.WriteLine("Opção Inválida");
                                break;
                            }
                        }while( respostaProduto!= 4);


                        

                    
                    break;

                    case 3:
                        Usuario.ListarUsuario();
                    break;

                    case 9:
                    break;


                    
                    default:
                    System.Console.WriteLine("Valor inválido");
                    break;
                }
                
            }while(resposta != 9);
        }
    }
}
