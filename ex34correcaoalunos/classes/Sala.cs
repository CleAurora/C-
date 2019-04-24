using System;

namespace ex34correcaoalunos
{
    public class Sala
    {
        public int NumeroSala {get; set;}
        public int CapacidadeAtual {get; set;}
        public int CapacidadeTotal {get; set;}
        public string[] Alunos {get; set;}

        public string AlocarAluno (string nomeAluno){
            if(CapacidadeAtual!=0){
                
                CapacidadeAtual--;
                Alunos[CapacidadeAtual] = nomeAluno;
                return $"Aluno(a) {nomeAluno} cadastrado com sucesso!"; // não declarei meu public como void, mas como string, assim não preciso do cw; e essa mensagem é o que vai retornar pro meu usuário.
            }else{
                return "Limite excedido";
            }
        }

        
        public string RemoverAluno(string nomeAluno){
           for (int i = 0; i < Alunos.Length; i++){
               if(Alunos[i] != null && nomeAluno.Equals(Alunos[i])){
                   Alunos[i] = null;
                   CapacidadeAtual ++;
                   return $"Aluno(a) {nomeAluno} removido com sucesso!";
               }
           }
           return $"Não foi possível remover o aluno(a) {nomeAluno}";
                
            
        }
    }
}