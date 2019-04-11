using System;

namespace ex26superdados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receber o nome, sobrenome, dados de nascimento e 2 notas de 10 alunos e armazene essas 
            // informações em vetores distintos. Calcule e imprima: 
            // a. O nome completo, idade, média do aluno e se foi Aprovador ou reprovado.
            // Para ser aprovado o aluno deve ser maior ou igual a 50.
            // Efetuar todas as validações possíveis.


            string[] nome = new string[3];
            string[] sobrenome = new string[3];
            //int[] idade = new int[10];
            DateTime [] dataNascimento = new DateTime[3];
            int[] prova1 = new int[3];
            int[] prova2 = new int[3];

            //TimeSpan idade;


            for (int i = 0; i < nome.Length; i++){

                System.Console.WriteLine("Digite seu nome (primeiro nome): ");
                nome[i] = Console.ReadLine();

                System.Console.WriteLine("Digite seu sobrenome (último nome):");
                sobrenome[i] = Console.ReadLine();

                //exibição: dataNascimento[i]: dd/MM/yyyy;

                // System.Console.WriteLine("Digite sua idade: ");
                // idade[i] = int.Parse(Console.ReadLine());
                
                System.Console.WriteLine("Digite sua data de nascimento:");
                dataNascimento[i] = DateTime.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a nota da P1: ");
                prova1[i] = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a nota da P2: ");
                prova2[i] = int.Parse(Console.ReadLine());

                System.Console.WriteLine(""); 
            }


            for (int i = 0; i < nome.Length; i++){
                System.Console.WriteLine($"-------Aluno {i+1}------");
                System.Console.WriteLine($"{nome[i]} {sobrenome[i]}");

                int idade = DateTime.Now.Year - dataNascimento[i].Year;
                if (DateTime.Now.Month < dataNascimento[i].Month || (DateTime.Now.Month == dataNascimento[i].Month && DateTime.Now.Day < dataNascimento[i].Day)){
                    idade--;

                //return idade;
                }
                //idade = DateTime.Today.Subtract(dataNascimento[i]);
                System.Console.WriteLine($"{idade} anos");



                int media = (prova1[i] + prova2[i])/2;
                System.Console.WriteLine($"Sua média é {media}");

                if(media>=50){
                    System.Console.WriteLine($"Portanto você passou!");
                }
                else{
                    System.Console.WriteLine("Que pena... você reprovou..");
                }

                System.Console.WriteLine("");
            }

        }
    }
}
