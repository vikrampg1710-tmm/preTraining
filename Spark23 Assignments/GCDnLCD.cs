using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using static System.ConsoleColor;
using System.Numerics;

namespace Spark;

public class Q4 {
   public static void main () {
      List<int> TestCases = new () {6, 7, 8, 9, 10, 30, 72, 135, 180, 225 };
      Console.WriteLine ("\x1B[4m" + "GCD & LCM Generator:-" + "\x1B[0m");
      Console.Write ("The test cases are: ");
      foreach (var item in TestCases) WriteInYellow (item + ", ");
      Console.CursorLeft -= 2;
      Console.Write ("\nGCD = ");
      WriteInYellow ($"{GCDof (TestCases)}");
      Console.Write ("\nLCM = ");
      WriteInYellow ($"{LCMof (TestCases)}");
   }
   public static void GCDnLCM () {
      Console.WriteLine ("\x1B[4m" + "GCD & LCM Generator:-" + "\x1B[0m");
      for (; ; ) {
         Console.Write ("\nEnter the count of no. of inputs: ");
         if (int.TryParse (Console.ReadLine (), out int n) && n > 0 && n < 10) {
            List<int> inputs = new ();
            for (int i = 0; i < n; i++) {
               Console.Write ($"Enter input-{i + 1} = ");
               if (int.TryParse (Console.ReadLine (), out int j)) inputs.Add (j);
               else i--;
            }
            Console.Write ("GCD = ");
            WriteInYellow($"{GCDof (inputs)}");
            Console.Write ("LCM = ");
            WriteInYellow ($"{LCMof (inputs)}");
         }
         else if (n < 0 || n > 30) Console.Write ("Incorrect input!");
         Console.Write ("\nWant to try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("\nProgram terminated due to incorrect input.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
   }

   public static int GCDof (List<int> inputs) {
      for (int value = inputs.Min (); value > 0; value--) {
         if (inputs.All(a => a % value == 0))
            return value; 
      }
      return 1;
   }
   public static int LCMof (List<int> inputs) {
      int pr = inputs.Aggregate ((x, y) => x * y);
      for (int value = inputs.Max (); value <= pr; value++) {
         if (inputs.All (a => value % a == 0))
            return value;
      }
      return 1;
   }

   public static void WriteInYellow (string output) {
      Console.WriteLine (output, Console.ForegroundColor = Yellow);
      Console.ResetColor ();
   }
}
