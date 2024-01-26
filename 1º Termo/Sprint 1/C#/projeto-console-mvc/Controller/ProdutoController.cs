using projeto_console_mvc.Model;
using projeto_console_mvc.View;

namespace projeto_console_mvc.Controller
{
    public class ProdutoController
    {
        //instanciar objeto produto e produto view
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //listas de produtos chamada pela model
            List<Produto> produtos = produto.Ler();
            //chamada do metodo de exibição(View) recebendo como argumento a lista <Produto> produtos
            produtoView.Listar(produtos);
        }
        //metodo controller para acessar o cadastro de produto
        public void CadastrarProduto()
        {
            //chamada para a view que recebe cada objeto a ser inserido no csv
          Produto novoProduto= produtoView.Cadastrar();
          //chamada para a model para inserir esse objeto no csv
          produto.Inserir(novoProduto);
        }
    }
}