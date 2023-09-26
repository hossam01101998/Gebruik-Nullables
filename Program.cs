// verkoop, ondersteuning administratie


Console.WriteLine("Naam van de werknemer");
string naam = Console.ReadLine();

Console.WriteLine("Hoeveel jaren heeft die in Verkoop afdeling gewerkt? (Indien 0 schrijf niks)");
string uitvoer1 =Console.ReadLine();
int? jarenVerkoop = null;
if(uitvoer1 != "") { jarenVerkoop = Convert.ToInt32(uitvoer1); }

Console.WriteLine("Hoeveel jaren heeft die in Ondersteuning afdeling gewerkt? (Indien 0 schrijf niks)");
string uitvoer2 = Console.ReadLine();
int? jarenOndersteuning = null;
if (uitvoer2 != "") { jarenOndersteuning = Convert.ToInt32(uitvoer2); }

Console.WriteLine("Hoeveel jaren heeft die in Administratie afdeling gewerkt? (Indien 0 schrijf niks)");
string uitvoer3 = Console.ReadLine();
int? jarenAdministratie = null;
if (uitvoer3 != "") { jarenAdministratie = Convert.ToInt32(uitvoer3); }


int aantalAfdelingen = 0;
int aantalJaren = 0;

if (jarenVerkoop.HasValue && jarenVerkoop != 0)
{
    aantalAfdelingen++;
    aantalJaren += jarenVerkoop.Value;
}

if (jarenOndersteuning.HasValue && jarenOndersteuning != 0)
{
    aantalAfdelingen++;
    aantalJaren += jarenOndersteuning.Value;
}

if (jarenAdministratie.HasValue && jarenAdministratie != 0)
{
    aantalAfdelingen++;
    aantalJaren += jarenAdministratie.Value;
}

double bonuspercentage = 0.02 * aantalJaren;

//Console.WriteLine(aantalAfdelingen);

if (aantalAfdelingen >= 2)
{
    Console.WriteLine($"Bonus percentage voor {naam} is {bonuspercentage}");
}
else
{
    Console.WriteLine($"{naam} heeft geen bonus percentage");
}