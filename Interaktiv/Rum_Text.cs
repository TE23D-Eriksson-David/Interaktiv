using System;
using System.Reflection.Metadata;

namespace Interaktiv;

class Rum_Text
{


 public string answer;
 //static string tidigareVal;

 //float tco = 3.14f;
 //public int oct = 1;
public void makeChoice(){
answer = Console.ReadLine();  

}



public void printChoice(){
//Console.WriteLine(oct);


switch ((string)answer) { 

case (string)"1":
Console.WriteLine("1 midle");
Console.WriteLine("Left or right");
break;

case (string)"2":
Console.WriteLine("2 midle");
Console.WriteLine("Left or right");
break;

case (string)"3":
Console.WriteLine("1.1 end");
break;

case (string)"4":
Console.WriteLine("1.2 end");
break;

case (string)"5":
Console.WriteLine("2.1 end");
break;

case (string)"6":
Console.WriteLine("2.2 end");
break;


} // switch

} // test metod


} // class

