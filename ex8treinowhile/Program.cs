using System;

namespace ex8treinowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool emailInvalido = true;
            do{
                System.Console.WriteLine("Digite seu e-mail");
                string email = Console.ReadLine();
                
                //se o email contem o @
                if(email.Contains("@") && email.Contains(".")){
                    emailInvalido = false;
                }
                else{
                System.Console.WriteLine("Email Inválido. Tente novamente.");
                }

            }while(emailInvalido);
            System.Console.WriteLine("Email Válido!");
        }
    }
}
