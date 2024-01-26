using projeto_console_mvc.Controller;
using projeto_console_mvc.Model;

Produto p = new Produto();

ProdutoController controller = new ProdutoController();

controller.CadastrarProduto();

//chamada do metodo controlador
controller.ListarProdutos();