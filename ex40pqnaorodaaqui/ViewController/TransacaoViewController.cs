using System;
using System.Collections.Generic;
using ex40pqnaorodaaqui.Repositorio;
using ex40pqnaorodaaqui.Utils;
using ex40pqnaorodaaqui.ViewModel;

namespace ex40pqnaorodaaqui.ViewController
{
    public class TransacaoViewController
    {
        static TransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();
        // Cadastrar transação

        public static void CadastrarTransacao(UsuarioViewModel usuario){
            string tipo = "", descricao;
            float valor;
            int opcaoTipo;


            do{
                MenuUtil.TipoTransacao();
                opcaoTipo = int.Parse(Console.ReadLine());

                switch (opcaoTipo){
                    case 1:
                        //Despesa
                        tipo = "Despesa";
                    break;

                    case 2:
                        //Receita
                        tipo = "Receita";
                    break;
                    
                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break;
                }
            }while(opcaoTipo<1 || opcaoTipo>2);
            

            System.Console.WriteLine("Descreva sua transação");
            descricao = Console.ReadLine();

            System.Console.WriteLine("Digite o valor da transação:");
            valor = float.Parse(Console.ReadLine());

            TransacaoViewModel transacao = new TransacaoViewModel();
        
            transacao.Tipo = tipo;
            transacao.Descricao = descricao;
            transacao.Valor = valor;
            transacao.IdUsuario = usuario.Nome;

            transacaoRepositorio.Inserir(transacao);
            transacaoRepositorio.CriarArquivo();//estou criando / substituindo meu arquivo de word
            

            System.Console.WriteLine("Transação efetuada com sucesso");


        }//fim cadastrar transação

        public static void Listar(UsuarioViewModel usuario){

            //UsuarioViewModel us = new UsuarioViewModel();
            List<TransacaoViewModel> listaDeTransacoes = transacaoRepositorio.Listar();


            foreach (var item in listaDeTransacoes){
                if (usuario.Nome.Equals(item.IdUsuario)){

                    System.Console.WriteLine($"Responsável pela Transação: {usuario.Nome} ID: {item.Id} - Tipo: {item.Tipo} - Descrição:{item.Descricao} - Valor: {item.Valor} - Data de Criação: {item.Data}");
                }

            }
        }//fim listar
    }
}