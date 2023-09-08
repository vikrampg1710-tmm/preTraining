using System;
using static System.ConsoleColor;

namespace Spark;

public class Q19 {
   public static void main () {
      Console.WriteLine ("\x1B[4m" + "Factorial Computer:-" + "\x1B[0m");
      for (; ; ) {
         Console.Write ("\nEnter the number n = ");
         if (int.TryParse (Console.ReadLine (), out int num) && num < 21) {
            Console.Write ($"Factorial of {num} = ");
            Console.Write ($"{FactorialOf (num)}", Console.ForegroundColor = Yellow);
            Console.ResetColor ();
         }
         Console.Write ("\n\nTry again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            break;
         }
      }
   }

   public static int FactorialOf (int n) {
      if (n == 0) return 1;
      int ans = 1;
      for (int i = n; i > 0; i--) ans *= i;
      return ans;
   }
}
