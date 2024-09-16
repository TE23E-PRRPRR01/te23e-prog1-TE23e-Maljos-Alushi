// Spelat - Gissa ett slumptal 1-100
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Spelet - Gissa ett slumptal 1-100");

// Be användare ange slumptalets gänser med min och max 
Console.WriteLine("Ange lumptalets min-värde");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Ange lumptalets max-värde");
int max = int.Parse(Console.ReadLine());


// Slumpar ett tal 1-100
int slumptal= Random.Shared.Next(min, max +1);

// upprepning - loop
while (true)
{
  // ställ fråga till användare 
  Console.WriteLine($"Gissa ett tal ({min}-{max})");
  int gissning = int.Parse(Console.ReadLine());
  
  

 // kontroll om gissningen är rätt?
  if (gissning == slumptal)
  {
    Console.WriteLine("Jackpot");
    break;
  }
  else if (gissning > slumptal)
  {
    Console.WriteLine("För Högt");
  }
  else
  {
    Console.WriteLine("För Lågt");
  }
  // Vill användaren gissa en gång till?
  Console.WriteLine("Vill du gissa en gång till? (j/n)");
  string svar = Console.ReadLine();
  if(svar == "n");
  {
    break;
  }
}


// slut på spelet 
Console.WriteLine("Tack för att du har spelat mitt fina spel");
