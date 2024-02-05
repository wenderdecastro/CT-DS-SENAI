Console.WriteLine($"Qual o seu salário?");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Quanto você gastou?");
float gastos = float.Parse(Console.ReadLine());

if (salario >= gastos)
{
    Console.WriteLine($"Os gastos estão dentro do orçamento.");
}
else
{
    Console.WriteLine($"Os gastos estouraram o orçamento.");
}