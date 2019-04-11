using System;

namespace ex28datasmedia
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Notas dos alunos");

            string [] nomes = new string[2];
            string[] sobreNomes = new string[2];
            DateTime[] datasNascimentos = new DateTime[2];
            float [] nota1 = new float[2];
            float [] nota2 = new float[2];
            float[] medias = new float [2];
            string [] situacao = new string[2];
           

            for (int i = 0; i < 2; i++){
                System.Console.WriteLine($"Digite o nome do {i+1}º aluno");
                nomes[i] = Console.ReadLine();
                
                System.Console.WriteLine($"Digite o sobrenome");
                sobreNomes[i] = Console.ReadLine();

                System.Console.WriteLine("Digite a data de nascimento");
                datasNascimentos[i] = DateTime.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a primeira nota");
                nota1[i] = float.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite a segunda nota");
                nota2[i] = float.Parse(Console.ReadLine());

                medias[i] = (nota1[i]+nota2[i])/2;

                if(medias[i]>=50){
                    situacao[i] = "Aprovado";
                }

                else{
                    situacao[i] = "Reprovado";
                }



            }//fim do for

            for (int i = 0; i < 2; i++){
                TimeSpan tempoVivido = (DateTime.Today - datasNascimentos[i]);
                DateTime idade = new DateTime().Add(tempoVivido).AddYears(-1);
                System.Console.WriteLine($"O aluno {nomes[i]} {sobreNomes[i]}, {idade.Year} anos, está com média {medias[i]} e sua situação é {situacao[i]}.");
            }
        }
    }
}
