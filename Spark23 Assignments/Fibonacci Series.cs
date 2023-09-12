using System;
using System.Collections.Generic;
using static System.ConsoleColor;

namespace Spark;

public class Q3 {
   public static void main() {
      Console.WriteLine ("\x1B[4m" + "Fibonacci Series Printer:-" + "\x1B[0m");
      List<int> test = new () {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 25 };
      foreach (int i in test) {
         Console.Write ($"\nf{i} ==> ");
         Console.ForegroundColor = Yellow;
         FiboSeries (i);
         Console.ResetColor ();
      }
      Console.Write ("\n\nTry Yourself! Enter the length of series, l = ");
      if (int.TryParse (Console.ReadLine (), out int l) && l < 45) {
         Console.Write ($"\nf{l} ==> ");
         Console.ForegroundColor = Yellow;
         FiboSeries (l);
         Console.ResetColor ();
      }
   }

   public static void FiboSeries (int count) {
      if (count <= 0) Console.WriteLine ("Please enter a +ve value");
      var (f0, f1) = (0, 1);
      while (0 < count--) {
         Console.Write ($"{f0}  ");
         (f0, f1) = (f1, f0 + f1);
      }
   }
   public static void NthFibNumber (int n) {
      //This method works upto (n <= 71)
      double sqrt5 = Math.Sqrt (5);
      double phi = (sqrt5 + 1) / 2;
      Console.WriteLine((ulong)(Math.Ceiling(Math.Pow(phi, n) - Math.Pow(1 - phi, n)) / sqrt5));
   }
}
