using System;

namespace ex22notasalunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = new int[10];
            int media = 0;
            for (int i = 0; i < notas.Length; i++){
                System.Console.WriteLine($"Entre com a nota do aluno {i+1}");
                notas[i] = int.Parse(Console.ReadLine());
                somaNotas += notas[i];
                if(notas[i]<5){
                    System.Console.WriteLine("Recuperação");
                }
                else{
                    System.Console.WriteLine("Passou!");
                }
                
            }
            media = somaNotas / notas.Length;
            System.Console.WriteLine($"A média da turma é {media}");
        
        }
    }
}
