/**********************************************
*                   M A I N                   *
**********************************************/
// Skriv all kod här 
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

string val = Console.ReadLine();
Console.WriteLine("Välkommen till Ceasar-kryptot!");

Meny();

while (true)
{
   if (val == "1")
   {
    Kryptera();
   }
   else if (val == "2")
   {
     Avkryptera();
   } else if (val == "3")
   {
       Console.WriteLine("Tack och hej för idag!!!");
       break;
   }
}


/**********************************************
*               M E T H O D S                 *
**********************************************/
// skriv alla metoder här 
static void Meny()
{
Console.WriteLine("""
1. Kryptera meddelande
2. Avkryptera meddelande
3. Avsluta programmet
Ange ditt val:
""");
}
static void Kryptera()
{
    Console.WriteLine("Ange det du vill Kryptera:");
    string svar = Console.ReadLine();
}
static void Avkryptera()
{
    Console.WriteLine("Ange det du vill Avkryptera:");
    string svar1 = Console.ReadLine();
}