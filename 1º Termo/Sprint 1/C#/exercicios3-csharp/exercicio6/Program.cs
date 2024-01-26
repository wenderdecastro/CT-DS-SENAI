string[] nomes = new string[10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Insira um nome");
    nomes[i] = Console.ReadLine();

}

Console.WriteLine($"agora, insira o nome a ser procurado: ");
string busca = Console.ReadLine();

if (nomes.Contains(busca))
{
    Console.WriteLine($"ACHEI");

}
else
{
    Console.WriteLine($"NÃO ACHEI");

}

