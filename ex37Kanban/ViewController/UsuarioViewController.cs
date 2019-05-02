using System;
using System.Collections.Generic;
using ex37Kanban.Repositorio;
using ex37Kanban.Utils;
using ex37Kanban.ViewModel;

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

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            usuarioRepositorio.Inserir(usuarioViewModel);
            System.Console.WriteLine("Usuário Cadstrado com sucesso");


        }//Fim do cadastro do usuário

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuario = usuarioRepositorio.Listar();

            foreach(var item in listaDeUsuario){
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - senha: {item.Senha} - Data Da Criação: {item.DataCriacao}");
            }
        }//Fim listar usuário

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do{
                System.Console.WriteLine("Digite o e-mail");
                email = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("E-mail invá");
                }
            }while(!ValidacaoUtil.ValidadorDeEmail(email));

            System.Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();
            
            UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario(email, senha);

            if (usuarioRetornado != null){
                return usuarioRetornado;
            }else{
                System.Console.WriteLine($"Usuário ou Senha inválida");
                return usuarioRetornado;
            }
        }//fim efetuar Login

    }
}