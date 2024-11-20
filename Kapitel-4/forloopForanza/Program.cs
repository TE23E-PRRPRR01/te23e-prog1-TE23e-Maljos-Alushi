using System.Diagnostics;

Console.Clear();
string input = Console.ReadLine();
Console.Write("Ange minimum värde: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ange maximum värde: ");
int max = int.Parse(Console.ReadLine());
int summan = 0;
for (int i = min; i <= max + 1; i++)
{
    if (i % 2 == 0)
    {
   summan += i;

    }
}
Console.WriteLine($"Summan av sifruorna {min} till {max} är {summan}");

Console.WriteLine("Jämna siffror från 1 till 20: ");
for (int i = 1; i < 20; i++)
{
    if (1 % 2 == 0)
    {
        Console.Write($"{i}");
    }
}
