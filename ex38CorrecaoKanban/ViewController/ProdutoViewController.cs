using System;
using System.Collections.Generic;
using ex38CorrecaoKanban.Repositorio;
using ex38CorrecaoKanban.ViewModel;

namespace ex38CorrecaoKanban.ViewController
{
    public class ProdutoViewController
    {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto(UsuarioViewModel usuario){
            string nome, descricao, categoria;
            float preco;

            System.Console.WriteLine("Digite o nome do produto");
            nome = Console.ReadLine();

            System.Console.WriteLine("Digite a descrição do Produto:");
            descricao = Console.ReadLine();
            
            System.Console.WriteLine("Digite a Categoria");
            categoria = Console.ReadLine();
            
            System.Console.WriteLine("Digite o preço: ");
            preco = float.Parse(Console.ReadLine());

            ProdutoViewModel produto = new ProdutoViewModel();

            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Descricao = descricao;
            produto.Preco = preco;
            produto.IdResponsavel = usuario.Id;

            produtoRepositorio.Inserir(produto);

            System.Console.WriteLine("Produto Cadastrado com sucesso! Você é demais!!");

            
            
        }//fim cadastrar produto

        public static void Listar(){
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();

            foreach (var item in listaDeProdutos){
                System.Console.WriteLine($"ID: {item.Nome} - Criador: {item.IdResponsavel}");
            }

        }
    }
}