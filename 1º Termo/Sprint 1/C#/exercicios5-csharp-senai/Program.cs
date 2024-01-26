int indice = 0;
string usuarioAdmin = "admin";
string senhaAdmin = "admin";
string[] nomes = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];
bool encerrarPrograma = false;
bool novaPassagem = false;
bool validadorInput = false;
bool loginValido = false;

do
{

    Console.WriteLine("Insira o seu usuário: ");
    usuarioAdmin = Console.ReadLine();

    Console.WriteLine("Insira a sua senha: ");
    senhaAdmin = Console.ReadLine();

    if (usuarioAdmin != "admin" || senhaAdmin != "admin")
    {
        Console.WriteLine($"Senha ou usuário incorretos, insira-os novamente.");

    }
    else
    {
        loginValido = true;
    }
} while (loginValido == false);

do
{
    Console.WriteLine(@$"
==================================
|     MENU                       |
==================================
|                                |
| (1) Cadastrar passagens        |
| (2) Listar passagens           |
| (0) Sair                       |
|                                |
==================================
");

    ConsoleKeyInfo opcao = Console.ReadKey();


    switch (opcao.Key)
    {
        case ConsoleKey.D1:



            do
            {
                while (nomes[indice] == string.Empty)
                {
                    Console.WriteLine($"\n Digite o nome do {indice + 1}º Passageiro: ");
                    nomes[indice] = Console.ReadLine();
                }

                while (origem[indice] == string.Empty)
                {
                    Console.WriteLine($"\n Digite a origem do {indice + 1}º Passageiro: ");
                    origem[indice] = Console.ReadLine();
                }
                while (destino[indice] == string.Empty)
                {
                    Console.WriteLine($"\n Digite o destino do {indice + 1}º Passageiro: ");
                    destino[indice] = Console.ReadLine();
                }
                while (data[indice] == string.Empty)
                {
                    Console.WriteLine($"\n Digite a data de voo do {indice + 1}º Passageiro: ");
                    data[indice] = Console.ReadLine();
                }
                indice++;

                do
                {
                    Console.WriteLine($"\n Passageiro cadastrado com sucesso. Deseja cadastrar uma nova passagem? (S/N)");
                    ConsoleKeyInfo novaPassagemInput = Console.ReadKey();

                    switch (novaPassagemInput.Key)
                    {
                        case ConsoleKey.S:
                            novaPassagem = true;
                            validadorInput = true;
                            break;
                        case ConsoleKey.N:
                            novaPassagem = false;
                            validadorInput = true;
                            break;
                        default:
                            Console.WriteLine($"\n Insira uma alternativa válida (S/N)");
                            validadorInput = false;
                            novaPassagem = false;
                            break;
                    }

                } while (validadorInput == false);



            } while (novaPassagem == true && indice < 5);

            break;
        case ConsoleKey.D2:
            if (indice < 1)
            {
                Console.WriteLine($"\n Nenhum usuário cadastrado, Cadastre um usuario na opção 1 do menu.");

            }
            else
            {
                for (var i = 0; i < indice; i++)
                {
                    Console.WriteLine(@$"Foram cadastradas as seguintes passagens: 
        
        {i + 1} - Nome: {nomes[i]} Origem: {origem[i]} Destino: {destino[i]} Data: {data[i]}

        ");

                }
            }
            break;
        case ConsoleKey.D0:

            encerrarPrograma = true;

            break;
    }

} while (encerrarPrograma == false);