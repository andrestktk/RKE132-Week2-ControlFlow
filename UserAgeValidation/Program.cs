// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajalt valida tema sugu (m/f)
//Rakendus küsib kasutajal sisestada tema perekonnanime
//Lähetudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome, MR. [kasutaja perekonnanimi] / Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Pleas, enter your last name");

string userLastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastname}!");
}
else
{
    Console.WriteLine("Welcome!");
}
