using System;

namespace ex29geradorabobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Manda  uma palavra aí meu consagrado");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 5;

            string[] palavrasUsuario = new string[5];

            for (int i = 0; maxPalavrasUsuario > 0; i++){//maneira de colocar o for diferente maxPalavras é maior que 0, e já é 5, e toda vez que eu repito ee diminui (condição no if)
                palavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario !=0){
                    System.Console.WriteLine("Faltam " + maxPalavrasUsuario + ". Digite mais uma!");

                }else{
                    System.Console.WriteLine("Valeu, meu bom! Agora deixa comigo!");
                }
            }
            //matriz é um array de array, vc coloca o numero de  linhas e colunas e vai lá!
            // minha matriz de strings, com uma palavra fal
            string[,] matrizPalavras = {
                {""           , "eu"         , "nós"         , "passa"       , "louco"     },
                {"sangue"     , "sou"        , "computadores", "melão"       , ""          },
                {"tem"        , "estudante"  , ""            , "e"           , "passeia"   },
                {"eosinófilos", ""           , "dá"          , "limão"       , "na"        },
                {"nele"       , "feliz"      , "certo"       , ""            , "passarela" }, 
            };
            //Get.Length = tamanho da lilnha, se eu tenho "" na linha da matriz escolhida de maneira randomica\ eu substitui pela palavra dada pelo usuario
            for(int i=0; i< matrizPalavras.GetLength(0); i++){
                for (int j = 0; j < matrizPalavras.GetLength(0); j++)
                {
                    if("".Equals(matrizPalavras[i,j])){
                        matrizPalavras[i,j] = palavrasUsuario[j];
                    }
                }
            }

            // chamei a variável randômica e ele escolhe pelo next alguma palavra aleatoria naquela linha
            string frase = "";
            Random r = new Random();
            for(int i = 0; i< maxPalavrasFrase; i++){
                frase +=matrizPalavras[i/* r.Next(matrizPalavras.GetLength(0))*/, r.Next(matrizPalavras.GetLength(0))] +" ";
            }

            System.Console.WriteLine("Minha frase é \n" + frase);

        }
    }
}
