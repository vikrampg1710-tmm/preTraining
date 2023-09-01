using System;
using System.Collections.Generic;
using System.Linq;

namespace Spark;

public class Q12 {
   public static void PascalTriangle () {
      Console.WriteLine ("\x1B[4m" + "Pascal Triangle Printer:-" + "\x1B[0m");
      int midPos = Console.WindowWidth / 2;
      int count = 10;
      List<int> roots = new () { 1 };
      List<int> temp = new ();
      Console.CursorLeft = midPos - 1;
      int left = Console.CursorLeft - 3;
      Console.WriteLine (roots[0]);
      while (count > 0) {
         int size = roots.Count;
         for (int i = 0; i < size; i++) {
            var item = roots[i];
            if (i == 0) temp.Add(item);
            else {
               temp.Add(item + roots[i - 1]);
            }
         }
         temp.Add (roots[size - 1]);
         //string a = "";
         //for (int t = 0; t < temp.Count; t++) {
         //   if (t == 0) a += temp[t];
         //   else {
         //      string space1 = " ", space2 = " ";
         //      if (t != temp.Count - 1) {
         //         int m = (int)Math.Log10 (temp[t]) + 1;
         //         int n = (int)Math.Log10 (temp[t + 1]) + 1;
         //         if (m < n) space1 += " ";
         //         if (n < m) space2 = "";
         //      }
         //      a += $" {space1} ─ {space2}{temp[t]}";
         //   }
         //}
         Console.CursorLeft = left - 1;
         for (int x = 0; x < temp.Count - 1; x++) {
            Console.Write ($"{new string(' ', (int)Math.Floor(Math.Log10 (temp[x])))}  /{new string (' ', 3)}\\", 5);
         }
         Console.WriteLine ();
         string s = string.Join ($"  ─   ", temp);
         Console.CursorLeft = midPos - s.Length / 2 - 1;
         left = Console.CursorLeft - 3;
         Console.WriteLine (s);
         count--;
         roots.Clear ();
         roots.AddRange (temp);
         temp.Clear ();
      }
   }
}
