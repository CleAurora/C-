using System;
using System.Collections.Generic;
using ex37Kanban.ViewModel;

namespace ex37Kanban.Repositorio
{
    public class UsuarioRepositorio
    {
        static List<UsuarioViewModel> listaDeUsuarios = new List<ViewModel.UsuarioViewModel> ();
        public UsuarioViewModel Inserir (UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count +1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add (usuario);
            return usuario;
        }
        public static List<UsuarioViewModel> Listar(){
            return listaDeUsuarios;
        }

        public UsuarioViewModel BuscarUsuario(string email, string senha){
            foreach (var item in listaDeUsuarios){
                if (email.Equals(item.Email) && senha.Equals(item.Senha)){
                    return item;
                }
            }
            return null;
        }
    }
}