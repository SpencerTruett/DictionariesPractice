using System;
using System.Collections.Generic;

namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {

      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      Dictionary<string, string> excitedWord = new Dictionary<string, string>();
      Dictionary<string, string> despairWord = new Dictionary<string, string>();
      Dictionary<string, string> base10Word = new Dictionary<string, string>();

      excitedWord.Add("Word", "excited");
      excitedWord.Add("Definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
      excitedWord.Add("Part of Speech", "adjective");
      excitedWord.Add("Example Sentence", "I am excited to learn C#!");
      dictionaryOfWords.Add(excitedWord);

      despairWord.Add("Word", "despair");
      despairWord.Add("Definition", "the complete loss or absence of hope.");
      despairWord.Add("Part of Speech", "noun");
      despairWord.Add("Example Sentence", "The entire cohort is in a state of despair...");
      dictionaryOfWords.Add(despairWord);

      base10Word.Add("Word", "Base-10");
      base10Word.Add("Definition", "Black Box");
      base10Word.Add("Part of Speech", "noun");
      base10Word.Add("Example Sentence", "Don't worry about Base-10...It's a black box. --Steve");
      dictionaryOfWords.Add(base10Word);

      /*
          Use square brackets to get the definition of two of the
          words and then output them to the console
      */

      foreach (Dictionary<string, string> word in dictionaryOfWords)
      {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> wordData in word)
        {
          Console.WriteLine($"{wordData.Key}: {wordData.Value}");
        }

      }
    }
  }
}