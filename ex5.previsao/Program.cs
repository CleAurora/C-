using System;

namespace ex5.previsao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a previsão do tempo para hoje? ");
            string previsao = Console.ReadLine();
            previsao = previsao.ToUpper();

            //eu poderia usar o equals para comparar, ficaria assim if(clima.Equals("calor")){}...

            if(previsao == "FRIO"){
                Console.WriteLine("Vamos à Montanha?");                
            }
            else if (previsao == "CALOR"){
                Console.WriteLine("Vamos à praia?");
            }
            else if (previsao == "CHUVA"){
                Console.WriteLine("Vamos para o Steam?");
                string gosto = Console.ReadLine();
                gosto = gosto.ToUpper();
                if(gosto == "SIM"){
                    Console.WriteLine("Legal cara! Boralá!");
                }
                else if(gosto == "NAO"){
                    Console.WriteLine("Então bora assistir Netflix!!");
                }
                else{
                    Console.WriteLine("Não é uma entrada válida, entre com sim ou não!");
                }
            }
            else{
                Console.WriteLine("Não é uma entrada válida! Entre com calor, frio ou chuva!");
            }


        }

        private static string ToUpper(string v)
        {
            throw new NotImplementedException();
        }
    }
}
