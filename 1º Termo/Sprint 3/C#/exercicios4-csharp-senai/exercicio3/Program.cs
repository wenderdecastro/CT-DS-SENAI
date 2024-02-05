int num = 0;
bool valorValido = false;

do
{

    Console.WriteLine("Insira um numero: ");

    string input = (Console.ReadLine());

    if (int.TryParse(input, out num))
    {
        valorValido = true;
    }


} while (valorValido == false);

int fator;

Console.WriteLine(@$"A tabuada do numero {num} é:");

for (fator = 1; fator <= 10; fator++)
{
    Console.WriteLine($"{num} . {fator} = {num * fator}");
}

