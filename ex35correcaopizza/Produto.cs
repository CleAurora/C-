using System;
namespace ex35correcaopizza
{
    public class Produto
    {
        static Produto [] ArrayDeProdutos = new Produto[100];
        static int contador = 0;
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public float Preco {get; set;}
        public string Categoria {get; set;}
        public DateTime DataCriacao {get; set;}


        public Produto(string nome, string descricao, string categoria, float preco){ //- quando instanciar meu metodo construtor, ele já pede todos esses atributos
            this.Nome = nome;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Preco = preco;
            this.Id = contador + 1;
            this.DataCriacao = DateTime.Now;
        }

        


        //inserir produto
        public static void InserirProduto(){
            string nome, descricao, categoria;
            float preco;
            

            System.Console.WriteLine("Digite o produto:");
            nome = Console.ReadLine();
            
            System.Console.WriteLine("Digite o preço deste produto: ");
            preco = float.Parse(Console.ReadLine());


            System.Console.WriteLine("Descreva o produto");
            descricao = Console.ReadLine();
            
            System.Console.WriteLine("Digite a Categoria do produto (pizza ou bebida):");
            categoria = Console.ReadLine();
            
            // Produto prod = new Produto ();
            // prod.Id = contador + 1;
            // prod.Nome = produto;
            // prod.Preco = preco;
            // prod.Descricao = descricao;
            // prod.Categoria = categoria;
            // prod.DataCriacao = DateTime.Now;
            //metodo construtor:
            Produto prod = new Produto(nome, descricao, categoria, preco);

            ArrayDeProdutos[contador] = prod;
            contador++;
            
        }// fim inserirproduto
        
        //listar produtos
        public static void ListarProduto(){

            foreach (var item in ArrayDeProdutos){
                if (item!=null){
                    System.Console.WriteLine($"ID: {item.Id}");
                    System.Console.WriteLine($"Produto: {item.Nome}");
                    System.Console.WriteLine($"Preço: {item.Preco}");
                    System.Console.WriteLine($"Categoria: {item.Categoria}");
                    System.Console.WriteLine($"Data da Criação: {item.DataCriacao}");
                }else{
                    break;
                }//fim if
            }
        }//fim listar produto

        //busca por Id

        public static void BuscaPorId(){
            int prodProcurado;

            System.Console.WriteLine("Digite o ID do Produto");
            prodProcurado = int.Parse(Console.ReadLine());

            foreach (var item in ArrayDeProdutos){
                if (item == null){
                    break;
                }
                if(item.Id == prodProcurado){
                    System.Console.WriteLine($"ID: {item.Id}");
                    System.Console.WriteLine($"Produto: {item.Nome}");
                    System.Console.WriteLine($"Preço: {item.Preco}");
                    System.Console.WriteLine($"Categoria: {item.Categoria}");
                    System.Console.WriteLine($"Data da Criação: {item.DataCriacao}");
                }
            }//fim foreach
            
        }//fim buscaporID

    }
}