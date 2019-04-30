using System;
using System.Collections.Generic;
using ex36PastelariaMVC.ViewModel;

namespace ex36PastelariaMVC.Repositorio
{
    public class ProdutoRepositorio
    {
        
        static List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel> ();
        public ProdutoViewModel Inserir (ProdutoViewModel produto){
            produto.Id = listaDeProdutos.Count +1;
            produto.DataCriacao = DateTime.Now;

            listaDeProdutos.Add (produto);
            return produto;
        }
        public List<ProdutoViewModel> Listar(){
            return listaDeProdutos;
        }

        public ProdutoViewModel BuscarProduto(int id){
            foreach (var item in listaDeProdutos){
                if(id.Equals(item.Id)){
                    return item;
                }
            }
            return null;
        }
    }
}