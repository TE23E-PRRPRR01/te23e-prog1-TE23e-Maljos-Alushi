Console.Clear();


//Skriv ut lista med foreach
List<string> listaNamn = ["Pizza", "Pasta", "Sallad",];
Console.WriteLine("Alla namn: ");
foreach (string namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}

//Skriv ut alla årtalen i en lista
List<int> listÅrtal = [1492, 1776, 1914, 1945, 1969];
Console.WriteLine("Årtal i listan: ");
foreach (int årtal in listÅrtal)
{
    Console.WriteLine($"* {årtal}");
}

//Skriv ut på en rad
Console.Write("Alla årtal: ");
foreach (int år in årtal)
{
    Console.Write($"{år}, ");
}
Console.WriteLine();

