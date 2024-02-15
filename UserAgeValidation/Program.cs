// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int UserAge = Int32.Parse (Console.ReadLine()); //"13" - heap, 13 - stack 

Console.WriteLine($"Parse result {isAgeNumber}, user is {userAgeNum} years old.");

if (isAgeNumber == true)
{
    if(userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagaram!");
     }
    else 
    { Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}