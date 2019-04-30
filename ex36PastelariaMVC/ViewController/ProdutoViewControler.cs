using System;
using System.Collections.Generic;
using ex36PastelariaMVC.Repositorio;
using ex36PastelariaMVC.ViewModel;

namespace ex36PastelariaMVC.ViewController
{
    public class ProdutoViewControler
    {
        //Instanciar um repositorio
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        //Cadastrar produto - nome, id, preço, tipo, descricao, dataCriacao, Listar Produtos e Buscar Produto por ID

        public static void CadastrarProduto(){
            string nomeProduto, tipo, descricao;
            float preco;

            do{
                System.Console.WriteLine("Digite o nome do produto");
                nomeProduto = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nomeProduto)){
                    System.Console.WriteLine("Nome inválido");
                }

            }while(string.IsNullOrEmpty(nomeProduto));

            System.Console.WriteLine("Digite o tipo do produto(pastel, salgado, bebida)");
            tipo = Console.ReadLine();

            System.Console.WriteLine("Descreva o produto");
            descricao = Console.ReadLine();
            
            System.Console.WriteLine("Digite o preço do produto ");
            preco = float.Parse(Console.ReadLine());

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Nome = nomeProduto;
            produtoViewModel.Categoria = tipo;
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Preco = preco;

            produtoRepositorio.Inserir(produtoViewModel);

            System.Console.WriteLine("Produto Cadastrado com sucesso!");

        }//Fim do cadastro do produto

        public static void ListarProdutos(){
            List<ProdutoViewModel> listaDeProduto = produtoRepositorio.Listar();

            foreach (var item in listaDeProduto){
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Descrição: {item.Descricao} - Tipo: {item.Categoria} - Preço: {item.Preco} - Data da Criação: {item.DataCriacao}");
            }
        }//Fim Listar Produto

        public static ProdutoViewModel BuscarProdutoPorId(){
            int id;
            
            System.Console.WriteLine("Digite o Id desejado");
            id = int.Parse(Console.ReadLine());

            ProdutoViewModel item = produtoRepositorio.BuscarProduto(id);

            if(item != null){
                System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Descrição: {item.Descricao} - Tipo: {item.Categoria} - Preço: {item.Preco} - Data da Criação: {item.DataCriacao}");
                return item;
            }else{
                System.Console.WriteLine($"Id Inválido");
                return item;
            }

            
        }

        
        
    }
}