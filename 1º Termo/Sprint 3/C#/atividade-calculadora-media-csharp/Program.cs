Console.WriteLine($"Insira a nota 1: ");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota 2: ");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota 3: ");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota 4: ");
int nota4 = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a nota 5: ");
int nota5 = int.Parse(Console.ReadLine());

int resultado = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"A média do aluno é igual a: {resultado}.");

if (resultado > 5)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}