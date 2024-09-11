// program för att konvertera Fahrenheit till celcius
Console.Clear();
Console.WriteLine("American to European");

//läser in temp i fahrenheit
Console.Write("Ange temperatur i Fahrenheit: ");
double tempFahrenheit = double.Parse(Console.ReadLine()); 

// Konvertera Fa > Ce
double tempCelcius = (tempFahrenheit-32)*5/9;

// Skriva ut resultatet  med decimaler
Console.WriteLine($"{tempFahrenheit} F  blir {tempCelcius} C");
