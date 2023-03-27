
using GestoreEventi;

Console.WriteLine("Inserisci un nuovo evento");

Console.WriteLine();

Console.WriteLine("inserisci nome evento");
string? eventName = Console.ReadLine();

Console.WriteLine("inserisci data evento (dd/MM/YYYY)");
DateTime eventDate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("inserisci massima capacita evento");
int maxCapacity = Convert.ToInt32(Console.ReadLine());

Evento evento = new Evento(eventName, eventDate, maxCapacity);

Console.WriteLine(evento);