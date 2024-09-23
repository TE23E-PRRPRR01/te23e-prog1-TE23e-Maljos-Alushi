//en menyprogram som användaren kan välja val
Console.Clear();
Console.WriteLine("Min meny los tacos");
Console.InputEncoding=System.Text.Encoding.Unicode;
Console.OutputEncoding=System.Text.Encoding.Unicode;

// variabel för valet 
string val="";

while (true)
{
    //visar en meny och läser användarens val
    Console.Write("""
    1. Omvandla  en tex till versaler
    2. Omvandla en text till gemener
    3. Avsluta
    Välj ett av alternativ övan:
    """);
    val = Console.ReadLine();
    // handera användares val
    if (val=="1")
    {
        Console.WriteLine("Skriv in en text");
        string texten= Console.ReadLine().ToUpper();
        Console.WriteLine($"Texten i versaler blir:{texten}");
    }
    else if (val=="2")
    {
         Console.WriteLine("Skriv in en text");
        string texten= Console.ReadLine().ToLower();
        Console.WriteLine($"Texten i gemener blir:{texten}");
    }
    else if (val=="3")
    {
         Console.WriteLine("Avslutar.....");
         break;
       
    }
    else
    {
        Console.WriteLine("Dahri vad gör du?");
    }
}



