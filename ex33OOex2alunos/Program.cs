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
            int capacidadeAtual = 0;
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
                        a.nome = Console.ReadLine();

                        System.Console.WriteLine("Digite sua data de Nascimento");
                        a.dataNascimento = DateTime.Parse(Console.ReadLine());

                        System.Console.WriteLine("Digite seu curso: ");
                        a.curso = Console.ReadLine();

                        // System.Console.WriteLine("Digite o número da Sua Sala");
                        // a.numeroSala = int.Parse(Console.ReadLine());
                        
                        alunos[numAlunos] = a;
                        numAlunos++;
                        System.Console.WriteLine("Cadastro concluido!");

                    break;

                    case 2:
                        System.Console.WriteLine("Digite o número da sala:");
                        Sala s = new Sala();
                        s.numeroSala = int.Parse(Console.ReadLine());

                        // System.Console.WriteLine("Digite a Capacidade Atual: ");
                        // s.capacidadeAtual = Console.ReadLine();

                        System.Console.WriteLine("Digite a Capacidade Total: ");
                        s.capacidadeTotal = int.Parse(Console.ReadLine());
                        
                        // System.Console.WriteLine("Digite o Aluno: ");
                        // s.alunos[capacidadeAtual] = Console.ReadLine();

                        salas[capacidadeAtual] = s;
                        capacidadeAtual++;
                        System.Console.WriteLine("Cadastro de Sala Concluído");
                    break;

                    case 3:
                        System.Console.WriteLine("Digite o nome do aluno e a sala que ele vai");
                        s.Adicionar(Console.ReadLine());
                    break;

                    case 4:
                        System.Console.WriteLine("Digite o nome do aluno a ser removido");
                        s.Remover(Console.ReadLine());
                    break;

                    case 5:
                        System.Console.WriteLine( "-------------Salas-----------");
                        System.Console.WriteLine($"Sala de número {s.numeroSala}");
                        System.Console.WriteLine($"Capacidade Atual: {s.capacidadeAtual}");
                        System.Console.WriteLine($"Capacidade Total: {s.capacidadeTotal}");
                        s.Exibir();
                    break;

                    case 6:
                        System.Console.WriteLine("----------Alunos----------");
                        System.Console.WriteLine($"Nome do Aluno: {a.nome}");
                        System.Console.WriteLine($"Data de Nascimento: {a.dataNascimento}");
                        System.Console.WriteLine($"Curso: {a.curso}");
                    break;

                    case 0:
                        System.Console.WriteLine("Fechando o programa! Obrigado por entrar em SENAIzinho");
                        sair = true;
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida. Tente Novamente.");
                        break;
                }
            }while(!sair);




        }
    }
}
