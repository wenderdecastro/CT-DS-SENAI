Console.WriteLine(@"
-------------------------------------------------
|             CARDÁPIO DE BEBIDAS               |
-------------------------------------------------
|     Pressione o numero da bebida desejada     |
-------------------------------------------------
|                                               |
|  1 - Água                                     |
|  2 - Refrigerante                             |
|  3 - Drink alcólico                           |
|  4 - Suco natural                             |
|                                               |
|  5 - Não desejo bebida                        |
|                                               |
-------------------------------------------------
");

ConsoleKeyInfo inputOpcao = Console.ReadKey();
string drink1 = "Água";
string drink2 = "Refrigerante";
string drink3 = "Drink alcólico";
string drink4 = "Suco natural";

string escolha = "Vidro";

switch (inputOpcao.Key)
{
    case ConsoleKey.D1:
        Console.WriteLine($"Você selecionou a opção {drink1}.");
        escolha = drink1;
        break;
    case ConsoleKey.D2:
        Console.WriteLine($"Você selecionou a opção {drink2}.");
        escolha = drink2;
        break;
    case ConsoleKey.D3:
        Console.WriteLine($"Você selecionou a opção {drink3}");
        escolha = drink3;
        break;
    case ConsoleKey.D4:
        Console.WriteLine($"Você selecionou a opção {drink4}");
        escolha = drink4;
        break;
    case ConsoleKey.D5:
        Console.WriteLine($"Tudo bem, tenha um bom dia.");
        Environment.Exit(0);
        break;
}

Console.WriteLine(@$"
-------------------------------------------------
|             CARDÁPIO DE BEBIDAS               |
-------------------------------------------------
|     Deseja adicionar gelo no seu copo de      |
|     {escolha}?                   
-------------------------------------------------
|                                               |
|  S - Sim                                      |
|  N - Não                                      |
|                                               |
-------------------------------------------------
");

ConsoleKeyInfo desejaGelo = Console.ReadKey();

switch (desejaGelo.Key)
{
    case ConsoleKey.S:
        Console.WriteLine($"Tudo bem, adicionaremos gelo no seu copo de {escolha}.");
        break;
    case ConsoleKey.N:
        Console.WriteLine($"Tudo bem, não adicionaremos gelo no seu copo de {escolha}.");
        break;
    default:
        Console.WriteLine($"Você não inseriu uma resposta válida, não adicionaremos gelo.");
        break;
}




