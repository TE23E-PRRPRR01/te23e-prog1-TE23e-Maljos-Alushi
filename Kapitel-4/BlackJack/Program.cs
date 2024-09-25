//Svartjack även kallat för 21
using System.Security.Cryptography;

Console.Clear();
Console.WriteLine("Välkomen till svartjack!");

//kortens värde är 
// 2-10 = 2-10
//knekt, dam, kung = 10
// ess = 1 eller 11 
//@todo slump måste efeter lika riktig kortlek ,dv 4x1 4x2 4x3 4x4

//variabeler 
int summaSpelare = 0;
int summaDeler = 0;
int kort = 0;

// dela ut två kort till spelaren 
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
// dela ut två kort till datorn 
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDeler += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDeler += kort;


// flera gånger (loop)
while (true)
{
    // skriv ut summorna 
    Console.WriteLine($"Du har {summaSpelare} poäng ");
    Console.WriteLine($"Datorn har {summaDeler} poäng");

    // stanna eller dra ett kort?
    Console.Write("Vill du ha ett ny kort? (j/n)");
    string svar = Console.ReadLine().ToLower();

    if (svar == "n")
    {
        // @attodo datorn får ta <=17
        while (summaDeler < 17)
        {
            kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
            summaDeler += kort;
        }
        //vem har vunnit ?
        // den som har närmast 21 har vunnit 
        if (summaSpelare > summaDeler && summaSpelare < 21)
        {
            Console.WriteLine("Du har vunnit!");
        }
        else
        {
            Console.WriteLine("Datorn har vunnit!");
        }
        break;
    }

    // ta ett extra kort om man vill
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaSpelare += kort;
    //skriv ut kortet
    Console.WriteLine($"Du fick {kort}");

    // Datorn får också ett ny kort 
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaDeler += kort;
    //skriv ut kortet
    Console.WriteLine($"Deler fick {kort}");

    // vem har vunnit?
    // har spelaren fårtt 21 har spelaren vunnit 
    if (summaDeler == 21)
    {
        Console.WriteLine("Deler har vunnit");
        break;
    }
    // om deler har fått 21 har den vunnit 
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit");
        break;
    }

    // är spelaren tjock
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat!");
        break;
    }

    //on darorn är tjock
    if (summaDeler > 21)
    {
        Console.WriteLine("Deler är tjock!");
        break;
    }
}


