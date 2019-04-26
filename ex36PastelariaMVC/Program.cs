using System;
using ex36PastelariaMVC.ViewModel;

namespace ex36PastelariaMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Id = 1;
            usuario.Nome = "Carlos";
            usuario.DataCriacao = DateTime.Now;

            ProdutoViewModel produto = new ProdutoViewModel();
            produto.Id = 1;
            produto.Nome = "Paxtel de Flango";
            usuario.DataCriacao = DateTime.Now;
        }
    }
}
