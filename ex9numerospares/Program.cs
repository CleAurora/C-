using System;

namespace ex9numerospares
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com um número natural");
            int numero = int.Parse(Console.ReadLine());
            int i = 0;
            int qtpares = 0;
            System.Console.WriteLine("Os números pares de 0 a {0} são:", numero);
            for (i=0; i<= numero; i+=2){
                System.Console.WriteLine("{0}", i);
                qtpares = ((i/2) + 1);

            }
            System.Console.WriteLine("Temos {0} pares!",qtpares);
        }
    }
}
