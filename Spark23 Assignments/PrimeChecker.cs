using System;
using static System.ConsoleColor;

namespace Spark;

public class Q5 {
   public static void PrimeNumCheck() {
      Console.WriteLine ("\x1B[4m" + "Prime Number Checker:-" + "\x1B[0m");
      for (; ; ) {
         bool isPrime;
         Console.Write ("\nEnter a number: ");
         //if (int.TryParse (Console.ReadLine (), out int num) && num > 1) {
         //   Console.ForegroundColor = Green;
         //   Console.WriteLine ($"{num}th Prime Number = {NthPrimeOf (num)}.");
         //   Console.ResetColor ();
         //}
         if (long.TryParse (Console.ReadLine (), out long num) && num > 1) {
            isPrime = IsPrime (num);
            Console.ForegroundColor = isPrime ? Green : Red;
            Console.WriteLine ($"==> {num} is{(isPrime ? "" : " NOT")} an Prime Number.");
            Console.ResetColor ();
         }
         else if (num < 2) { Console.WriteLine ("Incorrect input!"); continue; }
         Console.Write ("Try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("\nProgram terminated.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
         Console.WriteLine ();
      }
      
   }
   public static bool IsPrime (long num) {
      for (int i = 2; i <= (long)Math.Sqrt (num); i++) {
         if (num % i == 0) return false;
      }
      return true;
   }

   public static long NthPrimeOf (int N) {
      int nCount = 0;
      for (long i = 2; nCount <= N; i++) {
         if (IsPrime (i)) nCount++;
         if (nCount == N) return i;
      }
      return 1;
   }

}
