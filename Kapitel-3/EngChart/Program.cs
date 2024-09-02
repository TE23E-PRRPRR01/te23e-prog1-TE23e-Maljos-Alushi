// Program som simulerar kända Engeneering Flowchart
using System.Runtime.CompilerServices;
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("Välkomen till Ingensjörens flödesschema");


// ACSii art
Console.WriteLine($"""
                                  _
                                    (_)
              |    .
          .   |L  /|   .          _
      _ . |\ _| \--+._/| .       (_)
     / ||\| Y J  )   / |/| ./
    J  |)'( |        ` F`.'/        _
  -<|  F         __     .-<        (_)
    | /       .-'. `.  /-. L___       
    J \      <    \  | | O\|.-'  _   
  _J \  .-    \/ O | | \  |F    (_) 
 '-F  -<_.     \   .-'  `-' L__    
__J  _   _.     >-'  )._.   |-'  
`-|.'   /_.           \_|   F    
  /.-   .                _.<     
 /'    /.'             .'  `\    
  /L  /'   |/      _.-'-\
 /'J       ___.---'\|
   |\  .--' V  | `. `
   |/`. `-.     `._)
      / .-.\
VK    \ (  `\
       `.\
""");

Console.Write("Does it move? (y/n)");
string answer = Console.ReadLine();
//kolla om svar är ja eller nej 
if (answer == "y")
{ // y
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("No Problem!");
    }
    else
    {
        Console.WriteLine("Please use Duct Tape!");
    }
}
else
{// n
    Console.Write("Should it? (y/n)");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Please use WD-40!");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}
