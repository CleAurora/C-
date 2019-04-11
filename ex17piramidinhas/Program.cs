using System;

namespace ex17piramidinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir a pirâmide quantas vezes quiser
            //Fazer piramide

            System.Console.WriteLine("Entre com a base da pirâmide: ");
            int n = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o número de vezes que você quer que a pirâmide apareça.");
            int b = int.Parse(Console.ReadLine());
            
            
            for(int a = 0; a<b; a++){

                for (int i = 0; i < n; i++){
                    for(int j = 0; j<=i; j++){
                        System.Console.Write("*");
                    }
                    System.Console.WriteLine("");
                }
            }
        }
    }
}
