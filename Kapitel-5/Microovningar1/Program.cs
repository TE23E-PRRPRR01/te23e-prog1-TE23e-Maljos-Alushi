Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
// listan
List<string> listaNamn = ["Anna", "Björn", "Cecilia"];

Console.Write("Nuvarande lista: ");

Console.WriteLine(string.Join($",", listaNamn));

Console.WriteLine("Ange ett namn att addera till listan:");
string namn = Console.ReadLine();
listaNamn.Add($"{namn}");

Console.Write("Listan efter tillägg : ");

Console.WriteLine(string.Join($",", listaNamn));

Console.WriteLine("Ange ett namn att ta bort :");
string bortNamn = Console.ReadLine();

if (listaNamn.Contains(bortNamn))
{
    Console.WriteLine("Det finns");
    listaNamn.Remove(bortNamn);
}
else
{
    Console.WriteLine("Det finns inte");
}

Console.WriteLine(string.Join($",", listaNamn));