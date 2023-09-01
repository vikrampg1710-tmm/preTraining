using System;
using static System.ConsoleColor;

namespace Spark;

public class Q19 {
   public static void NthArmstrongNum () {
      Console.WriteLine ("\x1B[4m" + "Calculate Nth Armstrong Number:-" + "\x1B[0m");
      for (; ; ) {
         int nCount = 0, result = 0;
         Console.Write ("\nEnter a positive integer (1 to 27): ");
         if (int.TryParse (Console.ReadLine (), out int N) && N > 0 && N < 28) {
            for (int i = 0; nCount <= N; i++) {
               if (IsArmsNum(i)) nCount++;
               if (nCount == N) result = i + 1;
            }
            Console.ForegroundColor = Green;
            Console.WriteLine ($"{N}th Armstrong Number = {result}.");
            Console.ResetColor ();
         }
         else if (N < 0 || N > 30) Console.Write ("Incorrect input!");
         Console.Write ("\nWant to try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("\nProgram terminated due to incorrect input.", Console.ForegroundColor = Red);
            Console.ResetColor ();
            break;
         }
      }
      Console.WriteLine ();
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
