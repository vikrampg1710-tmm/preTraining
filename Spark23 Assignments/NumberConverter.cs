using System;
using System.Collections.Generic;
using System.Globalization;
using static System.ConsoleColor;

namespace Spark;
public class Q1 {
   public static void main () {
      List<int> Test = new () { 0, 1, 4, 9, 10, 11, 16, 25, 36, 49, 50, 81, 100, 109, 125, 216, 343, 729, 1000, 12001, 66000, 123450, 1000909, 987654321, 100000001 };
      Console.WriteLine ("\x1B[4m" + "Decimal to Binary & Hexadecimal:" + "\x1B[0m");
      for (int i = 0; i < Test.Count; i++) {
         var item = Test[i];
         Console.WriteLine ($"{i + 1,2}) {item,9}: ");
         Console.Write("In Binary: ", 16);
         WriteInYellow (BinaryFormOf (item));
         Console.Write ("In Hexadecimal: ", 16);
         WriteInYellow (HexaDecFormOf (item));
      }
   }

   public static void DecimalToBinAndHex () {
      Console.WriteLine ("\x1B[4m" + "Numbers to Binary & Hexadecimal converter:-" + "\x1B[0m");
      Console.WriteLine ("Instructions:  \n\t1.Maximum of 9-digit number can be converted to words.\n\t2.And, number < 5000 can be converted to roman letters.", Console.ForegroundColor = Cyan);
      while (true) {
         Console.ResetColor ();
         Console.Write ("\nEnter a positive integer: ");
         if (int.TryParse (Console.ReadLine (), out int num) && num >= 0 && Math.Floor (Math.Log10 (num) + 1) < 10) {
            Console.Write (num.ToString ("N0", new NumberFormatInfo () { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," }) + " ==> ");
            WriteInYellow (BinaryFormOf (num));
            if (num < 5000) {
               Console.Write ($"In Romans: ");
               WriteInYellow (HexaDecFormOf (num));
            }
         }
         Console.Write ("Try again? (y/n): ");
         if (char.ToLower (Console.ReadKey ().KeyChar) != 'y') {
            Console.WriteLine ("Program terminated.", Console.ForegroundColor = Red);
            break;
         }
      }
   }

   public static string BinaryFormOf (int num) => Convert.ToString(num, 2);
  
   public static string HexaDecFormOf (int num) => Convert.ToString (num, 16);

   public static void WriteInYellow (string output) {
      Console.WriteLine (output, Console.ForegroundColor = Yellow);
      Console.ResetColor ();
   }
}


