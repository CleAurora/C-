using System;
using System.Collections.Generic;
using ex40pqnaorodaaqui.Repositorio;
using ex40pqnaorodaaqui.Utils;
using ex40pqnaorodaaqui.ViewModel;

namespace ex40pqnaorodaaqui.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario(){
            string nome, email, senha, confimaSenha;
            DateTime dataNascimento;

            do{
                System.Console.WriteLine("Digite o nome do Usuário: ");
                nome = Console.ReadLine();
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }//fim if
            }while(string.IsNullOrEmpty(nome));

            do{
                System.Console.WriteLine("Digite o e-mail do usuário:");
                email = Console.ReadLine();
                if(!ValidacaoUtil.ValidacaoEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }//fim if
            }while(!ValidacaoUtil.ValidacaoEmail(email));

            System.Console.WriteLine("Digite a data de Nascimento");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            do{
                System.Console.WriteLine("Digite a Senha a ser cadastrada");
                senha = Console.ReadLine();
                
                System.Console.WriteLine("Digite novamente a senha");
                confimaSenha = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidacaoSenha(senha, confimaSenha)){
                    System.Console.WriteLine("Senha Inválida");
                }//fim if

            }while(!ValidacaoUtil.ValidacaoSenha(senha, confimaSenha));

            UsuarioViewModel usuario = new UsuarioViewModel();

            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataNascimento = dataNascimento;

            usuarioRepositorio.Inserir(usuario);

            System.Console.WriteLine("Usuário cadastrado com sucesso!");

        }//Fim Cadastrar Usuário

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios){
                System.Console.WriteLine($"ID{item.Id} - Nome: {item.Nome} E-mail: {item.Email} - Senha: {item.Senha} - Data de Nascimento: {item.DataNascimento}");
            }
            
        }// fim Listar

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;

            System.Console.WriteLine("Digite seu e-mail");
            email = Console.ReadLine();
            
            System.Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);

            if(usuarioRecuperado != null){
                return usuarioRecuperado;
            }

            System.Console.WriteLine("Usuario ou senha inválidas");
            return null;

        }// fim efetuar login
    }
}