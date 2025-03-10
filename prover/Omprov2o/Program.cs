Console.Clear();
Console.WriteLine("Temperaturlogg");

// en list för att lagra 7 temperaturer 
List<int> temperaturer = [];
while (true)
{
   Console.Write("""
   1. Registrera temperatur
   2. Visa medeltemperatur
   3. Lista alla temperaturer
   4. Ändra temperatur 
   5. Avsluta
   välj ett alternativ:
   """);
   int val = int.Parse(Console.ReadLine());


if (val == 1)
{
// loopa 7 gånger
for (var i = 0; i < 7; i++)
{

    // fråga användaren 
    Console.Write($"Ange en temperatur för dag {i + 1}: ");
    string temperaturText = Console.ReadLine();
    bool success = int.TryParse(temperaturText, out int temperatur);

    // lägg till temperatur
    temperaturer.Add(temperatur);
}
    
}
else if (val == 2)
{
// räkna ut medel
int summa = 0;
foreach (var temp in temperaturer)
{
    summa += temp;
}
Console.WriteLine($"Medel = {summa/7}");
    
} else if (val == 3)
{
 // skriva ut alla temperaturer från listan
//  foreach (var temp in temperaturer)
//  {
//     Console.WriteLine(temp);
//  }

for (var i = 0; i < 7; i++)
{
    Console.WriteLine($"Dag {i + 1} :{temperaturer[i]}");
}
    
} else if (val == 4)
{
    //Byta ut temperatur för en vald dag
    Console.WriteLine("Ange dag du vill byta temperatur: ");
    string dagText = Console.ReadLine();
    bool success = int.TryParse(dagText, out int dag);
    Console.WriteLine($"Ange ny temperatur för dag {dag}: ");
    string temperaturText = Console.ReadLine();
    success = int.TryParse(temperaturText, out int temperatur);

    temperaturer[dag - 1] = temperatur;
    Console.WriteLine($"Temperaturen för dag {dag} har ändrats till {temperatur}");
    for (var i = 0; i < 7; i++)
{
    Console.WriteLine($"Dag {i + 1} :{temperaturer[i]}");
}

} else if (val == 5)
{
    Console.WriteLine("Ok, hej då!");
    break;
}
}