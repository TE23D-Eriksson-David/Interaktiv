using System;
using System.Reflection.Metadata;
using System.Linq;

namespace Interaktiv;

class Rum_Text
{

bool validAnswer = true;
 public string answer;
 static string tidigareVal;
public static string[] tableAnser = ["home","outside","sofa","bath","buss","car"];
string choice = Console.ReadLine();
public static bool validAnswer = tableAnser.Contains(choice);

if (validAnswer == false) {

}




 //float tco = 3.14f;
 //public int oct = 1;
public void makeChoice(){
answer = Console.ReadLine(); 


}



public void printChoice(){
//Console.WriteLine(oct);


switch ((string)answer.ToLower()) { 

case (string)"home":
Console.WriteLine("1 midle");
Console.WriteLine("sofa or bath");
break;

case (string)"outside":
Console.WriteLine("2 midle");
Console.WriteLine("buss or car");
break;

case (string)"sofa":
Console.WriteLine("1.1 end");
Console.ReadLine();
break;

case (string)"bath":
Console.WriteLine("1.2 end");
Console.ReadLine();
break;

case (string)"buss stop":
Console.WriteLine("2.1 end");
Console.ReadLine();
break;

case (string)"car":
Console.WriteLine("2.2 end");
Console.ReadLine();
break;


} // switch

} // test metod


} // class

