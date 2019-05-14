using System;
using System.Collections.Generic;
using System.IO;
using ex40pqnaorodaaqui.ViewModel;
using Spire.Doc;
using Spire.Doc.Documents;
using Ionic.Zip;

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
            sw.WriteLine ($"{transacao.IdUsuario};{transacao.Id};{transacao.Tipo};{transacao.Descricao};{transacao.Data};{transacao.Valor}");

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
                transacao.IdUsuario = dadosDasTransacoes[0];
                transacao.Id = int.Parse (dadosDasTransacoes[1]);
                transacao.Tipo = dadosDasTransacoes[2];
                transacao.Descricao = dadosDasTransacoes[3];
                transacao.Data = DateTime.Parse (dadosDasTransacoes[4]);
                transacao.Valor = float.Parse (dadosDasTransacoes[5]);
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
                paragrafo.AppendText($"Nome: {item.Nome} - E-mail: {item.Email} Seenha{item.Senha}");
                //paragrafo.AppendText
            }

            var lista = Listar();
            foreach (var item in lista){
                paragrafo.AppendText($"Responsavel pela Transação: {item.IdUsuario} ID: {item.Id} - Tipo: {item.Tipo} - Descrição:{item.Descricao} - Valor: {item.Valor} - Data de Criação: {item.Data}");
            }


            documentoWord.SaveToFile("Teste.docx");
        }
        //instalei a bibioteca de zip por meio desse link dado pelo nuget dotnet add package DotNetZip --version 1.13.3

        public void CriarZip(){
            ZipFile zip = new ZipFile();//instanciando meu arquivo de zip
            zip.AddFile("transacoes.csv");// adicionando arquivos a serem zipados
            zip.AddFile("usuarios.csv");
            zip.Save("banco_de_dados.zip");// slavando meu zip

        }


    }
}