using System;

namespace ex31TsukaairlineOO
{
    class Program
    {
        static void Main(string[] args)
        {

            bool sair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int numPassageiros = 0;
            System.Console.WriteLine("Seja bem vindo(a) à Tsukamoto Airlines");
            
            do{

                System.Console.WriteLine("Escolha uma opção:");
                System.Console.WriteLine("1 -  Registrar passagem");
                System.Console.WriteLine("2 - Exibir passageiros");
                System.Console.WriteLine("0 - Sair");

                int codigo = int.Parse(Console.ReadLine());

                switch(codigo){
                    case 1:
                        System.Console.WriteLine("Digite o seu nome");
                        Passageiro p = new Passageiro();                   p.setNome(Console.ReadLine());

                        passageiros[numPassageiros] = p;
                        numPassageiros++;
                        System.Console.WriteLine("Cadastro concluido!");
                    break;
                    case 2:
                        System.Console.WriteLine("Todos os passageiros cadastrados:");
                        foreach (var passageiro in passageiros){
                            if (passageiro != null){
                            System.Console.WriteLine(passageiro.getNome());}
                        } 
                    break;

                }
                

            }while(!sair); /* diferente de sair - inverte o valor de sair - enquanto não quer sair, ele não sai */


        }
    }
}
