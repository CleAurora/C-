using System;

namespace ex18piramidinhascontcatenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Entre com a base da piramide");
            int b = int.Parse(Console.ReadLine());
                        
            System.Console.WriteLine("Entre com o número de vezes que vc quer ver a pirâmide:");
            int n = int.Parse(Console.ReadLine());

            for(int a = 0; a<n; a++){
                string estrela = "";
                for (int i = 0; i < b; i++){
                    estrela +="*";
                    System.Console.WriteLine(estrela);
                }
            }


        }
    }
}
