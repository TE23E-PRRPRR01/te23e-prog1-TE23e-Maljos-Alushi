/********************************************
***************   M A I N  *****************
/********************************************/
Console.Clear();
Console.WriteLine();

SägHejNamn("Maljos");
SägHejNamn("Deniss");
SägHejNamn("Dante");
SägHejNamn("");

KvadreraTal(2);


/********************************************
************* M E T O D E R *****************
/********************************************/
/// <summary>
/// Skriv ut hälsning 
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}! ");
}

/// <summary>
///  metod för nummer 
/// </summary>
/// <param name="nummer">tal</param>

static void KvadreraTal(int tal)
{
    Console.Write($"{tal} i kvadrat = {tal*tal}");
    
}