ConsoleKeyInfo combustivelInput;
double preco = 0;
double litros;
string combustivel = "";
double total;
bool doisCombustiveis = true;
do
{
    do
    {
        Console.WriteLine(@$"
    Escolha o combustível desejado: 
    G - Gasolina
    A - Alcool
    ");
        combustivelInput = Console.ReadKey();

        if (combustivelInput.Key == ConsoleKey.G)
        {
            preco = 5.30f;
            combustivel = "Gasolina";
        }
        else if (combustivelInput.Key == ConsoleKey.A)
        {
            preco = 4.90f;
            combustivel = "Alcool";
        }
        else
        {
            Console.WriteLine($"\n Opção inválida! Tente novamente. ");
        }

    } while (combustivelInput.Key != ConsoleKey.G && combustivelInput.Key != ConsoleKey.A);

    do
    {

        Console.WriteLine($"\n Digite a quantidade de litros: ");

        litros = double.Parse(Console.ReadLine());

    }
    while (litros.GetType() != typeof(double));

    double CalcularTotal(double l, double p)
    {

        switch (combustivel)
        {
            case "Gasolina" when litros < 20:
                p -= p * 0.03f;
                total = Math.Round(p * l, 2);
                return (total);
            case "Gasolina" when litros >= 20:
                p -= p * 0.05f;
                total = Math.Round(p * l, 2);
                return (total);
            case "Alcool" when litros < 20:
                p -= p * 0.02f;
                total = Math.Round(p * l, 2);
                return (total);
            case "Alcool" when litros >= 20:
                p -= p * 0.04f;
                total = Math.Round(p * l, 2);
                return (total);
            default:
                return 0;

        }
    }

    Console.WriteLine($"\n Total: {combustivel} - {CalcularTotal(litros, preco)} \n");

    Console.WriteLine(@$"
    Deseja calcular o valor de outro combustível? 
    Pressione:
    S para sim
    N para não");

    ConsoleKeyInfo inputDois = Console.ReadKey();

    switch (inputDois.Key)
    {
        case ConsoleKey.S:
            doisCombustiveis = true;
            break;
        case ConsoleKey.N:
            doisCombustiveis = false;
            break;
    }



} while (doisCombustiveis == true);

