// text editor som för text till fil eller fil till text
Console.Clear();
Console.WriteLine("FILosofi");
Console.InputEncoding=System.Text.Encoding.Unicode;
Console.OutputEncoding=System.Text.Encoding.Unicode;

// variabel för valet 
string val="";

while (true)
{
    //Visar en meny och läser användarens cal
    Console.Write("""
    1. Skriv till fil
    2. Läs från fil
    3. Avsluta 
    Välj en av alternativerna övan:
    """);
    val=Console.ReadLine();
    //handera användares val
    if (val=="1")
    {
        Console.WriteLine("Skriv in en text: ");
        string texten=Console.ReadLine();
        File.WriteAllText("filnamn.txt", texten);
    }
    else if (val=="2")
    {
        if (File.Exists("filnamn.txt"))
        {
        string texten=Console.ReadLine();
        File.ReadAllText("filnamn.txt");
        Console.WriteLine(texten);
    
        }
        else
        {
            Console.WriteLine("Filen finns inte, kan ej läsa text.");
        }
    }
    else if (val=="3")
    {
        Console.WriteLine("Avslutar....");
        break;
    }
    else{
         Console.WriteLine("Eyy vad säger du?");
    }














}





