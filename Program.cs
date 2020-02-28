using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {

            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();
            Dictionary<string, string> despairWord = new Dictionary<string, string> ();
            Dictionary<string, string> base10Word = new Dictionary<string, string> ();

            excitedWord.Add ("word", "excited");
            excitedWord.Add ("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add ("part of speech", "adjective");
            excitedWord.Add ("example sentence", "I am excited to learn C#!");
            dictionaryOfWords.Add (excitedWord);

            despairWord.Add ("word", "despair");
            despairWord.Add ("definition", "the complete loss or absence of hope.");
            despairWord.Add ("part of speech", "noun");
            despairWord.Add ("example sentence", "The entire cohort is in a state of despair...");
            dictionaryOfWords.Add (despairWord);

            base10Word.Add ("word", "Base-10");
            base10Word.Add ("definition", "Black Box --Steve");
            base10Word.Add ("part of speech", "noun");
            base10Word.Add ("example sentence", "Don't worry about Base-10...It's a black box.");
            dictionaryOfWords.Add (base10Word);

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            foreach (Dictionary<string, string> word in dictionaryOfWords) {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word) {
                    Console.WriteLine ($"{wordData.Key}: {wordData.Value}");
                }

            }
        }
    }
}