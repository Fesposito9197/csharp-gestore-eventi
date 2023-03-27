using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        string? titolo;
        List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AddEvent(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> FindEvent(DateTime date)
        {
            var filterdEvents = new List<Evento>();


            foreach(Evento evento in eventi)
            {
                if(evento.getData() == date)
                {
                    filterdEvents.Add(evento);
                }
                else
                {
                    Console.WriteLine("Non ci sono eventi in questa data");
                }
            }


            return filterdEvents;
        }
        public static string PrintListEvent(List<Evento> listaEventi)
        {
            string result = "";

            foreach (Evento evento in listaEventi)
            {
                result += $"{evento.getTitolo()}" + $"{evento.getData()}" + NewLine;
            }

            return result;
        }
        public string PrintEvent(List<Evento> listaEventi)
        {
            return PrintListEvent(listaEventi);
        }

        public List <Evento> GetEvent() 
        {
            return eventi;
        }

        public int NumberEvents()
        {
             return eventi.Count;
        }
        public void ClearEvents()
        {
            eventi.Clear();
        }
    }
}
