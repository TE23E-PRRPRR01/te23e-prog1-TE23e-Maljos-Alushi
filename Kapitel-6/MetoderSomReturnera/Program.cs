/********************************************
***************   M A I N  *****************
/********************************************/
using System.Runtime.ConstrainedExecution;

Console.Clear();
// Anväd mertoder här 
// int svar = Addera(2, 6);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera (2, 6));
// Console.WriteLine($" 2 + 6 = {Addera(2,6)}");


// string namn = "Maljos";
// Console.WriteLine($"{namn} baklänges är {VändText(namn)}");


// Console.WriteLine(Multiplicera(3, 8));
// Console.WriteLine(Dividera(8, 4));

// Console.WriteLine($"{Längst("Hej", "Hejsan")}");

Console.Write("Ange ett tal : ");
int nyTal = LäsInHeltal();

Console.Write("Ange ett tal : ");
int nyTal2 = LäsInHeltal();

/********************************************
************   M E T O D E R   **************
/********************************************/
// Skapa metoder här

/// <summary>
/// summerar 2 tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
// static int Addera(int tal1, int tal2) // signatur 
// {
//     int summa = tal1 + tal2 ; 
//     return summa; 
// }
/// <summary>
/// vänder på texten 
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (var i = text.Length - 1; i >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}
/// <summary>
/// multiplucera tal 
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera(double tal1, double tal2)
{
    double summa = tal1 * tal2;
    return summa;
}
/// <summary>
/// Dividera tal 
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    double summa = tal1 / tal2;
    return summa;
}

static string Längst(string text1, string text2)
{
    if (text1.Length > text2.Length)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}
/// <summary>
/// Säket sätt att läsa in ett tal (utan att det kraschar)
/// </summary>
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        string textSomBlirTal = Console.ReadLine();
        // kolla om texten är ett tal 
        bool lyckades = int.TryParse(textSomBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Fel! Va god ange ett tal!!!");
        }

    }
        return tal;
}