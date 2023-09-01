using System;
using System.Collections.Generic;
using System.Linq;

namespace Spark;

public class Q22 {
   public static void SwapIndex () {
      Console.WriteLine ("\x1B[4m" + "Index Swaping Game:-" + "\x1B[0m");
      Console.WriteLine ("Random series of numbers will be displayed. " 
         + "The user has to enter two indeces value for the values to be swaped.\n");
      Random r = new ();
      for (; ; ) {
         Console.Write ("Enter the length of sequence (5 or 10 or 15): ");
         if (int.TryParse (Console.ReadLine (), out int num) && num < 16 && num > 0) {
            List<int> list = new ();
            for (int i = 0; i < num; i++) list.Add (r.Next (1, 100));
            Console.WriteLine ($"\nHere is the sequence of {num} numbers...");
            DisplayInBox (list);
            Console.WriteLine ("Now, give your index values.");
            int ind1 = -1, ind2 = -1;
            //bool one = true;
            //while ((one ? ind1 : ind2) < 0) {
            //   Console.Write ($"Enter {(one ? "1st" : "2nd")} index: ");
            //   if (one) ind1 = Convert.ToInt32 (Console.ReadLine ());
            //   else ind2 = Convert.ToInt32 (Console.ReadLine ());
            //   if ((one ? ind1 : ind2) > num - 1) {
            //      (ind1, ind2) = one ? (-1, ind2) : (ind1, -1);
            //      Console.WriteLine ("Index out of range!\n");
            //   }
            //}
            while (ind1 < 0) {
               Console.Write ("Enter 1st index: ");
               ind1 = Convert.ToInt32 (Console.ReadLine ());
               if (ind1 > num - 1) {
                  ind1 = -1;
                  Console.WriteLine ("Index out of range!\n");
               }
            }
            while (ind2 < 0) {
               Console.Write ("Enter 2nd index: ");
               ind2 = Convert.ToInt32 (Console.ReadLine ());
               if (ind2 > num - 1 || ind2 == ind1) {
                  ind2 = -1;
                  Console.WriteLine ("Index out of range or same as first index!\n");
               }
            }
            (list[ind1], list[ind2]) = (list[ind2], list[ind1]);
            Console.WriteLine ("\nAfter swaping ==>\n");
            DisplayInBox (list);
            Console.WriteLine ();
         }
         else if ((num > 15 || num < 1) && num != 0) { Console.WriteLine ("Invalid input!"); continue; }
         else {
            Console.Write ("Do you want to continue this program (y/n): ");
            if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
               Console.WriteLine ("Program terminated.", Console.ForegroundColor = ConsoleColor.Red);
               Console.ResetColor ();
               break;
            }
         }
      }
      void DisplayInBox (List<int> list) {
         int lastInd = list.Count;
         for (int x = 0; x < lastInd; x++) Console.Write ($"{x, 4} ", Console.ForegroundColor = ConsoleColor.Yellow);
         Console.ResetColor ();
         for (int i = 0; i < 2; i++) {
            string s = (i == 0 ? "┌┬┐" :"└┴┘");
            for (int j = 0; j < lastInd + 1; j++)
               Console.Write (j == lastInd? $"{s[2]}\n" : (j == 0 ? $"\n{s[0]}" : s[1]) + "────");
            if (i == 1) break;
            Console.ResetColor ();
            for (int k = 0; k < lastInd + 1; k++) {
               Console.Write (k == lastInd ? $"│" : $"│ {list[k], 2} ");
            }
         }
      }
   }
}
