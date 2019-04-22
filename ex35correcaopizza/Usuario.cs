using System;
namespace ex35correcaopizza {
    public class Usuario {

        static Usuario[] ArrayDeUsuarios = new Usuario[1000];
        static int contador = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DateTime DataCriacao { get; set; }

        public static void Inserir () {
            string nome;
            string email;
            string senha;

            System.Console.WriteLine ("Digite o nome do Usuário");
            nome = Console.ReadLine ();

            //bool validador = true;

            //Validar email
            do {
                System.Console.WriteLine ("Digite Email");
                email = Console.ReadLine ();
                if (!email.Contains ("@") || !email.Contains (".")) {
                    System.Console.WriteLine ("Email inválido");
                    //validador = false;
                }

            } while (!email.Contains ("@") || !email.Contains ("."));

            //validar senha
            do {
                Console.WriteLine ("Digite a Senha:");
                senha = Console.ReadLine ();

                if (senha.Length < 6) {
                    System.Console.WriteLine ("Senha Inválida");
                }

            } while (senha.Length < 6);
            //Efetuar o registro

            Usuario user = new Usuario ();
            user.Id = contador + 1;
            user.Nome = nome;
            user.Email = email;
            user.Senha = senha;
            user.DataCriacao = DateTime.Now;

            ArrayDeUsuarios[contador] = user;
            contador++;

        } // fim inserir

        public static void EfetuarLogin () {
            string email;
            string senha;

            System.Console.WriteLine ($"Digite o emal");
            email = Console.ReadLine ();

            System.Console.WriteLine ("Digite a senha");
            senha = Console.ReadLine ();

            foreach (var item in ArrayDeUsuarios) {
                if (email.Equals (item.Email) && senha.Equals (item.Senha)) {
                    Console.WriteLine ("Bem vindo a matrix");

                } else {
                    System.Console.WriteLine ("Email ou senha invalidos");
                }
            }
        }

        public static void ListarUsuario () {
            foreach (var item in ArrayDeUsuarios) {
                if (item != null) {
                    System.Console.WriteLine ($"ID: {item.Id} nome: {item.Nome}");
                }

            }
        }

    }
}