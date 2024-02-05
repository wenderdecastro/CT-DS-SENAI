Console.WriteLine($"Insira a medida do primeiro lado:");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a medida do segundo lado:");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a medida do terceiro lado:");
int lado3 = int.Parse(Console.ReadLine());


if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"O triângulo é equilátero! Ele possui todos os lados iguais.");
}
else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
{
    Console.WriteLine($"O triângulo é isósceles! Ele possui ao menos 2 lados iguais.");
}
else
{
    Console.WriteLine($"O triangulo é escaleno! Todos os seus lados são diferentes");
}