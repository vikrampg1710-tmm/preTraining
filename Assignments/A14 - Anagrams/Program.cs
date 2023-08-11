// A.14.P11_Anagrams_VIKRAM
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System;

var DictWords = new List<string> (File.ReadAllLines (@"c:/etc/words.txt"));
Dictionary<string, List<string>> Anagrams = new ();
List<int> HashTable;
string Hash;

string HashTableOf (string word) {
   HashTable = new () { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
   foreach (char c in word) HashTable[c - 65]++;
   return string.Join ("", HashTable);
}
var watch = Stopwatch.StartNew (); //.............................TIMER ON
foreach (string A in DictWords) {
   Hash = HashTableOf (A);
   if (Anagrams.TryGetValue (Hash, out List<string> value)) value.Add (A);
   else Anagrams.Add (Hash, new List<string> { A });
}
watch.Stop ();//..................................................TIMER OFF

int count = 0;
foreach (KeyValuePair<string, List<string>> abc in Anagrams.Where (abc => abc.Value.Count >= 2).OrderByDescending (a => a.Value.Count))
   Console.WriteLine ($"{++count,4}. {abc.Value.Count,2}- {string.Join (", ", abc.Value)}");
Console.WriteLine ($"\nThe Execution time of the program: {watch.ElapsedMilliseconds} ms");