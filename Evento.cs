using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        string titolo;
        DateTime data;
        int maxcapacity;
        int reservedseats;
        string error = "Hai inserito un dato non valido";

        public Evento(string titolo, DateTime data, int maxcapacity)
        {
            this.titolo = titolo;
            this.data = data;
            this.maxcapacity = maxcapacity;
            this.reservedseats = 0;
        }

        public int PrenotaPosti( int _posti)
        {
            if (data > DateTime.Now && maxcapacity > reservedseats)
            {
                return reservedseats += _posti;
            }
            else
            {
                throw new Exception("Posti per l'evento terminati");
            }
        }
        public int DisdiciPosti(int _posti)
        {
            if (data > DateTime.Now &&  reservedseats > _posti)
            {
                return reservedseats -= _posti; 
            }
            else 
            {
                throw new Exception("Non puoi togliere piu posti di quelli che hai prenotato!!");
                    
            }
        }
        public override string ToString()
        {
            var dataTitolo = $"{setTitolo(titolo)} - {setMaxCapacity(maxcapacity)} - " + setData(data).ToString("dd/MM/yyyy"); 
            return dataTitolo;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string setTitolo( string _titolo)
        {
            if (_titolo != null && _titolo != "")
            {
                return this.titolo = _titolo;
            }
            else
            {
                Console.WriteLine(error);
                throw new Exception();
            }
        }
            
            
            
        public DateTime setData(DateTime _data)
        {
            var currentData = DateTime.Now;

            if (_data > currentData)
            {
                return this.data = _data;
            }
            else
            {
                Console.WriteLine(error);
                throw new Exception();
            }
            
        }
        public DateTime getData() 
        {
            return data;
        }
        public int getMaxcapacity() 
        {
            return maxcapacity;
        }
        public int setMaxCapacity(int _capacity)
        {
            if (_capacity < 0)
            {
                
                Console.WriteLine(error);
                throw new Exception();      
            }
            else
            {
                return this.maxcapacity = _capacity; 
            }

        }
       
        public int getReservedseats()
        {
            return reservedseats;
        }

    }
}
