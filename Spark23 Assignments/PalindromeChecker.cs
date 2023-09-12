using System;
using System.Linq;
using System.Text.RegularExpressions;
using static System.ConsoleColor;

namespace Spark;

public class Q6 {
   public static void main () {
      Console.WriteLine ("\x1B[4m" + "Palindrome Checker:-" + "\x1B[0m");
      int count = 1;
      string output;
      string[] test = new string[] { "Madam", "Equador", "Don't Nod", "123454321", "Borrow or rob?", "Sir, I demand, I am a maid named Iris;", "A man, a plan, a canal, Panamaa!" };
      Console.WriteLine ("A palindrome is a word, sentence, verse, or even number that reads the same backward or forward.  Eg: ");
      foreach (string str in test) { 
         Console.Write ($"{count++}. {str} ");
         (output, Console.ForegroundColor) = IsPalindrome (str) ? ("Palindrome", Green) : ("Not a Palindrome", Red);
         Console.WriteLine ($" - {output}");
         Console.ResetColor ();
      }
      Console.Write ("\nNow, lets enter a string to check: ");
      string s = Console.ReadLine ();
      (output, Console.ForegroundColor) = IsPalindrome (s) ? ("Palindrome", Green) : ("Not a Palindrome", Red);
      Console.WriteLine ($"{output}");
      Console.ResetColor ();
      Console.ReadLine ();
   }
   public static bool IsPalindrome (string str) {
      str = Regex.Replace (str, "[@,\\.\";'?\\\\ ]", "").ToLower();
      return str == new string (str.Reverse ().ToArray ());
   }
}
