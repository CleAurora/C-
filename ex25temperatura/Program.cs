using System;

namespace ex25temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturaMensal = new int[12];


            for (int i = 0; i < temperaturaMensal.Length; i++){
                System.Console.WriteLine($"Entre com a média da temperatura do mês {i+1}");
                temperaturaMensal[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(temperaturaMensal);

            System.Console.WriteLine($"A maior temperatura é {temperaturaMensal[11]} e a menor temperatura é {temperaturaMensal[0]}");

        
        }
    }
}
