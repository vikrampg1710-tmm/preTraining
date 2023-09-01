using System;
using static System.ConsoleColor;
namespace Spark;

public class Q14 {
   public static void ReduceString () {
      Console.WriteLine ("\x1B[4m" + "String Reducer:-" + "\x1B[0m");
      for (; ; ) {
         Console.Write ("\nEnter a string: ");
         string s = Console.ReadLine ().ToLower ();
         string outputs = "";
         for (int i = 0; i < s.Length; i++) {
            if (outputs.Length == 0) { outputs += s[i]; continue; }
            if (outputs[^1] != s[i]) outputs += s[i];
            else outputs = outputs[..^1];
         }
         Console.WriteLine ($"Reduced string: {outputs}");
         Console.Write ("\nTry again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
   }
}
