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
     

        public Evento(string titolo, DateTime data, int maxcapacity)
        {
            this.titolo = titolo;
            this.data = data;
            this.maxcapacity = maxcapacity;
            this.reservedseats = 0;
        }

        public int PrenotaPosti( int _posti)
        {
            try
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
            catch (Exception e) 
            {
                Console.WriteLine("Posti per l'evento terminati");
                return 0;
            }
        }
        public int DisdiciPosti(int _posti)
        {
            try
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
            catch(Exception e) 
            {
                Console.WriteLine("Non puoi togliere piu posti di quelli che hai prenotato!!");
                return _posti;
                    
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
            try
            {
                if (_titolo != null && _titolo != "")
                {
                    return this.titolo = _titolo;
                }
                else
                {
                   
                    throw new Exception();
                }

            }catch (Exception e)
            {


                return "titolo non valido";
            }
        }
            
            
            
        public DateTime setData(DateTime _data)
        {
            var currentData = DateTime.Now;
            try
            {

                if (_data > currentData)
                {
                    return this.data = _data;
                }
                else
                {
                    
                    throw new Exception();
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("Hai inserito una data non valida ed e stata inserita la data odierna!!");
                return currentData;
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
            try
            {
                if (_capacity < 0)
                {
                
                   
                    throw new Exception();      
                }
                else
                {
                    return this.maxcapacity = _capacity; 
                }

            }
            catch( Exception e)
            {
                Console.WriteLine("Hai inserito un dato non valido");
                return 0;
            }

        }
       
        public int getReservedseats()
        {
            return reservedseats;
        }

    }
}
