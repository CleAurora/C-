using System;

namespace ex33OOex2alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            Aluno[] alunos = new Aluno[4];
            int numAlunos = 0;
            Sala[] salas = new Sala[5];
            int numSalas = 0;
            System.Console.WriteLine("Seja bem vindo ao SENAIzinho");


            do{
                System.Console.WriteLine("==========SENAIzinho============");
                System.Console.WriteLine("||                            ||");
                System.Console.WriteLine("||    Escolha uma opção:      ||");
                System.Console.WriteLine("||    1. Cadastrar Aluno      ||");
                System.Console.WriteLine("||    2. Cadastrar Sala       ||");
                System.Console.WriteLine("||    3. Alocar Aluno         ||");
                System.Console.WriteLine("||    4. Remover Aluno        ||");
                System.Console.WriteLine("||    5. Verificar Salas      ||");
                System.Console.WriteLine("||    6. Verificar Alunos     ||");
                System.Console.WriteLine("||    0. Sair                 ||");
                System.Console.WriteLine("||============================||");

                int codigo = int.Parse(Console.ReadLine());

                switch(codigo){
                    case 1:
                        System.Console.WriteLine("Digite seu nome:");
                        Aluno a = new Aluno();
                        a.setNome = Console.ReadLine();

                        System.Console.WriteLine("Digite sua data de Nascimento");
                        a.setData = Console.ReadLine();

                        System.Console.WriteLine("Digite seu curso: ");
                        a.setCurso = Console.ReadLine();

                        System.Console.WriteLine("Digite o número da Sua Sala");
                        a.setnumeroSala = Console.ReadLine();
                        
                        alunos[numAlunos] = a;
                        numAlunos++;
                        System.Console.WriteLine("Cadastro concluido!");

                    break;

                    case 2:
                        System.Console.WriteLine("Digite o número da sala:");
                        Sala s = new Sala();
                        s.numeroSala = Console.ReadLine();

                        System.Console.WriteLine("Digite a Capacidade Atual: ");
                        s.capacidadeAtual = Console.ReadLine();

                        System.Console.WriteLine("Digite a Capacidade Total: ");
                        s.capacidadeTotal = Console.ReadLine();
                        
                        System.Console.WriteLine("Digite o Aluno: ");
                        s.alunos = Console.ReadLine();

                        salas[numSalas] = s;
                        numSalas++;
                        System.Console.WriteLine("Cadastro de Sala Concluído");


                    break;
                }



            }while(!sair);




        }
    }
}
