using System;
using System.Threading;

namespace Spark;

class Spark23 {
   public static void Main () {
      string s = ("\x1B[4m" + "Spark23 Assignments:-" + "\x1B[0m" +
                  "\n   1) Number Conversion Game\n" +
                  "   2) Number to Words & Numerals Converter\n" +
                  "   3) Fibonacci Series\n" +
                  "   4) LCM & GCD Generator\n" +
                  "   5) Prime Number Checker\n" +
                  "   6) Palindrome Checker\n" +
                  "   7) Chess Board\n" +
                  "   8) Multiplication Tables\n" +
                  "   9) Print Diamond\n" +
                  "  10) Reverse perform Given Number\n" +
                  "  11) Digital Root\n" +
                  "  12) Pascal's Triangle\n" + 
                  "  13) Strong Password\n" +
                  "  14) Reduce String\n" +
                  "  15) Isogram\n" +
                  "  16) Longest ABCEDarian Word\n" +
                  "  17) String Permutation\n" +
                  "  18) Armstrong Number Checker\n" +
                  "  18.1) Nth Armstrong Number\n" + 
                  "  19) Factorial Number\n" +
                  "  20) Diplay Digits from a Number\n" +
                  "  21) Swap Number\n" +
                  "  22) Swap Indices\n");
      for (; ; ) {
         Console.Write ($"\n{s}\nEnter a number between 1-22 to run corresponding program: ");
         if (int.TryParse (Console.ReadLine (), out int n) && n > 0 && n < 23) {
            Console.ResetColor();
            Console.WriteLine ($"Loading Program no. {n}...\n");
            Thread.Sleep (1000);
            switch (n) {
               case 1: Q1.main (); Q1.DecimalToBinAndHex(); break;
               case 2: Q2.main(); Q2.NumberToWordsAndRomans(); break;
               case 3: Q3.main(); Q3.FiboSeries(0, 1, 10); break;
               case 4: Q4.GCDnLCM(); break;
               case 5: Q5.PrimeNumCheck(); break;
               case 6: Q6.IsPalindrome(); break;
               case 7: Q7.PrintChessBoard (); Console.ReadLine (); break;
               case 8: Q8.MultiplicationTables (); break;
               case 9: Q9.PrintDiamond(); break;
               case 10: Q10.ReverseAInteger();  break;
               case 11: Q11.DigitalRoot (); break;
               case 12: Q12.PascalTriangle ();  break;
               case 13: Q13.IsStrongPassword(); break;
               case 14: Q14.ReduceString(); break;
               case 15: Q15.IsIsogram (); break;
               case 16: Q16.AbcdarainWord(); break;
               case 17: Q17.main(); break;
               case 18: Q18.main(); break;
               case 19: Q19.main(); break;
               case 20: Q20.main(); break;
               case 21: Q21.SwapNumber(); break;
               case 22: Q22.SwapIndex (); break;
               default: Console.WriteLine ("No such program is found!"); break;
            }
         }
         else Console.WriteLine ("Please give a correct input.");
         Console.WriteLine(new string('_', Console.WindowWidth));
      }
   }
}
