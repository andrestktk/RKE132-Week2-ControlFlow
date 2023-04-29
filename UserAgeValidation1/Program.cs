// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years ikd.");

if (isAgeNumber == true)
{
    if (userAgeNum >=13)
    {
        Console.WriteLine("Welcome to Instragram.");
     }

    else 
    {
        Console.WriteLine("You are to young to use Instragram");
     }
}
else
{
    Console.WriteLine("Could not read your age!");
}

//int userAge = Int32.Parse(Console.ReadLine());

