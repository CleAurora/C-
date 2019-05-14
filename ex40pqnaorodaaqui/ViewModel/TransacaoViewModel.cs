using System;

namespace ex40pqnaorodaaqui.ViewModel
{
    public class TransacaoViewModel : BaseViewModel 
    {
        public string Tipo {get; set;}
        public string Descricao {get; set;}
        public DateTime Data {get; set;}
        public float Valor {get; set;}
        public string IdUsuario {get; set;}
    }
}