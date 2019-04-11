using System;

namespace ex23correcaocaixanj
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {100, 50, 20, 10, 5, 2, 1};
            System.Console.WriteLine("Digite o valor do saque: ");
            int saque = int.Parse(Console.ReadLine());

            int qtNotas  = 0;

            for (int i = 0; i < notas.Length; i++){
                qtNotas = saque/notas[i];
                saque = saque%notas[i];
                if(qtNotas != 0){
                    System.Console.WriteLine($"Você recebeu {qtNotas} notas de {notas[i]}");
                }
            }

            DataTime data = DataTime.Parse(Console.ReadLine());
        }
    }
}
