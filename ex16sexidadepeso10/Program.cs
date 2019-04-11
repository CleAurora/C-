using System;

namespace ex16sexidadepeso10
{
    class Program
    {
        static void Main(string[] args)
        {
            //repetir 10x
            //Receber sexo
            //Receber idade
            //Receber peso
            //imprimir Total de homens
            //imprimir Total de mulheres
            //média idade dos homens
            //média idade das mulheres
            //média peso dos homens
            //média do peso das mulheres

            string sexo = "";
            int idade = 0;
            int peso = 0;

            int totalMulheres = 0;

            int idadeMulheres = 0;
            int mediaIdadeMulheres = 0;

            int pesoMulheres = 0;
            int mediaPesoMulheres = 0;

            int totalHomens = 0;

            int idadeHomens = 0;
            int mediaIdadeHomens = 0;

            int pesoHomens = 0;
            int mediaPesoHomens = 0;

            for (int i = 1; i < 4; i++)
            {
                System.Console.WriteLine("Pessoa número {0}", i);
                System.Console.WriteLine("Entre com o sexo (F ou M): ");
                sexo = Console.ReadLine();

                System.Console.WriteLine("Entre com a idade em anos: ");
                idade = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Entre com o peso em kg: ");
                peso = int.Parse(Console.ReadLine());

                if (sexo == "F")
                {
                    totalMulheres += 1;
                    idadeMulheres += idade;
                    pesoMulheres += peso;

                }

                else if(sexo == "M")
                {
                    totalHomens += 1;
                    idadeHomens += idade;
                    pesoHomens += peso;

                }

                else{
                    System.Console.WriteLine("Você não respondeu F ou M, e perdeu a oportunidade de participar do questionário.");
                }
                System.Console.WriteLine("Obrigada pelas informações!");


            }
                    mediaPesoMulheres = pesoMulheres / totalMulheres;
                    mediaIdadeMulheres = idadeMulheres / totalMulheres;
                    mediaIdadeHomens = idadeHomens / totalHomens;
                    mediaPesoHomens = pesoHomens / totalHomens;

            System.Console.WriteLine("Temos {0} homens e {1} mulheres", totalHomens, totalMulheres);
            System.Console.WriteLine("A média de idades das mulheres é {0} e dos homens é {1}", mediaIdadeMulheres, mediaIdadeHomens);
            System.Console.WriteLine("A média dos pesos das mulheres é {0} e dos homens é {1}", mediaPesoMulheres, mediaPesoHomens);


        }
    }
}
