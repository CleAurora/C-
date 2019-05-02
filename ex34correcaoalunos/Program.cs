using System;
using ex34correcaoalunos.enums;

namespace ex34correcaoalunos {
    class Program {
    enum MenuEnum : uint {
    CADASTRAR_ALUNO = 1,
    CADASTRAR_SALA,
    LISTAR_ALUNO,
    LISTAR_SALA,
    ALOCAR_ALUNO,
    REMOVER_ALUNO

    }
    

        static void Main (string[] args) {
            int limiteAlunos = 3;
            int limiteSalas = 2;
            bool sair = false;

            Aluno[] alunos = new Aluno[limiteAlunos];
            Sala[] salas = new Sala[limiteSalas];

            int contadorAluno = 0;
            int salasCadastradas = 0;

            do {
                Console.Clear ();
                #region MENU
                //HEADER

                string[] itensMenu = Enum.GetNames (typeof (MenuEnum));
                string barraMenu = "==================================";
                System.Console.WriteLine (barraMenu);
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine ("         **SENAIzinho**         ");
                Console.ResetColor ();
                System.Console.WriteLine ("||                            ||");
                System.Console.WriteLine ("||               ||");

                System.Console.WriteLine ("||============================||");
                //BODY

                for (int i = 0; i < itensMenu.Length; i++) {
                    string espacosFim = "";
                    string bordaLinha = "||";
                    string paragrafoInicio = "   ";
                    string separadorOpcao = " - ";

                    string nomeTratado = itensMenu[i].Replace ("_", " ").ToLower ();
                    nomeTratado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (nomeTratado);
                    int espacoDezena = i / 10;

                    string numeroOpcao = (i + 1).ToString ();

                    if (espacoDezena < 1) {
                        paragrafoInicio = paragrafoInicio + " ";
                    }

                    int qntdeEspacos = barraMenu.Length - (bordaLinha.Length * 2) - paragrafoInicio.Length - numeroOpcao.Length - separadorOpcao.Length - nomeTratado.Length;

                    for (int j = 0; j < qntdeEspacos; j++) {
                        espacosFim += " ";
                    }

                    System.Console.WriteLine ($"{bordaLinha}{paragrafoInicio}{numeroOpcao}{separadorOpcao}{nomeTratado}{espacosFim}{bordaLinha}");
                }

                //FOOTER
                System.Console.WriteLine (barraMenu);

                MenuEnum codigo = (MenuEnum) Enum.Parse (typeof (MenuEnum), Console.ReadLine ());

                string mensagem = "";
                //SAIR
                #endregion

                switch (codigo) {
                    #region CADASTRAR_ALUNO
                    case MenuEnum.CADASTRAR_ALUNO:
                        //Cadastrar Aluno

                        if (limiteAlunos != contadorAluno) {
                            Aluno a = new Aluno ();
                            System.Console.WriteLine ("Digite o nome do Aluno: ");
                            a.Nome = Console.ReadLine ();
                            System.Console.WriteLine ("Digite a data de Nascimento: ");
                            a.DataNascimento = DateTime.Parse (Console.ReadLine ());

                            a.Curso = ExibirMenuCursos ();

                            alunos[contadorAluno] = a;
                            contadorAluno++;

                            MostrarMensagem ($"Cadastro de {a.GetType().Name} feito com sucesso", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"Total de Alunos foi excedido", TipoMensagemEnum.ALERTA);
                        }
                        break;
                        #endregion

                        #region CADASTRAR_SALA
                    case MenuEnum.CADASTRAR_SALA:

                        //Cadastrar Sala
                        if (limiteSalas != salasCadastradas) {

                            System.Console.WriteLine ("Digite o número da sala: ");
                            int numeroSalaCadastrar = int.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Digite a Capacidade total: ");
                            int CapacidadeTotalCadastrar = int.Parse (Console.ReadLine ());

                            Sala sala = new Sala (numeroSalaCadastrar, CapacidadeTotalCadastrar);

                            salas[salasCadastradas] = sala;
                            salasCadastradas++;

                            MostrarMensagem ($"Cadastro de {sala.GetType().Name} feito com sucesso!", TipoMensagemEnum.SUCESSO);

                        } else {
                            MostrarMensagem ($"Total de Alunos foi excedido", TipoMensagemEnum.ALERTA);
                        }
                        break;
                        #endregion

                        #region ALOCAR_ALUNO
                    case MenuEnum.ALOCAR_ALUNO:
                        ValidarAlocarOuRemover (contadorAluno, salasCadastradas);

                        //Aluno nomeAlunoAloc;

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoAloc = Console.ReadLine ();
                        Aluno alunoRecuperado = ProcurarAlunoPorNome (nomeAlunoAloc, alunos);

                        if (alunoRecuperado == null) {
                            MostrarMensagem ($"Não há aluno cadastrado com o nome{nomeAlunoAloc}", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        //para sala

                        System.Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaAloc = int.Parse (Console.ReadLine ());
                        Sala salaRecuperada = ProcurarSalaPorNumero (numeroSalaAloc, salas);

                        if (salaRecuperada == null) {
                            MostrarMensagem ($"Não há sala cadastrada com o numero{numeroSalaAloc} ", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        if (salaRecuperada.AlocarAluno (alunoRecuperado, out mensagem)) {
                            MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem (mensagem, TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion

                        #region REMOVER_ALUNO
                    case MenuEnum.REMOVER_ALUNO:

                        ValidarAlocarOuRemover (contadorAluno, salasCadastradas);

                        //Aluno nomeAlunoAloc;

                        System.Console.WriteLine ("Digite o nome do aluno");
                        string nomeAlunoRem = Console.ReadLine ();
                        Aluno alunoRemover = ProcurarAlunoPorNome (nomeAlunoRem, alunos);

                        if (alunoRemover == null) {

                            MostrarMensagem ($"Não há aluno cadastrado com o nome {nomeAlunoRem}", TipoMensagemEnum.ALERTA);
                            continue;

                        }

                        //para sala

                        System.Console.WriteLine ("Digite o numero da sala");
                        int numeroSalaRem = int.Parse (Console.ReadLine ());
                        Sala salaRemover = ProcurarSalaPorNumero (numeroSalaRem, salas);

                        if (salaRemover == null) {
                            MostrarMensagem ($"Não há sala cadastrada com o nome {numeroSalaRem}", TipoMensagemEnum.ALERTA);
                            continue;
                        }

                        if (salaRemover.RemoverAluno (alunoRemover.Nome, out mensagem)) {
                            MostrarMensagem (mensagem, TipoMensagemEnum.SUCESSO);
                        } else {
                            MostrarMensagem (mensagem, TipoMensagemEnum.ERRO);
                        }

                        break;
                        #endregion

                        #region LISTAR SALAS
                    case MenuEnum.LISTAR_SALA:
                        //Listas salas
                        foreach (var item in salas) {
                            if (item != null) {
                                System.Console.WriteLine ("-------------------");
                                System.Console.WriteLine ($"Número da Sala: {item.NumeroSala}");
                                System.Console.WriteLine ($"Capacidade Total: {item.CapacidadeTotal}");
                                System.Console.WriteLine ($"Vagas Disponíveis: {item.CapacidadeAtual}");
                                System.Console.WriteLine ("-------------------");
                                System.Console.WriteLine ("Aperte enter para continuar!");
                            }
                        }
                        break;
                        #endregion

                        #region LISTAR_ALUNOS
                    case MenuEnum.LISTAR_ALUNO:
                        //Listar alunos
                        foreach (var item in alunos) {
                            if (item != null) {
                                System.Console.WriteLine ("------------------");
                                System.Console.WriteLine ($"Nome do Aluno: {item.Nome}");
                                System.Console.WriteLine ($"Data de Nascimento: {item.DataNascimento}");
                                System.Console.WriteLine ($"Nome do Curso: {item.Curso}");
                                System.Console.WriteLine ("------------------");
                                System.Console.WriteLine ("Aperte enter para continuar!");
                            }
                        }
                        break;
                        #endregion

                    default:
                        System.Console.WriteLine ("Entrada Inválida");
                        break;

                }
            } while (!sair);

        }

        static void MostrarMensagem (string mensagem, TipoMensagemEnum tipoMensagem) {

            switch (tipoMensagem) {
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

            System.Console.WriteLine (mensagem);
            Console.ResetColor ();

            System.Console.WriteLine ("Pressione ENTER para continuar");
            Console.ReadLine ();
        }

        static bool ValidarAlocarOuRemover (int alunosCadastrados, int salasCadastradas) {
            if (alunosCadastrados == 0) {
                MostrarMensagem ("Nenhum aluno cadastrado", TipoMensagemEnum.ALERTA);
                return false;
            } else if (salasCadastradas == 0) {
                MostrarMensagem ("Não há salas cadastradas", TipoMensagemEnum.ALERTA);
                return false;
            }
            return true;
        }

        static Aluno ProcurarAlunoPorNome (string nomeAluno, Aluno[] alunos) {
            foreach (Aluno item in alunos) {
                if (item != null && nomeAluno.Equals (item.Nome)) {
                    return item;
                }
            }
            return null;
        }

        static Sala ProcurarSalaPorNumero (int numeroSala, Sala[] salas) {
            foreach (Sala item in salas) {
                if (item != null && numeroSala.Equals (item.NumeroSala)) {
                    return item;
                }
            }
            return null;
        }

        static string ExibirMenuCursos () {

            string curso = "";
            bool cursoNaoEscolhido = false;
            do {

                System.Console.WriteLine ("======================================");
                System.Console.WriteLine ("||    Digite o código do Curso      ||");
                System.Console.WriteLine ("||    1. DESENVOLVIMENTO            ||");
                System.Console.WriteLine ("||    2. REDES                      ||");
                System.Console.WriteLine ("======================================");
                System.Console.Write ("Código: ");

                int codigoCurso = int.Parse (Console.ReadLine ());

                switch (codigoCurso) {
                    case 1:
                        curso = "DESENVOLVIMENTO";
                        cursoNaoEscolhido = false;
                        break;

                    case 2:
                        curso = "REDES";
                        cursoNaoEscolhido = false;
                        break;

                    default:
                        MostrarMensagem ("Esse código não existe!", TipoMensagemEnum.ERRO);
                        break;
                }

            } while (cursoNaoEscolhido);
            return curso;
        }
    }
}