using System;
using System.Collections.Generic;
using ex38CorrecaoKanban.Repositorio;
using ex38CorrecaoKanban.Utils;
using ex38CorrecaoKanban.ViewModel;

namespace ex38CorrecaoKanban.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmacaoSenha;

            do{
                System.Console.WriteLine("Digite o nome do usuário");
                nome = Console.ReadLine();
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }
            }while(string.IsNullOrEmpty(nome));

            do{
                System.Console.WriteLine("Digite o E-mail do usuário");
                email = Console.ReadLine();
                if(!ValidacaoUtil.ValidacaoEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }
            }while(!ValidacaoUtil.ValidacaoEmail(email));

            do{
                System.Console.WriteLine("Digite a Senha a ser cadastrada");
                senha = Console.ReadLine();
                
                System.Console.WriteLine("Digite nonvamente a senha");
                confirmacaoSenha = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidacaoSenha(senha, confirmacaoSenha)){
                    System.Console.WriteLine("Senha Inválida");
                }

            }while(!ValidacaoUtil.ValidacaoSenha(senha,confirmacaoSenha));

            UsuarioViewModel usuario = new UsuarioViewModel();//representa um objeto da classe ViewModel

            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;

            usuarioRepositorio.Inserir(usuario);

            System.Console.WriteLine("Cadastro efetuado com sucesso");


        }//fim Cadastrar usuário

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios){
                System.Console.WriteLine($"ID {item.Id} - Nome {item.Nome} - E-mail: {item.Email} - Senha: {item.Senha} - Data da Criação: {item.DataCriacao}");
            }//fim foreach
            
        }//fim listar usuário

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;

            System.Console.WriteLine("Digite seu e-mail");
            email = Console.ReadLine();
            
            System.Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);

            if(usuarioRecuperado != null) {
                return usuarioRecuperado;
            }

            System.Console.WriteLine("Usuário ou Senha Inválidas");
            return null;
        }// fim EfetuarLogin

        

    }// fim public class
}//fim namespace