using System;
using System.Collections.Generic;
using System.IO;
using ex40pqnaorodaaqui.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;

namespace ex40pqnaorodaaqui.Repositorio {
    public class TransacaoRepositorio {
        public TransacaoViewModel Inserir (TransacaoViewModel transacao) {

            List<TransacaoViewModel> listaDeTransacoes = Listar ();
            int contador = 0;
            if (listaDeTransacoes != null) {
                contador = listaDeTransacoes.Count;
            }
            transacao.Id = contador + 1;
            transacao.Data = DateTime.Now;

            StreamWriter sw = new StreamWriter ("transacoes.csv", true);
            sw.WriteLine ($"{transacao.Id};{transacao.Tipo};{transacao.Descricao};{transacao.Data};{transacao.Valor}");

            sw.Close ();

            return transacao;

        } // fim inserir transacao

        public List<TransacaoViewModel> Listar () {
            List<TransacaoViewModel> listaDeTransacoes = new List<TransacaoViewModel> ();
            TransacaoViewModel transacao;
            if (!File.Exists ("transacoes.csv")) {
                return null;
            }
            string[] transacoes = File.ReadAllLines ("transacoes.csv");

            foreach (var item in transacoes) {
                string[] dadosDasTransacoes = item.Split (";");
                transacao = new TransacaoViewModel ();
                transacao.Id = int.Parse (dadosDasTransacoes[0]);
                transacao.Tipo = dadosDasTransacoes[1];
                transacao.Descricao = dadosDasTransacoes[2];
                transacao.Data = DateTime.Parse (dadosDasTransacoes[3]);
                transacao.Valor = float.Parse (dadosDasTransacoes[4]);
                listaDeTransacoes.Add (transacao);
            }
            return listaDeTransacoes;
        } //fim listar


        //nuget galery - me deu o seguinte código: dotnet add package Spire.Doc --version 7.5.1
        //colei esse código no meu terminal
        public  void CriarArquivo(){
            Document documentoWord = new Document();//instanciando meu objeto em word
            Paragraph paragrafo = documentoWord.AddSection().AddParagraph();

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            var listaUser = usuarioRepositorio.Listar();
            foreach (var item in listaUser){
                System.Console.WriteLine($"Nome: {item.Nome} - E-mail: {item.Email} Seenha{item.Senha}");
                //paragrafo.AppendText
            }

            var lista = Listar();
            foreach (var item in lista){
                paragrafo.AppendText($"ID: {item.Id} - Tipo: {item.Tipo} - Descrição:{item.Descricao} - Valor: {item.Valor} - Data de Criação: {item.Data}");
            }


            documentoWord.SaveToFile("Teste.docx");
        }


    }
}