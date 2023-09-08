using System;

namespace Spark;

public class Q10 {
   public static void ReverseAInteger () {
      Console.WriteLine ("\x1B[4m" + "Integer Reversing:" + "\x1B[0m");
      for (; ; ) {
         int rInput = 0, sign = 1, d;
         Console.Write ("\nPlease enter an 9-digit integer [or] 0 to exit: ");
         var num = Console.ReadLine ();
         int c = num.Length;
         if (c > 9) continue;
         if (int.TryParse(num, out int input) && input != 0) {
            if (input < 0) sign *= -1; input *= sign; 
            Console.Write (input);
            for (int i = 0; i < c; i++) {
               d = input % 10; 
               input = (input - d) / 10;
               rInput += d * (int)Math.Pow (10, c - 1 - i);
            }
            Console.WriteLine ($" ==> {rInput * sign}", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.ResetColor ();
         }
         else break;
      }
   }
}
