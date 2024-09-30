// Hur man skapar och använder listor
Console.Clear();
Console.WriteLine("Slumpa kort ur en kortlek!");

// Skapa en lista kort
List<string> kortlek = ["Ess", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio", "Tio", "Knekt", "Dam", "Kung"];

int antal = 5;
while (antal > 0)
{

    int index = Random.Shared.Next(0, kortlek.Count);
    //Console.WriteLine($"Det slumpade index = {index}");

    //Plocka ut den sjunde kortet  index=6
    string kort = kortlek[index];

    //Skriv ut 7:e kortet 
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // räkna ned 
     antal--;
}