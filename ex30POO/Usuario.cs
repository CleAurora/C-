using System;

namespace ex30POO
{
    class Usuario
    {
        string nome;
        string senha;
        string cpf;
        string email;

        // setter - padrão que o mercado adotou para colocar métodos de acesso
        // parametro - parse - recebe um parametro
        //por boas práticas coloco o nome do parametro igual ao do atributo ao qual ele está relacionado
        // o valor que chegar em senha, eu quero gravar na minha variável senha -- senha = valor que eu quero gravar nela
        //senha igual a senha é uma boa prática, mas confunde...
        // existe uma palavrinha que quando a gente coloca do lado, ele se refere - quero que vc grave o que veio no parâmetro (que mandaram pra mim) no objeto. Essa palavra é  "this" - para diferenciar a senha da senha de outra classe. se eu fizesse senha = this.senha, eu to colocando o senha lá de cima no parametro que recebi, ou seja, estou anulando o que eu recebi. Isso não me serve.
        public void setSenha(string senha){
             this.senha = senha;   
            
        }
        //getter - padrão para pegar senha. Se eu nao quero que ninguem pegue a senha, eu apago as linhas abaixo. Isso nao me interessa, pois preciso que ele entre com a senha.
        //tudo o que vc quer executar antes do return, você coloca antes dele.
        public string getSenha() {
            return this.senha;
        }

    }
}
