Console.WriteLine("Digite o primeiro número: ");
float num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
float num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
float num3 = float.Parse(Console.ReadLine());

float maior = num1;
float menor = num1;

if (num2 > maior)
{
    maior = num2;

}

if (num3 > maior)
{
    maior = num3;

}



if (num2 < menor)
{
    menor = num2;

}

if (num3 < menor)
{
    menor = num3;
    
}

Console.WriteLine($"O maior numero é o {maior}, e o menor numero é o {menor}");
