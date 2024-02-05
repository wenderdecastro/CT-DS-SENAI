
Console.WriteLine($"Qual a pontuação do primeiro time?");
int pontuacao1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual a pontuação do segundo time?");
int pontuacao2 = int.Parse(Console.ReadLine());

if (pontuacao1 > pontuacao2)
{
    Console.WriteLine($"A vitória é do primeiro time!");

}
else if (pontuacao1 == pontuacao2)
{
    Console.WriteLine($"O resultado foi um empate!");

}
else
{
    Console.WriteLine($"A vitória é do segundo time!");

}
