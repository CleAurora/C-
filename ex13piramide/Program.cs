using System;

namespace ex13piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o tamanho da piramide: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= a; i++){
                for(int j = 0; j<= i; j++){
                    System.Console.Write("*");
                }
            System.Console.WriteLine("");
            }

        }
    }
}
