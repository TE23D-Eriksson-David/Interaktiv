using System;
using System.IO;
using Interaktiv;

bool firstRun = true;
Rum_Text a1 = new Rum_Text();

while(true){
if (firstRun == true){ 
  Console.WriteLine("home or outside?");
} else {
a1.makeChoice();
a1.printChoice();
//Console.ReadLine();
//Console.Clear();
}
firstRun = false;
}







//a1.oct = 10;

static void ostMetod()
{
  Console.WriteLine("Hej!");
}

//ostMetod();

if (Rum_Text.tableAnser.Contains("cgyjcguk"))
{}


//bool test true || false;
//Console.WriteLine(test);

/*
Console.WriteLine("Användarnamn");
string name = Console.ReadLine();

if (name.ToLower() == "mike") {
  Console.WriteLine("hej");
}


if (name == "mike" || name == "Mike") {
Console.WriteLine("Inloggad välkomen!");
} 

else if (name == "martin") {
  Console.WriteLine("Mja kanshe");
} 

else {
  Console.WriteLine("Nuh-uuh!");
}
Console.ReadLine();

*/