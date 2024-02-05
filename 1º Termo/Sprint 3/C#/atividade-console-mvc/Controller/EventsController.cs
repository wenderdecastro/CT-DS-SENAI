using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atividade_mvc_senai.Model;
using atividade_mvc_senai.View;

namespace atividade_mvc_senai.Controller
{
    public class EventsController
    {
        Events events = new Events();

        EventsView eventsView = new EventsView();

        public void ListEvents()
        {
            List<Events> listEvents = events.Read();

            eventsView.List(listEvents);
        }

        public void RegisterEvent()
        {
            Events newEvent = eventsView.Register();

            events.AddEvent(newEvent);
        }
    }
}