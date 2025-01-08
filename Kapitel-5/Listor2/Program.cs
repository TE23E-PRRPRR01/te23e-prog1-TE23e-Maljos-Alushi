Console.Clear();
Console.WriteLine("Allt om listor");

// skapa en lista 
List<string> listaPeng = [];

// infoga i en lista 
listaPeng.Add("Dollar");  // verb
listaPeng.Add("Euro");
Console.WriteLine($"Antal : {listaPeng.Count}");

// skriv ut listan 
foreach (var peng in listaPeng)
{
Console.Write($"{peng}, ");
}

// skriv ut första elementet i listan (index = 0)
Console.WriteLine($"Första elementet: {listaPeng[0]}");

// skriv ut namn ur lista 
for (var i = 0; i < 2; i++)
{
    Console.WriteLine($"{i}: {listaPeng[i]}");
}

// skriv ut alla namn i listan med for loop
for (var i = 0; i < listaPeng.Count; i++)
{
    Console.WriteLine($"{i}: {listaPeng[i]}");
}