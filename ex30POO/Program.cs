using System;

namespace ex30POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(); /* estou instanciando (criando) objeto (no caso o usuário) - quando coloquei o new. è como se eu tivesse um tipo de dado int, tipo de dado string, tipo de dado usuário */
            System.Console.WriteLine("Digite sua senha");
            usuario.setSenha(Console.ReadLine());
            string senha = usuario.getSenha();
            System.Console.WriteLine("Sua senha é "+senha);

        }
    }
}
