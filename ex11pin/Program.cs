using System;

namespace ex11pin
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com um número:");
            int numero = int.Parse(Console.ReadLine());
            for(int i=0; i<=numero; i++){
                //System.Console.WriteLine(((i % 4! =0)? i.ToString="PI"));

                if(i%4 == 0){
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    System.Console.WriteLine("PI");
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
