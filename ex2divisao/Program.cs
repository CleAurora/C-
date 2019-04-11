using System;

namespace numerointeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero;
            int segundoNumero;
            int resultado;
            Console.WriteLine("Entre com o primeiro Número: ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            resultado = primeiroNumero/segundoNumero;
            Console.WriteLine("O resultado da divisão do primeiro número pelo segundo número é " + resultado);


        }
    }
}
