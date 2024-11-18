using System.Reflection;

Console.Clear();
// Skapa en loop som körs 10 gånger.
// Varje gång loopen körs ska den skriva ut ditt namn, exempelvis:
while (true)
{
    // be användare att ange namn 
    Console.Write("Ange ditt namn: ");
    string namn = Console.ReadLine();

    int nummer = 0;

    while (true)
    {
        Console.WriteLine("Hur många gånger vill du skriva ut ditt namn?");
        string input = Console.ReadLine();
        if (int.TryParse(input, out nummer) && nummer >= 1 && nummer <= 10)
        {
            break;
        }
        else
        {
            Console.WriteLine("Fel aktigt inmatning. Ange ett tal mellan 1 och 10.");
        }
    }

    Console.WriteLine("Resultat: ");
    for (int i = 0; i < nummer; i++)
    {
        Console.WriteLine($"{i + 1}. {namn}");
    }

    break;

}