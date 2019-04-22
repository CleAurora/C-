using System;

namespace ex35correcaopizza
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Pizza");
            int resposta = 0;
            do{
                System.Console.WriteLine("Selecione");
                System.Console.WriteLine("1. Cadastrar");
                System.Console.WriteLine("2. Efetuar login");
                System.Console.WriteLine("3. Listar");
                Console.WriteLine("9. Sair");
                resposta = int.Parse(Console.ReadLine());
                

                switch (resposta)
                {
                    case 1:
                        Usuario.Inserir();
                    break;

                    case 2:
                    Usuario.EfetuarLogin();
                    
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
