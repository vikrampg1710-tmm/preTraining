using System;
using System.Collections.Generic;
using System.Linq;

namespace Spark;
public class Q16 {
   public static void AbcdarainWord () {
      List<string> words = new () { "apple", "first", "antwz", "efghijlk", "pqrst", "orange" };
      words = words.OrderBy(a => a.Length).ToList();
      Console.Write ($"Input list of words:  ");
      foreach (var wrd in words) Console.Write ($"{wrd}  ");
      foreach (var item in words) {
         if (IsArranged(item)) {
            Console.WriteLine ($"\nThe Longest Abcdarian word: {item}");
            break;
         }
      }
   }
   public static bool IsArranged (string word)
      => word == string.Concat (word.OrderBy (a => a));
   
}
