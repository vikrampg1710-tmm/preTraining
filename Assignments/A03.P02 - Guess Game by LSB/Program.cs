// ------------------------------------------------------------------------------------------------
// A.03.P02 - To make the computer to guess number [0 - 127] from Least Significant Digit.
// ------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

Console.Write ("Enter your name: ");
string name = Console.ReadLine ();
Console.WriteLine ();
Console.WriteLine ($"Hi {name}!  Welcome to Guess Game...\n");
Console.WriteLine ("Think of a number between 0 and 127.\nAnd I will try to guess it correctly, if you answer my 7 questions.");
Console.WriteLine ("Shall we start? (Press ENTER) ");
Console.ReadKey ();
List<int> bitList = new List<int> () { 0, 0, 0, 0, 0, 0, 0 };
List<int> twoPowers = new List<int> () { 64, 32, 16, 8, 4, 2, 1 };
int n = 2;

//Question 1:
Console.WriteLine ();
Console.Write ("Is your number even or odd? (e/o): ");
string firstLSD = Console.ReadLine ();
if (firstLSD == "o" || firstLSD == "O")
   bitList[6] = 1;
Console.WriteLine ($"The 1st least significant digit = {bitList[6]}");

//Question 2 to 7:
for (int i = 5; i >= 0; i--) {

   Console.WriteLine ();
   Console.Write ($"Your number mod {(Math.Pow (2, n))}, = [{(Math.Pow (2, n - 1))}, {(Math.Pow (2, n) - 1)}]? (y/n): ");
   string nthLSD = Console.ReadLine ();
   if (nthLSD == "y" || nthLSD == "Y")
      bitList[i] = 1;
   Console.WriteLine ($"The 2nd least significant digit = {bitList[i]}");
   n++;
}

for (int i = 0; i <= 6; i++)
   twoPowers[i] = twoPowers[i] * bitList[i];

Console.WriteLine ();
Console.WriteLine ($"I got you!\n\n0b{String.Join ("", bitList)} = {twoPowers.Sum ()}.");
Console.WriteLine ("And this it the number you have thought, isn't it?");
