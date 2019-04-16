using System;

namespace ex34correcaoalunos
{
    public class Sala
    {
        public int NumeroSala {get; set;}
        public int CapacidadeAtual {get; set;}
        public int CapacidadeTotal {get; set;}
        public string[] Alunos {get; set;}

        public int contadorAlunosAlocados = 0;
        public void Alocar (){
            if(CapacidadeAtual==0){
                System.Console.WriteLine("Limite excedido");
            }else{
                System.Console.WriteLine("Qual aluno a ser alocado?");
                Alunos[contadorAlunosAlocados] = Console.ReadLine();
                
                contadorAlunosAlocados++;
                CapacidadeAtual--;
            }
        }

        
        public void Remover(){
            int i = 0;
            foreach (string item in Alunos) {
                //System.Console.WriteLine(aluno);
                System.Console.WriteLine("Qual o nome a ser removido?");
                string nome = Console.ReadLine();
                
                if (nome.Equals(item)){
                Alunos[i] = "";
                CapacidadeAtual--;
                }
                i++;
                
            }
        }
    }
}