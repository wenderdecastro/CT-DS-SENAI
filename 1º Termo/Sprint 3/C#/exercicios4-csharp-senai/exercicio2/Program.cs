bool loginValido = true;

do
{

    Console.WriteLine($"Insira o nome de usuário: ");
    string nome = Console.ReadLine();

    Console.WriteLine($"Insira a senha: ");
    string senha = Console.ReadLine();

    if (nome == senha)
    {
        loginValido = false;
        Console.WriteLine($"Você inseriu credenciais iguais. Insira-as novamente.");

    }

} while (loginValido == false);

Console.WriteLine($"Login efetuado com sucesso.");

