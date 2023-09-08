// A.10.P08_FilePathParse_VIKRAM

using System;
using System.Collections.Generic;

// Test Cases:
Console.WriteLine ("Program to check whether entered string is a valid file path or not:\n\n");
List<string> Inputs = new () { "C:\\Repo\\Filename.cs", "D:\\\\Filename.docx", "D:Filename.txt", "C:/Repo1/Repo2/Repo3/Filename.pdf",
   ":\\Repo1\\Repo2\\Repo3\\Filename.jpg", "CRepo1\\Repo2\\Filename.csprog", "D:\\Repo1\\Repo2\\Repo3\\Filename.mp4",
   "C:\\Repo1\\Repo2\\Repo3\\Filenamezip", "D:\\Repo1$\\Repo2^\\Repo3*\\Filename.rar", "C:\\Repo1\\Repo2\\Repo3\\Filename.pd.g" };

Console.Write ("Do you want to enter (I)nput string [or] see the (T)est cases: ");
char choice = Char.ToUpper (Console.ReadKey ().KeyChar);
Console.WriteLine ();
if (choice == 'I') {
   Console.Write ("Enter your string: ");
   string File = Console.ReadLine ();
   File = File.Insert (File.LastIndexOf ('\\') + 1, "#");
   CheckFilePath (File);
   Console.WriteLine ();
}
else {
   int count = 1;
   foreach (string name in Inputs) {
      Console.WriteLine ($"\n{count}. Input: {name}");
      CheckFilePath (name.Insert (name.LastIndexOf ('\\') + 1, "#"));
      count++;
   }
   Console.WriteLine ("--------------------------------------------------------------");
}

// Please refer the attached State Machine diagram.
void CheckFilePath (string text) {
   State s = A;
   Action nowt = () => { }, perform;
   string DriveName = "", DirectoryName = "", FileName = "", FileType = "";
   foreach (var ch in text.Trim () + "#") {
      char c = ch;
      (s, perform) = (s, ch) switch {
         (A, >= 'A' and <= 'Z') => (B, () => DriveName += ch.ToString ()),
         (B, ':') => (C, nowt),
         (C or D, (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or (>= '0' and <= '9') or '\\') => (D, () => DirectoryName += ch.ToString ()),
         (C or D, ':' or '*' or '?' or '<' or '>' or '|') => (Z, nowt),
         (D, '#') => (E, () => DirectoryName = DirectoryName.Remove (0, 1)),
         (E or F, (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or (>= '0' and <= '9') or '\\') => (F, () => FileName += ch.ToString ()),
         (E or F, ':' or '*' or '?' or '<' or '>' or '|') => (Z, nowt),
         (F, '.') => (G, () => DirectoryName = DirectoryName.Remove (DirectoryName.Length - 1, 1)),
         (G, >= 'a' and <= 'z' or >= 'A' and <= 'Z' or >= '0' and <= '9') => (G, () => FileType += ch.ToString ()),
         (G, '#') => (H, nowt),
         _ => (Z, nowt)
      };
      perform ();
   }
   if (DirectoryName != "") { // Here the condition is to check the Directory Name not to be NIL.
      if (s == H) {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine ("--> It is a VALID File Name.\n");
         Console.ResetColor ();
         var FilePath = Tuple.Create (DriveName, DirectoryName, FileName, FileType);
         Console.WriteLine ($"Drive Name    : {FilePath.Item1}");
         Console.WriteLine ($"Directory Name: {FilePath.Item2}");
         Console.WriteLine ($"File Name     : {FilePath.Item3}");
         Console.WriteLine ($"File Type Name: {FilePath.Item4}");
      }

      else if (s == Z) {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine ("--> INVALID File Name.");
         Console.ResetColor ();
      }
   }

   else {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine ("--> INVALID File Name.");
      Console.ResetColor ();
   }
}
enum State { A, B, C, D, E, F, G, H, Z };
