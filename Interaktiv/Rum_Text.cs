using System;
using System.Reflection.Metadata;
using System.Linq;

namespace Interaktiv;

class Rum_Text
{

 public string answer;
public static string[] tableAnser = ["home","outside","sofa","bath","buss","car"];
 



public void makeChoice(){
answer = Console.ReadLine(); 
}


public void printChoice(){

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
break;

case (string)"bath":
Console.WriteLine("1.2 end");
break;

case (string)"buss stop":
Console.WriteLine("2.1 end");
break;

case (string)"car":
Console.WriteLine("2.2 end");
break;


} // switch

} // test metod

} // class

