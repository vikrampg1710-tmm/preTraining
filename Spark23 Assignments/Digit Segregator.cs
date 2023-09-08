using System;
using System.Collections.Generic;
using static System.ConsoleColor;

namespace Spark;
public class Q20 {
   public static void main () {
      List<double> wTestCases = new () { 1, 23, 1234, 5678.345, 0.789, -2.60, -0.0123, -56.90, -0.98723, 0.005 };
      Console.WriteLine ("\x1B[4m" + "Digit Segregator:" + "\x1B[0m");
      for (int i = 0; i < wTestCases.Count; i++) {
         var item = wTestCases[i];
         Console.WriteLine ($"\n{i + 1}) {item} ");
         var ans = DigitParse (item);
         Console.Write ($"Sign: ", 15);
         WriteInYellow ($"{ans.Item1}");
         Console.Write ($"Integer part: ", 15);
         WriteInYellow ($"{ans.Item2}");
         Console.Write ($"Decimal part: ", 15);
         WriteInYellow ($"{ans.Item3}");
         Console.Write ($"Exponent part: ", 15);
         WriteInYellow ($"{ans.Item4}");
      }
   }
   public static void NumberToRomans () {
      Console.WriteLine ("\x1B[4m" + "Digit Segregator:-" + "\x1B[0m");
      while (true) {
         Console.ResetColor ();
         Console.Write ("\nEnter a decimal number: ");
         if (double.TryParse (Console.ReadLine (), out double num)) {
            var ans = DigitParse (num);
            Console.Write ($"Sign: ", 15);
            WriteInYellow ($"{ans.Item1}");
            Console.Write ($"Integer part: ", 15);
            WriteInYellow ($"{ans.Item2}");
            Console.Write ($"Decimal part: ", 15);
            WriteInYellow ($"{ans.Item3}");
            Console.Write ($"Exponent part: ", 15);
            WriteInYellow ($"{ans.Item4}");
         }
         else continue;
         Console.Write ("Try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            break;
         }
      }
   }
 
   public static Tuple<string, string, string, string> DigitParse (double num) {
      string i = "", d = "", e = "";
      bool sign = true;
      string input = num.ToString();
      State st = State.A;
      foreach (char ch in input + "#") {
         switch (st, ch) {
            case (State.A, '+' or '-'): { st = State.B; sign = ch != '-'; break; }
            case (State.A or State.B or State.C, >= '0' and <= '9'): { st = State.C; i += ch.ToString (); break; }
            case (State.C, '.'): { st = State.D; break; }
            case (State.D or State.E, >= '0' and <= '9'): { st = State.E; d += ch.ToString (); break; }
            case (State.C or State.E, '#'): { st = State.H; break; }
            default: {st = State.H; break; }
         }
      }
      string s;
      (s, i, d, e) = ((sign ? "+" : "-"), (i == "" ? "0" : i), (d == "" ? "0" : d), (e == "" ? "0" : e));

      Tuple<string, string, string, string> output = new (s, i, d, e);
      return output;
   }
   enum State { A, B, C, D, E, F, G, H, I, Z };

   public static void WriteInYellow (string output) {
      Console.WriteLine (output, Console.ForegroundColor = Yellow);
      Console.ResetColor ();
   }
}


