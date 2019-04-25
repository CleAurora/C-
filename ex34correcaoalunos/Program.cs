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
            int salasCadastradas = 0;


            do{
                Console.ForegroundColor = ConsoleColor.Red;
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
                string mensagem = "";

                switch (codigo){
                    #region CADASTRAR_ALUNO
                    case 1:
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

                    #region CADASTRAR_SALA
                    case 2:

                        //Cadastrar Sala
                        if(limiteSalas != salasCadastradas){

                            System.Console.WriteLine("Digite o número da sala: ");
                            int numeroSalaCadastrar = int.Parse(Console.ReadLine());

                            System.Console.WriteLine("Digite a Capacidade total: ");
                            int CapacidadeTotalCadastrar = int.Parse(Console.ReadLine());

                            
                            Sala sala = new Sala(numeroSalaCadastrar, CapacidadeTotalCadastrar);

                            salas[salasCadastradas] = sala;
                            salasCadastradas++;
                           

                            MostrarMensagem($"Cadastro de {sala.GetType().Name} feito com sucesso!", TipoMensagemEnum.SUCESSO);
                            
                            
                        }else{
                            MostrarMensagem($"Total de Alunos foi excedido", TipoMensagemEnum.ALERTA);
                        }
                    break;
                    #endregion

                    #region ALOCAR_ALUNO
                    case 3:
                        ValidarAlocarOuRemover(contadorAluno, salasCadastradas);

                        //Aluno nomeAlunoAloc;
                        
                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoAloc = Console.ReadLine();
                        Aluno alunoRecuperado = ProcurarAlunoPorNome(nomeAlunoAloc, alunos);
                       
                        if (alunoRecuperado == null){
                            MostrarMensagem($"Não há aluno cadastrado com o nome{nomeAlunoAloc}", TipoMensagemEnum.ALERTA);
                            continue;
                        }


                        //para sala

                        System.Console.WriteLine("Digite o numero da sala");
                        int numeroSalaAloc = int.Parse(Console.ReadLine());
                        Sala salaRecuperada = ProcurarSalaPorNumero(numeroSalaAloc, salas);

                        if (salaRecuperada == null){
                            MostrarMensagem($"Não há sala cadastrada com o numero{numeroSalaAloc} ", TipoMensagemEnum.ALERTA);
                            continue;
                        }
                        
                        if(salaRecuperada.AlocarAluno(alunoRecuperado, out mensagem)){
                            MostrarMensagem(mensagem, TipoMensagemEnum.SUCESSO);
                        }else{
                            MostrarMensagem(mensagem, TipoMensagemEnum.ERRO);
                        }

                    break;
                    #endregion

                    #region REMOVER_ALUNO
                    case 4:
                        
                       ValidarAlocarOuRemover(contadorAluno, salasCadastradas);

                        //Aluno nomeAlunoAloc;

                        System.Console.WriteLine("Digite o nome do aluno");
                        string nomeAlunoRem = Console.ReadLine();
                        Aluno alunoRemover = ProcurarAlunoPorNome(nomeAlunoRem, alunos);

                        if (alunoRemover == null){

                            MostrarMensagem($"Não há aluno cadastrado com o nome {nomeAlunoRem}", TipoMensagemEnum.ALERTA);
                            continue; 

                     
                        }

                        //para sala

                        System.Console.WriteLine("Digite o numero da sala");
                        int numeroSalaRem = int.Parse(Console.ReadLine());
                        Sala salaRemover = ProcurarSalaPorNumero(numeroSalaRem, salas);

                        if (salaRemover == null){
                            MostrarMensagem($"Não há sala cadastrada com o nome {numeroSalaRem}", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        if(salaRemover.RemoverAluno(alunoRemover.Nome, out mensagem)){
                            MostrarMensagem(mensagem, TipoMensagemEnum.SUCESSO);
                        }else{
                            MostrarMensagem(mensagem, TipoMensagemEnum.ERRO);
                        }

                    break;
                    #endregion

                    #region LISTAR SALAS
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
                    #endregion

                    #region LISTAR_ALUNOS
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

