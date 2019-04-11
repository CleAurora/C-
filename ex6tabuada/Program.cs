using System;

namespace ex6tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string resposta = "";
            
            do{
                int contador = 0;
                Console.WriteLine("Entre com o número de tabuada");
                int numero = int.Parse(Console.ReadLine());

                    while (contador <=10){
                        int resultado = numero*contador;
                        Console.WriteLine("{0} x {1} = {2}", numero, contador, resultado);
                        contador = contador+1;
                    }

                Console.WriteLine("Gostaria de calcular a tabuada de mais um número (responda sim ou não)?");
                resposta = Console.ReadLine();
            }while ("sim".Equals(resposta, StringComparison.CurrentCultureIgnoreCase));

           
            Console.WriteLine("Beleza! mas o programa encerrou então...");
            
            

            

        }
    }
}
