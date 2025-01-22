/*************
*** M A I N ***
**************/
Console.Clear();

VisaProgram();

while (true)
{
    Meny();
    string val = Console.ReadLine();
    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {
        Subtraktion();
    }else if (val == "3")
    {
        Multiplikation();
    }else if (val == "4")
    {
        Divition();
    }else if (val == "5")
    {
        Console.WriteLine("Hej då");
        break;
    }
}

/* ****************
*** M E T O D E R **
********************/
static void VisaProgram()
{
    
}

static void Meny()
{
    Console.WriteLine("""
    
    1. Addition
    2. Subtraktion
    3. Multiplikation
    4. Divition
    5. Avsluta Programet
    """);
    Console.WriteLine("Ange ditt val: ");
}

static void Addition( )
{
    Console.WriteLine("Ange tal:");
    int tal1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange tal:");
    int tal2 = int.Parse(Console.ReadLine());
}

static void Subtraktion()
{
    Console.WriteLine("Ange tal:");
    int tal1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange tal:");
    int tal2 = int.Parse(Console.ReadLine());
}
static void Multiplikation()
{
    Console.WriteLine("Ange tal:");
    int tal1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange tal:");
    int tal2 = int.Parse(Console.ReadLine());
}
static void Divition()
{
   Console.WriteLine("Ange tal:");
    int tal1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange tal:");
    int tal2 = int.Parse(Console.ReadLine());
}
