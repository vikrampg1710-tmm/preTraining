using System;
using System.Linq;
using static System.ConsoleColor;

namespace Spark;

public class Q9 {
   public static void PrintDiamond () {
      Console.WriteLine ("\x1B[4m" + "N-Row Diamond Printer:-" + "\x1B[0m");
      for (; ; ) {
         Console.ResetColor ();
         int midPos = Console.WindowWidth  / 2;
         Console.Write ("\nEnter the row length in integer (1-50): ");
         if (int.TryParse (Console.ReadLine (), out int row) && row > 0 && row < 51) {
            bool above = true;
            //For the 1st half of the diamond, above is true.  For the next half, above is false;
            for (int i = (above ? 1 : row); above ? (i <= row) : (i >= 1); i += above ? 1 : -1) {
               //above ? for (int i = 1; i <= row; i++) : for (int i = row; i >= 1; i--)
               Console.CursorLeft = midPos - i + 1;
               for (int j = 1; j <= 2 * i - 1; j++) 
                  Console.Write ("*", Console.ForegroundColor = (j % 2 == 0) ? Magenta : Blue);
               Console.WriteLine ();
               //Console.WriteLine (new string ('*', (2 * i) - 1), Console.ForegroundColor = (i % 2 == 0) ? Green : Yellow);
               if (above && i == row) above = false;
            }
            Console.ResetColor ();
         }
         Console.Write ("Try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            break;
         }
      }
   }
}
