int[] numeros = new int[10];

for (var i = 0; i < 10; i++)
{
Console.WriteLine("Insira um valor: ");
numeros[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine($"\n O maior valor da lista é: {numeros.Max()}");

