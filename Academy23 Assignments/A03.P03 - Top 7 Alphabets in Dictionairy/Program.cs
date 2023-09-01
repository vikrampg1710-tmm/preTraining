// ------------------------------------------------------------------------------------------------
// A.04.P03 - To find Top#7 frequent alphabets used in the Dictionary.
// ------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Importing all dictionary words from the text file "c:/etc" into an array.
string[] discWords = File.ReadAllLines (@"c:/etc/words.txt");

// Creating a dictionary to store the letter and its frequencies in (key, value) pairs.
Dictionary<char, int> Frequency = new ();

//Computing the frequencies of each letter in alphabets and updating that in the Dictionary.
foreach (var word in discWords) {
   foreach (var c in word) {
      if (Frequency.TryGetValue (c, out int count)) Frequency[c] = count + 1;
      else if (c >= 'A' && c <= 'Z') Frequency.Add (c, 1);
   }
}

// Arranging the Dictionary based on the Keys.
Console.WriteLine ("Alphabets and their occuerences in the English Dictionairy:-\n");
foreach (KeyValuePair<char, int> abc in Frequency.OrderBy (a => a.Key))
   Console.WriteLine ("Letter: {0} | Occurence: {1}", abc.Key, abc.Value);

//Printing the top 7 frequent letters.
Console.WriteLine ("\nHere the top 7 frequent letters are: ");
foreach (KeyValuePair<char, int> abc in Frequency.OrderByDescending (a => a.Value).Take (7))
   Console.WriteLine ("{0} - {1} times.", abc.Key, abc.Value);
