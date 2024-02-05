using atividade_mvc_senai.Model;
using atividade_mvc_senai.Controller;

Events ModelEvents = new Events();

EventsController ControllerEvents = new EventsController();

do
{
    Console.WriteLine($"\n1 . List Events \n2 . Register Events \n0 . Exit");


    ConsoleKeyInfo option = Console.ReadKey(true);

    switch (option.Key)
    {
        case ConsoleKey.D1:
            ControllerEvents.ListEvents();
            break;
        case ConsoleKey.D2:
            ControllerEvents.RegisterEvent();
            break;
        case ConsoleKey.D0:
            Environment.Exit(0);
            break;
    }


} while (true);






