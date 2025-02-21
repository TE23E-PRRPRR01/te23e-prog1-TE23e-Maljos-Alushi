using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("Listor!");
Console.WriteLine();
// skapa en tom lista för pizza rätter
List<string> pizzas = [];

// skapa en tom lista för frukter 
List<string> frukter = [];

// skapa en tom lista för skorstorlek
List<int> skorstorlekar = [];

// skapa en lista med olika namn 
List<string> NamnLista =["Anders", "Anna", "Calle"];

//Lägg till i listor men .Add()
// Lägg till tre pizzas
pizzas.Add("Margharita");
pizzas.Add("Kebab");
pizzas.Add("Peperoni");

// lägg till i list frukter
frukter.Add("Banan");
frukter.Add("Äpple");
frukter.Add("Mango");

// skriv ut alla frukter
foreach (var frukt in frukter)
{
    Console.WriteLine($"Frukt: {frukt}");
}

// Nu låter vi användaren mata in ett ny pizza
Console.WriteLine("Addera ett till namn: ");
string nypizza = Console.ReadLine();
NamnLista.Add(nypizza);

// skriv ut alla pizzor
foreach (var pizza in pizzas)
{
    Console.WriteLine($"Pizza: {pizza}");
}

// Nu låter vi användaren mata in ett fjärde namn 
Console.WriteLine("Addera ett till namn: ");
string nynamn = Console.ReadLine();
NamnLista.Add(nynamn);

// skriv ut alla namn
foreach (var namn in NamnLista)
{
    Console.WriteLine($"Namn:-{namn}");
}

// Nu låter vi användaren mata in skorstorleeken
Console.WriteLine("Ange din skorstorlek: ");
int input = int.Parse(Console.ReadLine());
skorstorlekar.Add(input);

// skriv ut alla skorstorlek
foreach (var skorstorlek in skorstorlekar)
{
    Console.WriteLine($"Skorstorlek: {skorstorlek}");
}

// Hur många pizzor har vi ?
int antal = pizzas.Count;
Console.WriteLine($"Total antal pizzor = {antal}");

// Hur många frukter?
Console.WriteLine($"Total antal frukter = {frukter.Count}");

// Hur många namn ?
Console.WriteLine($"Total antal namn = {NamnLista.Count}");

// Byta första namn med en annat
NamnLista[0] = "Max";
Console.WriteLine($"Första namnet är {NamnLista[0]}");

// skriv ut första namnet
Console.WriteLine($"Första namnet: {NamnLista[0]}");

// Byta första namn med en annat
NamnLista[1] = "Hippo";
Console.WriteLine($"Andra namnet är {NamnLista[1]}");
// skriv ut andra  namnet
Console.WriteLine($"Andra namnet: {NamnLista[1]}");
// skriv ut sista namnet
Console.WriteLine($"Sista namnet: {NamnLista[NamnLista.Count-1]}");

// Be användren att byta ut första pizzan 
Console.WriteLine("Ange en ny första pizza: ");
string ennypizza = Console.ReadLine();
pizzas[0] = ennypizza;

//  Be användaraen vilken pizza som ska bytas ut
Console.WriteLine("Vilken pizza vill du byta ut? : (0, 1, 2): ");
int index = int.Parse(Console.ReadLine());

// Be användaren vad heter nya pizzan
Console.WriteLine("Vad heter nya pizzan");
nypizza = Console.ReadLine();
pizzas[index]= nypizza ; 