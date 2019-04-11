using System;

namespace ex14pirconcatenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o tamanho da pirâmide: ");
            int tamanho = int.Parse(System.Console.ReadLine());
            string estrela = "";

            for(int i=0; i<tamanho; i++){
                estrela += "*";
                System.Console.WriteLine(estrela);
            }

        }
    }
}
