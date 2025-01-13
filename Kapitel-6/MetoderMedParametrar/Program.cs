/********************************************
***************   M A I N  *****************
/********************************************/
Console.Clear();

KastaTärning(2);
// OmvandlaTemperatur(16);
// //Skriv ut ett medelade vertikalt 
// string meddelade1 = "Måndag!";
// // SkrivVertikalt(meddelade1);
// //Skriv ut ett medelade vertikalt nr2
// string meddelade2 = "Tisdag är bättre!";
// // SkrivVertikalt(meddelade2);

// //Skriv ut ett medelade vertikalt nr2
// string meddelade3 = "Onsdag är lång!";
// // SkrivVertikalt(meddelade3);

// // rita ut en fyrkant med sidläng 3
// RitaKvadrat(3);
// RitaKvadrat(4);
// /********************************************
// **************  M E T O D E R   *************
// /********************************************/
// /// <summary>
// /// Skriv in meddelande vertikaln 
// /// </summary>
// /// <param name="meddelade">meddelande</param>
// static void SkrivVertikalt(string meddelade)
// {
//     for (var i = 0; i < meddelade.Length; i++)  // 0->6
//     {
//         Console.WriteLine(meddelade[i]);
//     }
// }
// static void RitaKvadrat(int sidlängd)
// {
//     for (var i = 0; i < sidlängd; i++)
//     {
//         for (var j = 0; j < sidlängd; j++)
//         {
//             Console.Write("*");
//         }
//         Console.WriteLine();
//     }
// }

// static void UpprepaText(string text, int antal)
// {
//     for (var i = 0; i < antal; i++)
//     {
//         Console.WriteLine(text);
//     }
// }

// Omvandla C till F

// static void OmvandlaTemperatur(int celsius)
// {
//     int farhrenheit = celsius * 9/5 + 32;
//     Console.WriteLine($"{celsius} grader Celsius motsvara {farhrenheit} grader Farhrenheit");
// }

 static void KastaTärning(int antal)
 {
  for (var i = 0; i < antal; i++)
  {
    Console.WriteLine($"Tärningen visar {Random.Shared.Next(1,7)}");
  }
 }