﻿using System;
using System.IO;

String filepath = @"C:\Users\david.eriksson5\Programering VS\Interaktiv\Interaktiv\ASCII.txt";
string info = File.ReadAllText(filepath);
Console.WriteLine(info);
Console.ReadLine();

/*
                        (
                          )     (
                   ___...(-------)-....___
               .-""       )    (          ""-.
         .-'``'|-._             )         _.-|
        /  .--.|   `""---...........---""`   |
       /  /    |                             |
       |  |    |                             |
        \  \   |                             |
         `\ `\ |                             |
           `\ `|                             |
           _/ /\                             /
          (__/  \                           /
       _..---""` \                         /`""---.._
    .-'           \                       /          '-.
   :               `-.__             __.-'              :
   :                  ) ""---...---"" (                 :
    '._               `"--...___...--"`              _.'
      \""--..__                              __..--""/
       '._     """----.....______.....----"""     _.'
          `""--..,,_____            _____,,..--""`
                        `"""----"""`
*/



//bool test true || false;
//Console.WriteLine(test);

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




