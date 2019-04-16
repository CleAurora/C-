namespace ex33OOex2alunos
{
    public class Sala
    {
       public int numeroSala {get; set;}
       public int capacidadeAtual{get; set;}
       public int capacidadeTotal {get; set;}
       public string[] alunos {get; set;} 

       public void Adicionar(string aluno){
           if(capacidadeAtual>capacidadeTotal){
               System.Console.WriteLine("Infelizmente não é possível realizar essa operação pois a sala já ultrapassou seu limite.");
           }else{
               alunos[capacidadeAtual] =  aluno;
               capacidadeAtual++;
           }
       }

       public void Remover(){
        //    foreach (string aluno in alunos){
        //        System.Console.WriteLine(aluno);
        //    }
           if (string aluno = alunos[i])
           capacidadeAtual--;

       }
    }
}