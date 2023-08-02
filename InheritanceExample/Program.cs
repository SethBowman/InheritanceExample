
using InheritanceExample;


var seth = new Coder();

seth.Name = "Seth";

seth.ProgrammingLanguage = "C#";

seth.Greet();
seth.Code();

Console.WriteLine();

var bob = new Person();

bob.Name = "Bob";

bob.Greet();

Console.WriteLine();

var bill = new Athlete();

bill.Name = "Bill";

bill.Greet();

bill.Sport = "Football";
bill.PlayGame();

bill.Code();
Console.WriteLine();

var people = new List<Person>() 
{ 
    seth, 
    bob, 
    bill
};

foreach(var person in people)
{
    if (person is Coder)
    {
        Console.WriteLine($"My name is {person.Name} and I am a coder!");
    }
    else if (person is Athlete)
    {
        Console.WriteLine($"My name is {person.Name} and I play sports!");
    }
    else
    {
        Console.WriteLine($"My name is {person.Name} and I'm jus a regular ole guy.");
    }
}
