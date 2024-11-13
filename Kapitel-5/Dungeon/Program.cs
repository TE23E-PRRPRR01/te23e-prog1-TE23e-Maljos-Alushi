// Ett dungeon spel med massa rum saker, fiender, sktter ....
using System.Globalization;

Console.Clear();
Console.WriteLine("Ett Dungeon Spel");

// Programvariabel (state variables)
string rum = "hallen";
List<string> inventory = [];

// spelloop
while (true)
{
    // är vi i hallen?
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra?");
        string val= Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar i rumet och ser några gamla tavlor.");
        }
        else if (val == "2")
        {
            rum = "rum1";
            Console.WriteLine(" ... du går in i nästa rum");
        }
    }
    else if (rum== "rum1")
    {
         Console.WriteLine("Du är i rum1");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå tillbacka till hallen");
        Console.Write("Vad vill du göra?");
        string val= Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du sen en nyckel op golvet.");
            Console.Write("Vill du plocka upp nyckel (j/n)");
            if (val == "j")
            {
                inventory.Add("nyckel");
                Console.WriteLine("Du plockade upp nyckeln.");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet!");
            }
        }
        else if (val == "2")
        {
            rum = "hallen";
            Console.WriteLine(" ... du går in i hallenb");
        }
    }
    else if (rum== "rum2")
    {
        Console.WriteLine("Du är i rum2");
        Console.WriteLine("1. Titta runt");
        Console.WriteLine("2. Gå till nästa rum");
        Console.Write("Vad vill du göra?");
        string val= Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar i rumet och ser några gamla tavlor.");
        }
        else if (val == "2")
        {
            rum = "rum1";
            Console.WriteLine(" ... du går in i nästa rum");
        }
    }
    
}