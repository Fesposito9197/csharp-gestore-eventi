
using GestoreEventi;
Console.WriteLine("Inserisci il nome del tuo programma di eventi ");
string? eventsName = Console.ReadLine();
var eventProgram = new ProgrammaEventi(eventsName);

Console.WriteLine("Inserisci il numero degli eventi presenti nel programma");
var eventsNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < eventsNumber; i++)
{
    Console.WriteLine("inserisci nome evento");
    string? eventName = Console.ReadLine();

    Console.WriteLine("inserisci data evento (dd/MM/YYYY)");
    DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

    Console.WriteLine("inserisci massima capacita evento");
    int maxCapacity = Convert.ToInt32(Console.ReadLine());

    Evento evento = new Evento(eventName, eventDate, maxCapacity);

    eventProgram.AddEvent(evento);
}

List<Evento> allevents = eventProgram.GetEvent();

Console.WriteLine(eventProgram.PrintEvent(allevents));


Console.WriteLine("--------------------------");


//Console.WriteLine("inserisci nome evento");
//string? eventName = Console.ReadLine();

//Console.WriteLine("inserisci data evento (dd/MM/YYYY)");
//DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

//Console.WriteLine("inserisci massima capacita evento");
//int maxCapacity = Convert.ToInt32(Console.ReadLine());
//int maxCapacity = 100;

//Evento evento = new Evento(eventName, eventDate, maxCapacity);
//Evento evento = new Evento("prova", Convert.ToDateTime("12/12/2024"), maxCapacity);

//Console.WriteLine(evento);

Console.WriteLine("--------------------------");

//Console.WriteLine("Quanti posti desideri prenotare?");
//int postiPrenotati = Convert.ToInt32(Console.ReadLine());
//evento.PrenotaPosti(postiPrenotati);
//Console.WriteLine($"Numero posti prenotati: {evento.getReservedseats()}");
//Console.WriteLine($"Numero di posti rimasti: {maxCapacity - postiPrenotati}");

//Console.WriteLine("--------------------------");

//while (true)
//{
//    Console.WriteLine("Vuoi disdire dei posti prenotati? (s/n)");
//    var userChoice = Console.ReadLine();
//    if(postiPrenotati == 0 )
//    {
//        Console.WriteLine("Non hai posti prenotati");
//        break;


//    }else if(userChoice is "n") 
//    {
//        Console.WriteLine("Goditi l'evento");
//        break;


//    }else if (userChoice is "s")
//    {
//            Console.WriteLine("Quanti posti prenotati vuoi disdire?");
//            var userDeleteSeat = Convert.ToInt32(Console.ReadLine());
//            evento.DisdiciPosti(userDeleteSeat);
//            Console.WriteLine($"I tuoi posti prenotati sono: {evento.getReservedseats()}");
//            Console.WriteLine($"I posti dell'evento ora sono: {evento.getMaxcapacity() - evento.getReservedseats()}");
            

//    }
//}

    
    
        
       

    
