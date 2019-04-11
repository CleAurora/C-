using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            float primeiraNota;
            float segundaNota = 0;
            float terceiraNota;
            float notaFinal;
            
            do{
                Console.WriteLine("Entre com a primeira Nota (entre 0 e 10): ");
                primeiraNota = float.Parse(Console.ReadLine());

            }while (primeiraNota<0 || primeiraNota>10);
    
            do{
                Console.WriteLine("Entre com a segunda nota (entre 0 e 10): ");
                segundaNota = float.Parse(Console.ReadLine()); 
            }while (segundaNota<0 || segundaNota>10);
            
            do{
                Console.WriteLine("Entre com a terceira Nota (entre 0 e 10): ");
                terceiraNota = float.Parse(Console.ReadLine()); 
            }while(terceiraNota<0 || terceiraNota>10);

            
            notaFinal = (primeiraNota + segundaNota + terceiraNota) / 3;
            Console.WriteLine("Sua nota final é: " + notaFinal);

            //exibir se aprovado ou reprovado
            if (notaFinal < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else if (notaFinal < 9)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("É isso aí meu jovem!!");
            }


        }
    }
}
