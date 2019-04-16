using System;

namespace ex34correcaoalunos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            Aluno[] alunos = new Aluno[4];
            Sala[] salas = new Sala[1];
            int contadorAluno = 0;
            int contadorSala = 0;
            do{
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("==========SENAIzinho============");
                Console.ResetColor();
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

                switch (codigo){
                    case 1:
                        //Cadastrar Aluno

                        if(contadorAluno <4){
                            Aluno a = new Aluno();
                            System.Console.WriteLine("Digite o nome do Aluno: ");
                            a.Nome = Console.ReadLine();
                            System.Console.WriteLine("Digite a data de Nascimento: ");
                            a.DataNascimento = DateTime.Parse(Console.ReadLine());
                            System.Console.WriteLine("Digite o nome do Curso: ");
                            a.Curso = Console.ReadLine();
                            // System.Console.WriteLine("Digite o número da sala");
                            // a.NumeroSala = int.Parse(Console.ReadLine());

                            //vou adicionar esse aluno cadastrado ao array de alunos
                            alunos[contadorAluno] = a;
                            contadorAluno++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro efetuado com sucesso");
                            Console.ResetColor();
                        }//fim do if
                    break;

                    case 2:
                        //Cadastrar Sala
                        if(contadorSala<1){
                            Sala s = new Sala();
                            System.Console.WriteLine("Digite o número da sala: ");
                            s.NumeroSala = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Digite a Capacidade total: ");
                            s.CapacidadeTotal = int.Parse(Console.ReadLine());
                            
                            s.CapacidadeAtual = s.CapacidadeTotal;

                            s.Alunos = new string[s.CapacidadeTotal];//declarando que o máximo de alunos é a capacidade total - to criando meu array de string

                            salas[contadorSala] = s;
                            contadorSala++;
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro efetuado com sucesso");
                            Console.ResetColor();
                            
                        }//fim if
                    break;

                    case 3:
                        System.Console.WriteLine("Qual sala você gostaria de alocar o aluno?");
                        int salaAlocar = int.Parse(Console.ReadLine());
                        foreach (var item in salas){
                            if(item.NumeroSala == salaAlocar){

                                item.Alocar();
                            }
                        }
                        
                    break;

                    case 4:
                        System.Console.WriteLine("Qual sala você gostaria de remover o aluno?");
                        int salaRemover = int.Parse(Console.ReadLine());
                        foreach (var item in salas){
                            if(item.NumeroSala == salaRemover){
                                item.Remover();
                            }
                        }
                    break;

                    case 5:
                        //Listas salas
                        foreach (var item in salas){
                            if(item != null){
                                System.Console.WriteLine("-------------------");
                                System.Console.WriteLine($"Número da Sala: {item.NumeroSala}");
                                System.Console.WriteLine($"Capacidade Total: {item.CapacidadeTotal}");
                                System.Console.WriteLine($"Vagas Disponíveis: {item.CapacidadeAtual}");
                                System.Console.WriteLine("-------------------");
                                System.Console.WriteLine("Aperte enter para continuar!");
                            }
                        }
                    break;

                    case 6:
                        //Listar alunos
                        foreach (var item in alunos){
                            if(item != null){
                                System.Console.WriteLine("------------------");
                                System.Console.WriteLine($"Nome do Aluno: {item.Nome}");
                                System.Console.WriteLine($"Data de Nascimento: {item.DataNascimento}");
                                System.Console.WriteLine($"Nome do Curso: {item.Curso}");
                                System.Console.WriteLine("------------------");
                                System.Console.WriteLine("Aperte enter para continuar!");
                            }
                        }
                    break;

                    default:
                    break;
                }
            }while(!sair);
        }
    }
}

