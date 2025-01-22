/*************
*** M A I N ***
**************/


Console.Clear();

VisaPresentation();

string filnamn = "Text.medd";

while (true)
{
   VisaMeny();
    string val = Console.ReadLine();
    if (val == "1")
    {
        SparaMeddelande(filnamn);
    }
    else if (val == "2")
    {
        LäsaMeddelande(filnamn);
    } else if (val == "3")
    {
        Console.WriteLine("Tack och hej!");
        break;
    }


}
/* ****************
*** M E T O D E R **
********************/


/// <summary>
/// Programen
/// </summary>
static void VisaPresentation()
{
    Console.WriteLine("""
    =======================================
    Program för att spara program på disken
    =======================================
    """);
}

/// <summary>
/// Visar programets meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""

    1. Spara Meddelande
    2. Läsa Meddelande
    3. Avsluta Programet
    Vad väljer du?
    """);
    Console.WriteLine("Ange ditt val: ");
}

/// <summary>
/// Sparar ett meddelande i en textfil
/// </summary>
static void SparaMeddelande(string fil)
{
    Console.WriteLine("Ange ditt Meddelande:");
    string meddelande = Console.ReadLine();
    File.WriteAllText("Text.medd", meddelande);
    Console.WriteLine("Ditt meddelande har sparas ");
}
/// <summary>
/// Läsrer in från textfilen och skriver meddelande
/// </summary>
static void LäsaMeddelande(string filin)
{
    string meddelande = File.ReadAllText("Text.medd");
    Console.WriteLine("Ditt senaste meddelande:");
    Console.WriteLine("---------------------");
    Console.WriteLine(meddelande);
    Console.WriteLine("---------------------");
}