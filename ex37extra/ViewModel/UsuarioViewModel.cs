using System;
namespace ex37extra.ViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        public string Email {get; set;}
        public string Senha {get; set;}
        public TipoUsuario Tipo {get; set;}
    }
}