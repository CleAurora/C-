using System;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());
        
            float media = (nota1+nota2+nota3)/3;

            Console.WriteLine("Sua média é "+ media);

            Console.WriteLine("Quantas faltas você teve no semestre?");
            int faltas = int.Parse(Console.ReadLine());

            if(media>5 && faltas<=25){
                Console.WriteLine("Aprovado");
            }
            else{
                Console.WriteLine("Reprovado");
            }        
        }
    }
}
