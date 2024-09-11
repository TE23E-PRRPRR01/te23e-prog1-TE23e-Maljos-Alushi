// Program för att räckna ditt BMI!!!!!!!
Console.Clear();
Console.WriteLine("BMI Räknare!");

//Läser in ditt längd och vikt
Console.Write("Ange dit längd i (cm):");
float längd = float.Parse(Console.ReadLine());

Console.Write("Ange din vikt i (kg):");
float vikt = float.Parse(Console.ReadLine());

// konvertera allt information till bmi
float BMI = vikt / ((längd/100)*(längd/100) );

// Skriv ut dit bmi
Console.WriteLine($"Ditt BMI är {BMI:00.00}");

