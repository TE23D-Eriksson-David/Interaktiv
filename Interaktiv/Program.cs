using System;
using System.IO;
using Interaktiv;

bool firstRun = true;
Rum_Text a1 = new Rum_Text();

while(true){

if (firstRun == true){ 
  Console.WriteLine("home or outside?");
} 

else {
a1.makeChoice();
if (Rum_Text.tableAnser.Contains(a1.answer))
{
a1.printChoice();
//Console.ReadLine();
//Console.Clear();
}
}

firstRun = false;
}