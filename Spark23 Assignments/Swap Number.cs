using System;
using System.Collections.Generic;

namespace Spark;
public class Q21 {
   public static void SwapNumber () {
      Console.WriteLine ("\x1B[4m" + "Swap Numbers:" + "\x1B[0m");
      Console.Write ("Enter Number 1: ");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.Write ("Enter Number 1: ");
      int b = Convert.ToInt32(Console.ReadLine());
      (a, b) = Swap(a, b);
      Console.WriteLine ($"After Swaping: \na = {b}\nb = {a}");
   }
   public static (int, int) Swap (int a, int b) => (b, a);
}

