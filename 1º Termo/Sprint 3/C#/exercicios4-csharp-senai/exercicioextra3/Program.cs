int numHomens = 0;
int numMulheres = 0;
bool sexoValido = false;
int idadeTotalHomens = 0;
int idadeTotalMulheres = 0;
int pessoas = 0;

for (pessoas = 0; pessoas < 10; pessoas++)
{
    do
    {
        Console.WriteLine($" Qual o seu sexo? Pressione 1 para homem e 2 para mulher.");

        ConsoleKeyInfo inputSexo = Console.ReadKey();

        if (inputSexo.Key == ConsoleKey.D1 || inputSexo.Key == ConsoleKey.D2)
        {
            sexoValido = true;
        }
        else
        {
            sexoValido = false;
        }


        switch (inputSexo.Key)
        {
            case ConsoleKey.D1:

                Console.WriteLine($"\r \nVocê selecionou a opção homem.");

                numHomens++;

                Console.WriteLine($"\r \nQual a sua idade?");
                int idadeHomem = int.Parse(Console.ReadLine());

                Console.WriteLine($"\r \nQual o seu peso?");
                float pesoHomens = int.Parse(Console.ReadLine());

                idadeTotalHomens += idadeHomem;

                break;
            case ConsoleKey.D2:

                Console.WriteLine($"\r \nVocê selecionou a opção mulher.");

                numMulheres++;

                Console.WriteLine($"\r \nQual a sua idade?");
                int idadeMulher = int.Parse(Console.ReadLine());

                Console.WriteLine($"\r \nQual o seu peso?");
                int pesoMulheres = int.Parse(Console.ReadLine());

                idadeTotalMulheres += idadeMulher;

                break;
        }
    } while (sexoValido == false);
}

Console.WriteLine($"O numero total de mulheres é de {numMulheres}");
Console.WriteLine($"O numero total de homens é de {numHomens}");
Console.WriteLine($"A média de idade das mulheres é igual a {Math.Round((float)idadeTotalMulheres / numMulheres, 2)}");
Console.WriteLine($"A média de idade dos homens é igual a {Math.Round((float)idadeTotalHomens / numHomens, 2)}");
