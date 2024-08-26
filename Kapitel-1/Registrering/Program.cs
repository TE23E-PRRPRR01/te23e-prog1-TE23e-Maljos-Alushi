// Program för att registrera förnamn och efternam 
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternam" );
Console.Write("Ange förnamn:");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn:");
string efternamn = Console.ReadLine();
//Console.WriteLine("Hej! "+ förnamn + " " + efternamn);
Console.WriteLine($"Hej! {förnamn} {efternamn}");

// Är det Maljos som loggar in
if (förnamn == "Maljos")
{
    Console.WriteLine("Va roligt att du e tillbacka!");
}

// Är dett Alushi som loggar in
if (efternamn == "Alushi")
{
    Console.WriteLine("Vad gör du här?");
}


