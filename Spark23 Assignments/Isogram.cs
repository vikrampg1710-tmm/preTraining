using System;
using System.Collections.Generic;
using System.Linq;

namespace Spark;

public class Q15 {
   public static void IsIsogram () {
      Console.WriteLine ("\x1B[4m" + "Check for Isogram Word:-" + "\x1B[0m");
      for (; ; ) {
         bool yes = true;
         Console.Write ("\nEnter a word: ");
         string s = Console.ReadLine ().ToUpper();
         if (s.All (char.IsLetter)) {
            List<int> HashTable = new ();
            for (int j = 0; j < 26; j++) HashTable.Add (0);
;           foreach (char c in s) {
               if (HashTable[c - 65] == 0) HashTable[c - 65]++;
               else yes = false;
            }
            Console.WriteLine ($"{s} is {(yes ? "" : "NOT ")}an Isogram.");
         }
         else {
            Console.WriteLine ("Program terminated due to incorrect input...", Console.ForegroundColor = ConsoleColor.Red);
            break;
         }
      }
   }
}
