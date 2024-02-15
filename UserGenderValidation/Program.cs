// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Alex!");
// 
Console.WriteLine("Please select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine());//

Console.WriteLine("Please enter your last name:");

    string UserLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserLastName}!");
}
else 
{
    Console.WriteLine($"Welcome, {UserLastName}!");
}
