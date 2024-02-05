for (var num = 1; num <= 10; num++)
{
    Console.WriteLine(@$"A tabuada do numero {num} é: ");
    for (var fator = 1; fator <= 10; fator++)
    {
        Console.WriteLine($"{num} . {fator} = {num * fator}");
    }
}