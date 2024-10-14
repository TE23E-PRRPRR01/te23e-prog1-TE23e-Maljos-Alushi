// Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");

List<string> namnlista = [];

// progrmloopen
while (true)
{
    // visa en meny
    Console.WriteLine("""
1. Registrera namn 
2. Skriva ut alla namn
3. Avsluta
Ange ditt val:
""");
    string val = Console.ReadLine();
    if (val == "1")
    {
      Console.WriteLine("Ange ett namn:");
      string namn = Console.ReadLine();
      namnlista.Add(namn);
    }
    if (val == "2")
    {
       foreach (var namn in namnlista)
       {
         Console.Write($"{namn}");
       }
       Console.WriteLine();
    }
    if (val == "3")
    {
        break;
    }
}
