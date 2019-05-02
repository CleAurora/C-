using System;
namespace ex37extra.ViewModel
{
    public class TarefaViewModel : BaseViewModel
    {
        public string Descricao {get; set;}
        public TipoTarefa Tipo {get; set;}
        public string IdUsuario {get; set;}

    }
}