using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_mvc_senai.Controller;
using atividade_mvc_senai.Model;


namespace atividade_mvc_senai.View
{
    public class EventsView
    {
        public void List(List<Events> eventList)
        {
            foreach (var item in eventList)
            {
                Console.WriteLine($"\nName: {item.Name}\nOrganizator: {item.Organizator}\nLocal: {item.Local}");
            }
        }

        public Events Register()
        {
            Events newEvent = new Events();

            Console.WriteLine($"\n\nEnter event name: \n");
            newEvent.Name = Console.ReadLine();

            Console.WriteLine($"\nEnter event local: \n");
            newEvent.Local = Console.ReadLine();

            Console.WriteLine($"\nEnter event organizator name: \n");
            newEvent.Organizator = Console.ReadLine();

            return newEvent;
        }
    }
}