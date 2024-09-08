using SC = System.Console;
using System.IO;
using Interaktiv;

Rum_Text a1 = new Rum_Text();

while(a1.run == true){
SC.WriteLine($"write where you want to go {a1.choice1} or {a1.choice2}?");
a1.makeChoice();
SC.Clear();
if (Rum_Text.tableAnser.Contains(a1.answer))
{
a1.printChoice();
}
SC.ReadLine();
} //while