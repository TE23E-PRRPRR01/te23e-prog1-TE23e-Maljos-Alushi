// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välkomen til vår LuckText!");
Console.WriteLine(" Ange namn:");
string namn = Console.ReadLine();
Console.Write("Vad är tysklands huvudstad?:");
string huvudstad = Console.ReadLine();
Console.Write("Nämn en frukt:");
string frukt = Console.ReadLine();
Console.Write("Nämn ett sport:");
string sport = Console.ReadLine();


Console.WriteLine($"{namn} åkte til {huvudstad} för att äta {frukt} medans hen kollade på {sport}");
