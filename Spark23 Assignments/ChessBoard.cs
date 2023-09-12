// Printing Chess Board with piece symbols

using System;
using System.Collections.Generic;
using static System.ConsoleColor;

namespace Spark;

public class Q7 {
   public static void PrintChessBoard () {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Console.WriteLine ("\n\x1B[4m" + "Printing 8x8 Chess Board:\n" + "\x1B[0m");
      List<string> black = new () { "♜", "♞", "♝", "♛", "♚", "♝", "♞", "♜", "♟", " " };
      List<string> white = new () { "♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖", "♙", " " };

      #region By Box-Unicodes:
      Console.WriteLine ("1) Using box-unicodes:\n");
      for (int i = 0; i < 9; i++) {
         string s = (i == 0 ? "┌┬┐" : i == 8 ? "└┴┘" : "├┼┤");
         for (int j = 0; j < 9; j++)
            Console.Write (j == 8 ? $"{s[2]}\n" : (j == 0 ? $"   {s[0]}" : $"{s[1]}") + "───");
         if (i == 8) break;
         Console.Write ($" {8 - i} ", Console.ForegroundColor = Yellow);
         Console.ResetColor ();
         for (int k = 0; k < 9; k++) {
            int a = (i == 1 || i == 6) ? 8 : ((i == 0 || i == 7) ? k : 9);
            Console.Write (k == 8 ? "│\n" : $"│ {(i < 5 ? black[a] : white[a])} ");
         }
      }
      Console.WriteLine ("     A   B   C   D   E   F   G   H", Console.ForegroundColor = Yellow);
      Console.ResetColor ();
      #endregion

      #region By Alternating Background colours:
      Console.WriteLine ("\n\n2) Without using box-unicodes:\n");
      
      for (int i = 0; i < 8; i++) {
         Console.Write ($" {8 - i} ", Console.ForegroundColor = Yellow);
         Console.ResetColor ();
         for (int j = 0; j < 8; j++) {
            int a = (i == 1 || i == 6) ? 8 : ((i == 0 || i == 7) ? j : 9);
            Console.BackgroundColor = ((i + j) % 2 == 0) ? White : DarkMagenta;
            Console.Write ($" {(i < 4 ? black[a] : white[a])} ", Console.ForegroundColor = Black);
         }
         Console.ResetColor ();
         Console.WriteLine ();
      }
      Console.WriteLine ("    A  B  C  D  E  F  G  H", Console.ForegroundColor = Yellow);
   }
}
#endregion