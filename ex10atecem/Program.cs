using System;

namespace ex10atecem
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=100; i++){
                
                if(i%4 == 0){
                    System.Console.WriteLine("PI");

                }
                else{
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
