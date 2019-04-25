using System;
using ex34correcaoalunos.enums;

namespace ex34correcaoalunos
{
    class Program
    {
        static void Main(string[] args)
        {   
            int limiteAlunos = 3;
            int limiteSalas = 2;
            bool sair = false;

            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];

            int contadorAluno = 0;
            int contadorSala = 0;

            do{
                MostrarMensagem("==========SENAIzinho============", TipoMensagemEnum.ERRO);
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
                    #region CADASTRAR_ALUNO
                        //Cadastrar Aluno



                        if(limiteAlunos != contadorAluno){
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

                            MostrarMensagem($"Cadastro de {a.GetType().Name} feito com sucesso", TipoMensagemEnum.SUCESSO);

                        }else{
                            MostrarMensagem($"Total de Alunos foi excedido", TipoMensagemEnum.ALERTA);
                        }
                    break;
                    #endregion

                    case 2:
                    #region CADASTRAR_SALA

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

                            MostrarMensagem($"Cadastro de {s.GetType().Name} feito com sucesso!", TipoMensagemEnum.SUCESSO);
                            
                            
                        }else{
                            MostrarMensagem($"Total de Alunos foi excedido", TipoMensagemEnum.ALERTA);
                        }
                    break;
                    #endregion

                    #region ALOCAR_ALUNO
                    case 3:
                        ValidarAlocarOuRemover(contadorAluno, contadorSala);

                        //Aluno nomeAlunoAloc;
                        
                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoAloc = Console.ReadLine();
                        Aluno alunoRecuperadoAloc = ProcurarAlunoPorNome(nomeAlunoAloc, alunos);
                       
                        if (alunoRecuperadoAloc == null){
                            MostrarMensagem($"Não há aluno cadastrado com o nome{nomeAlunoAloc}", TipoMensagemEnum.ALERTA);
                            continue;
                        }


                        //para sala

                        System.Console.WriteLine("Digite o numero da sala");
                        int numeroSalaAloc = int.Parse(Console.ReadLine());
                        Sala salaRecuperadaAloc = ProcurarSalaPorNumero(numeroSalaAloc, salas);

                        if (salaRecuperadaAloc == null){
                            MostrarMensagem($"Não há sala cadastrada com o numero{numeroSalaAloc} ", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        MostrarMensagem(salaRecuperadaAloc.AlocarAluno(alunoRecuperadoAloc.Nome), TipoMensagemEnum.DESTAQUE);
                    break;
                    #endregion

                    case 4:
                    #region REMOVER_ALUNO
                        
                       ValidarAlocarOuRemover(contadorAluno, contadorSala);

                        //Aluno nomeAlunoAloc;

                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoRem = Console.ReadLine();
                        Aluno alunoRecuperadoRem = ProcurarAlunoPorNome(nomeAlunoRem, alunos);

                        if (alunoRecuperadoRem == null){

                            MostrarMensagem($"Não há aluno cadastrado com o nome {nomeAlunoRem}", TipoMensagemEnum.ALERTA);
                            continue; 

                     
                        }

                        //para sala

                        System.Console.WriteLine("Digite o numero da sala");
                        int numeroSalaRem = int.Parse(Console.ReadLine());
                        Sala salaRecuperadaRem = ProcurarSalaPorNumero(numeroSalaRem, salas);

                        if (salaRecuperadaRem == null){
                            MostrarMensagem($"Não há sala cadastrada com o nome {numeroSalaRem}", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        MostrarMensagem(salaRecuperadaRem.RemoverAluno(alunoRecuperadoRem.Nome), TipoMensagemEnum.ALERTA);

                    break;
                    #endregion

                    case 5:
                    #region LISTAR SALAS
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
                    #endregion

                    case 6:
                    #region LISTAR_ALUNOS
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
                    #endregion

                    default:
                        System.Console.WriteLine("Entrada Inválida");
                    break;
                    
                }
            }while(!sair);

            


          
        }

            static void MostrarMensagem(string mensagem, TipoMensagemEnum tipoMensagem){

                switch(tipoMensagem){
                    case TipoMensagemEnum.SUCESSO:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                
                
                    case TipoMensagemEnum.ERRO:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                    case TipoMensagemEnum.ALERTA:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                    case TipoMensagemEnum.DESTAQUE:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                }



                    System.Console.WriteLine(mensagem);
                    Console.ResetColor();
            
                    System.Console.WriteLine("Pressione ENTER para continuar");
                    Console.ReadLine();
            }

            static bool ValidarAlocarOuRemover(int alunosCadastrados, int salasCadastradas){
                if(alunosCadastrados == 0){
                    MostrarMensagem("Nenhum aluno cadastrado", TipoMensagemEnum.ALERTA);
                    return false;
                }else if(salasCadastradas == 0){
                    MostrarMensagem("Não há salas cadastradas", TipoMensagemEnum.ALERTA);
                    return false;
                }
            return true;
            }

            static Aluno ProcurarAlunoPorNome(string nomeAluno, Aluno[] alunos){
                foreach (Aluno item in alunos){
                    if(item != null && nomeAluno.Equals(item.Nome)){
                        return item;
                    }
                }
                return null;
            }

            static Sala ProcurarSalaPorNumero(int numeroSala, Sala[] salas){
                foreach (Sala item in salas){
                    if(item != null && numeroSala.Equals(item.NumeroSala)){
                        return item;
                    }
                }
                return null;
            }
    }
}

