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

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            
                            
                        }//fim if
                    break;

                    case 3:

                        if(contadorAluno == 0){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há aluno cadastrado");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue; // o continue reinicia o laço mais próximo - Fizemos uma armadilha pra quem quer burlar o sistema

                        }

                        if(contadorSala == 0){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há sala cadastrada");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue; 
                        }

                        //Aluno nomeAlunoAloc;
                        Aluno alunoRecuperadoAloc = null;
                        
                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoAloc = Console.ReadLine();

                        foreach (Aluno item in alunos){
                            if(item != null && nomeAlunoAloc.Equals(item.Nome)){
                                alunoRecuperadoAloc = item;// tipo um resgate do nome com uma referência que está fora do foreach (linha 104)
                                break;// no switc o break fecha o case, no if ele fecha o loop mais próximo.
                            }
                        }// isso tudo tem a ver com a busca do aluno

                        if (alunoRecuperadoAloc == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há aluno cadastrado com o nome {nomeAlunoAloc}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        //para sala

                        Sala salaRecuperadaAloc = null;
                        System.Console.WriteLine("Digite o numero da sala");
                        int numeroSalaAloc = int.Parse(Console.ReadLine());

                        foreach (Sala item in salas){
                            if(item != null && numeroSalaAloc.Equals(item.NumeroSala)){
                                salaRecuperadaAloc = item;
                            }
                        }

                        if (salaRecuperadaAloc == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há sala cadastrada com o numero{numeroSalaAloc}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(salaRecuperadaAloc.AlocarAluno(alunoRecuperadoAloc.Nome));
                        Console.ResetColor();
                        
                        System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                        Console.ReadLine();

                        
                    break;

                    case 4:
                        
                        if(contadorAluno == 0){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há aluno cadastrado");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue; // o continue reinicia o laço mais próximo - Fizemos uma armadilha pra quem quer burlar o sistema

                        }

                        if(contadorSala == 0){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há sala cadastrada");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue; 
                        }

                        //Aluno nomeAlunoAloc;
                        Aluno alunoRecuperadoRem = null;
                        
                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoRem = Console.ReadLine();

                        foreach (Aluno item in alunos){
                            if(item != null && nomeAlunoRem.Equals(item.Nome)){
                                alunoRecuperadoRem = item;// tipo um resgate do nome com uma referência que está fora do foreach (linha 104)
                                break;// no switc o break fecha o case, no if ele fecha o loop mais próximo.
                            }
                        }// isso tudo tem a ver com a busca do aluno

                        if (alunoRecuperadoRem == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há aluno cadastrado com o nome {nomeAlunoRem}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        //para sala

                        Sala salaRecuperadaRem = null;
                        System.Console.WriteLine("Digite o numero da sala");
                        int numeroSalaRem = int.Parse(Console.ReadLine());

                        foreach (Sala item in salas){
                            if(item != null && numeroSalaRem.Equals(item.NumeroSala)){
                                salaRecuperadaRem = item;
                            }
                        }

                        if (salaRecuperadaRem == null){
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            System.Console.WriteLine($"Não há sala cadastrada com o numero{numeroSalaRem}");
                            Console.ResetColor ();

                            System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                            Console.ReadLine();
                            continue;
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(salaRecuperadaRem.RemoverAluno(alunoRecuperadoRem.Nome));
                        Console.ResetColor();
                        
                        System.Console.WriteLine("Aperte a tecla ENTER para voltar ao menu");
                        Console.ReadLine();

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

