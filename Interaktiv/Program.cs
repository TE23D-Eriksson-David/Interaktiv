using System;
using System.IO;
using Interaktiv;

bool firstRun = false;
Rum_Text a1 = new Rum_Text();

while(true){
if (firstRun != true){ 
  Console.WriteLine("Left or right?");
  firstRun = true;
} else {
a1.makeChoice();
a1.printChoice();
Console.ReadLine();
Console.Clear();
}

}







//a1.oct = 10;

static void ostMetod()
{
  Console.WriteLine("Hej!");
}

//ostMetod();




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