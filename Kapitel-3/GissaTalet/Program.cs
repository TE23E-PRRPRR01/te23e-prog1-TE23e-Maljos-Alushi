﻿// Ett litet spel - gissa ett hemligt heltal!
Console.Clear();
Console.WriteLine("Ett litet spel - gissa ett hemligt heltal!");

//slumpa ett tal
int slumptalet = Random.Shared.Next(1, 101); // mellan 1-100
Console.WriteLine($"Slumptalet är {slumptalet}");

Console.Write("Gissa ett tal 1-100: ");
// läs in texten, t.ex "100" 
string gissningText = Console.ReadLine();
// konvertera text till heltal, blir 100
int gissning = int.Parse(gissningText);

if (gissning == slumptalet)
{
    Console.WriteLine("Bra du har gissat rätt!");
    
}
else if (gissning > slumptalet)
{
    Console.WriteLine("För Högt");
}
else
{
    Console.WriteLine("För Lågt");
}


