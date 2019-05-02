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

        

        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha, opcaoTipos =" ";

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

            Utils.MenuUtil.MenuTipoUsuario();
            int opcaoTipoMenu = int.Parse(Console.ReadLine());
            
            do{
                switch (opcaoTipoMenu){
                    case 1:
                        opcaoTipos = "Usuário";
                    break;

                    case 2:
                        opcaoTipos = "Admin";
                    break;

                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break; 
                }
            }while(opcaoTipoMenu > 2 || opcaoTipoMenu < 0);

            

            do{
                System.Console.WriteLine("Digite a senha a ser cadastrada");
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
            usuarioViewModel.Tipo = opcaoTipos;

            usuarioRepositorio.Inserir(usuarioViewModel);
            System.Console.WriteLine("Usuário Cadstrado com sucesso");


        }//Fim do cadastro do usuário

        public static void ListarUsuario(UsuarioViewModel us){

            foreach (var item in UsuarioRepositorio.Listar()){
                if (us.Tipo.Equals("Adimin")){
                    System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - senha: {item.Senha} - Data Da Criação: {item.DataCriacao}");
                }else{
                    System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} ");
                }
                
        }//Fim listar usuário

}
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