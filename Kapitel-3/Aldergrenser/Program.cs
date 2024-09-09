// Skapa ett program som implementerar valfria åldersregler.
//Välj 4 åldersgränser och associera dem med något som är tillåtet att göra vid den åldern.
Console.Clear();


Console.WriteLine("Kan du dricka en ÖL i Europa?");

Console.Write("Hur gammal är du?");

string ageText = Console.ReadLine();

int age = int.Parse(ageText);

if (age >= 20)
{
    Console.WriteLine("Du får dricka öl i alla lände i Europa");
}
else if (age <= 17 && age >= 16)
{ 
    Console.WriteLine("Nä du fåt inte drika i de flesta europeiska länderna.");
}
else if (age == 15)
{
    Console.WriteLine("Du kan inte dricka Öl als förutom i privat område i de flästa länderna i europa.");
}
else if (age >= 14)
{
    Console.WriteLine("Nej du kan inte dricka alls");
}
