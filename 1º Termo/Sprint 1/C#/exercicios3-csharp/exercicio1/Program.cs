Console.WriteLine("Insira seu ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

IdadeVotacao(anoNascimento);

void IdadeVotacao(int a)
{
    int anoAtual = DateTime.Today.Year;

    if (anoAtual - anoNascimento < 16)
    {
        Console.WriteLine($"Você não pode votar porque tem idade abaixo de 16 anos.");
    }
    else
    {
        Console.WriteLine($"Você pode votar.");
    }
}