using System;
using System.Collections.Generic;
using System.Linq;
using static System.ConsoleColor;

namespace Spark;

public class Q4 {
   public static void main () {
      List<List<int>> test = new () { new () { 5, 10, 15, 21 }, new () { 6, 18, 36, 54, 96 }, new () { 6, 8, 12, 10, 30, 72, 134 }, new () { 2, 3, 5, 7, 11, 13 }, new () { 17, 34, 51, 68, 36 } };
      Console.WriteLine ("\x1B[4m" + "GCD & LCM Generator:-" + "\x1B[0m");
      for (int i = 0; i < test.Count; i++) {
         Console.Write ($"\nTest case-{i + 1}: ");
         var t = test[i];
         foreach (var item in t)
            Console.Write ($"{item}  ", Console.ForegroundColor = Cyan);
         Console.ResetColor ();
         Console.Write ("\nGCD = "); WriteInYellow ($"{GCDof (t)}");
         Console.CursorTop -= 1;
         Console.Write ("\nLCM = "); WriteInYellow ($"{LCMof (t)}");
      }
      Console.Write ("\nNow, lets try. Enter the count of no. of inputs (2 - 7): ");
      if (int.TryParse (Console.ReadLine (), out int n) && n > 1 && n < 8) {
         List<int> inputs = new ();
         for (int i = 0; i < n; i++) {
            Console.Write ($"Enter input-{i + 1} = ");
            if (int.TryParse (Console.ReadLine (), out int j)) inputs.Add (j);
            else i--;
         }
         Console.Write ("GCD = "); WriteInYellow ($"{GCDof (inputs)}");
         Console.CursorTop -= 1;
         Console.Write ("LCM = "); WriteInYellow ($"{LCMof (inputs)}");
      }
      else {
         Console.WriteLine ("\nProgram terminated due to incorrect input.", Console.ForegroundColor = Red);
         Console.ResetColor ();
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
