using System;
using System.Collections.Generic;
using System.IO;
using ex40pqnaorodaaqui.ViewModel;

namespace ex40pqnaorodaaqui.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            int contador = 0;
            if (listaDeUsuarios != null){
                contador = listaDeUsuarios.Count;
            }

            usuario.Id = contador +1;
            
            //Gera um arquivo CSV

            StreamWriter sw = new StreamWriter("usuarios.csv", true);
            sw.WriteLine($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.DataNascimento};{usuario.Senha}");

            sw.Close();
            return usuario;
        }//Fim inserir

        public List<UsuarioViewModel>Listar(){
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();

            UsuarioViewModel usuario;

            if(!File.Exists("usuarios.csv")){
                return null;
            }
            string[] usuarios = File.ReadAllLines("usuarios.csv");

            foreach (var item in usuarios){
                if (item!=null){
                    string[] dadosDoUsuario = item.Split(";");
                    usuario = new UsuarioViewModel();
                    usuario.Id = int.Parse(dadosDoUsuario[0]);
                    usuario.Nome = dadosDoUsuario[1];
                    usuario.Email = dadosDoUsuario[2];
                    usuario.DataNascimento = DateTime.Parse(dadosDoUsuario[3]);
                    usuario.Senha = dadosDoUsuario[4];

                    listaDeUsuarios.Add(usuario); 
                }
            }
            return listaDeUsuarios;
        }// fim listar

        public UsuarioViewModel BuscarUsuario(string email, string senha){

            List<UsuarioViewModel>listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios){

                if(email.Equals(item.Email) && senha.Equals(item.Senha)){
                    return item;
                }
            }
            return null;
            
        }//fim buscar usuario
    }
}