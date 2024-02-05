string[] nomeProduto = new string[10];
double[] precoProduto = new double[10];
bool[] produtoPromocao = new bool[10];
double[] precoPromocao = new double[10];
bool sair = false;
bool novoProduto = false;
bool validadorInput = false;
ConsoleKeyInfo input;
int produtoID = 0;

do
{
    Console.WriteLine(@$"

==================================
|     MENU                       |
==================================
|                                |
| (1) Cadastrar produto          |
| (2) Listar passagens           |
| (0) Sair                       |
|                                |
==================================

");

    MostrarMenu();

} while (sair == false);

bool MostrarMenu()
{

    input = Console.ReadKey();

    if (input.Key == ConsoleKey.D1)
    {
        CadastrarProduto();
        sair = false;
        return (sair);
    }
    else if (input.Key == ConsoleKey.D2)
    {
        if (produtoID > 0)
        {
            ListarProdutos();
        }
        else
        {
            Console.WriteLine($"\n\nNenhum produto cadastrado, cadastre um produto utilizando a opção 1 do menu.");
        }

        sair = false;
        return (sair);
    }
    else if (input.Key == ConsoleKey.D0)
    {
        Console.WriteLine($"\n\nSaindo do programa...");

        sair = true;
        return (sair);
    }
    else
    {
        Console.WriteLine($"\nOPÇÃO INVÁLIDA \n\nInsira uma opção válida!");
        sair = false;
        return (sair);
    }
}

void CadastrarProduto()
{
    do
    {
        do
        {
            Console.WriteLine($"\n\nDigite o nome do {produtoID + 1}º produto: \n");
            nomeProduto[produtoID] = Console.ReadLine();
        } while (nomeProduto[produtoID] == string.Empty);

        do
        {
            Console.WriteLine($"\nDigite o preço do {produtoID + 1}º produto: \n");
            precoProduto[produtoID] = double.Parse(Console.ReadLine());
        } while (precoProduto[produtoID] == null || precoProduto[produtoID].GetType() == typeof(string));

        produtoPromocao[produtoID] = Math.Round(precoProduto[produtoID]) > 10 ? true : false;

        if (produtoPromocao[produtoID])
        {
            precoPromocao[produtoID] = precoProduto[produtoID] - (precoProduto[produtoID] * 0.10);
        }
        else
        {
            precoPromocao[produtoID] = precoProduto[produtoID];
        }

        produtoID++;

        do
        {
            Console.WriteLine($"\nProduto cadastrado com sucesso. Deseja cadastrar algum mais? (S/N) \n");
            ConsoleKeyInfo opcaoNovoProduto = Console.ReadKey();

            switch (opcaoNovoProduto.Key)
            {
                case ConsoleKey.S:
                    novoProduto = true;
                    validadorInput = true;
                    break;
                case ConsoleKey.N:
                    novoProduto = false;
                    validadorInput = true;
                    break;
                default:
                    Console.WriteLine($"\nInsira uma alternativa válida (S/N)");
                    novoProduto = false;
                    validadorInput = false;
                    break;
            }

        } while (validadorInput == false);

    } while (novoProduto == true && produtoID < 3);
}

void ListarProdutos()
{

    Console.WriteLine($"\nForam cadastrados os seguintes produtos: ");

    for (var i = 0; i < produtoID; i++)
    {
        Console.WriteLine(@$"
        {i + 1} - Nome do produto: {nomeProduto[i]} Preço original: {precoProduto[i]:F2} Preço final: {precoPromocao[i]:F2} 
        ");
    }
}
