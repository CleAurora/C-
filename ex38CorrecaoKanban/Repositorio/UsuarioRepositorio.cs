using System;
using System.Collections.Generic;
using System.IO;
using ex38CorrecaoKanban.ViewModel;

namespace ex38CorrecaoKanban.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            int contador = 0;
            if(listaDeUsuarios != null){
                contador = listaDeUsuarios.Count;
            }
            
            usuario.Id = contador + 1;
            usuario.DataCriacao = DateTime.Now;

            //Gera um arquivo CSV

            StreamWriter sw = new StreamWriter("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}"); //estou escrevendo essa linha no sw

            sw.Close();

            return usuario;

        }//Fim inserir

        public List<UsuarioViewModel> Listar(){
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();

            UsuarioViewModel usuario;//só declarei, não instancieu meu objeti viewmodel

            if(!File.Exists("usuarios.csv")){
                return null;
            }
            string[] usuarios = File.ReadAllLines("usuarios.csv");//pedindo para ler todas as linhas do arquivo

            foreach (var item in usuarios){
                if(item!= null){

                    string[] dadosDoUsuario = item.Split(";"); //separando minha string a cada ponto e vírgula. Armazena ele num array de string
                    usuario = new UsuarioViewModel();
                    usuario.Id = int.Parse(dadosDoUsuario[0]);
                    usuario.Nome = dadosDoUsuario[1];
                    usuario.Email = dadosDoUsuario[2];
                    usuario.Senha = dadosDoUsuario[3];
                    usuario.DataCriacao = DateTime.Parse(dadosDoUsuario[4]);

                    listaDeUsuarios.Add(usuario);
                }//fim if null
            }//fim foeach

            return listaDeUsuarios;
        }//fim listar

        public UsuarioViewModel BuscarUsuario(string email, string senha){
            
            List<UsuarioViewModel> listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios){

                if(email.Equals(item.Email) && senha.Equals(item.Senha)){
                    return item;
                }//fim if validador email e senha
                
            }// fim foreach

            return null;
        }//fim BuscarUsuario


    }//fim public class
}//fim namespace