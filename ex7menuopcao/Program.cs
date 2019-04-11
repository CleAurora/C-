using System;

namespace ex7menuopcao
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta = 0;
            bool repeteco = true;
            string nome = "visitante";

            
            System.Console.WriteLine("Bem Vindo {0}!!!", nome);
            Console.WriteLine("Menu: ");
            System.Console.WriteLine("1. Efetuar Login");
            System.Console.WriteLine("2. Contato");
            System.Console.WriteLine("3. Listar Comentários");
            System.Console.WriteLine("9. Sair do programa");
            System.Console.WriteLine("Escreva (em número) a opção que você quer:");
            resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                System.Console.WriteLine("Digite seu login: ");
                nome = Console.ReadLine();
                System.Console.WriteLine("Login Efetuado");

                Console.WriteLine("Gostaria de voltar ao menu inicial se sim, aperte enter");
                string repetir = Console.ReadLine();
                repeteco = repetir.Equals("")? true: false;
            }
            else if (resposta == 2)
            {
                System.Console.WriteLine("Contato feito");
                Console.WriteLine("Gostaria de voltar ao menu inicial se sim, aperte enter");
                string repetir = Console.ReadLine();
                repeteco = repetir.Equals("")? true: false;
            }
            else if (resposta == 3)
            {
                System.Console.WriteLine("Comentário Listado");
                Console.WriteLine("Gostaria de voltar ao menu inicial se sim, aperte enter");
                string repetir = Console.ReadLine();
                repeteco = repetir.Equals("")? true: false;
            }
            else if(resposta ==9){
                System.Console.WriteLine("Você pediu pra sair. Encerrando o programa...");
            }
            else
            {
                System.Console.WriteLine("Opção Não inclusa no menu, por favor, digite o número 1, 2, 3 ou 9. ");
            }
                
            

            




        }
    }
}
