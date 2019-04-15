using System;
namespace ex33OOex2alunos
{
    public class Aluno
    {
        string nome;
        public void setNome(string nome){
            this.nome = nome;
        }
        public void getNome(){
            return this.nome;
        }
        DateTime dataNascimento;
        public void setData(DateTime dataNascimento){
            this.dataNascimento = dataNascimento;
        }
        public void getData(){
            return this.dataNascimento;
        }

        string curso;
        public void setCurso(string curso){
            this.curso = curso;
        }
        public void getCurso(){
            return this.curso;
        }

        public int numeroSala;
        public void setnumeroSala(int numeroSala){
            this.numeroSala = numeroSala;
        }
        public void getnumeroSala(){
            return this.numeroSala;
        }
    }
}