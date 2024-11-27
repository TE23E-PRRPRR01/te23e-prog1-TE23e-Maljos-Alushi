using System.Net.WebSockets;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// lista med 5 namn
List<string> namnLista = ["Anna", "Benjamin", "Patrik", "Jonas", "Maya" ];

Console.WriteLine($"Min kompisar är: {string.Join(",",  namnLista)}.");

// lista med 5 orter 
List<string> orter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];

// Fem orter ligger i 
Console.WriteLine($"Fen orter: {string.Join(",",  orter )} ligger i Sverige.");

// skapa en lista med 5 årtal 
List<int> listaArTal =[1492, 1776, 1914, 1945, 1969];

// skriva utt det 
Console.WriteLine($"Fem viktiga årtal = '{string.Join("','", listaArTal)}'");

// skriva ut namn 
Console.WriteLine("Första namnet: " + namnLista[0]);
Console.WriteLine("Sista namnet : " + namnLista[4]);

// Favoritdrikor
List<string> drickor = ["Kaffe", "Juice", "Läsk", "Vin", "Öl" ];

// skriv ut de 
Console.WriteLine("1." + drickor[0]);
Console.WriteLine("2." + drickor[1]);
Console.WriteLine("3." + drickor[2]);
Console.WriteLine("4." + drickor[3]);
Console.WriteLine("5." + drickor[4]);

Console.WriteLine($"Nuvarande lista: {namnLista}");
string namn = Console.ReadLine();
Console.WriteLine($"Ange ett namn att lägga till:");

