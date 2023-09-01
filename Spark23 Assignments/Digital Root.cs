using System;
using System.Collections.Generic;
using System.Linq;

namespace Spark;

public class Q11 {
   public static void DigitalRoot () {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine ("\x1B[4m" + "Digital Root:" + "\x1B[0m" +
         "\nThe digital root or digital sum of a non-negative integer is the " +
         "single-digit value obtained by an iterative process of summing digits.");
      Console.Write ("\nPlease ENTER A NUMBER to compute digital root(dgrt) [or] enter anything else to exit: ");
      while (long.TryParse (Console.ReadLine (), out long input)) {
         if (input < 0) {
            Console.Write ("Please enter a non-negative number: ");
            continue;
         }
         else if (input == 0) Console.WriteLine ($"DigitalRoot({input}) = 0");
         else if (input % 9 == 0 && input > 0) Console.WriteLine ($"dgrt({input}) = 9");
         else Console.WriteLine ($"dgrt({input}) = {input % 9}");
         if (input > 9) {
            Console.Write ("Show the steps (y/n)? ");
            if (char.ToLower (Console.ReadKey ().KeyChar) == 'y') {
               Console.WriteLine ("\n\n" + "\x1B[4m" + "Steps:" + "\x1B[0m");
               int x = input.ToString ().Length;
               DigitalSumOF (input);
               void DigitalSumOF (long num) {
                  List<int> parts = new ();
                  Console.Write (num == input ? $"  dgrt({num}) = " : $"{new string (' ', 7 + x)}==> ");
                  while (num > 9) {
                     int d = (int)(num % 10);
                     parts.Add (d);
                     num = (num - d) / 10;
                  }
                  if (num < 10) parts.Add ((int)num);
                  parts.Reverse ();
                  int sum = parts.Sum ();
                  if (parts.Count > 1) {
                     Console.CursorLeft = 12 + x;
                     for (int d = 0; d < parts.Count; d++)
                        Console.Write (d == parts.Count - 1 ? parts[d] : $"{parts[d]} + ");
                     Console.CursorLeft = 12 + x * 5;
                     Console.WriteLine ($" = {sum}");
                     if (sum > 9) {
                        num = sum;
                        DigitalSumOF (num);
                     }
                     else {
                        Console.WriteLine ($"∴ dgrt({input}) =  {sum}", Console.ForegroundColor = ConsoleColor.Cyan);
                        Console.ResetColor ();
                     }
                  }
               }
            }
         }
         Console.Write ("\nTry another number: ");
      }
   }
}
