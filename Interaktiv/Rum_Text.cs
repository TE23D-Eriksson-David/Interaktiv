using SC = System.Console;
using System.Reflection.Metadata;
using System.Linq;

namespace Interaktiv;
class Rum_Text
{
int place = 0;
public bool run = true;
 public string answer;
 public string choice1 = "home";
 public string choice2 = "outside";
public static string[] tableAnser = ["home","sofa","bath","outside","buss","car"];
 

public void makeChoice(){
answer = SC.ReadLine().ToLower(); 
}
public void printChoice(){
switch ((string)answer) { 

case (string)"home":
if (place > -1 & place < 1) {
SC.WriteLine("1 midle");
place = -1;
choice1 = "sofa";
choice2 = "bath";
}
break; 

case (string)"outside":
if (place > -1 & place < 1) {
SC.WriteLine("2 midle");
place = 1;
choice1 = "buss stop";
choice2 = "car";
}
break;

case (string)"sofa":
if (place > -2 & place <= -1) {
SC.WriteLine("1.1 end");
place = -2;
run = false;
}
break;

case (string)"bath":
if (place > -2 & place <= -1) {
SC.WriteLine("1.2 end");
place = -2;
run = false;
}
break;

case (string)"buss stop":
if (place >= 1 & place < 2) {
SC.WriteLine("2.1 end");
place = 3;
run = false;
}
break;

case (string)"car":
if (place >= 1 & place < 2) {
SC.WriteLine("2.2 end");
place = 3;
run = false;
}
break;

} // switch
} // test metod
} // class