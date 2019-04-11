using System;

namespace ex24passagemaviao
{
    class Program
    {
        static void Main(string[] args)


        {   
            //até 5 passagens disponíveis
                // app para passagens aéreas com as opções: 
                // 1 - Registrar passagens,
                    // comprador deve inserir o número da passagen desejada, o nome do comprador e a data do voo 
                // 2 - Visualizar passagens, 
                // 0 - sair

                //Para converter uma data, faça: DateTime data = DateTime.Parse(Console.ReadLine());
                //Para exibir uma data (na interpolação de strings) use: (data:dd/MM/yyyy)

            int [] numeroVoo = new int[5];
            string [] nome = new string[5];
            DateTime [] dataVoo = new DateTime[5];

            int opcao;
            int contador = 0;

            for (int i = 0; i < 5; i++)
            {
                
            

                System.Console.WriteLine("Seja Bem vindo!! Digite o número da opção desejada!");
                System.Console.WriteLine("1. Registrar Passagens");
                System.Console.WriteLine("2. Visualizar passagens");
                System.Console.WriteLine("0. Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                        System.Console.WriteLine("Insira o número da sua passagem ");
                        numeroVoo[i] = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("Insira seu nome completo");
                        nome[i] = Console.ReadLine();
                        
                        System.Console.WriteLine("insira a data do vôo ");
                        dataVoo[i] = DateTime.Parse(Console.ReadLine());

                        contador+=1;
                    break;

                    case 2:

                        for (int a = 0; a < contador; a++){
                            System.Console.WriteLine($"----------Passageiro {a+1}----------");
                            System.Console.WriteLine($"Número Vôo = {numeroVoo[a]}");
                            System.Console.WriteLine($"Nome: {nome[a]}");
                            System.Console.WriteLine($"Data: {dataVoo[a]}");
                            System.Console.WriteLine("");  
                        }
                    break;

                    default: 
                        System.Console.WriteLine("Você digitou opção inválida ou pediu para sair");
                    break;
                }
            }
        }
    }
}
