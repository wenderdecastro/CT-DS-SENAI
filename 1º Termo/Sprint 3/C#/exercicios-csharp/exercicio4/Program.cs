Console.WriteLine($"Insira a senha:");
string senha = Console.ReadLine();

if (senha == "1234")
{
    Console.WriteLine($"Acesso permitido.");
}
else
{
    Console.WriteLine($"Acesso negado.");
}