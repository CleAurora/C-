using System;
using System.Collections.Generic;
using ex36PastelariaMVC.Repositorio;
using ex36PastelariaMVC.Utils;
using ex36PastelariaMVC.ViewModel;

namespace ex36PastelariaMVC.ViewController
{
    public class UsuarioViewController
    {
        //Instanciar um repositório
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha;

            do{
                System.Console.WriteLine("Digite o nome do usuário");
                nome = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }

            }while (string.IsNullOrEmpty(nome));   

            do{
                System.Console.WriteLine("Digite o seu e-mail:");
                email = Console.ReadLine();
                if(!ValidacoesUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }
            } while(!ValidacoesUtil.ValidadorDeEmail(email));


            do{
                System.Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();

                System.Console.WriteLine("Confirme a senha");
                confirmaSenha = Console.ReadLine();

                if(!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha)){
                    System.Console.WriteLine("Senha inválida");
                }

            }while(!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha));    

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            
            usuarioRepositorio.Inserir(usuarioViewModel);

            System.Console.WriteLine("Usuário Cadastrado com sucesso");

        }//fim do cadastro do usuário

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuario = usuarioRepositorio.Listar();
        
            foreach (var item in listaDeUsuario){
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - E-mail: {item.Email} senha: {item.Senha} - Data Da criação: {item.DataCriacao} ");
            }
        }//fim Listar Usuário

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
            do{
                System.Console.WriteLine("Digite o e-mail");
                email = Console.ReadLine();
                
                if(!ValidacoesUtil.ValidadorDeEmail(email)){
                    System.Console.WriteLine("E-mail Inválido");

                }
            }while(!ValidacoesUtil.ValidadorDeEmail(email));

            System.Console.WriteLine("Digite a Senha:");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario(email, senha);
            
            if(usuarioRetornado != null){
                return usuarioRetornado;
            }else{
                System.Console.WriteLine($"Usuário ou Senha inválida");
                return usuarioRetornado;
            

        }//fim efetuar Login

    }
}
}