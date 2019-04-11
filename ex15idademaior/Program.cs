using System;

namespace ex15idademaior
{
    class Program
    {
        static void Main(string[] args)
        {

            //Repetir 10x
            //Exibir mensagem de digite sua idade
            //Receber a idade
            //Ver se essa idade é maior ou igual a 18
            //Se a idade <= 18, add ao grupo de maiores
            int idade = 0;
            int maiores = 0;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    maiores++;
                }

            }
            System.Console.WriteLine("Temos {0} maiores!", maiores);






            //int idade = 0;

            //int[] idades;
            //for (int i = 0; i <10; i++){      
            //System.Console.WriteLine( "Idades = " + idades[i]);

            //idades[i] = int.Parse(Console.ReadLine());

            //System.Console.WriteLine();

        }
    }
}
