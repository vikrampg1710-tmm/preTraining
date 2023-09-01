using System;
using System.Linq;
using static System.ConsoleColor;

namespace Spark;

public class Q18 {
   public static void IsArmstrongNum () {
      Console.WriteLine ("\x1B[4m" + "Armstrong Number Checker:-" + "\x1B[0m");
      for (; ; ) {
         bool isArms;
         int temp, d, sum = 0;
         Console.Write ("\nEnter a positive integer: ");
         if (int.TryParse (Console.ReadLine (), out int num) && num >= 0) {
            temp = num;
            int n = num.ToString ().Length;
            while (temp > 0) {
               d = temp % 10;
               temp = (temp - d) / 10;
               sum += (int)Math.Pow(d, n);
            }
            isArms = (sum == num) ;
            Console.ForegroundColor = isArms ? Green : Red;
            Console.WriteLine($"The number {num} is{(isArms ? "" : " NOT")} an Armstrong Number.");
            Console.ResetColor();
         }
         else if (num < 0) { Console.WriteLine ("Incorrect input!"); continue; }
         Console.Write ("Try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("\nProgram terminated.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
      Console.WriteLine ();
   }
}
