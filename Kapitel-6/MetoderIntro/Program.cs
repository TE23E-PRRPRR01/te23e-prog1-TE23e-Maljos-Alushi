/********************************************************************
* ********************  M E T O D E R  ******************************
****************************************************************** */

Console.Clear();
Console.WriteLine("Hej Metoder!");

// använd metoden 
SägHej();
//Anropa metoden meny
VisaMeny();
//Anropa metoden namn fråga
NamnFråga();


/********************************************************************
* ***********************   M A I N  ********************************
****************************************************************** */


/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}
/// <summary>
///  metod för att vissa meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1.Lägg till uppgift
    2.Ta bort uppgift
    3. Skriv ut alla uppgift 
    4. Avsluta
    """);
}

/// <summary>
/// Metod för att fråga namn 
/// </summary>
static void NamnFråga()
{
    Console.Write("Vad heter du?");
    string namn = Console.ReadLine();
    Console.WriteLine(namn);
}