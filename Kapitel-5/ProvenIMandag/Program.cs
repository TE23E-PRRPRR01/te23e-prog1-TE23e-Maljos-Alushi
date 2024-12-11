using System.Runtime.ConstrainedExecution;

Console.Clear();
Console.WriteLine("Filmregister");

// lista för lagring
List<string> listaFilmer = [];

// be användare ange ett antal
Console.WriteLine("Ange antal filmer per sida (3-5): ");
int antal = int.Parse(Console.ReadLine());
bool success = int.TryParse(antalText, out antal);

// program loop
while (true)
{
    // visa en meny 
    Console.Write("""
1.Lägg till filmer 
2.Lista alla filmer 
3.Sök en film
4.Avsluta
Välj en alternativ:
""");
    string val = Console.ReadLine();
    Console.WriteLine();

    if (val == "1")
    {
        // lägg till filmer 
        for (int i = 0; i < antal; i++)
        {
        Console.WriteLine("Lägg till en film:");
        string film = Console.ReadLine();
        listaFilmer.Add($"-{film}");
        }
    }
    if (val == "2")
    {
        // skriv ut alla filmer 
       foreach(var filmnamn in listaFilmer)
       {
        Console.WriteLine(filmnamn);
       }
    }
    if (val == "3")
    {
        // söker på en film som finns in i listan 
        Console.WriteLine("Ange en film att söka efter (första bokstav) ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            // kolla om varje film börjar på bokstaven 
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine(filmnamn);
            }
        }
        
        
    }
    if (val == "4")
    {
        Console.WriteLine("Tack och hej");
        break;
    }
    else{
        Console.WriteLine("Fel val! Försök igen!!");
    }
}
