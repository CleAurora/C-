using System;

namespace ex34correcaoalunos
{
    public class Sala
    {
        public int NumeroSala {get; private set;}//quando o set é privado, você tem um atributo que pertence à uma classe, vc tem um construtorcom parâmetro definido, mas dentro desse atributo, vc pode criar um método que altera o seu atributo (ou alguma característica da sala)
        public int CapacidadeAtual {get; private set;}
        public int CapacidadeTotal {get;}
        public Aluno[] Alunos {get;}


        public Sala(int numeroSala, int capacidadeTotal){
            this.NumeroSala = numeroSala;
            this.CapacidadeTotal = capacidadeTotal;
            this.CapacidadeAtual = capacidadeTotal;
            this.Alunos = new Aluno[capacidadeTotal];
        }
        public bool AlocarAluno ( Aluno aluno,out string mensagem){
            if(CapacidadeAtual > 0){
                CapacidadeAtual--;
                for (int i = 0; i<Alunos.Length; i++){
                    if(Alunos[i] == null){
                        Alunos[i] = aluno;
                        mensagem = $"Aluno(a) {aluno.Nome} alocado com sucesso!";
                        return true; 
                    }
                }    
            }
            mensagem = $"Capacidade da sala {NumeroSala} excedida!";
            return false;
        }

        
        public bool RemoverAluno(string nomeAluno, out string mensagem){
            if(this.CapacidadeAtual <= 0){
                for (int i = 0; i < Alunos.Length; i++){
                    if(Alunos[i] != null && nomeAluno.Equals(Alunos[i])){
                        Alunos[i] = null;
                        CapacidadeAtual ++;
                        mensagem = $"Aluno(a) {nomeAluno} removido com sucesso!";
                        return true;
                    }
                }
                
            } 
            mensagem = $"Não foi possível remover o aluno(a) {nomeAluno}";
            return false;
            
        }
    }
}