Console.WriteLine($"Qual a porcentagem de frequência do aluno? (insira em numeros inteiros).");
float frequencia = float.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"Aluno reprovado por falta de frequência.");

}
else
{
    Console.WriteLine($"Qual é a média do aluno?");
    int media = int.Parse(Console.ReadLine());

    if (media >= 7)
    {
        Console.WriteLine($"Aluno aprovado.");
    }
    else if (media >= 3)
    {
        Console.WriteLine($"O aluno tem direito a uma avaliação de recuperação.");
    }
    else
    {
        Console.WriteLine($"Aluno reprovado por média muito baixa.");
    }
}