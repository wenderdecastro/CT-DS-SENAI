using atividade8_csharp_senai;
Celular Smartphone = new Celular();

ConsoleKeyInfo opcao;
bool fecharMenu = false;

do
{


    Console.WriteLine(@$"
=====================================
        MENU DE AÇÕES

    O celular está: {(Smartphone.Ligado ? "ligado" : "desligado")}

=====================================

    1. Ligar celular
    2. Desligar celular
    3. Fazer chamada
    4. Mandar mensagem
    5. Ver propriedades

=====================================
    6. Sair
=====================================
");

    do
    {

        opcao = Console.ReadKey();


        switch (opcao.Key)
        {
            case ConsoleKey.D1:
                Smartphone.Ligar();
                break;
            case ConsoleKey.D2:
                Smartphone.Desligar();
                break;
            case ConsoleKey.D3:
                Smartphone.fazerChamada();
                break;
            case ConsoleKey.D4:
                Smartphone.enviarMensagem();
                break;
            case ConsoleKey.D5:
                Smartphone.verPropriedades();
                break;
            case ConsoleKey.D6:
                Console.WriteLine($"\n\nMenu de ações fechado!");
                Environment.Exit(0);
                break;
        }

    } while (opcao.Key != ConsoleKey.D1 && opcao.Key != ConsoleKey.D2 && opcao.Key != ConsoleKey.D3 && opcao.Key != ConsoleKey.D5 && opcao.Key != ConsoleKey.D4 && opcao.Key != ConsoleKey.D6);

} while (fecharMenu == false);