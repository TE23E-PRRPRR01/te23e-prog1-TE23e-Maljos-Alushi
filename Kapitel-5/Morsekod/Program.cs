// En linten morsekod app
Console.Clear();
Console.WriteLine("En liten morsekod app");
Console.InputEncoding = System.Text.Encoding.Unicode; 

// två listor 
List<string> alfabet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ",
             "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/", 
            ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----"];
List<string> nummer =["0", "1", "2", "3", "4", "5", "6", "7", "8", "9",];

// läs in text 
Console.Write("Ange en meddelande: ");
string meddelande = Console.ReadLine();

// få igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    // uppslag i afabetet efter index
    int index = alfabet.IndexOf(bokstav.ToString());

    // hittar morseteknet (A-Ö)?
    if (index >= 0)
    {
       // Console.Write($"{index}");

        // Plocka ut morsetecknet för detta index
        string morseteckne = morsekod[index];
        //Console.Write($"Morsekoden för {bokstav} är {morseteckne}");
        Console.Write($"{morseteckne}");

        // spela upp morse som ljud-beep
        //tex D = "-.."
        // loopa idenom morsetecknet
        foreach (var signal in morseteckne)
        {
           if (signal =='.') //'.'
           {
            //1000Hz, 200ms
            Console.Beep(1000, 200);
           }
           else // '-'
           {
             Console.Beep(1000, 600);
           }
        }

    }
    else
    {
        Console.WriteLine("?");
    }


}


