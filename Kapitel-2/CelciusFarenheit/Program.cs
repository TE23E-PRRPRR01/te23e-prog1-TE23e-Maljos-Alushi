// Program för att konvertera celcius till farenheit
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("European to American");

//läser in temp i celcius
Console.Write("Ange temperatur i celcius: ");
int tempCelcius = int.Parse(Console.ReadLine());

// konvertera till fahrenhait
int tempFahrenheit= tempCelcius* 9/5 + 32;

//skriver ut resultaten 
Console.WriteLine($"{tempCelcius} celcius är {tempFahrenheit} Fahrenheit");

