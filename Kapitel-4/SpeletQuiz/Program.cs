// Sett spel som frågar personer om dens kunskaper 
Console.Clear();
Console.WriteLine("Välkomen till Quiz the game");

Console.Write("Vad heter du?");
string namn = Console.ReadLine();

Console.WriteLine("""
Fråga 1: Vad är Albaniens Huvudstad?
a)Tirana 
b)Paris 
c)Pristina 
Ditt svar(a, b eller c):
""");
string answer1 = Console.ReadLine().ToLower();

if (answer1 == "a")
{
    Console.WriteLine("Bravo, det är rätt");
}
else
{
    Console.WriteLine("Nej det är fel svar");
}

Console.WriteLine("""
 Fråga 2: Vad är den största land (i landmassa)?
  a) Kina
  b) Ryssland
  c) Norge
 """);
string answer2 = Console.ReadLine().ToLower();

if (answer2 == "b")
{
    Console.WriteLine("Perfekt !!!");
}
else
{
    Console.WriteLine("Nej men landets granne");
}

Console.WriteLine("""
Fråga 3: Vad heter den längsta floden i världen?

a) Amazonas
b) Nilen
c) Yangtze
""");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "b")
{
    Console.WriteLine("Det är rätt!");
}
else
{
    Console.WriteLine("Fel!!!!!");
}


Console.WriteLine("""
Fråga  4: Vilken planet är känd som "den röda planeten"?

a) Venus
b) Mars
c) Jupiter
""");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "b")
{
    Console.WriteLine("Det är rätt!");
}
else
{
    Console.WriteLine("No good");
}















