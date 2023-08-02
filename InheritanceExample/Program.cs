
using InheritanceExample;


var seth = new Coder();

seth.Name = "Seth";

seth.ProgrammingLanguage = "C#";
seth.Code();

seth.Greet();

var bob = new Person();

bob.Name = "Bob";

bob.Greet();


var bill = new Athlete();

bill.Name = "Bill";

bill.Greet();

bill.Sport = "Football";
bill.PlayGame();

bill.Code();
