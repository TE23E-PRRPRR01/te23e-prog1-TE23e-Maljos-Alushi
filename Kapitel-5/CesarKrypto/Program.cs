// program för kryptering med Cesar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för kryptering med Cesar-chiffer");

// alfabetet, lista av bokstaver att använda 
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWYZÅÄÖ";

// ange en meddelande
Console.Write("Ange en meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

// göra nummer till variabel
Console.WriteLine(" Ange ett nyckel från (1-9)");
int nummer = int.Parse(Console.ReadLine());

// Loopa igenom meddelandet bokstav öfr bokstav
foreach (char bokstav in meddelande)
{


    // hitta bokstavens position (index)
    int index = alfabetet.IndexOf(bokstav);
    //Console.WriteLine($"{bokstav} så är index = {index}");

    //om bokstaven finns i alfabetet 
    if (index != -1)
    {

        // cesar kryptering, addera en nyckel (tex 2)
        int nyIndex = index + nummer;
        //Console.WriteLine($"{index} + {nummer} = {nyIndex}");

        // börja om från början efter 29
        if (nyIndex >= alfabetet.Length)
        {
            nyIndex = nyIndex - alfabetet.Length;
        }

        // Pkocka ut bokstaven för ny index
        char krypteradBokstav = alfabetet[nyIndex];
        //Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
        Console.Write(krypteradBokstav);

    }
    else
    {
        //Console.WriteLine($" Bokstaven är oförändrad : {bokstav}");
        Console.Write(bokstav);
    }


}
