int classificacao = 0;



Console.WriteLine("Você telefonou para a vítima? Responda S para sim e N para não.");
ConsoleKeyInfo resposta = Console.ReadKey();

if (resposta.Key.ToString().ToUpper() == "S")
{
    classificacao++;

}
else if (resposta.Key.ToString().ToUpper() != "N")
{
    Console.WriteLine($"{Environment.NewLine}Você inseriu um valor incorreto.");
    Environment.Exit(0);

}



Console.WriteLine($"{Environment.NewLine}Esteve no local do crime?");
resposta = Console.ReadKey();

if (resposta.Key.ToString().ToUpper() == "S")
{
    classificacao++;

}
else if (resposta.Key.ToString().ToUpper() != "N")
{
    Console.WriteLine($"{Environment.NewLine}Você inseriu um valor incorreto.");
    Environment.Exit(0);

}



Console.WriteLine($"{Environment.NewLine}Mora perto da vítima?");
resposta = Console.ReadKey();

if (resposta.Key.ToString().ToUpper() == "S")
{
    classificacao++;

}
else if (resposta.Key.ToString().ToUpper() != "N")
{
    Console.WriteLine($"{Environment.NewLine}Você inseriu um valor incorreto.");
    Environment.Exit(0);

}



Console.WriteLine($"{Environment.NewLine}Devia para a vítima?");
resposta = Console.ReadKey();

if (resposta.Key.ToString().ToUpper() == "S")
{
    classificacao++;

}
else if (resposta.Key.ToString().ToUpper() != "N")
{
    Console.WriteLine($"{Environment.NewLine}Você inseriu um valor incorreto.");
    Environment.Exit(0);

}



Console.WriteLine($"{Environment.NewLine}Já trabalhou com a vítima?");
resposta = Console.ReadKey();

if (resposta.Key.ToString().ToUpper() == "S")
{
    classificacao++;

}
else if (resposta.Key.ToString().ToUpper() != "N")
{
    Console.WriteLine($"{Environment.NewLine}Você inseriu um valor incorreto.");
    Environment.Exit(0);

}



Console.WriteLine($"{Environment.NewLine}");

switch (classificacao)
{
    case 0 or 1:
        Console.WriteLine($"A pessoa é inocente.");
        break;
    case 2:
        Console.WriteLine($"A pessoa é suspeita.");
        break;
    case 3 or 4:
        Console.WriteLine($"A pessoa é cúmplice.");
        break;
    case 5:
        Console.WriteLine($"A pessoa é culpada.");
        break;

}
