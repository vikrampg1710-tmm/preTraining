using System;
using System.Collections.Generic;
using System.Linq;
using static System.ConsoleColor;

namespace Spark;

public class Q17 {
   public static void main () {
      Console.WriteLine ("\x1B[4m" + "String Permutator:-" + "\x1B[0m");
      for (; ; ) {
         Console.Write ("\nEnter a string: ");
         string s = Console.ReadLine ().ToUpper ();
         if (s.Length > 3 && s.Length ==1) continue;
         var output = Permutated (s);
         Console.WriteLine ($"Permutations of {s} are: ");
         foreach (var item in output) Console.WriteLine (item, Console.ForegroundColor = Yellow) ;
         Console.ResetColor ();
         Console.Write ("\nTry again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
   }

   public static List<string> Permutated (string input) {
      if (input.Length == 2) return TwoPermsOf (input);
      if (input.Length == 3) return ThreePermsOf (input);
      return FourPermsOf(input);

      static List<string> TwoPermsOf (string input) 
         => new () { $"{input[0]}{input[1]}", $"{input[1]}{input[0]}" };

      static List<string> ThreePermsOf(string input) {
         List<string> p = new ();
         List<string> perms = new ();
         for (int i = 0; i < 3; i++)
            perms.AddRange (TwoPermsOf ($"{input[i]}{input[(i + 1) % 3]}"));
         foreach (char c in input) {
            foreach (string s in perms) {
               if (!s.Contains (c)) {
                  p.Add (c + s);
                  p.Add (s + c);
               }
            }
         }
         return p;
      }
      static List<string> FourPermsOf (string input) {
         List<string> p = new ();
         List<string> perms = new ();
         for (int i = 0; i < 3; i++)
            perms.AddRange (ThreePermsOf ($"{input[i]}{input[(i + 1) % 4]}{input[(i + 2) % 4]}"));
         foreach (char c in input) {
            foreach (string s in perms) {
               if (!s.Contains (c)) {
                  p.Add (c + s);
                  p.Add (s + c);
               }
            }
         }
         return p;
      }
   }

   public static List<string> Permutated2 (string input) {
      int size = input.Length;
      List<string> output = new ();
      var charList = input.ToCharArray().ToList();
      List<char> temp = charList;
      for (int i = 0; i < size; i++) {
         for (int j = 0; j < size; j++) {
            (temp[i], temp[j]) = (temp[j], temp[i]);
            var ans = new string (temp.ToArray ());
            if (!output.Contains(ans)) output.Add(ans);
         }
      }
      
      return output;
   }

}
