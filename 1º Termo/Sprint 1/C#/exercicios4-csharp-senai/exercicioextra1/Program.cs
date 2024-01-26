int numHomens = 0;
int numMulheres = 0;
int homensAvaliacao = 0;
int mulheresAvaliacao = 0;
bool inputValido = false;
bool sexoValido = false;


for (var numPessoas = 0; numPessoas < 10; numPessoas++)
{
    do
    {
        Console.WriteLine($" Qual o seu sexo? Pressione 1 para homem e 2 para mulher. \r \n");

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

                inputValido = false;

                Console.WriteLine($"Você selecionou a opção homem.");

                numHomens++;

                ConsoleKeyInfo inputOpiniaoHomens;

                do
                {
                    Console.WriteLine($"\r \n Você gostou do produto? Pressione 1 para sim e 2 para não. \r \n");

                    inputOpiniaoHomens = Console.ReadKey();

                    if (inputOpiniaoHomens.Key == ConsoleKey.D1)
                    {
                        homensAvaliacao++;

                        Console.WriteLine($@"
                    
                    Obrigado pela avaliação!
                    Próximo da lista!

                    ");

                        inputValido = true;
                    }
                    else if (inputOpiniaoHomens.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine($@"{Environment.NewLine}Obrigado pela avaliação! {Environment.NewLine}
                    Próximo da lista!
                    {Environment.NewLine}");

                        inputValido = true;
                    }

                } while (inputValido == false);

                break;
            case ConsoleKey.D2:

                inputValido = false;

                Console.WriteLine($"Você selecionou a opção mulher.");

                numMulheres++;

                ConsoleKeyInfo inputOpiniaoMulheres;

                do
                {
                    Console.WriteLine($"\r \n Você gostou do produto? Pressione 1 para sim e 2 para não. \r \n");

                    inputOpiniaoMulheres = Console.ReadKey();

                    if (inputOpiniaoMulheres.Key == ConsoleKey.D1)
                    {
                        mulheresAvaliacao++;

                        inputValido = true;

                        Console.WriteLine($@"{Environment.NewLine}Obrigado pela avaliação!{Environment.NewLine}
                    Próximo da lista!
                    {Environment.NewLine}");

                    }
                    else if (inputOpiniaoMulheres.Key == ConsoleKey.D2)
                    {
                        Console.WriteLine($@"{Environment.NewLine}Obrigado pela avaliação! {Environment.NewLine}
                    Próximo da lista!
                    {Environment.NewLine}");

                        inputValido = true;
                    }

                } while (inputValido == false);

                break;
        }
    } while (sexoValido == false);
}

Console.WriteLine($"{numHomens} foi o total de homens e {numMulheres} o total de mulheres");

double resultadoPorcentagem = Math.Round(((((double)numHomens - homensAvaliacao) / numHomens) * 100), 2);

Console.WriteLine(@$"

O numero de pessoas que responderam sim é {homensAvaliacao + mulheresAvaliacao}
O numero de pessoas que responderam não é {(numHomens + numMulheres) - (homensAvaliacao + mulheresAvaliacao)}
O numero de mulheres que responderam sim é {mulheresAvaliacao}
O numero de homens que responderam sim é {homensAvaliacao}

");

if (numHomens == 0)
{
    Console.WriteLine($"não houveram homens analisados.");
}
else
{
    Console.WriteLine($"A porcentagem de homens que responderam não entre todos é {resultadoPorcentagem}");
}
