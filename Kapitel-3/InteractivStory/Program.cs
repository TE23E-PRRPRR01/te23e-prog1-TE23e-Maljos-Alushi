// See https://aka.ms/new-console-template for more informatio
Console.Clear();

Console.WriteLine("welcome till Drake och dongeunus.");

Console.Write("You see a cave, do you go inside of it? (y/n)");
string answer  = Console.ReadLine();

if (answer == "y")
{
    Console.WriteLine("Now you are inside of the cave and you see a wizard. Do you talk to him or leave him alone? (y/n)");
    answer=Console.ReadLine();
    
    if (answer=="y")
    {
        Console.WriteLine("The wizard gives you a potion. Do you drink it? (y/n)");
        answer = Console.ReadLine();
    
        if (answer=="y")
        {
            Console.WriteLine("You have been poisoned! and now you are dead.");
        }
        else
        {
            Console.WriteLine("The wizard gets mad at you and throws the potion at your head and you die.");
        }
    }
    else
    {
        Console.WriteLine("You go further in the cave and die from low oxygen levels!");
    }
}
else
{
    Console.WriteLine("You live a another day!");
}