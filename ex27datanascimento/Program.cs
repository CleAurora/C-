using System;

namespace ex27datanascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Como calcular idade pela data de nascimento:

            DateTime hoje = DateTime.Today;
            DateTime niver = new DateTime(2010, 1, 23);
            TimeSpan tempoDecorrido = hoje.Subtract(niver);
            int anos = tempoDecorrido.Days / 365;
            System.Console.WriteLine(anos);// problema não considera ano bissexto
        }
    }
}
