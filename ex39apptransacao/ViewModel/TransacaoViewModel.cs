using System;

namespace ex39apptransacao.ViewModel
{
    public class TansacaoViewModel : BaseViewModel
    {
        public string Tipo {get; set;}
        public string Descricao {get; set;}
        public DateTime Data {get; set;}
        public float Valor {get; set;}
    }//fim public class
}// fim namespace