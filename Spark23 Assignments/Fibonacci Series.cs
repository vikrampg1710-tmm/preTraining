using System;

namespace Spark;

public class Q3 {
   public static void main() {
      Console.WriteLine ("\x1B[4m" + "Fibonacci Series Printer:-" + "\x1B[0m");
      Console.Write ("\nEnter the length of series, l = ");
      if (int.TryParse (Console.ReadLine (), out int l) && l < 45) FiboSeries (0, 1, l);
   }

   public static void FiboSeries (int f0, int f1, int count) {
      if (count == 1) { Console.Write ($"{f0}  "); return; }
      if (count == 2) { Console.Write ($"{f0}  {f1}  "); return; }
      Console.Write ($"{f0 + f1}  ");
      (f0, f1) = (f1, f0 + f1);
      count--;
      if (count > 0) FiboSeries (f0, f1, count);
   }
}
