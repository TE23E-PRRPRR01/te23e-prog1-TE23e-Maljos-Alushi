// Använda listor för att skapa/hantera samligar

using System.Runtime.CompilerServices;

Console.Clear();

// lista på trevliga frukter. tex "äpple", "bannan", "apelsin"
List<String> frukter = ["äpple", "bannan", "apelsin"];

Console.WriteLine($"Min frukt lista: {frukter[0]},{frukter[1]},{frukter[2]}");


// ändra i listan
frukter[0] = "morrot" ;
Console.WriteLine($"Min frukt lista: {frukter[0]},{frukter[1]},{frukter[2]}");

// gå igenom listan == loopa igenom listan == från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// skapa en lista på valfri sak (4st)
// skriv ut varje sak på samma rad 
List<String> ämnen = ["Engelska","Svenska","Mattematik","Fysik"];

Console.WriteLine($"Min frukt lista: {ämnen[0]},{ämnen[1]},{ämnen[2]},{ämnen[3]}");


// ändra i listan
ämnen[0] = "Iddrot" ;
Console.WriteLine($"Min ämne lista: {ämnen[0]},{ämnen[1]},{ämnen[2]},{ämnen[3]}");

// gå igenom listan == loopa igenom listan == från första till sista
foreach (var ämne in ämnen)
{
    Console.Write($"ämne");
}
for (int i = 0; i < ämnen.Count; i++)
{
    Console.Write($"{ämnen[i]}");
}

//skapa ett register
Console.Clear();
//en tom lista 
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    //skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet},");
    }
    Console.WriteLine();
    
}