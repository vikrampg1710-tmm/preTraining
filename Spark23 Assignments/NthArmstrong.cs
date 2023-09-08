using System;
using static System.ConsoleColor;

namespace Spark;

public class Q18 {
   public static void main () {
      Console.WriteLine ("\x1B[4m" + "Armstrong Number:-" + "\x1B[0m");
      for (; ; ) {
         Console.WriteLine ("\n\t(1) Nth Armstrong Number Computer\n\t(2) Check for Armstrong Number");
         Console.Write ("\nPlease type 1 or 2: ");
         var input = Console.ReadLine ();
         switch (input) {
            case "1": NthArmstrongNum (); break;
            case "2": {
                  Console.Write ("\nEnter a positive number: ");
                  if (int.TryParse (Console.ReadLine (), out int num) && num > 0) {
                     Console.WriteLine ($"{num} is {(IsArmsNum (num) ? "" : "NOT ")}an Armstrong Number ", Console.ForegroundColor = Yellow);
                     Console.ResetColor ();
                  }
                  else continue;
                  break;
            }
            default: break;
         }
         
         Console.Write ("\nWant to try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("\nProgram terminated.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
   }

   public static void NthArmstrongNum () {
      int nCount = 0, result = 0;
      Console.Write ("\nEnter a positive integer (1 to 27): ");
      if (int.TryParse (Console.ReadLine (), out int n) && n > 0 && n < 28) {
         for (int i = 0; nCount <= n; i++) {
            if (IsArmsNum(i)) nCount++;
            if (nCount == n) result = i + 1;
         }
         Console.ForegroundColor = Green;
         Console.WriteLine ($"{n}th Armstrong Number = {result}.");
         Console.ResetColor ();
      }
      else if (n < 0 || n > 30) Console.Write ("Incorrect input!");
   }

   public static bool IsArmsNum (int num) {
      int temp = num, sum = 0, d;
      int n = num.ToString ().Length;
      while (temp > 0) {
         d = temp % 10;
         temp = (temp - d) / 10;
         sum += (int)Math.Pow (d, n);
      }
      return sum == num;
   }
}
