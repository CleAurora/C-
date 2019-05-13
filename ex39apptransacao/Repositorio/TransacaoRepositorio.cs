using System;
using System.Collections.Generic;
using System.IO;

namespace ex39apptransacao.Repositorio
{
    public class TransacaoRepositorio
    {
        public TransacaoViewModel Inserir(TransacaoViewModel transacao){
            
            List<TransacaoViewModel> listaDeTransacoes = Listar();
            int contador = 0;
            if(listaDeTransacoes != null){
                contador = listaDeTransacoes.Count;
            }
            transacao.Id = contador + 1;
            transacao.Data = DateTime.Now;

            StreamWriter sw = new StreamWriter("produtos.csv", true);
            sw.WriteLine($"{transacao.Id};{transacao.Tipo};{transacao.Descricao};{transacao.Data};{transacao.Valor}");

            sw.Close();

            return transacao;

        }// fim inserir transacao


    }
}

