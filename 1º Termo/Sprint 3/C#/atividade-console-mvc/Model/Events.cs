using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_mvc_senai.Model
{
    public class Events
    {

        public string? Name { get; set; }
        public string? Local { get; set; }
        public string? Organizator { get; set; }
        public int Code { get; set; }
        public int currentCode { get; set; } = 0;

        private const string PATH = "Database/Events.csv";

        public Events()
        {
            string folder = PATH.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Events> Read()
        {
            List<Events> EventList = new List<Events>();

            string[] lines = File.ReadAllLines(PATH);

            foreach (string item in lines)
            {
                string[] atributes = item.Split(";");

                Events _event = new Events();

                _event.Name = atributes[1];
                _event.Local = atributes[2];
                _event.Organizator = atributes[3];

                EventList.Add(_event);
            }

            return EventList;
        }

        public string LineFormat(Events CurrentEvent)
        {
            return $"{CurrentEvent.Name};{CurrentEvent.Local};{CurrentEvent.Organizator}";
        }

        public void AddEvent(Events CurrentEvent)
        {
            string[] lines = { LineFormat(CurrentEvent) };

            File.AppendAllLines(PATH, lines);
        }

    }
}