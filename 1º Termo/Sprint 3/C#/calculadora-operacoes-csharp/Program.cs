Console.WriteLine(@"
-------------------------------------------------
|            CALCULADORA DE CONSOLE             |
-------------------------------------------------
|     Qual operação você deseja realizar?       |
-------------------------------------------------
|                                               |
| Pressione 1 para soma;                        |
| Pressione 2 para subtração;                   |
| Pressione 3 para multiplicação;               |
| Pressione 4 para divisão.                     |
|                                               |
-------------------------------------------------
");

ConsoleKeyInfo inputOperacao = Console.ReadKey();

float resultado = 0;

Console.WriteLine(@"
-------------------------------------------------
|            CALCULADORA DE CONSOLE             |
-------------------------------------------------
|           Insira o primeiro valor             |
-------------------------------------------------
");

float valor1 = float.Parse(Console.ReadLine());

Console.WriteLine(@"
-------------------------------------------------
|            CALCULADORA DE CONSOLE             |
-------------------------------------------------
|            Insira o segundo valor             |
-------------------------------------------------
");

float valor2 = float.Parse(Console.ReadLine());


switch (inputOperacao.Key)
{
    case ConsoleKey.D1 :
        resultado = valor1 + valor2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        break;
    case ConsoleKey.D2:
        resultado = valor1 - valor2;
        Console.WriteLine($"O resultado da subtração é {resultado}");
        break;
    case ConsoleKey.D3:
        resultado = valor1 * valor2;
        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        break;
    case ConsoleKey.D4:
        resultado = valor1 / valor2;
        Console.WriteLine($"O resultado da divisão é {resultado}");
        break;
    default:
        Console.WriteLine($"Não existe essa opção, tente novamente.");
        break;
}
