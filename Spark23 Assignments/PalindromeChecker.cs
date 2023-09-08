using System;
using System.Linq;
using static System.ConsoleColor;

namespace Spark;

public class Q6 {
   public static void IsPalindrome () {
      Console.WriteLine ("\x1B[4m" + "Palindrome Checker:-" + "\x1B[0m");
      for (; ; ) {
         Console.Write ("\nEnter a string: ");
         string s = Console.ReadLine ().ToLower ();
         bool palindrome = false;
         string reversed = new string(s.Reverse ().ToArray());
         if (s == reversed) palindrome = true;
         Console.WriteLine ($"{s} is {(palindrome ? "" : "NOT")} a palindrome");
         Console.Write ("\nTry again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
   }
}