using System;

namespace ex12Contagem
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com um número: ");
            int numero = int.Parse(Console.ReadLine());
            int qtpares = 0;

            for(int i =0; i<= numero; i++){
                if (i%2 == 0){
                    //Resultado par
                    System.Console.WriteLine(i);
                    qtpares++;
                }//fim if
            }//fim for
            System.Console.WriteLine("A quantidade de pares é {0}!", qtpares);
        }
    }
}
