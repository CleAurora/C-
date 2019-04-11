using System;

namespace ex20maisarray
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] numerosDeCasas = new int[5];

            for (int i = 0; i < numerosDeCasas.Length; i++){
            Console.WriteLine("Fale o número da sua casa:");
            numerosDeCasas [i] = int.Parse(Console.ReadLine());    
            } 

            foreach (int numeroDeCasa in numerosDeCasas)//exemplo de foreach (var item in collection) em que eu declaro a variavel aqui mesmo...
            {  
                System.Console.WriteLine($"{numeroDeCasa},");
            }
            
            
            //System.Console.WriteLine(numerosDeCasas[0]);
            //System.Console.WriteLine($"Os números das casas da minha mesa são: {numerosDeCasas[]} ");
        }
    }
}
