using System;

namespace ex21caixaeletronico
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Gravar num array as notas de 100 a 1
            // em um loop passar por cada nota e fazer o valor referente ao saque
            
            
            int[] notas = {100, 50, 20, 10, 5, 2, 1};
            System.Console.WriteLine("Digite o valor de saque");
            int valor = int.Parse(Console.ReadLine());
            int valorNotas = 0;

            for (int i = 0; i <= notas.Length; i++){
                while(valorNotas<valor && valor-valorNotas>=notas[i]){
                    valorNotas += notas[i];
                    System.Console.WriteLine(notas[i]);
                }
                
            }
            System.Console.WriteLine(valorNotas);

            
            // while(valorNotas<valor){
            //     foreach (int nota in notas){
                    
            //     }
            //     valorNotas

            // }
                
            
            // foreach (int a in notas){
            //     if (valorNotas < valor){
            //         valorNotas += a; 
            //         System.Console.WriteLine($"{a} + ");
            //     }
            // }


        }

    }
}
