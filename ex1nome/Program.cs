using System;

namespace primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)

        {   
            //Programa inicial para aprenser os comandos CW e CR e início de C#

            string nome; //declarei uma variável chamada nome
            string sobrenome; //declarei uma outra variável
            Console.WriteLine("Digite seu nome: ");//comando de imprimir no console - exibe na tela
            nome = Console.ReadLine(); // Efetua a leitura e armazena o que foi digitado
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Bom dia " + nome + " " + sobrenome);
            
        }
    }
}
