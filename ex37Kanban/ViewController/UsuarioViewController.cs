using System;
using ex37Kanban.Utils;

namespace ex37Kanban.ViewController
{
    public class UsuarioViewController
    {
        // Instanciar um repositorio
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        // public static ValidacoesUtil { get; private set; }

        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha;

            do{
                System.Console.WriteLine("Digite o nome do usuário");
                nome = Console.ReadLine();

                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }
                
            }while(string.IsNullOrEmpty(nome));

            do{
                System.Console.WriteLine("Digite o seu e-mail: ");
                email = Console.ReadLine();

                if(!ValidacaoUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("E-mail Inválido");
                }
                
            }while(!ValidacaoUtil.ValidadorDeEmail(email));

            do{
                System.Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
                
                System.Console.WriteLine("Confirme a senha");
                confirmaSenha = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidadorDeSenha(senha, confirmaSenha)){
                    System.Console.WriteLine("Senha Inválida");
                }
            }while(!ValidacaoUtil.ValidadorDeSenha(senha, confirmaSenha));


        }

    }
}