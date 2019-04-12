using System;

namespace ex31TsukaairlineOO
{
    public class Passageiro
    {
        string nome;
        int numeroPassagem;
        DateTime data;

        public void setNome(string nome){//produzi o atributo nome
            this.nome = nome;
        }

        public string getNome(){//get - retornei esse atributo pra mim
            return this.nome;
        }



    }
}