using System;
using System.Linq;
using static System.ConsoleColor;

namespace Spark;

public class Q13 {
   public static void IsStrongPassword () {
      Console.WriteLine ("\x1B[4m" + "Password Strength Checker:-" + "\x1B[0m");
      Console.WriteLine ("\nInstructions: Password considered to be strong if it satisfies the following criteria: " +
         "\n   1. Its length is at least 6. " +
         "\n   2. It contains at least one digit." +
         "\n   3. It contains at least one lowercase English character." +
         "\n   4. It contains at least one uppercase English character. " +
         "\n   5. It contains at least one special character: [!@#$%^&*()-+].");
      for (; ; ) {
         Console.Write ("\nEnter your password: ");
         bool strong = true;
         string reason = "\b", pswd = Console.ReadLine ();
         int len = pswd.Length, count = pswd.Count (x => char.IsDigit (x));
         int lower = 0, upper = 0, spl = 0, num = 0;
         foreach (char c in pswd) {
            if (char.IsDigit (c)) continue;
            if (!char.IsLetter (c)) spl++;
            if (char.IsLower (c)) lower++;
            if (char.IsUpper (c)) upper++;
         }
         if (len < 7) { reason += $"\n{++num}) Your password length is lesser than 6. It should >= 6."; strong = false; }
         if (count < 1) { reason += $"\n{++num}) Your password has no digits. It should contain atleast one."; strong = false; }
         if (lower < 1) { reason += $"\n{++num}) Your password has no lowercase letters, it should contain atleast one."; strong = false; }
         if (upper < 1) { reason += $"\n{++num}) Your password has no uppercase letters, it should contain atleast one."; strong = false; }
         if (spl < 1) { reason += $"\n{++num}) Your password has no special characters [!@#$%^&*()-+], it should contain atleast one."; strong = false; }
         Console.ForegroundColor = strong ? Green : Red;
         Console.Write ($"Your password is {(strong ? "Strong.\n" : "Weak.")}");
         Console.ResetColor ();
         if (!strong) Console.WriteLine ($" Becasue, {reason}\n");
         
         Console.Write ("Try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            break;
         }
      }
   }
}
